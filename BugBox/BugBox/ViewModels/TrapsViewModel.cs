using BugBox.Models;
using BugBox.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace BugBox.ViewModels
{
    internal class TrapsViewModel : BaseViewModel
    {
        private IServices _services;
        private List<Trap> _traps;
        public List<Trap> Traps { get => _traps; set => SetPropertyValue(ref _traps, value, "Traps"); }

        private ICommand _loadCardsCommand;

        public ICommand LoadTrapsCommand => _loadCardsCommand ?? (_loadCardsCommand = new Command(
                async () => await RunSafe(
                    GetTrapsAsync()
                    )
                ));

        public TrapsViewModel()
        {
            _services = DependencyService.Get<IServices>();
            LoadTrapsCommand.Execute(null);
        }

        private async Task GetTrapsAsync()
        {
            Traps = await _services.GetAllTraps();
        }
    }
}