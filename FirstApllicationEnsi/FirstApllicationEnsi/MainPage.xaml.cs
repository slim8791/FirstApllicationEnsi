using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApllicationEnsi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
           InitializeComponent();
            MySlider.Value = 0.1;
        }
        //
        private void Button_OnClicked(object sender, EventArgs e)
        {

            DisplayAlert("This a message", "Welcome to Xamarin Forms", "Cancel");
        }

        //private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    MyBoxView.Opacity = e.NewValue;
        //    MyLabel.Text = String.Format("Value is {0:F2}", e.NewValue);
        //}
    }
}
