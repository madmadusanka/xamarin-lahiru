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
       
        #region
        public string _username;
        public string _password;
        #endregion


        #region
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
        public Command Login 
        {
            get; }
        #endregion


        #region
        public MainViewModel()
        {
            Login = new Command(async() => await Validate());
            
        }
       

        public string DisplayName => $"Username Entered : {Username} ";
        public string Status => $"{Username} Authenticated";
        
       
        #endregion
        public async Task Validate()
        {
            try
            {
                if (_username == null || _password == null)
                {
                    await Application.Current.MainPage.DisplayAlert("Warning", "Please Double Check the Credentials", "Ok");
                }
                else if (_username == "lahiru" && _password == "lahiru")
                {
                    await Application.Current.MainPage.DisplayAlert("Successfull", "Welcome ", "Ok");
                    App.Current.MainPage = new MainMenu();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Access Denied", "Please Check your Connection ", "Ok");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }

        }


        
        public event PropertyChangedEventHandler PropertyChanged;

        protected  void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        

    }
}
