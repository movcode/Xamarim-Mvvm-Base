using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Registro.Services.Interfaces
{
    public interface INavigateService
    {
        Task To(Page page);
    }
}
