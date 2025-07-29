using BeijingNan.TicketCheckScreen.ViewModels;
using System.Windows.Controls;
namespace BeijingNan.TicketCheckScreen.Views
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
