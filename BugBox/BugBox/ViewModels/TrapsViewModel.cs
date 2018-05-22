using BugBox.Models;
using BugBox.Services;
using System.Collections.Generic;

namespace BugBox.ViewModels
{
    internal class TrapsViewModel : BaseViewModel
    {
        private DummyService _services;
        private List<Trap> _traps;
        public List<Trap> Traps { get => _traps; set => SetPropertyValue(ref _traps, value, "Traps"); }

        public TrapsViewModel()
        {
            _services = new DummyService();
            Traps = _services.GetAllTrapsPublic();
        }
    }
}