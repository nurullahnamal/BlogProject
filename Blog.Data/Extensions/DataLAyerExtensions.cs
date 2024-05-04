using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Extensions
{
    public static class DataLAyerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration configuration) {

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); 
            
            return services;
        }
    }
}
