using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;
using ReactiveUI;
using PropertyChanged;

using Splat;

namespace NapsterSampleApp.ViewModels
{
    [ImplementPropertyChanged]
    public class StartViewModel : FreshBasePageModel
    {
        

        public ReactiveCommand GoToPublicApi { get; protected set; }


        public StartViewModel()
        {
            
            GoToPublicApi = ReactiveCommand.Create(Execute);
            
            GoToPublicApi.ThrownExceptions.Subscribe(OnNext);
        }

        private async void Execute()
        {
            await CoreMethods.PushPageModel<PublicApiViewModel>();
        }

        private void OnNext(Exception exception)
        {
            Debug.WriteLine(exception.Message);
        }
    }
}