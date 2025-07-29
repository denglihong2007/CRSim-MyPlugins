using BeijingXi.PrimaryScreen.ViewModels;
using System.Windows.Controls;
namespace BeijingXi.PrimaryScreen.Views
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
