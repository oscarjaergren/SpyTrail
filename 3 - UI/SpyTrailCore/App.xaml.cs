using System;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Auth;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Data;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpyTrail.Services;
using SpyTrail.Views;

namespace SpyTrail
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        //To debug on Android emulators run the web backend against .NET Core not IIS
        //If using other emulators besides stock Google images you may need to adjust the IP address
        public static string AzureBackendUrl =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static bool UseMockDataStore = true;

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=d21f596b-2b07-4aad-902c-4226d432c562;" +
                            "uwp={Your UWP App secret here};" +
                            "ios={Your iOS App secret here}",
                typeof(Analytics), typeof(Crashes), typeof(Data), typeof(Auth));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
