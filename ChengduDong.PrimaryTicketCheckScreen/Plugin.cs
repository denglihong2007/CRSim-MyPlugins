using CRSim.Core.Abstractions;
        using CRSim.Core.Attributes;
        using ChengduDong.PrimaryTicketCheckScreen.ViewModels;
        using ChengduDong.PrimaryTicketCheckScreen.Views;
        using Microsoft.Extensions.DependencyInjection;
        using Microsoft.Extensions.Hosting;

        namespace ChengduDong.PrimaryTicketCheckScreen
        {
            [PluginEntrance]
            public class Plugin : PluginBase
            {
                public override Type ViewModel => typeof(ScreenViewModel);

                public override Type View => typeof(ScreenView);

                public override void Initialize(HostBuilderContext context, IServiceCollection services)
                {
                    services.AddTransient(ViewModel);
                    services.AddTransient(View);
                }
            }
        }
        