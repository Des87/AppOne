using App.Services;
using App.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit;

namespace App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
           // Device.SetFlages( new[] { "MediaElement_Experimental", "Brush_Experimental" });
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
