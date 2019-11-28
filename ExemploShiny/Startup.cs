using System;
using ExemploShiny.Delegates;
using Microsoft.Extensions.DependencyInjection;
using Shiny;

namespace ExemploShiny
{
    public class Startup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.UseGps<LocationDelegates>();
            services.UseMotionActivity();
        }
    }
}
