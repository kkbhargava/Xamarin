using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllControlsPage : ContentPage
    {
        private IList<ContactMethod> _contactMethods;

        public AllControlsPage()
        {
            InitializeComponent();

            _contactMethods = GetContactMethods();

            foreach (var method in GetContactMethods())
            {
                ContactMethods.Items.Add(method.Name);
            }
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            Label.Text = "Complete";
        }

        private void ContactMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Name = ContactMethods.Items[ContactMethods.SelectedIndex];
            var ContactMethod = _contactMethods.Single(cm => cm.Name == Name);
            DisplayAlert("Selection", Name, "OK");
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod{Id=1, Name="SMS"},
                new ContactMethod{Id=2, Name="Email"}
            };
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}