using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using NapsterSampleApp.ViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;

namespace NapsterSampleApp.Views
{
    public partial class PublicApiView : IViewFor<PublicApiViewModel>
    {
        public PublicApiView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                ViewModel = (PublicApiViewModel)BindingContext;

                this.OneWayBind(ViewModel, vm => vm.AlbumsList, v => v.AlbumListView.ItemsSource).DisposeWith(d);

                this.Bind(ViewModel, vm => vm.ItemType, v => v.ItemType.SelectedIndex);
                this.BindCommand(ViewModel, vm => vm.UpdateViewCommand, v => v.UpdateButton);

            });



            
        }


        public PublicApiViewModel ViewModel
        {
            get { return (PublicApiViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
        public static readonly BindableProperty ViewModelProperty =
            BindableProperty.Create<PublicApiView, PublicApiViewModel>(x => x.ViewModel, default(PublicApiViewModel), BindingMode.OneWay);


        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (PublicApiViewModel)value; }
        }



    }
}
