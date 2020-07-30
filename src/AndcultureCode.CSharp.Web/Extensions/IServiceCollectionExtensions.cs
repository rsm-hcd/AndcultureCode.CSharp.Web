using System.Threading.Tasks;
using AndcultureCode.CSharp.Business.Core.Models.Configuration;
using AndcultureCode.CSharp.Web.Constants;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
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
                }
            };

            // Register actors
            services
                .AddSingleton((sp) => cookieConfig)
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

        /// <summary>
        /// Enables HTTP Header forwarding for proxies. This is not enabled by default when hosting out of process (i.e kestrel)
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddForwardedHeaders(this IServiceCollection services)
            => services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
            });
    }
}
