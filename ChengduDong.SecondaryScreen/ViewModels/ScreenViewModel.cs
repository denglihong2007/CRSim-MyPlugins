using CRSim.ScreenSimulator.ViewModels;
﻿using CRSim.Core.Models;
using CRSim.Core.Abstractions;
namespace ChengduDong.SecondaryScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = "    检票口信息请以车站显示屏信息为准。公共场所请妥善保管个人贵重物品。";
            ItemsPerPage = 12;
            ScreenCount = 2;
            StationType = StationType.Departure;
        }
    }
}
