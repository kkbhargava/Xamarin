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
    public partial class ContactGroupListView : ContentPage
    {
        public ContactGroupListView()
        {
            InitializeComponent();

            listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("K", "K")
                {
                    new Contact{Name="Kamal", ImageUrl="http://lorempixel.com/100/100/people/1"},
                },

                new ContactGroup("R", "R")
                {
                    new Contact{Name="Rohan", ImageUrl="http://lorempixel.com/100/100/people/1"},
                }
            };
        }
    }
}