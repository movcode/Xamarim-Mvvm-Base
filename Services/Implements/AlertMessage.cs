using System;
using System.Threading.Tasks;
using Registro.Services.Interfaces;
using Xamarin.Forms;

namespace Registro.Services.Implements
{
    public class AlertMessage : Interfaces.IAlertMessage
    {
        public async Task Show(string title, string msg, string btn)
        {
            await Application.Current.MainPage.DisplayAlert(title, msg, btn);
        }

        public async Task ShowOption(string title, string cancel, string destruction, params string[] buttons)
        {
            await Application.Current.MainPage.DisplayActionSheet(title, cancel, destruction, buttons);
        }
    }
}
