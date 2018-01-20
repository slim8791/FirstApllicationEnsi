using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApllicationEnsi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhoneKeyboard : ContentPage
    {
        public PhoneKeyboard()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Button myBtn = (Button) sender;
            Number.Text = Number.Text + myBtn.Text;
        }
    }
}