using CRSim.ScreenSimulator.ViewModels;
using CRSim.Core.Abstractions;
namespace Yakeshi.PlatformScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = $"上下车不要拥挤，小心列车与站台之间的缝隙，看管好老人和同行的儿童";
            ItemsPerPage = 1;
        }
    }
}
