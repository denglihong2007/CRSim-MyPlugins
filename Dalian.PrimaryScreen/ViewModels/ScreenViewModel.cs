using CRSim.ScreenSimulator.ViewModels;
﻿using CRSim.Core.Models;
using CRSim.Core.Abstractions;
namespace Dalian.PrimaryScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = $"开车前 {settingsService.GetSettings().StopCheckInAdvanceDuration.TotalMinutes} 分钟停止检票   服务监督电话：024-12306";
            ItemsPerPage = 6;
            ScreenCount = 2;
            StationType = StationType.Departure;
        }
    }
}
