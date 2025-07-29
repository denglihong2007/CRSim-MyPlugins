using CRSim.ScreenSimulator.ViewModels;
﻿using CRSim.Core.Models;
using CRSim.Core.Abstractions;
namespace Jinanxi.SmallScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            ItemsPerPage = 9;
            ScreenCount = 1;
            StationType = StationType.Departure;
            SetText();
        }
        private async Task SetText()
        {
            await DataLoaded.Task;
            Text = $"{string.Join(" ", ThisStation.Name.ToCharArray())} 站 欢 迎 您";
        }
    }
}
