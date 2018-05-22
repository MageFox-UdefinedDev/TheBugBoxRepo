using BugBox.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BugBox.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MDPMaster : ContentPage
    {
        public ListView ListView;

        public MDPMaster()
        {
            InitializeComponent();

            BindingContext = new MDPMasterViewModel();
            ListView = MenuItemsListView;
        }
    }
}