using RailWaveTrack.Pages;
using RailWaveTrack.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace RailWaveTrack
{
	public partial class App : Application
	{
        public static ServiceManager serviceManager = null;
		public App ()
		{
            // Fetch and Sync Operations not working
			InitializeComponent();

            if (serviceManager == null)
                serviceManager = new ServiceManager(new RestServices());
            Application.Current.MainPage = new NavigationPage(new RailMainGui());
        }
        
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
