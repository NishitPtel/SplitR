using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using User.Data.iFace;
using ISplit.Repo;


namespace ISplit.Extentions
{
    public static class dInject
    {
        public static IServiceCollection addRepos(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<isUser, sUser>();
            services.AddScoped<iUofWork, UofWork>();
            services.AddScoped<idatabaseInit, DatabaseInit>();
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"], b => b.MigrationsAssembly("SplitR")));

            return services;
        }
            
     }
}
