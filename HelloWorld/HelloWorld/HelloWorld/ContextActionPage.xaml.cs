using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContextActionPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;
        public ContextActionPage()
        {
            InitializeComponent();

            _contacts = new ObservableCollection<Contact> {
                new Contact{Name="Kamal", ImageUrl="http://lorempixel.com/100/100/people/1"},
                new Contact{Name="Rahul", ImageUrl="http://lorempixel.com/100/100/people/2", Status="Hey, Let's talk!"}
            };
            ListView.ItemsSource = _contacts;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;

            _contacts.Remove(contact);
        }
    }
}