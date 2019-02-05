
namespace Lands.ViewModels
{
    using System;
    public class MainViewModel
    {
        #region ViewModel
        public LoginViewModel Login
        {
            get;
            set;
        }
        #endregion

        #region Contructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();  
        }
        #endregion
    }
}
