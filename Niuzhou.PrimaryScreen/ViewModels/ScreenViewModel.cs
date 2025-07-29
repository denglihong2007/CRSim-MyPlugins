using CRSim.ScreenSimulator.ViewModels;
﻿using CRSim.Core.Models;
using CRSim.Core.Abstractions;
namespace Niuzhou.PrimaryScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = $"开车前{settingsService.GetSettings().PassingCheckInAdvanceDuration.TotalMinutes}分钟开始检票，开车前{settingsService.GetSettings().StopCheckInAdvanceDuration.TotalMinutes}分钟停止检票。";
            ItemsPerPage = 10;
            ScreenCount = 1;
            StationType = StationType.Departure;
        }
    }
}
