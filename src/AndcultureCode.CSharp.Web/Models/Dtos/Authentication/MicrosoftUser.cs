using System.Text.Json.Serialization;
using AndcultureCode.CSharp.Core.Constants;
using AndcultureCode.CSharp.Core.Interfaces.Authentication;

namespace AndcultureCode.CSharp.Web.Models.Dtos.Authentication
{
    /// <summary>
    /// Data transfer object for microsoft user account
    /// </summary>
    public class MicrosoftUser : IOAuthUser
    {
        /// <summary>
        /// List of business phones
        /// </summary>
        /// <value></value>
        public object[] BusinessPhones { get; set; }

        /// <summary>
        /// General 'name'
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        [JsonPropertyName("mail")]
        public string Email { get; set; }

        /// <summary>
        /// Given name / First name
        /// </summary>
        [JsonPropertyName("givenName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Unique external user identifier (guid)
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Job title
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// Surname / Lastname
        /// </summary>
        [JsonPropertyName("surName")]
        public string LastName { get; set; }

        /// <summary>
        /// Cell phone number
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// Office address
        /// </summary>
        public object OfficeLocation { get; set; }

        /// <summary>
        /// RFC-4646 locale string (en-US)
        /// </summary>
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// Which UserMetadata.Name is associated for this OAuth User type
        /// </summary>
        public string UserMetadataName { get => UserMetadataNames.MICROSOFT; }
    }
}
