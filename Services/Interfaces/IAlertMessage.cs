using System;
using System.Threading.Tasks;

namespace Registro.Services.Interfaces
{
    public interface IAlertMessage
    {
        Task Show(string title, string msg,  string btn);

        Task ShowOption(string title, string cancel, string destruction, params string[] buttons);
    }
}
