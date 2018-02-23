using Microsoft.AppCenter.Analytics;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppCenterDemo.ViewModels
{
	public class AboutViewModel : BaseViewModel
	{
		public AboutViewModel()
		{
			Title = "About";

			OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));

            
            TrackCommand = new Command(() => Analytics.TrackEvent("About Clicked"));

            CrashCommand = new Command(() =>
            {
                string message = null;
                if(message.Length > 256)
                {
                    message.Substring(0, 50);
                }
            });
		}

        public ICommand CrashCommand { get; }

        public ICommand TrackCommand { get; }

		/// <summary>
		/// Command to open browser to xamarin.com
		/// </summary>
		public ICommand OpenWebCommand { get; }
	}
}
