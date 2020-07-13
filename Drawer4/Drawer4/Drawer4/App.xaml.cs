using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Drawer4.Services;
using Drawer4.Views;

namespace Drawer4
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
