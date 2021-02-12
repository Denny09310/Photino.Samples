using Microsoft.Extensions.DependencyInjection;
using Photino.Blazor;

namespace HelloPhotinoBlazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        { }

        public void Configure(DesktopApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
