using RailWaveTrack.Modal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RailWaveTrack.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PnrPage : ContentPage
	{
         
        List<Passenger> passengers;     
        public ObservableCollection<Passenger> Observablepassengers { get; set; }
        public PnrPage ()
		{
			InitializeComponent ();                 
        }        

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                ctrlActivator.IsRunning = true;
                PNRRootobject pnrRootobject = null;
                if (CheckForInternetConnection())
                {
                    pnrRootobject = await App.serviceManager.RefreshDataAsync(ctrlTxtPNR.Text);
                    if (pnrRootobject != null)
                    {
                        ctrlFramePNRResult.IsVisible = true;
                        ctrlFrameBookingStatus.IsVisible = true;
                        ctrlBottomFrame.IsVisible = true;
                        ctrlBookingStatus.IsVisible = true;
                        Observablepassengers = new ObservableCollection<Passenger>(pnrRootobject.passengers);
                        ctrlGridSource.ItemsSource = Observablepassengers; 
                        this.BindingContext = pnrRootobject;
                    }
                    else
                        await DisplayAlert("Information !", "Please Enter valid PNR..", "OK");
                }
                else
                    await DisplayAlert("Warning !", "Internet Connection Lost..", "OK");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                ctrlActivator.IsRunning = false;
                // pnrRootobject = null;
            }
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}