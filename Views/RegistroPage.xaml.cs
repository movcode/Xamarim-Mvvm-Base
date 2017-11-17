using System;
using System.Collections.Generic;
using Registro.ViewsModels;
using Xamarin.Forms;

namespace Registro.Views
{
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
            BindingContext = new UsuariosViewsModels();
        }


    }
}
