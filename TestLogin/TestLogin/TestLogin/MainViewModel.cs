using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace TestLogin
{
    internal class MainViewModel : INotifyPropertyChanged
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
        public Command LoginCommand
        {
            get; }
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
                if (_username == null || _password == null)
                {
                    await new Alerts().WarningAlertAsync();
                }
                else if (_username == "lahiru" && _password == "lahiru")
                {
                    await new Alerts().SuccesAlerts();
                    App.Current.MainPage = new MainMenu();
                }
                else
                {
                     new Alerts().ErrorAlertAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }

        }
        #endregion


        #region Property_Change_Handler
        public event PropertyChangedEventHandler PropertyChanged;

        protected  void OnPropertyChanged(string propertyName)
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
        #endregion

    }
}
