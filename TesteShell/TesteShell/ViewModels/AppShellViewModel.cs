using System;
using System.Collections.Generic;
using System.Text;
using TesteShell.Cache;
using Xamarin.Essentials;
using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;
using TesteShell.Views;

namespace TesteShell.ViewModels
{
    public class AppShellViewModel
    {
        public Command LogOutCommand { get; private set; }

        public AppShellViewModel()
        {
            LogOutCommand = new Command(LogOutAction);
        }

        private void LogOutAction()
        {
            CacheSettings.LoggedIn = false;

            SecureStorage.RemoveAll();

            App.Current.MainPage = Startup.ServiceProvider.GetService<LoginPage>();
        }
    }
}
