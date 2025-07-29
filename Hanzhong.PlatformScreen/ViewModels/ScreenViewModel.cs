using CRSim.ScreenSimulator.ViewModels;
using CRSim.Core.Abstractions;
namespace Hanzhong.PlatformScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            ItemsPerPage = 1;
            Text = "请注意列车与站台之间的间隙，请勿携带危险品上车";
        }
    }
}