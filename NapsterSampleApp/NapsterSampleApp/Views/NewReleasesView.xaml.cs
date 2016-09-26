using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NapsterSampleApp.ViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;

namespace NapsterSampleApp.Views
{
    public partial class NewReleasesView : IViewFor<NewReleasesViewModel>
    {
        public NewReleasesView()
        {
            InitializeComponent();

            this.OneWayBind(ViewModel, vm => vm.AlbumsList, v => v.AlbumListView.ItemsSource);
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        public NewReleasesViewModel ViewModel
        {
            get { return (NewReleasesViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
        public static readonly BindableProperty ViewModelProperty =
            BindableProperty.Create<NewReleasesView, NewReleasesViewModel>(x => x.ViewModel, default(NewReleasesViewModel), BindingMode.OneWay);


        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (NewReleasesViewModel)value; }
        }



    }
}
