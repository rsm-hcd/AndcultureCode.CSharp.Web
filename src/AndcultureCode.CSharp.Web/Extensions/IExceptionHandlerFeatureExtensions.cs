using AndcultureCode.CSharp.Core.Interfaces;
using AndcultureCode.CSharp.Core.Models.Errors;
using Microsoft.AspNetCore.Diagnostics;

namespace AndcultureCode.CSharp.Web.Extensions
{
    /// <summary>
    /// Extensions for IExceptionHandlerFeature
    /// </summary>
    public static class IExceptionHandlerFeatureExtensions
    {
        /// <summary>
        /// Transform exception context feature to IResult
        /// </summary>
        public static IResult<object> ToResult(this IExceptionHandlerFeature feature)
        {
            if (feature?.Error == null)
            {
                return null;
            }

            var exception = feature.Error;

            return new Result<object>(exception.GetType().Name, exception.ToString());
        }
    }
}
