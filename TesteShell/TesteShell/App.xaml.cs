using System;
using TesteShell.Cache;
using TesteShell.Services;
using TesteShell.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteShell
{
    public partial class App : Application
    {

        public App(App app)
        {
            InitializeComponent();
            RegisterRoutes();

            DependencyService.Register<MockDataStore>();

            RedirectFirstPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private void RedirectFirstPage()
        {
            if (CacheSettings.HasWizard)
                MainPage = Startup.ServiceProvider.GetService<LanguagePage>();
            else if (CacheSettings.LoggedIn)
                MainPage = Startup.ServiceProvider.GetService<AppShell>();
            else
                MainPage = Startup.ServiceProvider.GetService<LoginPage>();
        }
    }
}
