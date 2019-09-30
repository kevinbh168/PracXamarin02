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
    public partial class DatePicker : ContentPage
    {
        public DatePicker()
        {
            InitializeComponent();

            datepicker.MinimumDate = new DateTime(2019, 1, 1);
            datepicker.MaximumDate = new DateTime(2019, 12, 31);
            datepicker.Date = DateTime.Now;
            
        }
    }
}