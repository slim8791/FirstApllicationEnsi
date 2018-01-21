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
          //  MySlider.Value = 0.1;
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
        //private void Entry_OnCompleted(object sender, EventArgs e)
        //{

        //    DisplayAlert("Alert", MyEntry.Text, "Cancel", "OK");
        //}

        //private void MyEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        //{
        //  //  MyLabel.Text = e.NewTextValue;
        //    MyLabel.Text = e.OldTextValue;
        //}
        //private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        //{

        //    DisplayAlert("Selected index", "The selected item is : " + MyPicker.Items[MyPicker.SelectedIndex], "Cancel");
        //}
        private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {

            DisplayAlert("Selected date", e.NewDate.Day.ToString() + "-"+e.NewDate.Month.ToString() + "-"+e.NewDate.Year.ToString() , "Cancel");
        }
    }
}
