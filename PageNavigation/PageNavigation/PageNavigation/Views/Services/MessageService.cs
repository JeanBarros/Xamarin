using PageNavigation.ViewModels.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigation.Views.Services
{
    public class MessageService : IMessageService
    {
        public async Task ShowAsync(string message)
        {
            await PageNavigation.App.Current.MainPage.DisplayAlert("MVVM", message, "Ok");
        }
    }
}
