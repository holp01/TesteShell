using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;
using TesteShell.ViewModels;
using Xamarin.Essentials;

namespace TesteShell
{

    public static class Startup
    {
        public static IServiceProvider ServiceProvider { get; set; }
        public static App Init(Action<IServiceCollection> nativeConfigureServices)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            //all of the same code from before
            return ServiceProvider.GetService<App>();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<LoginViewModel>();
            services.AddTransient<CarrierListViewModel>();
            services.AddTransient<LoginViewModel>();
        }
    }
}
