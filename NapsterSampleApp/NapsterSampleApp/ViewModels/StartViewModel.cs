using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

using Splat;

namespace NapsterSampleApp.ViewModels
{
    public class StartViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment { get; }
        public IScreen HostScreen { get; }


        public ReactiveCommand NewReleases { get; protected set; }


        public StartViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();
            
            var load = 

            NewReleases = ReactiveCommand.Create(Execute);
            
            NewReleases.ThrownExceptions.Subscribe(OnNext);
        }

        private void Execute()
        {
            HostScreen.Router.Navigate.Execute(new NewReleasesViewModel(HostScreen)).Subscribe();
        }

        private void OnNext(Exception exception)
        {
            Debug.WriteLine(exception.Message);
        }
    }
}