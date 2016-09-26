using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NapsterSampleApp.ItemViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;

namespace NapsterSampleApp.Views
{
    public partial class ItemViewAlbum 
    {
        public ItemViewAlbum()
        {
            InitializeComponent();
            this.OneWayBind(ViewModel, vm => vm.Name, v => v.Name);
        }

     }
}
