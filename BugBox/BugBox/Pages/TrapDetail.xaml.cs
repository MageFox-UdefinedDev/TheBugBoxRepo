using System;
using BugBox.Models;
using BugBox.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace BugBox.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrapDetail : ContentPage
    {
        private Map _map;
        private Trap _trap;

        public TrapDetail(Trap trap)
        {
            _trap = trap;
            BindingContext = new TrapDetailViewModel(trap);
            InitializeComponent();
            AddMap();
        }

        private void AddMap()
        {
            _map = new Map
            {
                IsShowingUser = true,
                HeightRequest = 1000,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            _map.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(_trap.Latitude, _trap.Longitude), Distance.FromMiles(3))); // Santa Cruz golf course

            var position = new Position(_trap.Latitude, _trap.Longitude); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Playa",
                Address = "Que miera pondra?"
            };
            _map.Pins.Add(pin);
            MapStackLayout.Children.Add(_map);
        }
    }
}