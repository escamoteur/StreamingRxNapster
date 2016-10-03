using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using NapsterSampleApp.ItemViewModels;
using NapsterSampleApp.ViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;

namespace NapsterSampleApp.Views
{
    public partial class ItemView : IViewFor<ItemViewModel>, IActivatable
    {
        public ItemView()
        {
            InitializeComponent();
            this.WhenActivated(d =>
            {
                ViewModel = (ItemViewModel)BindingContext;

                this.OneWayBind(ViewModel, vm => vm.FirstCol, v => v.Name.Text).DisposeWith(d);
            });

        }


        public ItemViewModel ViewModel
        {
            get { return (ItemViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
        public static readonly BindableProperty ViewModelProperty =
            BindableProperty.Create<ItemView, ItemViewModel>(x => x.ViewModel, default(ItemViewModel), BindingMode.OneWay);


        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ItemViewModel)value; }
        }


    }
}
