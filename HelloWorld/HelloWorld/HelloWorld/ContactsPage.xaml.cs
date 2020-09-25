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
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();

            ListView.ItemsSource = new List<Contact>
            {
                new Contact {Name = "Rahul", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Contact {Name = "Rahul", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, Let's talk!"}
            };
        }

        async private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailPage(contact));
            ListView.SelectedItem = null;
        }
    }
}