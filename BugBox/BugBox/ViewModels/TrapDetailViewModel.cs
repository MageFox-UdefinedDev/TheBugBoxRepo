using BugBox.Models;

namespace BugBox.ViewModels
{
    internal class TrapDetailViewModel : BaseViewModel
    {
        private Trap _trap;
        public Trap SingleTrap { get => _trap; set => SetPropertyValue(ref _trap, value, "SingleTrap"); }

        public TrapDetailViewModel()
        {
        }

        public TrapDetailViewModel(Trap trap)
        {
            SingleTrap = trap;
        }
    }
}