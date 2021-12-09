using System;
using System.Collections.Generic;
using System.Text;
using TesteShell.Cache;
using TesteShell.Views;
using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace TesteShell.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private void OnLoginClicked(object obj)
        {
            //Microsoft login e pedidos em brackground _=Task.Run(()=> {})
            CacheSettings.LoggedIn = true;
            App.Current.MainPage = Startup.ServiceProvider.GetService<AppShell>();
        }
    }
}
