using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage : ContentPage
    {
        public SearchBarPage()
        {
            InitializeComponent();

            ListView.ItemsSource = GetContacts();
        }

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
            {
                new Contact{Name="Amit", ImageUrl="http://lorempixel.com/100/100/people/1"},
                new Contact{Name="Bimal", ImageUrl="http://lorempixel.com/100/100/people/1"},
                new Contact{Name="Chetan", ImageUrl="http://lorempixel.com/100/100/people/1"},
                new Contact{Name="Deepak", ImageUrl="http://lorempixel.com/100/100/people/1"},
                new Contact{Name="Ekant", ImageUrl="http://lorempixel.com/100/100/people/1"},
                new Contact{Name="Fuddu", ImageUrl="http://lorempixel.com/100/100/people/2", Status="Hey, Let's talk!"}
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(c => c.Name.StartsWith(searchText));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListView.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}