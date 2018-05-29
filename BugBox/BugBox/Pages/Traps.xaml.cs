using BugBox.Models;
using BugBox.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BugBox.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Traps : ContentPage
    {
        public Traps()
        {
            BindingContext = new TrapsViewModel();
            InitializeComponent();
        }

        private void Handle_TrapsListView_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var trap = e.SelectedItem as Trap;
            var page = (Page)Activator.CreateInstance(typeof(TrapDetail), trap);
            Navigation.PushAsync(page);
        }
    }
}