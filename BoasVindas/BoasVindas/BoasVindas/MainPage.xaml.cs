using BoasVindas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BoasVindas
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.BindingContext = new MainPageViewModel();
		}

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    var nome = txtNome.Text;
        //    lblMensagem.Text = "Bem vindo, " + nome;
        //}

    }
}
