using CRSim.ScreenSimulator.ViewModels;
using CRSim.Core.Abstractions;
namespace GuangdongIntercity.SecondaryScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = $"列 车 到 发 信 息";
            ItemsPerPage = 8;
            ScreenCount = 1;
        }
    }
}
