using Xamarin.Forms;

namespace BugBox
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            RegisterDependencies(_mock);
            MainPage = new Pages.MDP();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}