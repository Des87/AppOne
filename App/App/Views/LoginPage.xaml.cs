using App.Repositories;
using App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
            AnimateCarousel();
            this.BindingContext = new LoginViewModel();
        }
        Timer timer;
        private void AnimateCarousel()
        {
            timer = new Timer(5000) { AutoReset = true, Enabled = true };
            timer.Elapsed += (s, e) =>
            {
                if (BgVideo.CurrentState != Xamarin.CommunityToolkit.UI.Views.MediaElementState.Playing)
                {
                    BgVideo.Play();
                }
                Device.BeginInvokeOnMainThread(() =>
                {
                    if (cvOnboarding.Position == 2)
                    {
                        cvOnboarding.Position = 0;
                        return;
                    }
                    cvOnboarding.Position += 1;
                });
            };
        }
    }
}