using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Dnx.Runtime;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.OptionsModel;
using System.Security.Cryptography.X509Certificates;
using System.IdentityModel.Tokens;
using foriswebapi.Models.Interfaces;
using foriswebapi.Models;

namespace foriswebapi
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; set; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ITrailsRepository, TrailsRepository>();
            services.Configure<Auth0Settings>(Configuration.GetSection("Auth0"));
            services.AddCors();
            services.AddMvc();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            var logger = loggerFactory.CreateLogger("Auth0");
            
            var settings = app.ApplicationServices.GetService<IOptions<Auth0Settings>>();

            var certificateData = settings.Value.CertificateData;
            var certificate = new X509Certificate2(Convert.FromBase64String(certificateData));

            app.UseJwtBearerAuthentication(options =>
            {   
                options.Audience = settings.Value.ClientId;
                options.Authority = $"https://{settings.Value.Domain}";
                options.AutomaticChallenge = true;
                options.AutomaticAuthenticate = true;
                options.TokenValidationParameters.IssuerSigningKey = new X509SecurityKey(certificate);
                options.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        logger.LogError("Authentication failed.", context.Exception);
                        return Task.FromResult(0);
                    },
                    OnValidatedToken = context =>
                    {
                        var claimsIdentity = context.AuthenticationTicket.Principal.Identity as ClaimsIdentity;
                        claimsIdentity?.AddClaim(
                            new Claim(
                                "id_token",
                                context.Request.Headers["Authorization"][0].Substring(context.AuthenticationTicket.AuthenticationScheme.Length + 1)
                                )
                            );
                        return Task.FromResult(0);
                    }
                };
            });

            app.UseCors(builder => builder.WithOrigins("http://localhost:4200").WithMethods("GET", "POST", "PUT", "DELETE").WithHeaders("Authorization"));

            app.UseIISPlatformHandler();

            app.UseStaticFiles();

            app.UseMvc();
        }
        
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
