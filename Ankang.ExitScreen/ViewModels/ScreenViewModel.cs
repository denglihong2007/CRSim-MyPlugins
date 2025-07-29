using CRSim.ScreenSimulator.ViewModels;
using CRSim.Core.Abstractions;
using CRSim.Core.Models;
namespace Ankang.ExitScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = $"西安局集团公司推出西铁行APP站车服务产品，欢迎体验使用。";
            ItemsPerPage = 7;
            ScreenCount = 1;
            StationType = StationType.Arrival;
        }
    }
}
