using CRSim.ScreenSimulator.ViewModels;
﻿using CommunityToolkit.Mvvm.ComponentModel;
using CRSim.Core.Models;
using CRSim.Core.Abstractions;
using CRSim.ScreenSimulator.Models;
using System.Windows;
namespace ChengduDong.PillarTicketCheckScreen.ViewModels
{
    public partial class ScreenViewModel : BaseScreenViewModel
    {
        [ObservableProperty]
        private TrainInfo _firstTrain = new();
        [ObservableProperty]
        private TrainInfo _secondTrain = new();
        [ObservableProperty]
        private TrainInfo _checkingTrain = new();
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            StationType = StationType.Departure;
        }
        public override void RefreshDisplay(object? sender, EventArgs e)
        {
            UIDispatcher.Invoke(() =>
            {
                if (TrainInfo.Count == 0)
                {
                    return;
                }
                var now = TimeService.GetDateTimeNow();
                var departureTime = TrainInfo[0].DepartureTime!.Value;

                TimeSpan checkInStartOffset = TrainInfo[0].ArrivalTime is DateTime
                    ? _settings.PassingCheckInAdvanceDuration   // 过路站
                    : _settings.DepartureCheckInAdvanceDuration; // 始发站

                bool checking = now > departureTime - checkInStartOffset && now < departureTime - _settings.StopCheckInAdvanceDuration;

                if (checking)
                {
                    CheckingTrain = TrainInfo[0];
                    FirstTrain = TrainInfo.ElementAtOrDefault(1);
                    SecondTrain = TrainInfo.ElementAtOrDefault(2);
                }
                else
                {
                    CheckingTrain = null;
                    if(now < departureTime && now > departureTime - _settings.StopCheckInAdvanceDuration)
                    {
                        FirstTrain = TrainInfo.ElementAtOrDefault(1);
                        SecondTrain = TrainInfo.ElementAtOrDefault(2);
                        return;
                    }
                    FirstTrain = TrainInfo.ElementAtOrDefault(0);
                    SecondTrain = TrainInfo.ElementAtOrDefault(1);
                }
            });
        }
    }
}
