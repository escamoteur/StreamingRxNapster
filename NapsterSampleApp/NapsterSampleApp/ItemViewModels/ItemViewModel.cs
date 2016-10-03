using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using ReactiveUI;

namespace NapsterSampleApp.ItemViewModels
{
    [ImplementPropertyChanged]
    public class ItemViewModel
    {
        public string FirstCol { get; set; }
        public string SecondCol { get; set; }
        public string ThirdCol { get; set; }
    }
}
