using System;
using AndcultureCode.CSharp.Core.Interfaces.Entity;

namespace AndcultureCode.CSharp.Web.Models.Dtos
{
    /// <summary>
    /// Data transfer object for Auditable models
    /// </summary>
    public class AuditableDto : EntityDto, IAuditable
    {
        /// <inheritdoc />
        public long? CreatedById { get; set; }

        /// <inheritdoc />
        public DateTimeOffset? CreatedOn { get; set; }

        /// <inheritdoc />
        public long? DeletedById { get; set; }

        /// <inheritdoc />
        public DateTimeOffset? DeletedOn { get; set; }

        /// <inheritdoc />
        public long? UpdatedById { get; set; }

        /// <inheritdoc />
        public DateTimeOffset? UpdatedOn { get; set; }
    }
}
