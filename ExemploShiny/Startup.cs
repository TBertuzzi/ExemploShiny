using System;
using Microsoft.Extensions.DependencyInjection;
using Shiny;

namespace ExemploShiny
{
    public class Startup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            //Caso queira utilizar seu proprio Delegate
            //services.UseGps<LocationDelegates>();
            services.UseGps();
            services.UseMotionActivity();
        }
    }
}
