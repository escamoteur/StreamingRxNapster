using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
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

            provider = new StreamingProviderNapster(ApiKeyProvider.GetApiKey);
            var b = new Button {Text = "TestCall"};
            b.Clicked += B_Clicked;
            // The root page of your application
            MainPage = new ContentPage
            {

                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        },
                        b
                    }
                }
            };
        }

        private void B_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            var o = provider.GetNewReleases(10, 0);
           
            o.Subscribe(OnNext,OnError,OnCompleted);
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
