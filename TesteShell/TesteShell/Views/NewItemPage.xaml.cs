using System;
using System.Collections.Generic;
using System.ComponentModel;
using TesteShell.Models;
using TesteShell.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteShell.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}