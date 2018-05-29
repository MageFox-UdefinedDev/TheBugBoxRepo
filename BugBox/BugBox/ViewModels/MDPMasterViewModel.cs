﻿using BugBox.Models;
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
                    new MDPMenuItem { Id = 0, Title = "Traps" ,TargetType = typeof(Traps)},
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