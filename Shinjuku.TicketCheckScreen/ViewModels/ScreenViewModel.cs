using CRSim.ScreenSimulator.ViewModels;
using CRSim.Core.Abstractions;
using CRSim.Core.Models;

namespace Shinjuku.TicketCheckScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            ItemsPerPage = 3;
            ScreenCount = 1;
            StationType = StationType.Departure;
        }
    }
}
