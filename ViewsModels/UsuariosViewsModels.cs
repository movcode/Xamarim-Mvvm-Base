using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Registro.ViewsModels
{
    public class UsuariosViewsModels:Services.BaseViewModel
    {
        public Command Exec { get; set; }


        public  UsuariosViewsModels()
        {
            AlertMessage.Show("Sucess", "Sejá Bem Vindo!", "Fechar");
            Exec = new Command(show);
        }

        public async void show()
        {            
            MessagingCenter.Send<LoginViewsModels>(new LoginViewsModels(), "login");
            await Navigate.To(new Views.LoginPage());

        }
    }
}