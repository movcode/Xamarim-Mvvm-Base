using Xamarin.Forms;
using Registro.Services;
using Registro.Services.Interfaces;


namespace Registro
{
    public partial class App : Application
    {
                   
        public App()
        {
            InitializeComponent();

            registerDepedency();

            MainPage = new NavigationPage(new Views.LoginPage());
        }


        private void registerDepedency()
        {            
            DependencyService.Register<INavigateService, Services.Implements.NavigateSevice>();
            DependencyService.Register<IAlertMessage, Services.Implements.AlertMessage>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}