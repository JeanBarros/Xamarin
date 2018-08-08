using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace PageNavigation
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            DependencyService.Register<ViewModels.Services.IMessageService, Views.Services.MessageService>();
            
            // P�gina inicial da aplica��o
            MainPage = new NavigationPage(new Views.LoginView());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
