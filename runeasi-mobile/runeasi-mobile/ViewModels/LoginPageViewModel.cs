// using System;
// using System.Collections.Generic;
// using System.IdentityModel.Tokens.Jwt;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AppCenter.Crashes;
// using RunEasi.DataAccess;
// using RunEasi.DataAccess.Repositories.AccountRepository;
// using RunEasi.Services;
// using RunEasi.Views;
// using Xamarin.Essentials;
// using Xamarin.Forms;

using Prism.Navigation;
using Prism.Commands;
using Prism.Services;
using System.ComponentModel;


namespace RunEasi.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged//: ViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isLoginFormVisible;
        public bool IsLoginFormVisible
        {
            get => _isLoginFormVisible;
            set
            {
                _isLoginFormVisible = value;
                OnPropertyChanged(nameof(IsLoginFormVisible));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}