using CRSim.ScreenSimulator.ViewModels;
using CRSim.Core.Abstractions;
namespace Guangzhou.PlatformScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = $"请在白线内行走，乘降列车时注意脚下站台与列车之间的空隙，看护好老人和儿童。";
            ItemsPerPage = 1;
        }
    }
}
