<a name='assembly'></a>
# AndcultureCode.CSharp.Web

## Contents

- [ApiClaimsPrincipal](#T-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal 'AndcultureCode.CSharp.Web.Controllers.ApiClaimsPrincipal')
  - [IsAuthenticated](#P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-IsAuthenticated 'AndcultureCode.CSharp.Web.Controllers.ApiClaimsPrincipal.IsAuthenticated')
  - [IsSuperAdmin](#P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-IsSuperAdmin 'AndcultureCode.CSharp.Web.Controllers.ApiClaimsPrincipal.IsSuperAdmin')
  - [IsUnauthenticated](#P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-IsUnauthenticated 'AndcultureCode.CSharp.Web.Controllers.ApiClaimsPrincipal.IsUnauthenticated')
  - [RoleId](#P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-RoleId 'AndcultureCode.CSharp.Web.Controllers.ApiClaimsPrincipal.RoleId')
  - [RoleIds](#P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-RoleIds 'AndcultureCode.CSharp.Web.Controllers.ApiClaimsPrincipal.RoleIds')
  - [UserId](#P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-UserId 'AndcultureCode.CSharp.Web.Controllers.ApiClaimsPrincipal.UserId')
  - [UserLoginId](#P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-UserLoginId 'AndcultureCode.CSharp.Web.Controllers.ApiClaimsPrincipal.UserLoginId')
- [ApiController\`1](#T-AndcultureCode-CSharp-Web-Controllers-ApiController`1 'AndcultureCode.CSharp.Web.Controllers.ApiController`1')
  - [#ctor(localizer)](#M-AndcultureCode-CSharp-Web-Controllers-ApiController`1-#ctor-Microsoft-Extensions-Localization-IStringLocalizer- 'AndcultureCode.CSharp.Web.Controllers.ApiController`1.#ctor(Microsoft.Extensions.Localization.IStringLocalizer)')
  - [ApiClaimsPrincipal](#P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-ApiClaimsPrincipal 'AndcultureCode.CSharp.Web.Controllers.ApiController`1.ApiClaimsPrincipal')
  - [ApiCulture](#P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-ApiCulture 'AndcultureCode.CSharp.Web.Controllers.ApiController`1.ApiCulture')
  - [CurrentCulture](#P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-CurrentCulture 'AndcultureCode.CSharp.Web.Controllers.ApiController`1.CurrentCulture')
  - [CurrentRoleId](#P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-CurrentRoleId 'AndcultureCode.CSharp.Web.Controllers.ApiController`1.CurrentRoleId')
  - [CurrentRoleIds](#P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-CurrentRoleIds 'AndcultureCode.CSharp.Web.Controllers.ApiController`1.CurrentRoleIds')
  - [CurrentUserId](#P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-CurrentUserId 'AndcultureCode.CSharp.Web.Controllers.ApiController`1.CurrentUserId')
  - [CurrentUserLoginId](#P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-CurrentUserLoginId 'AndcultureCode.CSharp.Web.Controllers.ApiController`1.CurrentUserLoginId')
  - [IsAuthenticated](#P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-IsAuthenticated 'AndcultureCode.CSharp.Web.Controllers.ApiController`1.IsAuthenticated')
  - [IsSuperAdmin](#P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-IsSuperAdmin 'AndcultureCode.CSharp.Web.Controllers.ApiController`1.IsSuperAdmin')
  - [IsUnauthenticated](#P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-IsUnauthenticated 'AndcultureCode.CSharp.Web.Controllers.ApiController`1.IsUnauthenticated')
- [Controller](#T-AndcultureCode-CSharp-Web-Controllers-Controller 'AndcultureCode.CSharp.Web.Controllers.Controller')
  - [#ctor(localizer)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-#ctor-Microsoft-Extensions-Localization-IStringLocalizer- 'AndcultureCode.CSharp.Web.Controllers.Controller.#ctor(Microsoft.Extensions.Localization.IStringLocalizer)')
  - [ERROR_ID_MISMATCH](#F-AndcultureCode-CSharp-Web-Controllers-Controller-ERROR_ID_MISMATCH 'AndcultureCode.CSharp.Web.Controllers.Controller.ERROR_ID_MISMATCH')
  - [ERROR_RESOURCE_NOT_FOUND](#F-AndcultureCode-CSharp-Web-Controllers-Controller-ERROR_RESOURCE_NOT_FOUND 'AndcultureCode.CSharp.Web.Controllers.Controller.ERROR_RESOURCE_NOT_FOUND')
  - [CurrentCulture](#P-AndcultureCode-CSharp-Web-Controllers-Controller-CurrentCulture 'AndcultureCode.CSharp.Web.Controllers.Controller.CurrentCulture')
  - [IpAddress](#P-AndcultureCode-CSharp-Web-Controllers-Controller-IpAddress 'AndcultureCode.CSharp.Web.Controllers.Controller.IpAddress')
  - [Localizer](#P-AndcultureCode-CSharp-Web-Controllers-Controller-Localizer 'AndcultureCode.CSharp.Web.Controllers.Controller.Localizer')
  - [UserAgent](#P-AndcultureCode-CSharp-Web-Controllers-Controller-UserAgent 'AndcultureCode.CSharp.Web.Controllers.Controller.UserAgent')
  - [Accepted\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Accepted``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.Accepted``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [BadRequest(key,message,type)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-BadRequest-System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType- 'AndcultureCode.CSharp.Web.Controllers.Controller.BadRequest(System.String,System.String,AndcultureCode.CSharp.Core.Enumerations.ErrorType)')
  - [BadRequest\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-BadRequest``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.BadRequest``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [BadRequest\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-BadRequest``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.BadRequest``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [BadRequest\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-BadRequest``1-``0,AndcultureCode-CSharp-Core-Interfaces-IError[]- 'AndcultureCode.CSharp.Web.Controllers.Controller.BadRequest``1(``0,AndcultureCode.CSharp.Core.Interfaces.IError[])')
  - [BadRequest\`\`1(value,key,message,type)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-BadRequest``1-``0,System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType- 'AndcultureCode.CSharp.Web.Controllers.Controller.BadRequest``1(``0,System.String,System.String,AndcultureCode.CSharp.Core.Enumerations.ErrorType)')
  - [Conflict\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Conflict``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.Conflict``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Conflict\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Conflict``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.Conflict``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreateResult\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-CreateResult``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.CreateResult``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtAction\`\`1(actionName,routeValues,value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-CreatedAtAction``1-System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.CreatedAtAction``1(System.String,System.Object,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtAction\`\`1(actionName,controllerName,routeValues,value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-CreatedAtAction``1-System-String,System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.CreatedAtAction``1(System.String,System.String,System.Object,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtAction\`\`1(actionName,value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-CreatedAtAction``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.CreatedAtAction``1(System.String,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtRoute\`\`1(routeName,value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-CreatedAtRoute``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.CreatedAtRoute``1(System.String,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtRoute\`\`1(routeValues,value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-CreatedAtRoute``1-System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.CreatedAtRoute``1(System.Object,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtRoute\`\`1(routeName,routeValues,value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-CreatedAtRoute``1-System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.CreatedAtRoute``1(System.String,System.Object,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Created\`\`1(value)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Created``1-``0- 'AndcultureCode.CSharp.Web.Controllers.Controller.Created``1(``0)')
  - [Created\`\`1(uriIdentifier,value)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Created``1-System-Int64,``0- 'AndcultureCode.CSharp.Web.Controllers.Controller.Created``1(System.Int64,``0)')
  - [Created\`\`1(uri,value)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Created``1-System-String,``0- 'AndcultureCode.CSharp.Web.Controllers.Controller.Created``1(System.String,``0)')
  - [Created\`\`1(uri,value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Created``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.Created``1(System.String,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Created\`\`1(uri,value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Created``1-System-Uri,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.Created``1(System.Uri,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Forbidden\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Forbidden``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.Forbidden``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Forbidden\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Forbidden``1-``0,AndcultureCode-CSharp-Core-Interfaces-IError[]- 'AndcultureCode.CSharp.Web.Controllers.Controller.Forbidden``1(``0,AndcultureCode.CSharp.Core.Interfaces.IError[])')
  - [Forbidden\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Forbidden``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.Forbidden``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Forbidden\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Forbidden``1-AndcultureCode-CSharp-Core-Interfaces-IError[]- 'AndcultureCode.CSharp.Web.Controllers.Controller.Forbidden``1(AndcultureCode.CSharp.Core.Interfaces.IError[])')
  - [GetIdMismatchError()](#M-AndcultureCode-CSharp-Web-Controllers-Controller-GetIdMismatchError 'AndcultureCode.CSharp.Web.Controllers.Controller.GetIdMismatchError')
  - [GetIdMismatchError(routeParameter,dtoProperty)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-GetIdMismatchError-System-String,System-String- 'AndcultureCode.CSharp.Web.Controllers.Controller.GetIdMismatchError(System.String,System.String)')
  - [GetNewError(key,message)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-GetNewError-System-String,System-String- 'AndcultureCode.CSharp.Web.Controllers.Controller.GetNewError(System.String,System.String)')
  - [GetResourceNotFoundError()](#M-AndcultureCode-CSharp-Web-Controllers-Controller-GetResourceNotFoundError 'AndcultureCode.CSharp.Web.Controllers.Controller.GetResourceNotFoundError')
  - [GetResourceNotFoundError(resourceName)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-GetResourceNotFoundError-System-String- 'AndcultureCode.CSharp.Web.Controllers.Controller.GetResourceNotFoundError(System.String)')
  - [GetResourceNotFoundError\`\`1()](#M-AndcultureCode-CSharp-Web-Controllers-Controller-GetResourceNotFoundError``1 'AndcultureCode.CSharp.Web.Controllers.Controller.GetResourceNotFoundError``1')
  - [InternalError\`\`1(value,errors,logger)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-InternalError``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},Microsoft-Extensions-Logging-ILogger- 'AndcultureCode.CSharp.Web.Controllers.Controller.InternalError``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError},Microsoft.Extensions.Logging.ILogger)')
  - [InternalError\`\`1(errors,logger)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-InternalError``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},Microsoft-Extensions-Logging-ILogger- 'AndcultureCode.CSharp.Web.Controllers.Controller.InternalError``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError},Microsoft.Extensions.Logging.ILogger)')
  - [InternalError\`\`1(key,message,type,logger)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-InternalError``1-System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType,Microsoft-Extensions-Logging-ILogger- 'AndcultureCode.CSharp.Web.Controllers.Controller.InternalError``1(System.String,System.String,AndcultureCode.CSharp.Core.Enumerations.ErrorType,Microsoft.Extensions.Logging.ILogger)')
  - [NotFound\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-NotFound``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.NotFound``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [NotFound\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-NotFound``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.NotFound``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [NotFound\`\`1(value,key,message,type)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-NotFound``1-``0,System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType- 'AndcultureCode.CSharp.Web.Controllers.Controller.NotFound``1(``0,System.String,System.String,AndcultureCode.CSharp.Core.Enumerations.ErrorType)')
  - [NotFound\`\`1()](#M-AndcultureCode-CSharp-Web-Controllers-Controller-NotFound``1 'AndcultureCode.CSharp.Web.Controllers.Controller.NotFound``1')
  - [Ok()](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Ok 'AndcultureCode.CSharp.Web.Controllers.Controller.Ok')
  - [Ok\`\`1(value)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Ok``1-``0- 'AndcultureCode.CSharp.Web.Controllers.Controller.Ok``1(``0)')
  - [Ok\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-Ok``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.Ok``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [StatusCode\`\`1(statusCode,value,errors)](#M-AndcultureCode-CSharp-Web-Controllers-Controller-StatusCode``1-System-Int32,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Controllers.Controller.StatusCode``1(System.Int32,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
- [GetClaimsCallback](#T-AndcultureCode-CSharp-Web-Middleware-OAuthHandler`4-GetClaimsCallback 'AndcultureCode.CSharp.Web.Middleware.OAuthHandler`4.GetClaimsCallback')
- [IApiEntityControllerExtensions](#T-AndcultureCode-CSharp-Web-Extensions-IApiEntityControllerExtensions 'AndcultureCode.CSharp.Web.Extensions.IApiEntityControllerExtensions')
  - [GetDefault\`\`3(controller,id)](#M-AndcultureCode-CSharp-Web-Extensions-IApiEntityControllerExtensions-GetDefault``3-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController{``0,``1},System-Int64- 'AndcultureCode.CSharp.Web.Extensions.IApiEntityControllerExtensions.GetDefault``3(AndcultureCode.CSharp.Web.Interfaces.IApiEntityController{``0,``1},System.Int64)')
  - [IndexDefault\`\`3(controller)](#M-AndcultureCode-CSharp-Web-Extensions-IApiEntityControllerExtensions-IndexDefault``3-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController{``0,``1}- 'AndcultureCode.CSharp.Web.Extensions.IApiEntityControllerExtensions.IndexDefault``3(AndcultureCode.CSharp.Web.Interfaces.IApiEntityController{``0,``1})')
- [IApiEntityController\`2](#T-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2 'AndcultureCode.CSharp.Web.Interfaces.IApiEntityController`2')
  - [Conductor](#P-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2-Conductor 'AndcultureCode.CSharp.Web.Interfaces.IApiEntityController`2.Conductor')
  - [Logger](#P-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2-Logger 'AndcultureCode.CSharp.Web.Interfaces.IApiEntityController`2.Logger')
  - [Mapper](#P-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2-Mapper 'AndcultureCode.CSharp.Web.Interfaces.IApiEntityController`2.Mapper')
- [IApplicationBuilderExtensions](#T-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions 'AndcultureCode.CSharp.Web.Extensions.IApplicationBuilderExtensions')
  - [UseCookieAuthentication(app,mode)](#M-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions-UseCookieAuthentication-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-AspNetCore-Http-SameSiteMode- 'AndcultureCode.CSharp.Web.Extensions.IApplicationBuilderExtensions.UseCookieAuthentication(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.AspNetCore.Http.SameSiteMode)')
  - [UseGlobalExceptionHandler()](#M-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions-UseGlobalExceptionHandler-Microsoft-AspNetCore-Builder-IApplicationBuilder- 'AndcultureCode.CSharp.Web.Extensions.IApplicationBuilderExtensions.UseGlobalExceptionHandler(Microsoft.AspNetCore.Builder.IApplicationBuilder)')
- [IController](#T-AndcultureCode-CSharp-Web-Interfaces-IController 'AndcultureCode.CSharp.Web.Interfaces.IController')
  - [CurrentCulture](#P-AndcultureCode-CSharp-Web-Interfaces-IController-CurrentCulture 'AndcultureCode.CSharp.Web.Interfaces.IController.CurrentCulture')
  - [Accepted\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Accepted``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Accepted``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [BadRequest(key,message,type)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest-System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType- 'AndcultureCode.CSharp.Web.Interfaces.IController.BadRequest(System.String,System.String,AndcultureCode.CSharp.Core.Enumerations.ErrorType)')
  - [BadRequest\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.BadRequest``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [BadRequest\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.BadRequest``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [BadRequest\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-``0,AndcultureCode-CSharp-Core-Interfaces-IError[]- 'AndcultureCode.CSharp.Web.Interfaces.IController.BadRequest``1(``0,AndcultureCode.CSharp.Core.Interfaces.IError[])')
  - [BadRequest\`\`1(value,key,message,type)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-``0,System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType- 'AndcultureCode.CSharp.Web.Interfaces.IController.BadRequest``1(``0,System.String,System.String,AndcultureCode.CSharp.Core.Enumerations.ErrorType)')
  - [Conflict\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Conflict``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Conflict``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Conflict\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Conflict``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Conflict``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreateResult\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreateResult``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreateResult``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtAction\`\`1(actionName,routeValues,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtAction``1-System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreatedAtAction``1(System.String,System.Object,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtAction\`\`1(actionName,controllerName,routeValues,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtAction``1-System-String,System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreatedAtAction``1(System.String,System.String,System.Object,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtAction\`\`1(actionName,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtAction``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreatedAtAction``1(System.String,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtRoute\`\`1(routeName,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtRoute``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreatedAtRoute``1(System.String,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtRoute\`\`1(routeValues,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtRoute``1-System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreatedAtRoute``1(System.Object,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtRoute\`\`1(routeName,routeValues,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtRoute``1-System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreatedAtRoute``1(System.String,System.Object,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Created\`\`1(value)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-``0- 'AndcultureCode.CSharp.Web.Interfaces.IController.Created``1(``0)')
  - [Created\`\`1(uriIdentifier,value)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-Int64,``0- 'AndcultureCode.CSharp.Web.Interfaces.IController.Created``1(System.Int64,``0)')
  - [Created\`\`1(uri,value)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-String,``0- 'AndcultureCode.CSharp.Web.Interfaces.IController.Created``1(System.String,``0)')
  - [Created\`\`1(uri,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Created``1(System.String,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Created\`\`1(uri,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-Uri,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Created``1(System.Uri,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Forbidden\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Forbidden``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Forbidden\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-``0,AndcultureCode-CSharp-Core-Interfaces-IError[]- 'AndcultureCode.CSharp.Web.Interfaces.IController.Forbidden``1(``0,AndcultureCode.CSharp.Core.Interfaces.IError[])')
  - [Forbidden\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Forbidden``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Forbidden\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-AndcultureCode-CSharp-Core-Interfaces-IError[]- 'AndcultureCode.CSharp.Web.Interfaces.IController.Forbidden``1(AndcultureCode.CSharp.Core.Interfaces.IError[])')
  - [InternalError\`\`1(value,errors,logger)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-InternalError``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},Microsoft-Extensions-Logging-ILogger- 'AndcultureCode.CSharp.Web.Interfaces.IController.InternalError``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError},Microsoft.Extensions.Logging.ILogger)')
  - [InternalError\`\`1(errors,logger)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-InternalError``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},Microsoft-Extensions-Logging-ILogger- 'AndcultureCode.CSharp.Web.Interfaces.IController.InternalError``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError},Microsoft.Extensions.Logging.ILogger)')
  - [InternalError\`\`1(key,message,type,logger)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-InternalError``1-System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType,Microsoft-Extensions-Logging-ILogger- 'AndcultureCode.CSharp.Web.Interfaces.IController.InternalError``1(System.String,System.String,AndcultureCode.CSharp.Core.Enumerations.ErrorType,Microsoft.Extensions.Logging.ILogger)')
  - [NotFound\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.NotFound``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [NotFound\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.NotFound``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [NotFound\`\`1(value,key,message,type)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1-``0,System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType- 'AndcultureCode.CSharp.Web.Interfaces.IController.NotFound``1(``0,System.String,System.String,AndcultureCode.CSharp.Core.Enumerations.ErrorType)')
  - [NotFound\`\`1()](#M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1 'AndcultureCode.CSharp.Web.Interfaces.IController.NotFound``1')
  - [Ok\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Ok``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Ok``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [StatusCode\`\`1(statusCode,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-StatusCode``1-System-Int32,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.StatusCode``1(System.Int32,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
- [IExceptionHandlerFeatureExtensions](#T-AndcultureCode-CSharp-Web-Extensions-IExceptionHandlerFeatureExtensions 'AndcultureCode.CSharp.Web.Extensions.IExceptionHandlerFeatureExtensions')
  - [ToResult()](#M-AndcultureCode-CSharp-Web-Extensions-IExceptionHandlerFeatureExtensions-ToResult-Microsoft-AspNetCore-Diagnostics-IExceptionHandlerFeature- 'AndcultureCode.CSharp.Web.Extensions.IExceptionHandlerFeatureExtensions.ToResult(Microsoft.AspNetCore.Diagnostics.IExceptionHandlerFeature)')
- [ILoggerExtensions](#T-AndcultureCode-CSharp-Web-Extensions-ILoggerExtensions 'AndcultureCode.CSharp.Web.Extensions.ILoggerExtensions')
  - [LogErrors\`\`1(logger,value,errors)](#M-AndcultureCode-CSharp-Web-Extensions-ILoggerExtensions-LogErrors``1-Microsoft-Extensions-Logging-ILogger,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Extensions.ILoggerExtensions.LogErrors``1(Microsoft.Extensions.Logging.ILogger,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
- [IServiceCollectionExtensions](#T-AndcultureCode-CSharp-Web-Extensions-IServiceCollectionExtensions 'AndcultureCode.CSharp.Web.Extensions.IServiceCollectionExtensions')
  - [AddCookieAuthentication(services,configRoot,mode)](#M-AndcultureCode-CSharp-Web-Extensions-IServiceCollectionExtensions-AddCookieAuthentication-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfigurationRoot,Microsoft-AspNetCore-Http-SameSiteMode- 'AndcultureCode.CSharp.Web.Extensions.IServiceCollectionExtensions.AddCookieAuthentication(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfigurationRoot,Microsoft.AspNetCore.Http.SameSiteMode)')
  - [AddForwardedHeaders(services)](#M-AndcultureCode-CSharp-Web-Extensions-IServiceCollectionExtensions-AddForwardedHeaders-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'AndcultureCode.CSharp.Web.Extensions.IServiceCollectionExtensions.AddForwardedHeaders(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [OAuthCreatingTicketContextExtensions](#T-AndcultureCode-GB-Presentation-Web-Extensions-OAuthCreatingTicketContextExtensions 'AndcultureCode.GB.Presentation.Web.Extensions.OAuthCreatingTicketContextExtensions')
  - [GetUser\`\`1()](#M-AndcultureCode-GB-Presentation-Web-Extensions-OAuthCreatingTicketContextExtensions-GetUser``1-Microsoft-AspNetCore-Authentication-OAuth-OAuthCreatingTicketContext- 'AndcultureCode.GB.Presentation.Web.Extensions.OAuthCreatingTicketContextExtensions.GetUser``1(Microsoft.AspNetCore.Authentication.OAuth.OAuthCreatingTicketContext)')
  - [Get\`\`1()](#M-AndcultureCode-GB-Presentation-Web-Extensions-OAuthCreatingTicketContextExtensions-Get``1-Microsoft-AspNetCore-Authentication-OAuth-OAuthCreatingTicketContext- 'AndcultureCode.GB.Presentation.Web.Extensions.OAuthCreatingTicketContextExtensions.Get``1(Microsoft.AspNetCore.Authentication.OAuth.OAuthCreatingTicketContext)')
- [OAuthHandler\`4](#T-AndcultureCode-CSharp-Web-Middleware-OAuthHandler`4 'AndcultureCode.CSharp.Web.Middleware.OAuthHandler`4')
  - [HandleCreatingTicket()](#M-AndcultureCode-CSharp-Web-Middleware-OAuthHandler`4-HandleCreatingTicket-Microsoft-AspNetCore-Authentication-OAuth-OAuthCreatingTicketContext,AndcultureCode-CSharp-Web-Middleware-OAuthHandler{`0,`1,`2,`3}-GetClaimsCallback- 'AndcultureCode.CSharp.Web.Middleware.OAuthHandler`4.HandleCreatingTicket(Microsoft.AspNetCore.Authentication.OAuth.OAuthCreatingTicketContext,AndcultureCode.CSharp.Web.Middleware.OAuthHandler{`0,`1,`2,`3}.GetClaimsCallback)')
- [WebConfiguration](#T-AndcultureCode-CSharp-Web-Constants-WebConfiguration 'AndcultureCode.CSharp.Web.Constants.WebConfiguration')
  - [AUTHENTICATION](#F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION 'AndcultureCode.CSharp.Web.Constants.WebConfiguration.AUTHENTICATION')
  - [AUTHENTICATION_BASIC](#F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_BASIC 'AndcultureCode.CSharp.Web.Constants.WebConfiguration.AUTHENTICATION_BASIC')
  - [AUTHENTICATION_COOKIE](#F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_COOKIE 'AndcultureCode.CSharp.Web.Constants.WebConfiguration.AUTHENTICATION_COOKIE')
  - [AUTHENTICATION_FACEBOOK](#F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_FACEBOOK 'AndcultureCode.CSharp.Web.Constants.WebConfiguration.AUTHENTICATION_FACEBOOK')
  - [AUTHENTICATION_GOOGLE](#F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_GOOGLE 'AndcultureCode.CSharp.Web.Constants.WebConfiguration.AUTHENTICATION_GOOGLE')
  - [AUTHENTICATION_MICROSOFT](#F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_MICROSOFT 'AndcultureCode.CSharp.Web.Constants.WebConfiguration.AUTHENTICATION_MICROSOFT')
  - [AUTHENTICATION_TWITTER](#F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_TWITTER 'AndcultureCode.CSharp.Web.Constants.WebConfiguration.AUTHENTICATION_TWITTER')

<a name='T-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal'></a>
## ApiClaimsPrincipal `type`

##### Namespace

AndcultureCode.CSharp.Web.Controllers

##### Summary

Base claims principal

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-IsAuthenticated'></a>
### IsAuthenticated `property`

##### Summary

Is the current request authenticated?

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-IsSuperAdmin'></a>
### IsSuperAdmin `property`

##### Summary

Is the current authenticated user a super admin?

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-IsUnauthenticated'></a>
### IsUnauthenticated `property`

##### Summary

Is the current request unauthenticated?

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-RoleId'></a>
### RoleId `property`

##### Summary

RoleId of current user

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-RoleIds'></a>
### RoleIds `property`

##### Summary

Available role ids for current user

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-UserId'></a>
### UserId `property`

##### Summary

Id of current user

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiClaimsPrincipal-UserLoginId'></a>
### UserLoginId `property`

##### Summary

Id of current user's login session

<a name='T-AndcultureCode-CSharp-Web-Controllers-ApiController`1'></a>
## ApiController\`1 `type`

##### Namespace

AndcultureCode.CSharp.Web.Controllers

##### Summary

Controller sub-class for servicing HTTP API requests

<a name='M-AndcultureCode-CSharp-Web-Controllers-ApiController`1-#ctor-Microsoft-Extensions-Localization-IStringLocalizer-'></a>
### #ctor(localizer) `constructor`

##### Summary

Controller sub-class for servicing HTTP API requests

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| localizer | [Microsoft.Extensions.Localization.IStringLocalizer](#T-Microsoft-Extensions-Localization-IStringLocalizer 'Microsoft.Extensions.Localization.IStringLocalizer') |  |

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-ApiClaimsPrincipal'></a>
### ApiClaimsPrincipal `property`

##### Summary

Current request's claims principal

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-ApiCulture'></a>
### ApiCulture `property`

##### Summary

Current request's culture

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-CurrentCulture'></a>
### CurrentCulture `property`

##### Summary

Culture of the current request

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-CurrentRoleId'></a>
### CurrentRoleId `property`

##### Summary

Current authenticated user's selected role id

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-CurrentRoleIds'></a>
### CurrentRoleIds `property`

##### Summary

Current authenticated user's role ids

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-CurrentUserId'></a>
### CurrentUserId `property`

##### Summary

Current authenticated user's id

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-CurrentUserLoginId'></a>
### CurrentUserLoginId `property`

##### Summary

Current authenticated user's UserLoginId

##### Returns



<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-IsAuthenticated'></a>
### IsAuthenticated `property`

##### Summary

Whether the current user is authenticated

<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-IsSuperAdmin'></a>
### IsSuperAdmin `property`

##### Summary

Is the CurrentUser a SuperAdmin

##### Returns



<a name='P-AndcultureCode-CSharp-Web-Controllers-ApiController`1-IsUnauthenticated'></a>
### IsUnauthenticated `property`

##### Summary

Whether the current user is unauthenticated

<a name='T-AndcultureCode-CSharp-Web-Controllers-Controller'></a>
## Controller `type`

##### Namespace

AndcultureCode.CSharp.Web.Controllers

##### Summary

Base localized controller

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-#ctor-Microsoft-Extensions-Localization-IStringLocalizer-'></a>
### #ctor(localizer) `constructor`

##### Summary

Base localized controller

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| localizer | [Microsoft.Extensions.Localization.IStringLocalizer](#T-Microsoft-Extensions-Localization-IStringLocalizer 'Microsoft.Extensions.Localization.IStringLocalizer') |  |

<a name='F-AndcultureCode-CSharp-Web-Controllers-Controller-ERROR_ID_MISMATCH'></a>
### ERROR_ID_MISMATCH `constants`

##### Summary

Data and route Ids do not match

<a name='F-AndcultureCode-CSharp-Web-Controllers-Controller-ERROR_RESOURCE_NOT_FOUND'></a>
### ERROR_RESOURCE_NOT_FOUND `constants`

##### Summary

Requested resource was not found

<a name='P-AndcultureCode-CSharp-Web-Controllers-Controller-CurrentCulture'></a>
### CurrentCulture `property`

##### Summary

Culture for current request

<a name='P-AndcultureCode-CSharp-Web-Controllers-Controller-IpAddress'></a>
### IpAddress `property`

##### Summary

Get current ip address

<a name='P-AndcultureCode-CSharp-Web-Controllers-Controller-Localizer'></a>
### Localizer `property`

##### Summary

Reference to localizer for sub-classes

<a name='P-AndcultureCode-CSharp-Web-Controllers-Controller-UserAgent'></a>
### UserAgent `property`

##### Summary

Requesting user's agent

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Accepted``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Accepted\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 202 Accepted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-BadRequest-System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>
### BadRequest(key,message,type) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [AndcultureCode.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType 'AndcultureCode.CSharp.Core.Enumerations.ErrorType') |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-BadRequest``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### BadRequest\`\`1(errors) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-BadRequest``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### BadRequest\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-BadRequest``1-``0,AndcultureCode-CSharp-Core-Interfaces-IError[]-'></a>
### BadRequest\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [AndcultureCode.CSharp.Core.Interfaces.IError[]](#T-AndcultureCode-CSharp-Core-Interfaces-IError[] 'AndcultureCode.CSharp.Core.Interfaces.IError[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-BadRequest``1-``0,System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>
### BadRequest\`\`1(value,key,message,type) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [AndcultureCode.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType 'AndcultureCode.CSharp.Core.Enumerations.ErrorType') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Conflict``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Conflict\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 409 Conflicted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Conflict``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Conflict\`\`1(errors) `method`

##### Summary

Responds with HTTP 409 Conflicted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-CreateResult``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreateResult\`\`1(value,errors) `method`

##### Summary

Create a result object given the value and errors list

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-CreatedAtAction``1-System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtAction\`\`1(actionName,routeValues,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| routeValues | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-CreatedAtAction``1-System-String,System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtAction\`\`1(actionName,controllerName,routeValues,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| controllerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| routeValues | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-CreatedAtAction``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtAction\`\`1(actionName,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-CreatedAtRoute``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtRoute\`\`1(routeName,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| routeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-CreatedAtRoute``1-System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtRoute\`\`1(routeValues,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| routeValues | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-CreatedAtRoute``1-System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtRoute\`\`1(routeName,routeValues,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| routeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| routeValues | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Created``1-``0-'></a>
### Created\`\`1(value) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Created``1-System-Int64,``0-'></a>
### Created\`\`1(uriIdentifier,value) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uriIdentifier | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| value | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Created``1-System-String,``0-'></a>
### Created\`\`1(uri,value) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Created``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Created\`\`1(uri,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Created``1-System-Uri,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Created\`\`1(uri,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Forbidden``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Forbidden\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 403 Forbidden

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Forbidden``1-``0,AndcultureCode-CSharp-Core-Interfaces-IError[]-'></a>
### Forbidden\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 403 Forbidden

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [AndcultureCode.CSharp.Core.Interfaces.IError[]](#T-AndcultureCode-CSharp-Core-Interfaces-IError[] 'AndcultureCode.CSharp.Core.Interfaces.IError[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Forbidden``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Forbidden\`\`1(errors) `method`

##### Summary

Responds with HTTP 403 Forbidden

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Forbidden``1-AndcultureCode-CSharp-Core-Interfaces-IError[]-'></a>
### Forbidden\`\`1(errors) `method`

##### Summary

Responds with HTTP 403 Forbidden

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [AndcultureCode.CSharp.Core.Interfaces.IError[]](#T-AndcultureCode-CSharp-Core-Interfaces-IError[] 'AndcultureCode.CSharp.Core.Interfaces.IError[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-GetIdMismatchError'></a>
### GetIdMismatchError() `method`

##### Summary

Constructors error object for ERROR_ID_MISMATCH_KEY

##### Returns



##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-GetIdMismatchError-System-String,System-String-'></a>
### GetIdMismatchError(routeParameter,dtoProperty) `method`

##### Summary

Constructors error object for ERROR_ID_MISMATCH_KEY

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| routeParameter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| dtoProperty | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-GetNewError-System-String,System-String-'></a>
### GetNewError(key,message) `method`

##### Summary

Constructors error object

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-GetResourceNotFoundError'></a>
### GetResourceNotFoundError() `method`

##### Summary

Constructors error object for ERROR_RESOURCE_NOT_FOUND_KEY

##### Returns



##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-GetResourceNotFoundError-System-String-'></a>
### GetResourceNotFoundError(resourceName) `method`

##### Summary

Constructors error object for ERROR_RESOURCE_NOT_FOUND_KEY

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-GetResourceNotFoundError``1'></a>
### GetResourceNotFoundError\`\`1() `method`

##### Summary

Constructors error object for ERROR_RESOURCE_NOT_FOUND_KEY

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-InternalError``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},Microsoft-Extensions-Logging-ILogger-'></a>
### InternalError\`\`1(value,errors,logger) `method`

##### Summary

Responds with HTTP 500 Internal Server Error

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-InternalError``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},Microsoft-Extensions-Logging-ILogger-'></a>
### InternalError\`\`1(errors,logger) `method`

##### Summary

Responds with HTTP 500 Internal Server Error

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-InternalError``1-System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType,Microsoft-Extensions-Logging-ILogger-'></a>
### InternalError\`\`1(key,message,type,logger) `method`

##### Summary

Responds with HTTP 500 Internal Server Error

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [AndcultureCode.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType 'AndcultureCode.CSharp.Core.Enumerations.ErrorType') |  |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-NotFound``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### NotFound\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 404 Not Found

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-NotFound``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### NotFound\`\`1(errors) `method`

##### Summary

Responds with HTTP 404 Not Found

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-NotFound``1-``0,System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>
### NotFound\`\`1(value,key,message,type) `method`

##### Summary

Responds with HTTP 404 Not Found

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [AndcultureCode.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType 'AndcultureCode.CSharp.Core.Enumerations.ErrorType') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-NotFound``1'></a>
### NotFound\`\`1() `method`

##### Summary

Responds with HTTP 404 Not Found

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Ok'></a>
### Ok() `method`

##### Summary

Responds with HTTP 200 Ok

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Ok``1-``0-'></a>
### Ok\`\`1(value) `method`

##### Summary

Responds with HTTP 200 Ok

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-Ok``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Ok\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 200 Ok

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Controllers-Controller-StatusCode``1-System-Int32,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### StatusCode\`\`1(statusCode,value,errors) `method`

##### Summary

Responds with HTTP supplied statusCode in our conventional IResult response.
Mostly to be used in a pinch or very edge case.
Ultimately we should continue to extend to offer wrapper methods around
HTTP status codes we use.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| statusCode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-AndcultureCode-CSharp-Web-Middleware-OAuthHandler`4-GetClaimsCallback'></a>
## GetClaimsCallback `type`

##### Namespace

AndcultureCode.CSharp.Web.Middleware.OAuthHandler`4

##### Summary

Requests custom application claims for the user at the correct time in the lifecycle of the handler

##### Returns



<a name='T-AndcultureCode-CSharp-Web-Extensions-IApiEntityControllerExtensions'></a>
## IApiEntityControllerExtensions `type`

##### Namespace

AndcultureCode.CSharp.Web.Extensions

##### Summary

Utility functions for IApiEntityController

<a name='M-AndcultureCode-CSharp-Web-Extensions-IApiEntityControllerExtensions-GetDefault``3-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController{``0,``1},System-Int64-'></a>
### GetDefault\`\`3(controller,id) `method`

##### Summary

Conventional Get(long id) controller method functionality

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| controller | [AndcultureCode.CSharp.Web.Interfaces.IApiEntityController{\`\`0,\`\`1}](#T-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController{``0,``1} 'AndcultureCode.CSharp.Web.Interfaces.IApiEntityController{``0,``1}') |  |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TController |  |
| TEntity |  |
| TDto |  |

<a name='M-AndcultureCode-CSharp-Web-Extensions-IApiEntityControllerExtensions-IndexDefault``3-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController{``0,``1}-'></a>
### IndexDefault\`\`3(controller) `method`

##### Summary

Conventional Index() controller method functionality

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| controller | [AndcultureCode.CSharp.Web.Interfaces.IApiEntityController{\`\`0,\`\`1}](#T-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController{``0,``1} 'AndcultureCode.CSharp.Web.Interfaces.IApiEntityController{``0,``1}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TController |  |
| TEntity |  |
| TDto |  |

<a name='T-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2'></a>
## IApiEntityController\`2 `type`

##### Namespace

AndcultureCode.CSharp.Web.Interfaces

##### Summary

Describes an ApiController that pertains to an Entity from the application's domain layer.

<a name='P-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2-Conductor'></a>
### Conductor `property`

##### Summary

Associated entity's repository conductor

<a name='P-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2-Logger'></a>
### Logger `property`

##### Summary

Controller logger

<a name='P-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2-Mapper'></a>
### Mapper `property`

##### Summary

Data mapping instance

<a name='T-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions'></a>
## IApplicationBuilderExtensions `type`

##### Namespace

AndcultureCode.CSharp.Web.Extensions

##### Summary

Extensions for IApplicationBuilder

<a name='M-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions-UseCookieAuthentication-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-AspNetCore-Http-SameSiteMode-'></a>
### UseCookieAuthentication(app,mode) `method`

##### Summary

Configure application to use cookie authentication

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') |  |
| mode | [Microsoft.AspNetCore.Http.SameSiteMode](#T-Microsoft-AspNetCore-Http-SameSiteMode 'Microsoft.AspNetCore.Http.SameSiteMode') |  |

<a name='M-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions-UseGlobalExceptionHandler-Microsoft-AspNetCore-Builder-IApplicationBuilder-'></a>
### UseGlobalExceptionHandler() `method`

##### Summary

Configure dotnet core API to wrap unhandled exceptions in IResult
and respond with json

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Web-Interfaces-IController'></a>
## IController `type`

##### Namespace

AndcultureCode.CSharp.Web.Interfaces

##### Summary

Application controller contract

<a name='P-AndcultureCode-CSharp-Web-Interfaces-IController-CurrentCulture'></a>
### CurrentCulture `property`

##### Summary

Current request's i18n/l10n culture

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Accepted``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Accepted\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 202 Accepted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest-System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>
### BadRequest(key,message,type) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [AndcultureCode.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType 'AndcultureCode.CSharp.Core.Enumerations.ErrorType') |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### BadRequest\`\`1(errors) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### BadRequest\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-``0,AndcultureCode-CSharp-Core-Interfaces-IError[]-'></a>
### BadRequest\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [AndcultureCode.CSharp.Core.Interfaces.IError[]](#T-AndcultureCode-CSharp-Core-Interfaces-IError[] 'AndcultureCode.CSharp.Core.Interfaces.IError[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-``0,System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>
### BadRequest\`\`1(value,key,message,type) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [AndcultureCode.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType 'AndcultureCode.CSharp.Core.Enumerations.ErrorType') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Conflict``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Conflict\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 409 Conflicted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Conflict``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Conflict\`\`1(errors) `method`

##### Summary

Responds with HTTP 409 Conflicted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreateResult``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreateResult\`\`1(value,errors) `method`

##### Summary

Constructs a response in the form of an IResult

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtAction``1-System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtAction\`\`1(actionName,routeValues,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| routeValues | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtAction``1-System-String,System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtAction\`\`1(actionName,controllerName,routeValues,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| controllerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| routeValues | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtAction``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtAction\`\`1(actionName,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtRoute``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtRoute\`\`1(routeName,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| routeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtRoute``1-System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtRoute\`\`1(routeValues,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| routeValues | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtRoute``1-System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtRoute\`\`1(routeName,routeValues,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| routeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| routeValues | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-``0-'></a>
### Created\`\`1(value) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-Int64,``0-'></a>
### Created\`\`1(uriIdentifier,value) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uriIdentifier | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| value | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-String,``0-'></a>
### Created\`\`1(uri,value) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Created\`\`1(uri,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-Uri,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Created\`\`1(uri,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Forbidden\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 403 Forbidden

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-``0,AndcultureCode-CSharp-Core-Interfaces-IError[]-'></a>
### Forbidden\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 403 Forbidden

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [AndcultureCode.CSharp.Core.Interfaces.IError[]](#T-AndcultureCode-CSharp-Core-Interfaces-IError[] 'AndcultureCode.CSharp.Core.Interfaces.IError[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Forbidden\`\`1(errors) `method`

##### Summary

Responds with HTTP 403 Forbidden

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-AndcultureCode-CSharp-Core-Interfaces-IError[]-'></a>
### Forbidden\`\`1(errors) `method`

##### Summary

Responds with HTTP 403 Forbidden

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [AndcultureCode.CSharp.Core.Interfaces.IError[]](#T-AndcultureCode-CSharp-Core-Interfaces-IError[] 'AndcultureCode.CSharp.Core.Interfaces.IError[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-InternalError``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},Microsoft-Extensions-Logging-ILogger-'></a>
### InternalError\`\`1(value,errors,logger) `method`

##### Summary

Responds with HTTP 500 Internal Server Error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-InternalError``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},Microsoft-Extensions-Logging-ILogger-'></a>
### InternalError\`\`1(errors,logger) `method`

##### Summary

Responds with HTTP 500 Internal Server Error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-InternalError``1-System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType,Microsoft-Extensions-Logging-ILogger-'></a>
### InternalError\`\`1(key,message,type,logger) `method`

##### Summary

Responds with HTTP 500 Internal Server Error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [AndcultureCode.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType 'AndcultureCode.CSharp.Core.Enumerations.ErrorType') |  |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### NotFound\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 404 Not Found

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### NotFound\`\`1(errors) `method`

##### Summary

Responds with HTTP 404 Not Found

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1-``0,System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>
### NotFound\`\`1(value,key,message,type) `method`

##### Summary

Responds with HTTP 404 Not Found

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [AndcultureCode.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType 'AndcultureCode.CSharp.Core.Enumerations.ErrorType') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1'></a>
### NotFound\`\`1() `method`

##### Summary

Responds with HTTP 404 Not Found

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Ok``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Ok\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 200 Ok

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-StatusCode``1-System-Int32,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### StatusCode\`\`1(statusCode,value,errors) `method`

##### Summary

Responds with HTTP supplied statusCode in our conventional IResult response.
Mostly to be used in a pinch or very edge case.
Ultimately we should continue to extend to offer wrapper methods around
HTTP status codes we use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| statusCode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-AndcultureCode-CSharp-Web-Extensions-IExceptionHandlerFeatureExtensions'></a>
## IExceptionHandlerFeatureExtensions `type`

##### Namespace

AndcultureCode.CSharp.Web.Extensions

##### Summary

Extensions for IExceptionHandlerFeature

<a name='M-AndcultureCode-CSharp-Web-Extensions-IExceptionHandlerFeatureExtensions-ToResult-Microsoft-AspNetCore-Diagnostics-IExceptionHandlerFeature-'></a>
### ToResult() `method`

##### Summary

Transform exception context feature to IResult

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Web-Extensions-ILoggerExtensions'></a>
## ILoggerExtensions `type`

##### Namespace

AndcultureCode.CSharp.Web.Extensions

##### Summary

ILogger convenience methods

<a name='M-AndcultureCode-CSharp-Web-Extensions-ILoggerExtensions-LogErrors``1-Microsoft-Extensions-Logging-ILogger,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### LogErrors\`\`1(logger,value,errors) `method`

##### Summary

Logging helper method

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-AndcultureCode-CSharp-Web-Extensions-IServiceCollectionExtensions'></a>
## IServiceCollectionExtensions `type`

##### Namespace

AndcultureCode.CSharp.Web.Extensions

##### Summary

Presentation.Web layer dependency registry methods

<a name='M-AndcultureCode-CSharp-Web-Extensions-IServiceCollectionExtensions-AddCookieAuthentication-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfigurationRoot,Microsoft-AspNetCore-Http-SameSiteMode-'></a>
### AddCookieAuthentication(services,configRoot,mode) `method`

##### Summary

Register cookie authentication related actors

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
| configRoot | [Microsoft.Extensions.Configuration.IConfigurationRoot](#T-Microsoft-Extensions-Configuration-IConfigurationRoot 'Microsoft.Extensions.Configuration.IConfigurationRoot') |  |
| mode | [Microsoft.AspNetCore.Http.SameSiteMode](#T-Microsoft-AspNetCore-Http-SameSiteMode 'Microsoft.AspNetCore.Http.SameSiteMode') |  |

##### Remarks

Remember to configure 'UseCookieAuthentication()' and 'UseAuthorization()'
after 'UseRouting()', but before 'UseEndpoints()'

<a name='M-AndcultureCode-CSharp-Web-Extensions-IServiceCollectionExtensions-AddForwardedHeaders-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddForwardedHeaders(services) `method`

##### Summary

Enables HTTP Header forwarding for proxies. This is not enabled by default when hosting out of process (i.e kestrel)

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='T-AndcultureCode-GB-Presentation-Web-Extensions-OAuthCreatingTicketContextExtensions'></a>
## OAuthCreatingTicketContextExtensions `type`

##### Namespace

AndcultureCode.GB.Presentation.Web.Extensions

##### Summary

Extension methods for OAuth context for successful login

<a name='M-AndcultureCode-GB-Presentation-Web-Extensions-OAuthCreatingTicketContextExtensions-GetUser``1-Microsoft-AspNetCore-Authentication-OAuth-OAuthCreatingTicketContext-'></a>
### GetUser\`\`1() `method`

##### Summary

Request associated user information from configured OAuth UserInformation endpoint

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-GB-Presentation-Web-Extensions-OAuthCreatingTicketContextExtensions-Get``1-Microsoft-AspNetCore-Authentication-OAuth-OAuthCreatingTicketContext-'></a>
### Get\`\`1() `method`

##### Summary

Get dependency injected resources

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Web-Middleware-OAuthHandler`4'></a>
## OAuthHandler\`4 `type`

##### Namespace

AndcultureCode.CSharp.Web.Middleware

##### Summary

Middleware event handlers for OAuth Accounts

<a name='M-AndcultureCode-CSharp-Web-Middleware-OAuthHandler`4-HandleCreatingTicket-Microsoft-AspNetCore-Authentication-OAuth-OAuthCreatingTicketContext,AndcultureCode-CSharp-Web-Middleware-OAuthHandler{`0,`1,`2,`3}-GetClaimsCallback-'></a>
### HandleCreatingTicket() `method`

##### Summary

OAuth 'OnCreatingTicket' Handler
Executed upon a successful external login.

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Web-Constants-WebConfiguration'></a>
## WebConfiguration `type`

##### Namespace

AndcultureCode.CSharp.Web.Constants

##### Summary

Identifiers used for IConfigurationRoot configured sections and values

<a name='F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION'></a>
### AUTHENTICATION `constants`

##### Summary

General authentication section

<a name='F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_BASIC'></a>
### AUTHENTICATION_BASIC `constants`

##### Summary

Authentication's basic subsection

<a name='F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_COOKIE'></a>
### AUTHENTICATION_COOKIE `constants`

##### Summary

Authentication's cookies subsection

<a name='F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_FACEBOOK'></a>
### AUTHENTICATION_FACEBOOK `constants`

##### Summary

Authentication's facebook oauth subsection

<a name='F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_GOOGLE'></a>
### AUTHENTICATION_GOOGLE `constants`

##### Summary

Authentication's google oauth subsection

<a name='F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_MICROSOFT'></a>
### AUTHENTICATION_MICROSOFT `constants`

##### Summary

Authentication's microsoft oauth subsection

<a name='F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_TWITTER'></a>
### AUTHENTICATION_TWITTER `constants`

##### Summary

Authentication's microsoft oauth subsection
