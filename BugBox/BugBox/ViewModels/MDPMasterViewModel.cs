using BugBox.Models;
using BugBox.Pages;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BugBox.ViewModels
{
    internal class MDPMasterViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MDPMenuItem> MenuItems { get; set; }

        public MDPMasterViewModel()
        {
            MenuItems = new ObservableCollection<MDPMenuItem>(new[]
            {
                    new MDPMenuItem { Id = 0, Title = "Page 1" ,TargetType = typeof(Page1)},
                    new MDPMenuItem { Id = 1, Title = "Page 2" ,TargetType = typeof(Page2)},
                    new MDPMenuItem { Id = 2, Title = "Page 3" ,TargetType = typeof(Page3)},
                });
        }

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion INotifyPropertyChanged Implementation
    }
}