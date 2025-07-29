using XuzhouMetro.PlatformScreen.ViewModels;
using System.Windows.Controls;
using System.Windows;

namespace XuzhouMetro.PlatformScreen.Views
{
    public partial class ScreenView : Page
    {
        public ScreenViewModel ViewModel { get; }
        public ScreenView(ScreenViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            DataContext = viewModel;
            player.Play();
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            player.Position = TimeSpan.Zero;
            player.Play();
        }

    }
}
