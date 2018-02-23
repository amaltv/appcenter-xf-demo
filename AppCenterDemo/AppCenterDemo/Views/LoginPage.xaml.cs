using AppCenterDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCenterDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel loginViewModel;
        public LoginPage()
        {
            InitializeComponent();
            loginViewModel = new LoginViewModel();
            BindingContext = this.loginViewModel;
        }

        private async void OnLogin(object sender, EventArgs e)
        {
            if (isAuthorizedUser(this.loginViewModel.UserName, this.loginViewModel.Password))
            {
                await Navigation.PushAsync(new TabbedPage
                {
                    Children =
                            {
                                new NavigationPage(new ItemsPage())
                                {
                                    Title = "Browse",
                                    Icon = Device.OnPlatform<string>("tab_feed.png",null,null)
                                },
                                new NavigationPage(new AboutPage())
                                {
                                    Title = "About",
                                    Icon = Device.OnPlatform<string>("tab_about.png",null,null)
                                },
                            }
                });
            }

        }

        /// <summary>
        /// Mock Authorization method
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool isAuthorizedUser(string userName, string password)
        {
            if (string.Compare(userName, "admin", true) == 0 && string.Compare(password, "admin", true) == 0)
            {
                this.loginViewModel.IsAuthorized = false;
                return true;
            }
            else
            {
                this.loginViewModel.IsAuthorized = true;
                return false;
            }
        }
    }
}