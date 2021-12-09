using System;
using System.Collections.Generic;
using System.Text;
using TesteShell.Cache;
using TesteShell.Views;
using Xamarin.Forms;

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
            CacheSettings.LoggedIn = true;
            if (string.IsNullOrEmpty(CacheSettings.UserSelectedCarrier)) // simulate more than one carrier for him
                App.Current.MainPage = new CarrierListPage();
            else
                App.Current.MainPage = new AppShell();
        }
    }
}
