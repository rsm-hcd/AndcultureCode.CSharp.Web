using AndcultureCode.CSharp.Core.Interfaces.Entity;

namespace AndcultureCode.CSharp.Web.Models.Dtos
{
    /// <summary>
    /// Data transfer object for Entity models
    /// </summary>
    public class EntityDto : IEntity
    {
        /// <inheritdoc />
        public long Id { get; set; }
    }
}
