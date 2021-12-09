using System;
using System.Collections.Generic;
using System.Text;
using TesteShell.Cache;
using TesteShell.Views;
using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace TesteShell.ViewModels
{
    public class LanguageViewModel: BaseViewModel
    {
        public Command NextCommand { get; private set; }

        public LanguageViewModel()
        {
            NextCommand = new Command(NextAction);
        }

        private void NextAction()
        {
            CacheSettings.HasWizard = false;
            App.Current.MainPage = Startup.ServiceProvider.GetService<LoginPage>();
        }
    }
}
