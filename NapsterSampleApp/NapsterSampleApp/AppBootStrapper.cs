using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;

namespace NapsterSampleApp
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        // The Router holds the ViewModels for the back stack. Because it's
        // in this object, it will be serialized automatically.
        public RoutingState Router { get; protected set; }

        public AppBootstrapper()
        {
            Router = new RoutingState();
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));


            // CoolStuff: For routing to work, we need to tell ReactiveUI how to
            // create the Views associated with our ViewModels
            //Locator.CurrentMutable.Register(() => new LoginStartView(), typeof(IViewFor<LoginStartViewModel>));
            //Locator.CurrentMutable.Register(() => new LoginView(), typeof(IViewFor<LoginViewModel>));
            //Locator.CurrentMutable.Register(() => new ChannelView(), typeof(IViewFor<ChannelViewModel>));

            //// Kick off to the first page of our app. If we don't navigate to a
            //// page on startup, Xamarin Forms will get real mad (and even if it
            //// didn't, our users would!)
            //Router.Navigate.Execute(new LoginStartViewModel(this));
        }

        public Page CreateMainPage()
        {
            // NB: This returns the opening page that the platform-specific
            // boilerplate code will look for. It will know to find us because
            // we've registered our AppBootstrapper as an IScreen.
            return new RoutedViewHost();
        }
    }
}
