using CRSim.ScreenSimulator.ViewModels;
﻿using CRSim.Core.Models;
using CRSim.Core.Abstractions;
namespace Huaibei.PrimaryScreen.ViewModels
{
    public class ScreenViewModel : BaseScreenViewModel
    {
        public ScreenViewModel(ITimeService timeService, ISettingsService settingsService)
            : base(timeService, settingsService)
        {
            Text = $"知法守法 文明出行\n各位旅客：\n当前铁路公安机关开展“三打三防”\n专项行动，对霸座、猥亵、醉酒滋事等\n违法犯罪行为严厉打击。发现一起、严\n处一起。绝不姑息，请各位旅客文明出\n行，共同营造平安旅途，乘车过程中，\n如遇有不法侵害，请第一时间报警。\n\n消防连万家，平安你我他\n火灾不留情，预防要先行\n\n铁路旅客文明出行倡议\n1.遵守站车秩序。持有效凭证进站乘车，\n听从工作人员指引，不闯口、不插队、\n不越席、不越站、不霸座、不喧哗，看护好\n随行儿童，不影响他人候车乘车。\n2.维护公共安全。不携带静止限制物品\n进站上床，不扒阻车门，不在动车组列车和\n其他静烟区吸烟，不擅自开启列车车门和操\n纵列车紧急设施。\n3.保持环境卫生。不随地吐痰，不乱扔\n垃圾，不随地坐卧，不乱扔烟头。\n4.爱护设备设施。正确使用车站和列车\n服务设备，不损坏公共设施，节约用水用纸。\n5.讲究以礼待人。注意个人言行，文明\n用语，尊老爱幼，互相谦让。\n\n   铁路安全事关人民福祉\n   维护铁路安全人人有责\n  铁路有危情  拨打110\n反恐防恐 人人有责\n全民反恐 共筑平安";
            ItemsPerPage = 7;
            ScreenCount = 1;
            StationType = StationType.Departure;
        }
    }
}
