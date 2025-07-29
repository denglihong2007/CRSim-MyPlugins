using ChengduDong.PrimaryTicketCheckScreen.ViewModels;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
namespace ChengduDong.PrimaryTicketCheckScreen.Views
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
