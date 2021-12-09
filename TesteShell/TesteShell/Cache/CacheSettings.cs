using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace TesteShell.Cache
{
    public class CacheSettings
    {
        public CacheSettings()
        {

        }

        public static bool HasWizard
        {
            get => Preferences.Get("HasWizard", true);
            set => Preferences.Set("HasWizard", value);
        }

        public static bool LoggedIn
        {
            get => Preferences.Get("LoggedIn", true);
            set => Preferences.Set("LoggedIn", value);
        }

        public static string UserSelectedCarrier
        {
            get => SecureStorage.GetAsync("UserSelectedCarrier").Result;
            set => SecureStorage.SetAsync("UserSelectedCarrier", value);
        }
    }
}
