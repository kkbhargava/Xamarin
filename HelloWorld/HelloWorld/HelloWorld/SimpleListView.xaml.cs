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
    public partial class SimpleListView : ContentPage
    {
        public SimpleListView()
        {
            InitializeComponent();

            /*
            var names = new List<string>
            {
                "Kamal",
                "Arun",
                "Amit",
                "Rahul"
            };
            */

            listView.ItemsSource = new List<Contact> { 
                new Contact{Name="Kamal", ImageUrl="http://lorempixel.com/100/100/people/1"},
                new Contact{Name="Rahul", ImageUrl="http://lorempixel.com/100/100/people/2", Status="Hey, Let's talk!"},

            };
        }
    }
}