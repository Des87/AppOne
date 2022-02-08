using App.Repositories;
using App.Views;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            Onboardings = GetOnboarding();
        }
        public List<Onboarding> Onboardings { get; set; }
        private List<Onboarding> GetOnboarding()
        {
        return new List<Onboarding>()
        {
            new Onboarding { Heading = "heding", Caption = "capcion"},
            new Onboarding { Heading = "heding2", Caption = "capc8ion"},
            new Onboarding { Heading = "hedi3ng", Caption = "ca9pcion"},

        };
        }
        public Command LoginCommand { get; }
        private string _Name;
        private string _Password;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }

        private async void OnLoginClicked(object obj)
        {
            bool NameValid = string.IsNullOrWhiteSpace(Name) ? true : false;
            bool PasswordValid = string.IsNullOrWhiteSpace(Password) ? true : false;
            if (!NameValid && !PasswordValid)
            {
                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            }
            else
            {
                if (NameValid && !PasswordValid)
                {
                    string Text = "kabbe";
                    bool isOk = false;
                    await PopupNavigation.Instance.PushAsync(new DialogOkPage(Text,out isOk), true);
                }
                if (!NameValid && PasswordValid)
                {

                    return;
                }
                if (NameValid && PasswordValid)
                {

                    return;
                }
            }
        }
        public class Onboarding
        {
            public string Heading { get; set; }
            public string Caption { get; set; }

        }
    }
}