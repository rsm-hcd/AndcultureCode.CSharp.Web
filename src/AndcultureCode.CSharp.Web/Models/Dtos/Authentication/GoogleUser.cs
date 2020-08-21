using System.Text.Json.Serialization;
using AndcultureCode.CSharp.Core.Constants;
using AndcultureCode.CSharp.Core.Interfaces.Authentication;

namespace AndcultureCode.CSharp.Web.Models.Dtos.Authentication
{
    /// <summary>
    /// Data transfer object for google user account
    /// </summary>
    public class GoogleUser : IOAuthUser
    {
        /// <summary>
        /// Email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Given name / First name
        /// </summary>
        [JsonPropertyName("given_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Uniquely assigned identifier from external oauth provider
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Surname / Lastname
        /// </summary>
        [JsonPropertyName("family_name")]
        public string LastName { get; set; }

        /// <summary>
        /// RFC-4646 locale string (en-US)
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Display name of user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Which UserMetadata.Name is associated for this OAuth User type
        /// </summary>
        public string UserMetadataName { get => UserMetadataNames.GOOGLE; }
    }
}
