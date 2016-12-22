namespace readmemory
{
    using Microsoft.AspNetCore.Builder;

    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                var x = context.Request.Headers["Accept"];
                await next();
            });
        }
    }
}
