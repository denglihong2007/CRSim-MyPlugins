using CRSim.ScreenSimulator.ViewModels;
﻿using CRSim.Core.Models;
using CRSim.Core.Abstractions;
namespace DaqingDong.ConcourseBridgeScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            ItemsPerPage = 3;
            StationType = StationType.Departure;
            timeService.RefreshSecondsElapsed += RefreshDisplay;
        }
    }
}
