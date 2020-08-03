using Microsoft.Extensions.Localization;
using AndcultureCode.CSharp.Core.Interfaces;
using AndcultureCode.CSharp.Extensions;

namespace AndcultureCode.CSharp.Web.Controllers
{
    /// <summary>
    /// Controller sub-class for servicing HTTP API requests
    /// </summary>
    public abstract class ApiController<TPrincipal> : Controller
        where TPrincipal : ApiClaimsPrincipal
    {
        #region Constructors

        /// <summary>
        /// Controller sub-class for servicing HTTP API requests
        /// </summary>
        /// <param name="localizer"></param>
        /// <returns></returns>
        public ApiController(IStringLocalizer localizer) : base(localizer) { }

        #endregion Constructors

        #region Protected Properties

        /// <summary>
        /// Current request's claims principal
        /// </summary>
        public virtual TPrincipal ApiClaimsPrincipal { get; set; }

        /// <summary>
        /// Current request's culture
        /// </summary>
        public virtual ICulture ApiCulture { get; set; }

        /// <summary>
        /// Current authenticated user's selected role id
        /// </summary>
        public virtual long? CurrentRoleId => ApiClaimsPrincipal != null ? ApiClaimsPrincipal.RoleId : User.RoleId();

        /// <summary>
        /// Current authenticated user's role ids
        /// </summary>
        protected virtual string[] CurrentRoleIds => ApiClaimsPrincipal != null ? ApiClaimsPrincipal.RoleIds : User.RoleIds();

        /// <summary>
        /// Current authenticated user's id
        /// </summary>
        public virtual long? CurrentUserId => ApiClaimsPrincipal != null ? ApiClaimsPrincipal.UserId : User.UserId();

        /// <summary>
        /// Current authenticated user's UserLoginId
        /// </summary>
        /// <returns></returns>
        public virtual long? CurrentUserLoginId => ApiClaimsPrincipal != null ? ApiClaimsPrincipal.UserLoginId : User.UserLoginId();

        /// <summary>
        /// Whether the current user is authenticated
        /// </summary>
        protected virtual bool IsAuthenticated => ApiClaimsPrincipal != null ? ApiClaimsPrincipal.IsAuthenticated : User.IsAuthenticated();

        /// <summary>
        /// Whether the current user is unauthenticated
        /// </summary>
        protected virtual bool IsUnauthenticated => ApiClaimsPrincipal != null ? ApiClaimsPrincipal.IsUnauthenticated : User.IsUnauthenticated();

        /// <summary>
        /// Is the CurrentUser a SuperAdmin
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsSuperAdmin => ApiClaimsPrincipal != null ? ApiClaimsPrincipal.IsSuperAdmin : User.IsSuperAdmin();

        #endregion Protected Properties

        #region Public Methods

        /// <summary>
        /// Culture of the current request
        /// </summary>
        public override ICulture CurrentCulture => ApiCulture ?? base.CurrentCulture;

        #endregion Public Methods
    }
}
