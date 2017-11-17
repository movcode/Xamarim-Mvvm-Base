using System.Threading.Tasks;
using Registro.Services.Interfaces;
using Xamarin.Forms;

namespace Registro.Services.Implements
{
    public class NavigateSevice : INavigateService
    {
        
        async Task INavigateService.To(Page page) =>   
            await Application.Current.MainPage.Navigation.PushAsync(page);

    }
}
