using AppShellBug_14063.Services;
using AppShellBug_14063.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppShellBug_14063
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
