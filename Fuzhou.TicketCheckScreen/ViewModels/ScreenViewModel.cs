using CRSim.ScreenSimulator.ViewModels;
using CRSim.Core.Abstractions;
using CRSim.Core.Models;
namespace Fuzhou.TicketCheckScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = $"开车前{settingsService.GetSettings().StopCheckInAdvanceDuration.TotalMinutes}分钟停止检票";
            ItemsPerPage = 4;
            StationType = StationType.Departure;
        }
    }
}
