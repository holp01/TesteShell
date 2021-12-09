using System;
using System.Collections.Generic;
using System.Text;
using TesteShell.Cache;
using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;

namespace TesteShell.ViewModels
{
    public class CarrierListViewModel : BaseViewModel
    {
        public Command TapCommand { get; private set; }

        private ObservableCollection<string> _CarrierListe;
        public ObservableCollection<string> CarrierList
        {
            get => _CarrierListe;
            set
            {
                _CarrierListe = value;
                OnPropertyChanged();
            }
        }

        public CarrierListViewModel()
        {
            CheckRedirectPage();
            TapCommand = new Command(ChooseCarrierAction);
        }

        private async void CheckRedirectPage()
        {
            if (!string.IsNullOrEmpty(CacheSettings.UserSelectedCarrier)) // simulates having one Carrier or opening app with login done
                await Shell.Current.GoToAsync($"///AboutPage"); //replaces the navigation stack with the Main Page
            else //doesnt replace the navigation stack and stays in the CarrierList
            {
                CarrierList = new ObservableCollection<string>() { "Carrier 1", "Carrier 2" };
            }
        }

        public async void ChooseCarrierAction()
        {
            CacheSettings.UserSelectedCarrier = "Carrier 1";
            await Shell.Current.GoToAsync($"///AboutPage");
        }
    }
}
