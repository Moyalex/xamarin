using Microsoft.WindowsAzure.MobileServices;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contactos
{
    public partial class App : Application
    {
        public static MobileServiceClient mobileclient = new MobileServiceClient("");
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static string RUTA_DB; 

        public App(string ruta_bd)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            RUTA_DB = ruta_bd;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
