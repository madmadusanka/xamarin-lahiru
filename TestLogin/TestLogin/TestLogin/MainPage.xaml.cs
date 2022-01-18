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
            //loginButton.Clicked += LoginButton_Clicked;
            // username = new Entry {Text = "lahiru"};
            // password = new Entry { Text = "lahiru" };
        }
        //void LoginButton_Clicked(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (username.Text == "lahiru" && password.Text == "lahiru")
        //        {
        //            App.Current.MainPage = new MainMenu();
        //            DisplayAlert("Successfull", "Welcome mr lahiru", "Great");
        //        }
        //        else
        //        {
        //            DisplayAlert("Warning", "Enter Credentials to Login", "OK");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Stopped Responding", ex);
        //    }
            
        //}
    }
}
