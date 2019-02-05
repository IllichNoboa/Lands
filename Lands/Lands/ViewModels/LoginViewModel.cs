
namespace Lands.ViewModels
{
    using System;

    using System.ComponentModel;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;

    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Attributes
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Properties
        public String Email
        {
            get;
            set;
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (this.password != value)
                {
                    this.password = value;
                    PropertyChanged?.Invoke(
                    this,
                    new PropertyChangedEventArgs(nameof(Password)));
                }
            }
        }
        public bool IsRunning
        {
            get
            {
                return isRunning;
            }
            set
            {
                if (this.isRunning != value)
                {
                    this.isRunning = value;
                    PropertyChanged?.Invoke(
                    this,
                    new PropertyChangedEventArgs(nameof(IsRunning)));
                }

            }
        }
        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get
            {
                return isEnabled;
            }
            set
            {
                if (this.isEnabled != value)
                {
                    this.isEnabled = value;
                    PropertyChanged?.Invoke(
                    this,
                    new PropertyChangedEventArgs(nameof(IsEnabled)));
                }
            }
        }
        #endregion

        #region Contrutors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.IsEnabled = true;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                "Error!",
                "You must enter an email.",
                "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                "Error!",
                "You must enter a password.",
                "Accept");
                return;
            }
            if (this.Email != "vladimirillichnoboap@gmail.com" || this.Password != "1234")
            {
                await Application.Current.MainPage.DisplayAlert(
                "Error!",
                "Email or password incorret.",
                "Accept");
                this.Password = string.Empty;
                return;
            }
            await Application.Current.MainPage.DisplayAlert(
                "Great!",
                "You're logged.",
                "Accept");
        }
        #endregion
    }
}
