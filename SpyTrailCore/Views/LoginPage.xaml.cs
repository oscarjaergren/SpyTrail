using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter.Auth;

namespace SpyTrail.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            LoginCommand = new Command(SignIn);

            SignIn();
        }

        public ICommand LoginCommand { get; set; }


        private async void SignIn()
        {
            try
            {
                // Sign-in succeeded.
                UserInformation userInfo = await Auth.SignInAsync();
            }
            catch (Exception e)
            {
                // Do something with sign-in failure.
                Debug.WriteLine(e);
            }
        }
    }
}