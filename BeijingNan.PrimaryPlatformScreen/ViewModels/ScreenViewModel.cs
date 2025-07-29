using CRSim.ScreenSimulator.ViewModels;
using CRSim.Core.Abstractions;
namespace BeijingNan.PrimaryPlatformScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            ItemsPerPage = 1;
        }
    }
}
