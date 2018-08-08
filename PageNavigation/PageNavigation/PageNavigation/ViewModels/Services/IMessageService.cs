using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigation.ViewModels.Services
{
    public interface IMessageService
    {
        Task ShowAsync(string message);
    }
}
