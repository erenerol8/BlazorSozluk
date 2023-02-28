using BlazorSozluk.Api.Application.Interfaces.Repositories;
using BlazorSozluk.Infrastucture.Persistence.Context;
using BlazorSozluk.Infrastucture.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Infrastucture.Persistence.Extensions
{
    public static class Registration
    {
        public static IServiceCollection AddInfrastuctureRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlazorSozlukContext>(conf =>
            {
                var SqlCon = configuration["BlazorSozlukDbConnectionString"].ToString();
                conf.UseSqlServer(SqlCon,opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            });

            // var seedData = new SeedData();
            // seedData.SeedAsync(configuration).GetAwaiter().GetResult(); 

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
