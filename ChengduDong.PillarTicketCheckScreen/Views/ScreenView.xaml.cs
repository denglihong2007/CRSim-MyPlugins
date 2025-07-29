using ChengduDong.PillarTicketCheckScreen.ViewModels;
using System.Windows.Controls;

namespace ChengduDong.PillarTicketCheckScreen.Views
{
    /// <summary>
    /// SecondaryScreen.xaml 的交互逻辑
    /// </summary>
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
