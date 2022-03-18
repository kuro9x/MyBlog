using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Post.Domain.SeedWork;

namespace Post.API.Extensions
{
    public static class ServiceInjection
    {
        public static void AddProjectModules(this IServiceCollection services, IConfiguration config, IWebHostEnvironment env)
        {
            services.AddApiVersioning();
            services.AddMediatR(typeof(ICommandHandlerInjectable), typeof(IQueryHandlerInjectable));
        }
    }
}
