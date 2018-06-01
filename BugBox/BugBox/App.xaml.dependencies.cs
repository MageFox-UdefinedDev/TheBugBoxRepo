using BugBox.Services;
using Xamarin.Forms;

namespace BugBox
{
    public partial class App
    {
        private bool _mock = true; // #TestSwitch

        private void RegisterDependencies(bool mock = true)
        {
            if (mock)
            {
                DependencyService.Register<IServices, DummyService>();
            }
            else
            {
                DependencyService.Register<IServices, BugServices>();
            }
        }
    }
}