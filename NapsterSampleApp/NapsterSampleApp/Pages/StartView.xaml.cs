using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using NapsterSampleApp.ViewModels;
using ReactiveUI;
using ReactiveUI.Legacy;
using Xamarin.Forms;

namespace NapsterSampleApp.Views
{
    public partial class StartView : ContentPage,IViewFor<StartViewModel>, IActivatable
    {


        public StartView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                ViewModel = (StartViewModel) BindingContext;


                this.BindCommand(ViewModel, vm => vm.GoToPublicApi, v => v.BtnPublicApi).DisposeWith(d);

            });
        }


        public StartViewModel ViewModel
        {
            get { return (StartViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
        public static readonly BindableProperty ViewModelProperty =
            BindableProperty.Create<StartView, StartViewModel>(x => x.ViewModel, default(StartViewModel), BindingMode.OneWay);


        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (StartViewModel)value; }
        }

    }
}
