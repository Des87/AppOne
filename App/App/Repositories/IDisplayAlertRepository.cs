using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public interface IDisplayAlertRepository
    {
        Task DisplayAlertOk(string title, string message, string cancel);
    }
}
