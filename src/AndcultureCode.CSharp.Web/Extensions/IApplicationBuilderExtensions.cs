using AndcultureCode.CSharp.Core.Constants;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;

namespace AndcultureCode.CSharp.Web.Extensions
{
    /// <summary>
    /// Extensions for IApplicationBuilder
    /// </summary>
    public static class IApplicationBuilderExtensions
    {
        /// <summary>
        /// Configure application to use cookie authentication
        /// </summary>
        /// <param name="app"></param>
        /// <param name="mode"></param>
        public static IApplicationBuilder UseCookieAuthentication(this IApplicationBuilder app, SameSiteMode mode = SameSiteMode.Lax)
            => app
                .UseAuthentication()
                .UseCookiePolicy(new CookiePolicyOptions { MinimumSameSitePolicy = mode });

        /// <summary>
        /// Configure dotnet core API to wrap unhandled exceptions in IResult
        /// and respond with json
        /// </summary>
        public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder app)
            => app.UseExceptionHandler(appError =>
                appError.Run(async context =>
                {
                    context.Response.ContentType = ContentTypes.JSON;
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    var result = contextFeature.ToResult();
                    if (result == null)
                    {
                        return;
                    }

                    await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
                })
            );
    }
}
