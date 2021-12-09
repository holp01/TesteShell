using System;
using System.Collections.Generic;
using TesteShell.Cache;
using TesteShell.ViewModels;
using TesteShell.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TesteShell
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            CacheSettings.LoggedIn = false;

            SecureStorage.RemoveAll();

            App.Current.MainPage = new LoginPage();
        }
    }
}
