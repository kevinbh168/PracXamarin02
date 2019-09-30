﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EvaluacionBrena02
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item0.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new StackLayout());

            };
            Item1.Clicked += async (sender, e) =>
            {
               await Navigation.PushAsync(new Grid());

            };

            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Navigation());

            };

            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TabbedEje());

            };

            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Formulario());

            };

            Item5.Clicked += async (sender, e) =>
            {
               await Navigation.PushAsync(new DatePicker());

            };

        }
    }
}
