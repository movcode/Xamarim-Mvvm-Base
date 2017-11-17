using System;
using System.Collections.Generic;
using Registro.ViewsModels;
using Xamarin.Forms;

namespace Registro.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            BindingContext = new LoginViewsModels();
        }

   }
}
