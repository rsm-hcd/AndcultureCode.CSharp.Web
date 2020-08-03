namespace AndcultureCode.CSharp.Web.Controllers
{
    /// <summary>
    /// Base claims principal
    /// </summary>
    public class ApiClaimsPrincipal
    {
        /// <summary>
        /// Is the current request authenticated?
        /// </summary>
        public virtual bool IsAuthenticated { get => UserId.HasValue; }

        /// <summary>
        /// Is the current authenticated user a super admin?
        /// </summary>
        public virtual bool IsSuperAdmin { get; set; }

        /// <summary>
        /// Is the current request unauthenticated?
        /// </summary>
        public virtual bool IsUnauthenticated { get => !IsAuthenticated; }

        /// <summary>
        /// RoleId of current user
        /// </summary>
        public virtual long? RoleId { get; set; }

        /// <summary>
        /// Available role ids for current user
        /// </summary>
        public virtual string[] RoleIds { get; set; }

        /// <summary>
        /// Id of current user
        /// </summary>
        public virtual long? UserId { get; set; }

        /// <summary>
        /// Id of current user's login session
        /// </summary>
        /// <value></value>
        public virtual long? UserLoginId { get; set; }
    }
}
