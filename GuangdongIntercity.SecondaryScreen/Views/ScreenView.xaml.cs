using GuangdongIntercity.SecondaryScreen.ViewModels;
using System.Windows.Controls;

namespace GuangdongIntercity.SecondaryScreen.Views
{
    public partial class ScreenView : Page
    {
        public ScreenViewModel ViewModel { get; }
        public ScreenView(ScreenViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            DataContext = viewModel;
        }
    }
}
