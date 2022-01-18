using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestLogin
{
    internal interface DisplayMessages
    {
        Task ShowAsync(string message);
    }
    public class ServiceMessage : DisplayMessages
    {
        public async Task ShowAsync(string message)
        {
            await App.Current.MainPage.DisplayAlert("YourApp", message, "Ok");
            throw new NotImplementedException();
        }
    }

}
