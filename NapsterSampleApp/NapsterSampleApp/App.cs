using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using ReactiveUI;
using StreamingRxCommons;
using StreamingRxNapster;
using Xamarin.Forms;

namespace NapsterSampleApp
{
    public class App : Application
    {
        private IStreamingProvider provider;

        public App()
        {
            var bootstrapper = RxApp.SuspensionHost.GetAppState<AppBootstrapper>();

            provider = new StreamingProviderNapster(ApiKeyProvider.GetApiKey);

            // The root page of your application
            MainPage = bootstrapper.CreateMainPage();
        }

        private void B_Clicked(object sender, EventArgs e)
        {
            var o = provider.GetNewReleases(10, 0);
           
            o.ObserveOn(SynchronizationContext.Current).
                Subscribe(OnNext);
        }

        private void OnCompleted()
        {
            throw new NotImplementedException();
        }

        private void OnError(Exception exception)
        {
            throw new NotImplementedException();
        }

        private void OnNext(IEnumerable<IAlbum> album)
        {
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
