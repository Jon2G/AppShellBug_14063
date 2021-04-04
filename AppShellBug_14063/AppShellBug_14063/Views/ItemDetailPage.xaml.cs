using AppShellBug_14063.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppShellBug_14063.Views
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