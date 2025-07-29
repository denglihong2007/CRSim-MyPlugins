using ChengduShuangliuAirport.SecondaryScreen.ViewModels;
using System.Windows.Controls;

namespace ChengduShuangliuAirport.SecondaryScreen.Views
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
