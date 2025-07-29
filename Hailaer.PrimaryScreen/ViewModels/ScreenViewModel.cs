using CRSim.ScreenSimulator.ViewModels;
﻿using CRSim.Core.Models;
using CRSim.Core.Abstractions;
namespace Hailaer.PrimaryScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            ItemsPerPage = 6;
            ScreenCount = 2;
            Text = $"    开车前{settingsService.GetSettings().StopCheckInAdvanceDuration.TotalMinutes}分钟停止检票";;
            StationType = StationType.Departure;
        }
    }
}
