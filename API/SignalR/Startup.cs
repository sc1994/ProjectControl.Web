using Owin;
using API.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;


[assembly: OwinStartup(typeof(Startup), "Configuration")]
namespace API.SignalR
{
    public static class Startup
    {
        public static void ConfigureSignalR(IAppBuilder app)
        {
            app.Map("/signalr", map =>
            {
                map.UseCors(CorsOptions.AllowAll);
                var hubConfiguration = new HubConfiguration
                {
                    EnableJSONP = true
                };
                map.RunSignalR(hubConfiguration);
            });
        }

        public static void Configuration(IAppBuilder app)
        {
            ConfigureSignalR(app);
        }
    }
}