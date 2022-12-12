namespace WebApi.MIddleware
{
    public partial class ExceptionMiddleware
    {
        public static async Task HandlExceptions(HttpContext ctx, Func<Task> next)
        {
            try
            {
                await next();
            }
            catch (Exception)
            {
                ctx.Response.StatusCode = 500;
                await ctx.Response.WriteAsync("An Error Occurred");
            }
        }      
    }
}
