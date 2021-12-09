using System;
using System.Collections.Generic;
using System.Text;
using TesteShell.Cache;
using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace TesteShell.ViewModels
{
    public class CarrierListViewModel
    {
        public Command TapCommand { get; private set; }

        public CarrierListViewModel()
        {
            TapCommand = new Command(ChooseCarrierAction);
        }

        public void ChooseCarrierAction()
        {
            CacheSettings.UserSelectedCarrier = "Carrier1";
            App.Current.MainPage = Startup.ServiceProvider.GetService<AppShell>();
        }
    }
}
