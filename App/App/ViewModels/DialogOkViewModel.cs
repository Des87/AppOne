using App.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App.ViewModels
{
    internal class DialogOkViewModel
    {
            public DialogOkViewModel(string text, out bool isOk)
            {
                OkCommand = new Command(OkClicked);
                Text = text;
                isOk = IsOk;
            }

            public Command OkCommand { get; }
            private string _Text;
        private bool _IsOk;
            public string Text
            {
                get
                {
                    return _Text;
                }
                set
                {
                _Text = value;
                }
            }
            public bool IsOk
            {
                get
                {
                    return _IsOk;
                }
                set
                {
                    _IsOk = value;
                }
            }
        private async void OkClicked(object obj)
            {
            IsOk = true;
            await PopupNavigation.Instance.PopAsync();
            }
        }
    }