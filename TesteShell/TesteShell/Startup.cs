using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;
using TesteShell.ViewModels;
using TesteShell.Views;
using Xamarin.Essentials;

namespace TesteShell
{
    public static class Startup
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static App Init(Action<IServiceCollection> nativeConfigureServices)
        {
            var serviceCollection = new ServiceCollection();
            if (ServiceProvider == null)
            {
                ConfigureServices(serviceCollection);
                ServiceProvider = serviceCollection.BuildServiceProvider();
            }

            //return the same code from before
            return ServiceProvider.GetService<App>();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //Pages
            services.AddTransient<LanguagePage>();
            services.AddTransient<LoginPage>();
            services.AddTransient<CarrierListPage>();
            services.AddTransient<AppShell>();
            services.AddTransient<AboutPage>();

            //ViewModels
            services.AddTransient<LanguageViewModel>();
            services.AddTransient<LoginViewModel>();
            services.AddTransient<CarrierListViewModel>();
            services.AddSingleton<AppShellViewModel>();
            services.AddTransient<AboutViewModel>();
        }
    }
}
