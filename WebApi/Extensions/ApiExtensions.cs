using Application.Abstractions;
using Application.Posts.Commands;
using Infrastructure;
using Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApi.Abstractions;

namespace WebApi.Extensions
{
    public static class ApiExtensions
    {

        // Add services to the container.
        public static void RegisterServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddAuthorization();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
            builder.Services.AddScoped<IPostRepository, PostRepository>();
            builder.Services.AddMediatR(typeof(Create).Assembly);
        }

        public static void RegisterEndpointDefinitions(this WebApplication app)
        {
            var defs = typeof(Program).Assembly
                .GetTypes()
                .Where(x => x.IsAssignableTo(typeof(IEndpointDefinition)) && !x.IsAbstract && !x.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<IEndpointDefinition>();

            foreach (var def in defs) 
            {
                def.RegisterEndpoints(app);
            }
        }
    }
}
