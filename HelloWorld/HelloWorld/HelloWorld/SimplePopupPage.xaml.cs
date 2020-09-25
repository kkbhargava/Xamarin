﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimplePopupPage : ContentPage
    {
        public SimplePopupPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            /*
            // Simple Popup Msg
            var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");

            if (response)
                DisplayAlert("Done", "Your response will be saved!", "OK");
            */

            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy link", "Message", "Email");

            await DisplayAlert("Response", response, "OK");

        }
    }
}