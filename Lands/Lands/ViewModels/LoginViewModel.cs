
namespace Lands.ViewModels
{
    using System;
    using System.Windows.Input;

    public class LoginViewModel
    {
        #region Properties
        public String Email
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }

        public bool IsRemembered
        {
            get;
            set;
        }
        #endregion

        #region Contrutors

        #endregion
        public LoginViewModel()
        {
            this.IsRemembered = true;
        }
        #region Commands
        public ICommand  LoginCommand
        {
            get;
            set;
        }
        #endregion
    }
}
