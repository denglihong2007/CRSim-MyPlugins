using CRSim.ScreenSimulator.ViewModels;
﻿using CRSim.Core.Models;
using CRSim.Core.Abstractions;
namespace ChengduDong.PrimaryTicketCheckScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = "持户口簿、护照、临时身份证的旅客，请在非居民身份证通道排队。请主动礼让老、弱、病、残、孕的旅客。";
            ItemsPerPage = 2;
            StationType = StationType.Departure;
        }
    }
}
