using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Drawer_2._0.Services;
using Drawer_2._0.Views;

namespace Drawer_2._0
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
