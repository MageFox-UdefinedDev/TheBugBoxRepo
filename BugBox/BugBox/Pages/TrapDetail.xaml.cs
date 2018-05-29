using BugBox.Models;
using BugBox.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BugBox.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrapDetail : ContentPage
    {
        public TrapDetail(Trap trap)
        {
            BindingContext = new TrapDetailViewModel(trap);
            InitializeComponent();
        }
    }
}