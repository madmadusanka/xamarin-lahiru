using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestLogin
{
    internal class Alerts
    {
        public async Task WarningAlertAsync()
        {
            await Application.Current.MainPage.DisplayAlert("Warning", "Please Double Check the Credentials", "Ok");
        }
        public async Task SuccesAlerts()
        {
            await Application.Current.MainPage.DisplayAlert("Successfull", "Welcome ", "Ok");
        }
        public async void ErrorAlertAsync()
        {
            await Application.Current.MainPage.DisplayAlert("Access Denied", "Please Check your Connection ", "Ok");
        }
    }
}
