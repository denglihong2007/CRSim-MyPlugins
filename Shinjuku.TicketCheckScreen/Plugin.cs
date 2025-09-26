using CRSim.Core.Abstractions;
using CRSim.Core.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenCCNET;
using Shinjuku.TicketCheckScreen.ViewModels;
using Shinjuku.TicketCheckScreen.Views;
using System.IO;
using System.Reflection;

namespace Shinjuku.TicketCheckScreen
{
    [PluginEntrance]
    public class Plugin : PluginBase
    {
        public override Type ViewModel => typeof(ScreenViewModel);

        public override Type View => typeof(ScreenView);

        public override void Initialize(HostBuilderContext context, IServiceCollection services)
        {
            string dllPath = Assembly.GetExecutingAssembly().Location;
            ZhConverter.Initialize(Path.Combine(Path.GetDirectoryName(dllPath), "Dictionary"), Path.Combine(Path.GetDirectoryName(dllPath), "JiebaResource"));
            services.AddTransient(ViewModel);
            services.AddTransient(View);
        }
    }
}
        