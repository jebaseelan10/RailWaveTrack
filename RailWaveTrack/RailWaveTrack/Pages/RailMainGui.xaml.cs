﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RailWaveTrack.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RailMainGui : ContentPage
    {
        public RailMainGui()
        {
            InitializeComponent();
        }

        private void PNRButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PnrPage());
        }

    }
}