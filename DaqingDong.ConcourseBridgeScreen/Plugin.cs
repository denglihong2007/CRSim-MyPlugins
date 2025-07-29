using CRSim.Core.Abstractions;
        using CRSim.Core.Attributes;
        using DaqingDong.ConcourseBridgeScreen.ViewModels;
        using DaqingDong.ConcourseBridgeScreen.Views;
        using Microsoft.Extensions.DependencyInjection;
        using Microsoft.Extensions.Hosting;

        namespace DaqingDong.ConcourseBridgeScreen
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
        