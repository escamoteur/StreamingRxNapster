using System;
using System.Collections.Generic;
using System.Linq;
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

        public StartViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();

        }
    }
}