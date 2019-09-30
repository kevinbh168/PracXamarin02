using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EvaluacionBrena02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedEje : TabbedPage
    {
        public TabbedEje()
        {
            InitializeComponent();
            btnClose.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };
        }
    }
}