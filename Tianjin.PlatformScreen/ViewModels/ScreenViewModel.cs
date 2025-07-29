using CRSim.ScreenSimulator.ViewModels;
using CRSim.Core.Abstractions;
namespace Tianjin.PlatformScreen.ViewModels
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
