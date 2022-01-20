using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestLogin.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;

namespace TestLogin
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {

            try
            {
                InitializeComponent();
            }
            catch(Exception ex)
            {

            }
            
            //loginButton.Clicked += login_button_clicked;  
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
        //public async void login_button_clicked(object sender,EventArgs e)
        //{
        //    try
        //    {
        //        IMyApi myapi;
        //        myapi = RestService.For<IMyApi>("https://reqres.in/api/login");

        //        PostContent post = new PostContent();
        //        post.email = "lahiru980529@gmail.com";
        //        post.password = "lahiru";

        //        PostContent result = await myapi.SubmitPost(post);
        //        if (result != null)
        //        {
        //            App.Current.MainPage = new MainMenu();
        //        }
        //        else
        //        {
        //            await DisplayAlert("Warning", "Please Check the Connection", "Ok");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Stopped Responding", ex);
        //    }
        //}
    }









}

