using App.ViewModels;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DialogOkPage : PopupPage
    {
        string Text;
        bool IsOk;

        public DialogOkPage(string text, out bool isOk)
        {
            InitializeComponent();
            Text = text;
            isOk = IsOk;

        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            IsOk = true;
            await PopupNavigation.Instance.PopAsync();
        }
    }
}