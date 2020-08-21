using System;
using System.Threading.Tasks;
using AndcultureCode.CSharp.Business.Core.Models.Configuration;
using AndcultureCode.CSharp.Web.Constants;
using Microsoft.AspNetCore.Authentication;
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
        /// <remarks>
        /// Remember to configure 'UseCookieAuthentication()' and 'UseAuthorization()'
        /// after 'UseRouting()', but before 'UseEndpoints()'
        /// </remarks>
        /// <param name="services"></param>
        /// <param name="configRoot"></param>
        /// <param name="mode"></param>
        public static AuthenticationBuilder AddCookieAuthentication(
            this IServiceCollection services,
            IConfigurationRoot configRoot,
            SameSiteMode mode = SameSiteMode.Lax
        )
        {
            var config = configRoot
                .GetSection(WebConfiguration.AUTHENTICATION)
                .GetSection(WebConfiguration.AUTHENTICATION_COOKIE)
                .Get<CookieAuthenticationConfiguration>();

            if (config == null)
            {
                var configPath = $"{WebConfiguration.AUTHENTICATION}:{WebConfiguration.AUTHENTICATION_COOKIE}";
                throw new Exception($"Unable to find configuration for '{configPath}' <CookieAuthenticationConfiguration>");
            }

            var cookie = new CookieBuilder
            {
                Name = config.CookieName,
                SameSite = mode
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

            services.AddSingleton((sp) => config);

            // Register actors
            return services
                .AddAuthentication((options) =>
                {
                    options.DefaultAuthenticateScheme =
                    options.DefaultChallengeScheme =
                    options.DefaultScheme =
                    options.DefaultSignInScheme = config.AuthenticationScheme;
                })
                .AddCookie(config.AuthenticationScheme, options =>
                {
                    options.AccessDeniedPath = new PathString(config.AccessDeniedPath);
                    options.Cookie = cookie;
                    options.Events = cookieEvents;
                    options.LoginPath = new PathString(config.LoginPath);
                });
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
