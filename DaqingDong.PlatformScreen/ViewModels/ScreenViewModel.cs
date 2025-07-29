using CRSim.ScreenSimulator.ViewModels;
using CRSim.Core.Abstractions;
namespace DaqingDong.PlatformScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            ItemsPerPage = 1;
            Text = $"请站在白色安全线以内排队候车";
        }
    }
}
