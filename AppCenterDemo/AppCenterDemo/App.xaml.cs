using AppCenterDemo.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppCenterDemo
{
	public partial class App : Application
	{
        public App()
		{
			InitializeComponent();

			SetMainPage();
		}

        protected override void OnStart()
        {
            AppCenter.LogLevel = LogLevel.Verbose;
            AppCenter.Start("android=04c56111-2b8a-4e57-b71e-87313ad92a3d;" +
                  typeof(Analytics), typeof(Crashes));
        }

		public static void SetMainPage()
		{
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse",
                        Icon = Xamarin.Forms.Device.OnPlatform<string>("tab_feed.png",null,null)
                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About",
                        Icon = Xamarin.Forms.Device.OnPlatform<string>("tab_about.png",null,null)
                    },
                }
            };
        }
	}
}
