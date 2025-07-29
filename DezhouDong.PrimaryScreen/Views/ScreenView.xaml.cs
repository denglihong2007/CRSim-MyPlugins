using DezhouDong.PrimaryScreen.ViewModels;
using System.Windows.Controls;
namespace DezhouDong.PrimaryScreen.Views
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
