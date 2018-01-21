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
    public partial class ListPage : ContentPage
    {
        List<Person> persons = new List<Person>();

        public ListPage()
        {
            InitializeComponent();
            persons.Add(new Person {Name = "Slim" , LastName = "Hammami", Age = 26});

            persons.Add(new Person { Name = "Ali", LastName = "Ben Mohamed", Age = 26 });

            persons.Add(new Person { Name = "Salah", LastName = "Salah", Age = 26 });

            MyList.ItemsSource = persons;

        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            //List<Person> p = new List<Person>();

            //foreach (Person person in persons)
            //{
            //    if (person.Name.Contains(e.NewTextValue))
            //    {
            //        p.Add(person);
                   
            //    }
            //}
            //MyList.ItemsSource = p;

            MyList.ItemsSource = persons.Where(a => a.Name.ToUpper().Contains(e.NewTextValue.ToUpper()));
        }
    }
}