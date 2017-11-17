using System;
using Registro.Services.Interfaces;
using Xamarin.Forms;

namespace Registro.Services
{
    public class BaseViewModel
    {
        public INavigateService Navigate { get; set; } = DependencyService.Get<INavigateService>();
        public IAlertMessage AlertMessage { get; set; } = DependencyService.Get<IAlertMessage>();
    }
}
