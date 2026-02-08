#if NET481
using Microsoft.Owin.Cors;
using Owin;
#else
using System.Windows.Controls.Primitives;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
#endif

namespace VNCSignalRServerHub
{
#if NET481
    /// <summary>
    /// Used by OWIN's startup process. 
    /// </summary>
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }
#else
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            // NOTE(crhodes)
            // SignalrR defaults to JSON
            //serviceCollection.AddSignalR();
            // Add support for MessagePack
            serviceCollection.AddSignalR().AddMessagePackProtocol();

            // TODO(crhodes)
            // Learn what these do.  Tried to make exceptions go away.

            //serviceCollection.AddSignalR(hubOptions =>
            //{
            //    hubOptions.EnableDetailedErrors = true;
            //    hubOptions.DisableImplicitFromServicesParameters = false;
            //}).AddJsonProtocol(options =>
            //   {
            //       options.PayloadSerializerOptions.PropertyNamingPolicy = null;
            //   });
            //serviceCollection.AddSignalR(
            //    options =>
            //    { options.DisableImplicitFromServicesParameters = true; }
            //);
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<SignalRHub>("/signalR");
            });
        }
    }
#endif

}
