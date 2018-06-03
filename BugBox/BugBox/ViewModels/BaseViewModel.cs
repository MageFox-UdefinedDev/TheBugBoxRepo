using Acr.UserDialogs;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BugBox.ViewModels
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        private INavigation _navigation { get; }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private bool _isBusy = false;

        public bool IsBusy
        {
            get => _isBusy;
            set => SetPropertyValue(ref _isBusy, value, "IsBusy");
        }

        public BaseViewModel(INavigation navigation = null)
        {
            _navigation = navigation;
        }

        protected void RaiseAllPropertiesChanged()
        {
            // By convention, an empty string indicates all properties are invalid.
            PropertyChanged(this, new PropertyChangedEventArgs(string.Empty));
        }

        protected void RaisePropertyChanged<T>(Expression<Func<T>> propExpr)
        {
            var prop = (PropertyInfo)((MemberExpression)propExpr.Body).Member;
            this.RaisePropertyChanged(prop.Name);
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetPropertyValue<T>(ref T storageField, T newValue, Expression<Func<T>> propExpr)
        {
            if (Equals(storageField, newValue))
                return false;

            storageField = newValue;
            var prop = (PropertyInfo)((MemberExpression)propExpr.Body).Member;
            this.RaisePropertyChanged(prop.Name);

            return true;
        }

        protected bool SetPropertyValue<T>(ref T storageField, T newValue, [CallerMemberName] string propertyName = "")
        {
            if (Equals(storageField, newValue))
                return false;

            storageField = newValue;
            this.RaisePropertyChanged(propertyName);

            return true;
        }

        public async Task RunSafe(Task task, bool ShowLoading = true, string loadingMessage = null)
        {
            try
            {
                if (IsBusy) return;

                IsBusy = true;

                if (ShowLoading) UserDialogs.Instance.ShowLoading(loadingMessage ?? "Loading");

                await task;
            }
            catch (Exception e)
            {
                IsBusy = false;
                UserDialogs.Instance.HideLoading();
            }
            finally
            {
                IsBusy = false;
                if (ShowLoading) UserDialogs.Instance.HideLoading();
            }
        }
    }
}