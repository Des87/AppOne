using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class DisplayAlertRepository : IDisplayAlertRepository
    {
        public Task DisplayAlertOk(string title, string message, string cancel)
        {
            return App.Current.MainPage.DisplayAlert(title, message, cancel);
          
        }
    }
}
