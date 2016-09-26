using System;
using System.Reactive.Linq;
using NapsterSampleApp.ItemViewModels;
using ReactiveUI;
using Splat;
using StreamingRxCommons;

namespace NapsterSampleApp.ViewModels
{
    public class NewReleasesViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment { get; }
        public IScreen HostScreen { get; }

        public NewReleasesViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();

            AlbumsList = new ReactiveList<AlbumViewModel>();
        

            var StreamingProvider = Locator.Current.GetService<IStreamingProvider>();

            StreamingProvider.GetNewReleases(10, 0).Subscribe(albums =>
            {
                foreach (var album in albums)
                {
                    var vm = new AlbumViewModel() {Name = album.Name};
                    AlbumsList.Add(vm);
                }
            });

        }
        
        public ReactiveList<AlbumViewModel> AlbumsList { get; set; }



    }
}