﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApllicationEnsi
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {

            //Navigation.PushAsync(new SecondPage());
            Navigation.PushModalAsync(new SecondPage());
        }
    }
}