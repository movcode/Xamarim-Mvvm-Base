using System;
using Registro.Services.Interfaces;
using Xamarin.Forms;

namespace Registro.ViewsModels
{
    public class LoginViewsModels : Services.BaseViewModel
    {
        public Command Execute { get; set; }
        public Command Assinar { get; set; }



        public LoginViewsModels()
        {
            Execute = new Command(show);
            Assinar = new Command(assinar);
        }

        public  void assinar()
        {
            AlertMessage.Show("Sucesso", "Pagina assinada com sucesso!", "Fechar");
             MessagingCenter.Subscribe<LoginViewsModels>(this, "login",(obj) => {
                AlertMessage.Show("sucesso", "recebeu!", "Fechar");
            });
        }


        public async void show() => await Navigate.To(new Views.RegistroPage());
    }

}
