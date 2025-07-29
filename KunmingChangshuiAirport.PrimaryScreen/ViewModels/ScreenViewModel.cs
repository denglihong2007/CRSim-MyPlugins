using CRSim.ScreenSimulator.ViewModels;
﻿using CRSim.Core.Models;
using CRSim.Core.Abstractions;
namespace KunmingChangshuiAirport.PrimaryScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = $"如需要任何帮助，或有相关建议，请拨打96566。";
            ItemsPerPage = 20;
            ScreenCount = 1;
            StationType = StationType.Departure;
        }
    }
}
