using Microsoft.Extensions.DependencyInjection;
using MyTime.Repository;
using MyTime.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTime.Api.Configuration
{
    public static  class ServiceRepositoryCollectionExtensions
    {
        public static IServiceCollection RegisterRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
