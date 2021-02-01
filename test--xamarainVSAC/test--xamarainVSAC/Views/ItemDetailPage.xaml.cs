using System.ComponentModel;
using Xamarin.Forms;
using test__xamarainVSAC.ViewModels;

namespace test__xamarainVSAC.Views
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