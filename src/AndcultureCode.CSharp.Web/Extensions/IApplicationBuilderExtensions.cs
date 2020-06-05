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
        /// Configure dotnet core API to wrap unhandled exceptions in IResult
        /// and respond with json
        /// </summary>
        public static void UseGlobalExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
                appError.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
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
}
