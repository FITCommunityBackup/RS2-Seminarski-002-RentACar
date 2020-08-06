﻿using RentaCar.Data.Requests.Vehicle;
using RentACar.Mobile.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehicleDetailPage : ContentPage
    {
        VehicleDetailsViewModel model = null;

        public VehicleDetailPage(VehicleRequest item)
        {
            InitializeComponent();

            BindingContext = model = new VehicleDetailsViewModel
            {
                vehicle = item
            };
        }

        private async void Booking_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookingVehicle());
        }
    }
}