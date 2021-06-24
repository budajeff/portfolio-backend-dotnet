using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace aspnetcoreapp
{
    public class Startup
    {
        // see: https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-5.0
        readonly string GitHubOrigins = "_GitHubOrigins";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
                {
                    options.AddPolicy(name: GitHubOrigins,
                        builder =>
                        {
                            builder.WithOrigins("https://budajeff.github.io/")
                                .WithOrigins("http://localhost:3000")
                                .AllowAnyHeader()
                                .AllowAnyMethod();;
                        });
                });
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseCors(GitHubOrigins);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}