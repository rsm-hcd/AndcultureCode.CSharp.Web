using System.Threading.Tasks;
using AndcultureCode.CSharp.Business.Core.Models.Configuration;
using AndcultureCode.CSharp.Web.Constants;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AndcultureCode.CSharp.Web.Extensions
{
    /// <summary>
    /// Presentation.Web layer dependency registry methods
    /// </summary>
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Register cookie authentication related actors
        /// </summary>
        /// <param name="services"></param>
        /// <param name="config"></param>

        public static IServiceCollection AddCookieAuthentication(this IServiceCollection services, IConfigurationRoot config)
        {
            var cookieConfig = config
                .GetSection(WebConfiguration.AUTHENTICATION)
                .GetSection(WebConfiguration.AUTHENTICATION_COOKIES)
                .Get<CookieAuthenticationConfiguration>();

            // Configuration
            var cookie = new CookieBuilder
            {
                Name = cookieConfig.CookieName,
                SameSite = SameSiteMode.Lax
            };

            var cookieEvents = new CookieAuthenticationEvents
            {
                OnRedirectToAccessDenied = context =>
                {
                    context.Response.StatusCode = 403; // Don't redirect, set to forbidden
                    return Task.CompletedTask;
                },
                OnRedirectToLogin = context =>
                {
                    context.Response.StatusCode = 401; // Don't redirect, set to unauthorized
                    return Task.CompletedTask;
                },
            };

            // Register actors

            services.AddSingleton((sp) => cookieConfig);

            services
                .AddAuthentication(cookieConfig.AuthenticationScheme)
                .AddCookie(cookieConfig.AuthenticationScheme, options =>
                {
                    options.AccessDeniedPath = new PathString(cookieConfig.AccessDeniedPath);
                    options.Cookie = cookie;
                    options.Events = cookieEvents;
                    options.LoginPath = new PathString(cookieConfig.LoginPath);
                });

            return services;
        }
    }
}
