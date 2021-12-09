using System;
using System.Collections.Generic;
using TesteShell.Cache;
using TesteShell.ViewModels;
using TesteShell.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace TesteShell
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell(AppShellViewModel appShellViewModel = null)
        {
            InitializeComponent();
            BindingContext = appShellViewModel;
        }
    }
}
