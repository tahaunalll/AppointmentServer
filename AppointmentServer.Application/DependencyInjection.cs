using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentServer.Application
{
    public static class DependencyInjection
    {
        //Microsoft.Extensions.DependencyInjection Nuget

        public static IServiceCollection AddApplication (this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            });
          
            return services;
        }
    }
}
