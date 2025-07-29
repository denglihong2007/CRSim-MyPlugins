using Yakeshi.PlatformScreen.ViewModels;
using System.Windows.Controls;

namespace Yakeshi.PlatformScreen.Views
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
