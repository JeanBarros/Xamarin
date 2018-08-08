using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PageNavigation.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                this.Notify("Email");
            }
        }

        string pass;
        public string Pass
        {
            get
            {
                return pass;
            }
            set
            {
                pass = value;
                this.Notify("Pass");
            }
        }

        public ICommand LoginCommand
        {
            get;
            set;
        }

        public ICommand RegisterCommand
        {
            get;
            set;
        }

        private readonly Services.IMessageService _messageService;
        public LoginViewModel()
        {
            this.LoginCommand = new Command(this.Login);
            this.RegisterCommand = new Command(this.Register);

            this._messageService = DependencyService.Get<Services.IMessageService>();
        }
        
        private void Login()
        {
            if(this.Email=="adm" && this.Pass=="123")
            {
                _messageService.ShowAsync("Bem vindo, ADM");
            }
            else
            {
                this._messageService.ShowAsync("Email ou senha inválidos");
            }
        }

        private void Register()
        {

        }
    }
}
