using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppointmentServer.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.UI;
using AppointmentServer.Domain.Entities;
using AppointmentServer.Domain.Repositories;
using AppointmentServer.Infrastructure.Repositories;
using GenericRepository;
using AppointmentServer.Application.Services;
using AppointmentServer.Infrastructure.Services;
using Scrutor;

namespace AppointmentServer.Infrastructure
{
    public static class DependencyInjection
    //Microsoft.Extensions.DependencyInjection Nuget
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
            });

            //Microsoft.AspNetCore.Identity.UI Nuget
            services.AddIdentity<AppUser, AppRole>(action=>
            {
                action.Password.RequiredLength = 1;
                action.Password.RequireUppercase = false;
                action.Password.RequireLowercase = false;
                action.Password.RequireNonAlphanumeric = false;
                action.Password.RequireDigit = false;

            }).AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<IUnitOfWork>(srv => srv.GetRequiredService<ApplicationDbContext>());

            services.Scan(action =>
            {
                action
                .FromAssemblies(typeof(DependencyInjection).Assembly)
                .AddClasses(publicOnly: false)
                .UsingRegistrationStrategy(registrationStrategy: RegistrationStrategy.Skip)
                .AsImplementedInterfaces()
                .WithScopedLifetime();
            });

            //scrutor kütüphanesi olmasaydı aşağıdaki gibi tek tek ekleyecektik
            //services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            //services.AddScoped<IDoctorRepository, DoctorRepository>();
            //services.AddScoped<IPatientRepository, PatientRepository>();

           
            
            //services.AddScoped<IJwtProvider, JwtProvider> ();

            return services;
        }
    }
}
