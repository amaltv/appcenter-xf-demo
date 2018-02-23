using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppCenterDemo.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string userName;
        private string password;
        private bool isAuthorized;
        public LoginViewModel()
        {
            
        }

        public string UserName
        {
            get => userName;
            set { SetProperty(ref userName, value); }
        }
        public string Password
        {
            get => password;
            set { SetProperty(ref password, value); }
        }

        public bool IsAuthorized
        {
            get => isAuthorized;
            set
            {
                SetProperty(ref isAuthorized, value);
            }
        }
    }
}
