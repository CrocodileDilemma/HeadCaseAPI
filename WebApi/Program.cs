using WebApi.Extensions;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.RegisterServices();

            var app = builder.Build();
            app.RegisterMiddleware();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.RegisterEndpointDefinitions();

            app.Run();
        }
    }
}