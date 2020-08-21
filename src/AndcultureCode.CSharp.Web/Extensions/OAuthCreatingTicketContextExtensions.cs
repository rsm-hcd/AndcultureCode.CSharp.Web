using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using AndcultureCode.CSharp.Core.Constants;
using AndcultureCode.CSharp.Core.Interfaces.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace AndcultureCode.GB.Presentation.Web.Extensions
{
    /// <summary>
    /// Extension methods for OAuth context for successful login
    /// </summary>
    public static class OAuthCreatingTicketContextExtensions
    {
        /// <summary>
        /// Get dependency injected resources
        /// </summary>
        public static T Get<T>(this OAuthCreatingTicketContext context) where T : class
        {
            var type = typeof(T);
            var instance = context.HttpContext.RequestServices.GetService(type) as T;

            if (instance == null)
            {
                throw new Exception($"Missing configuration for requested service '{type.Name}'");
            }

            return instance;
        }

        /// <summary>
        /// Request associated user information from configured OAuth UserInformation endpoint
        /// </summary>
        public static async Task<TUser> GetUser<TUser>(this OAuthCreatingTicketContext context)
            where TUser : class, IOAuthUser
        {
            var request = new HttpRequestMessage(HttpMethod.Get, context.Options.UserInformationEndpoint);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(ContentTypes.JSON));
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", context.AccessToken);

            var response = await context.Backchannel.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, context.HttpContext.RequestAborted);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<TUser>(content, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }
    }
}
