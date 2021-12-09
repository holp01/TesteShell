using System;
using System.Collections.Generic;
using System.Text;
using TesteShell.Cache;
using Xamarin.Forms;

namespace TesteShell.ViewModels
{
    public class CarrierListViewModel
    {
        public Command TapCommand { get; private set; }

        public CarrierListViewModel()
        {
            if (string.IsNullOrEmpty(CacheSettings.UserSelectedCarrier))
                App.Current.MainPage = new AppShell();
            else
            {

                TapCommand = new Command(ChooseCarrierAction);
            }
        }

        public void ChooseCarrierAction()
        {
            CacheSettings.UserSelectedCarrier = "Carrier1";
            App.Current.MainPage = new AppShell();
        }
    }
}
