using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            loginButton.Clicked += LoginButton_Clicked;
            var username = new Entry {Text = "lahiru"};
            var password = new Entry { Text = "lahiru"};
        }
        void LoginButton_Clicked(object sender, EventArgs e)
        {
            if (username.Text == "lahiru" && password.Text == "lahiru")
            {
                App.Current.MainPage = new Page1();
                DisplayAlert("Successfull", "Welcome mr lahiru", "Great");
            }
            else
            {
                DisplayAlert("Warning", "Enter Credentials to Login", "OK");
            }
            
        }
    }
}
