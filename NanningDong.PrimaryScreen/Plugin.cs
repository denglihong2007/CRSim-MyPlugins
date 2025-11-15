using CRSim.Core.Abstractions;
using CRSim.Core.Attributes;
using NanningDong.PrimaryScreen.ViewModels;
using NanningDong.PrimaryScreen.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NanningDong.PrimaryScreen
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
        