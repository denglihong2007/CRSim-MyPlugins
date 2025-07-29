using CRSim.Core.Abstractions;
        using CRSim.Core.Attributes;
        using Yakeshi.PlatformScreen.ViewModels;
        using Yakeshi.PlatformScreen.Views;
        using Microsoft.Extensions.DependencyInjection;
        using Microsoft.Extensions.Hosting;

        namespace Yakeshi.PlatformScreen
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
        