using BugBox.ViewModels;

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
    }
}