using System;
using System.Linq;
using System.Threading.Tasks;
using AndcultureCode.CSharp.Core.Constants;
using AndcultureCode.CSharp.Core.Extensions;
using AndcultureCode.CSharp.Core.Interfaces.Conductors;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using AndcultureCode.GB.Presentation.Web.Extensions;
using AndcultureCode.CSharp.Extensions;
using AndcultureCode.CSharp.Core.Interfaces.Authentication;
using AndcultureCode.CSharp.Core.Interfaces.Entity;
using AndcultureCode.CSharp.Core.Models.Entities;
using System.Collections.Generic;
using System.Security.Claims;

namespace AndcultureCode.CSharp.Web.Middleware
{
    /// <summary>
    /// Middleware event handlers for OAuth Accounts
    /// </summary>
    public static class OAuthHandler<TOAuthUser, TUser, TUserLogin, TUserMetadata>
        where TOAuthUser : class, IOAuthUser
        where TUser : Entity, IUser, new()
        where TUserLogin : Entity, IUserLogin, new()
        where TUserMetadata : Entity, IUserMetadata, new()
    {
        #region Delegates

        /// <summary>
        /// Requests custom application claims for the user at the correct time in the lifecycle of the handler
        /// </summary>
        /// <returns></returns>
        public delegate IEnumerable<Claim> GetClaimsCallback(TUser user, TUserLogin userLogin);

        #endregion Delegates

        #region Public Methods

        /// <summary>
        /// OAuth 'OnCreatingTicket' Handler
        /// Executed upon a successful external login.
        /// </summary>
        public static async Task HandleCreatingTicket(OAuthCreatingTicketContext context, GetClaimsCallback getClaimsCallback = null)
        {
            var oauthUser = await context.GetUser<TOAuthUser>();
            var logger = context.Get<ILogger<TOAuthUser>>();
            var metadataConductor = context.Get<IRepositoryConductor<TUserMetadata>>();
            var userConductor = context.Get<IRepositoryConductor<TUser>>();
            var userLoginConductor = context.Get<IRepositoryConductor<TUserLogin>>();

            logger.LogInformation($"Authentication request for {oauthUser.UserMetadataName} {NameOf<TUser>()} '{oauthUser.Id}' - {oauthUser.Email}");

            var user = FindOrCreateUser(oauthUser, userConductor, metadataConductor, logger);
            var userLogin = CreateLogin(userLoginConductor, user, context.Request, logger);

            if (getClaimsCallback != null)
            {
                context.Identity.AddClaims(getClaimsCallback(user, userLogin));
            }

            context.RunClaimActions();
        }

        #endregion Public Methods

        #region Private Methods

        private static TUserLogin CreateLogin(IRepositoryConductor<TUserLogin> conductor, TUser user, HttpRequest request, ILogger<TOAuthUser> logger)
        {
            var newUserLogin = new TUserLogin
            {
                Ip = request.GetIpAddress(),
                IsSuccessful = true,
                ServerName = Environment.MachineName,
                UserAgent = request.GetUserAgent(),
                UserId = user.Id,
                UserName = user.UserName
            };

            var userLogin = CreateOrThrow(conductor, newUserLogin);

            logger.LogInformation($"Created {NameOf<TUserLogin>()} '{userLogin.Id}' for {NameOf<TUser>()} '{user.Id}'");

            return userLogin;
        }

        private static TUserMetadata CreateMetadata(
            IRepositoryConductor<TUserMetadata> conductor,
            string type,
            string name,
            long userId,
            string value
        )
            => CreateOrThrow(conductor, new TUserMetadata
            {
                IsNameEditable = false,
                Name = name,
                Type = type,
                UserId = userId,
                Value = value
            });

        private static TUserMetadata CreateMetadata(IRepositoryConductor<TUserMetadata> conductor, long userId, IOAuthUser oauthUser)
            => CreateMetadata(conductor, UserMetadataTypes.ExternalUserId, oauthUser.UserMetadataName, userId, oauthUser.Id);

        private static T CreateOrThrow<T>(IRepositoryConductor<T> conductor, T newInstance) where T : Entity
            => conductor
                .Create(newInstance)
                .ThrowIfAnyErrorsOrResultIsNull()
                .ResultObject;

        private static TUser CreateUser(IRepositoryConductor<TUser> conductor, IOAuthUser oauthUser)
            => CreateOrThrow(conductor, InstantiateUser(oauthUser));

        private static TUser FindOrCreateUser(
            IOAuthUser oauthUser,
            IRepositoryConductor<TUser> conductor,
            IRepositoryConductor<TUserMetadata> metadataConductor,
            ILogger<IOAuthUser> logger
        )
        {
            var user = FindUserByOAuthUser(conductor, metadataConductor, oauthUser);
            if (user != null)
            {
                return user;
            }

            user = CreateUser(conductor, oauthUser);
            CreateMetadata(metadataConductor, user.Id, oauthUser);

            logger.LogInformation($"Created new {NameOf<TUser>()} '{user.Id}' for {oauthUser.UserMetadataName} {NameOf<TOAuthUser>()} '{oauthUser.Id}'");

            return user;
        }

        private static TUser FindUserByEmail(IRepositoryConductor<TUser> userConductor, string email)
        {
            var userResult = userConductor
                .FindAll(e => e.Email == email)
                .ThrowIfAnyErrors()
                .ResultObject;

            return userResult.FirstOrDefault();
        }

        private static TUser FindUserByMetadata(IRepositoryConductor<TUserMetadata> metadataConductor, IOAuthUser oauthUser)
        {
            var externalIdMetadataResult = metadataConductor
                .FindAll(e =>
                    e.Name == oauthUser.UserMetadataName &&
                    e.Type == UserMetadataTypes.ExternalUserId &&
                    e.Value == oauthUser.Id,
                    includeProperties: "User"
                )
                .ThrowIfAnyErrors()
                .ResultObject;

            return externalIdMetadataResult.FirstOrDefault()?.User as TUser;
        }

        private static TUser FindUserByOAuthUser(
            IRepositoryConductor<TUser> userConductor,
            IRepositoryConductor<TUserMetadata> metadataConductor,
            IOAuthUser oauthUser
        )
        {
            // Match by Google External Id
            var user = FindUserByMetadata(metadataConductor, oauthUser);
            if (user != null)
            {
                return user;
            }

            // Match by email address
            user = FindUserByEmail(userConductor, oauthUser.Email);

            // Connect user to Google External Id for future requests
            if (user != null)
            {
                CreateMetadata(metadataConductor, user.Id, oauthUser);
            }

            return user;
        }

        private static TUser InstantiateUser(IOAuthUser oauthUser) => new TUser
        {
            Email = oauthUser.Email,
            FirstName = oauthUser.FirstName,
            LastName = oauthUser.LastName,
            UserName = oauthUser.Email
        };

        private static string NameOf<T>() => typeof(T).Name;

        #endregion Private Methods
    }
}
