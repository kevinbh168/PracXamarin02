using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EvaluacionBrena02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario : ContentPage
    {
        public Formulario()
        {
            InitializeComponent();

            btnShow.Clicked += async (sender, e) =>
            {
                var nombre = name.Text;
                var descripcion = description.Text;
                var answer = await DisplayAlert("Mensaje", "Hola, "+nombre+" "+descripcion,"Cancelar","Genial");
                Debug.WriteLine("Answer: " + answer);
            };
           

        }
    }
}