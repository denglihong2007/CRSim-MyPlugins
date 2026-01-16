using CRSim.ScreenSimulator.ViewModels;
﻿using CRSim.Core.Models;
using CRSim.Core.Abstractions;
namespace Haikou.OutsideScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = "广铁U彩提醒您候车服务时间：00:00-23:59";
            ItemsPerPage = 4;
            ScreenCount = 1;
            StationType = StationType.Departure;
        }
    }
}
