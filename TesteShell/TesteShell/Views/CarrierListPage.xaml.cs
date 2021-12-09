using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteShell.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteShell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarrierListPage : ContentPage
    {
        public CarrierListPage()
        {
            InitializeComponent();
            this.BindingContext = new CarrierListViewModel();
        }
    }
}