using System.ComponentModel;
using TesteShell.ViewModels;
using Xamarin.Forms;

namespace TesteShell.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}