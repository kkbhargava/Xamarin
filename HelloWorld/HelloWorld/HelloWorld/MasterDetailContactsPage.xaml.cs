using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloWorld.Models;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailContactsPage : MasterDetailPage
    {
        public MasterDetailContactsPage()
        {
            InitializeComponent();

            ListView.ItemsSource = new List<Contact>
            {
                new Contact {Name = "Rahul", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Contact {Name = "Rahul", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, Let's talk!"}
            };
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;

            Detail = new ContactDetailPage(contact);

            IsPresented = false; // IsMasterPresented
        }
    }
}