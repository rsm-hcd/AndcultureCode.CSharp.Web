using System.Collections.Generic;
using System.Linq;
using AndcultureCode.CSharp.Core.Interfaces;
using Microsoft.Extensions.Logging;
using AndcultureCode.CSharp.Extensions;

namespace AndcultureCode.CSharp.Web.Extensions
{
    /// <summary>
    /// ILogger convenience methods
    /// </summary>
    public static class ILoggerExtensions
    {
        /// <summary>
        /// Logging helper method
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        public static void LogErrors<T>(this ILogger logger, T value, IEnumerable<IError> errors)
        {
            if (logger == null)
            {
                return;
            }

            var errorString = !errors.IsNullOrEmpty() ?
                string.Join(", ", errors.Select(e => $"${e.Key}: {e.Message}")) :
                "No errors were specified";

            logger.LogError(errorString, value);
        }
    }
}
