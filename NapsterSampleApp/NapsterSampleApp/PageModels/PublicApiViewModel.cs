using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading;
using FreshMvvm;
using NapsterSampleApp.ItemViewModels;
using PropertyChanged;
using ReactiveUI;
using Splat;
using StreamingRxCommons;

namespace NapsterSampleApp.ViewModels
{
    [ImplementPropertyChanged]
    public class PublicApiViewModel : FreshBasePageModel
    {
        private IStreamingProvider streamingProvider;

        protected ReactiveCommand<Unit, ItemViewModel> UpdateCommand;

        public ReactiveCommand<Unit, ItemViewModel> UpdateViewCommand { get; protected set; }

        public ObservableCollection<ItemViewModel> AlbumsList { get; set; } = new ObservableCollection<ItemViewModel>();

        public PublicApiViewModel()
        {

            streamingProvider = Locator.Current.GetService<IStreamingProvider>();

            // NewReleases
            UpdateViewCommand = ReactiveCommand.CreateFromObservable(()=> streamingProvider.GetNewReleases(10, 0)
                .Do(_ => AlbumsList.Clear())
                .ObserveOn(SynchronizationContext.Current)
                .SelectMany(albums => FlattenAlbumsList(albums)));

            UpdateViewCommand.Subscribe(x => AlbumsList.Add(x));
           
            
            
            //AlbumsList = UpdateViewCommand.CreateCollection();
            UpdateViewCommand.ThrownExceptions.Subscribe(OnError);

        }

        private IEnumerable<ItemViewModel> FlattenAlbumsList(IEnumerable<IAlbum> albums)
        {
            return albums.Select(album => new ItemViewModel() {FirstCol = album.Name});
        }



        //ObserveOn(SynchronizationContext.Current).Subscribe(albums =>
    //                    {

    //                        foreach (var album in albums)
    //                        {
    //                            var vm = new ItemViewModel() { FirstCol = album.Name };
    //                            l.Add(vm);
    //                        }

    //                    }, OnError);

    //                    AlbumsList = l;

    //                });
    //        UpdateCommands[0].ThrownExceptions.Subscribe(OnError);


    //        UpdateCommands[0] = ReactiveCommand.Create(() =>
    //        {
    //            var l = new ReactiveList<ItemViewModel>();

    //            streamingProvider.GetNewReleases(10, 0).ObserveOn(SynchronizationContext.Current).Subscribe(albums =>
    //            {

    //                foreach (var album in albums)
    //                {
    //                    var vm = new ItemViewModel() { FirstCol = album.Name };
    //                    l.Add(vm);
    //                }

    //            }, OnError);

    //            AlbumsList = l;

    //        });
    //        UpdateCommands[0].ThrownExceptions.Subscribe(OnError);







        

        private void OnError(Exception exception)
        {
            throw new NotImplementedException();
        }


        public  int ItemType { get; set; }





    }
}