using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces;
using Infrastructure.Repository;
using Infrastructure.Context;

namespace Infrastructure.InfraServices
{
    public static class ServicesRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ApplicationDBContext>();
            services.AddTransient<IUser, UserRepository>();
            
        }
    }
}
