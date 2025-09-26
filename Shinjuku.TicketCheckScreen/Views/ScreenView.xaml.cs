using Shinjuku.TicketCheckScreen.ViewModels;
using System.Windows.Controls;

namespace Shinjuku.TicketCheckScreen.Views
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
