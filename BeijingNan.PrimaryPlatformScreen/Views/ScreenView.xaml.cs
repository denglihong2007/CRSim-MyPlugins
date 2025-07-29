using BeijingNan.PrimaryPlatformScreen.ViewModels;
using System.Windows.Controls;

namespace BeijingNan.PrimaryPlatformScreen.Views
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
