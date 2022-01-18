using System;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using TestLogin.Models;
using System.Windows.Input;

namespace TestLogin
{
    public class MainViewModel : INotifyPropertyChanged
    {

       

        #region Variables
        public string _username;
        public string _password;
        #endregion


        #region Getters&Setters
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
                OnPropertyChanged(nameof(Username));
                OnPropertyChanged(nameof(DisplayName));

            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
                OnPropertyChanged(nameof(Password));
                OnPropertyChanged(nameof(Status));

            }

        }
        public ICommand LoginCommand
        {
            get;
        }
        public string DisplayName => $"Username Entered : {Username} ";
        public string Status => $"{Username} Authenticated";
        #endregion


        #region Command_Object
        public MainViewModel()
        {
            LoginCommand = new Command(async () => await Validate());

        }
        #endregion

        #region Validation
        public async Task Validate()
        {
            try
            {
                PostContent Registration = new PostContent
                {

                    email = _username,
                    password = _password

                };
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://reqres.in/api/");
                var Json = JsonConvert.SerializeObject(Registration);
                var content = new StringContent(Json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("https://reqres.in/api/login", content);

                var result = response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<TokenModel>(await result);
                if (data.Token == null )
                {
                    await Application.Current.MainPage.DisplayAlert("Success","Welcome", "Ok");
                    App.Current.MainPage = new MainMenu();
                    await new Alerts().SuccesAlerts();
                }
                else
                {
                    await new Alerts().WarningAlertAsync();
                }


            }
            catch (Exception ex)
            {
                //throw new Exception("Error", ex);
            }

        }
        #endregion


        #region Property_Change_Handler
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        internal class Services
        {
            internal interface IMessageService
            {
                void ShowAsync(string v);
            }
        }
       
    }
        #endregion

    
}
