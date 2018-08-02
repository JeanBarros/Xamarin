using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BoasVindas.ViewModels
{
    public class MainPageViewModel : NotificaBase
    {
        public string Nome { get; set; }

        private string _menssagem;
        public string Mensagem
        {
            get { return _menssagem; }
            set
            {   _menssagem = value;
                Notificar();
            }
        }

        public Command BoasVindasCommand
        {
            get
            {
                return new Command(() =>
               {
                   Mensagem = "Bem vindo, " + Nome;
               });
            }
        }
    }
}
