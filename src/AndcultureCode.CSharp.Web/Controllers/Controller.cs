using System;
using System.Collections.Generic;
using System.Linq;
using AndcultureCode.CSharp.Core.Constants;
using AndcultureCode.CSharp.Core.Enumerations;
using AndcultureCode.CSharp.Core.Interfaces;
using AndcultureCode.CSharp.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Localization;
using AndcultureCode.CSharp.Core.Utilities.Localization;
using AndcultureCode.CSharp.Web.Interfaces;
using Microsoft.AspNetCore.Localization;
using AndcultureCode.CSharp.Web.Extensions;
using AndcultureCode.CSharp.Core.Models.Errors;

namespace AndcultureCode.CSharp.Web.Controllers
{
    /// <summary>
    /// Base localized controller
    /// </summary>
    public class Controller : Microsoft.AspNetCore.Mvc.Controller, IController
    {
        #region Constants

        /// <summary>
        /// Data and route Ids do not match
        /// </summary>
        public const string ERROR_ID_MISMATCH = "Web.Controller.ERROR_ID_MISMATCH";

        /// <summary>
        /// Requested resource was not found
        /// </summary>
        public const string ERROR_RESOURCE_NOT_FOUND = ErrorConstants.ERROR_RESOURCE_NOT_FOUND_KEY;

        #endregion Constants

        #region Constructor

        /// <summary>
        /// Base localized controller
        /// </summary>
        /// <param name="localizer"></param>
        public Controller(IStringLocalizer localizer)
        {
            _localizer = localizer;
        }

        #endregion Constructor

        #region Private Properties

        private ICulture _currentCulture;
        private IStringLocalizer _localizer;

        #endregion Private Properties

        #region Protected Properties

        /// <summary>
        /// Reference to localizer for sub-classes
        /// </summary>
        protected IStringLocalizer Localizer { get => _localizer; }

        #endregion Protected Properties

        #region Public Properties

        /// <summary>
        /// Culture for current request
        /// </summary>
        public virtual ICulture CurrentCulture
        {
            get
            {
                if (_currentCulture != null)
                {
                    return _currentCulture;
                }

                var feature = HttpContext.Features.Get<IRequestCultureFeature>();
                _currentCulture = LocalizationUtils.CultureByCode(feature.RequestCulture.Culture.Name);

                return _currentCulture;
            }
        }

        /// <summary>
        /// Get current ip address
        /// </summary>
        /// <value></value>
        public virtual string IpAddress { get => Request?.GetIpAddress(); }

        /// <summary>
        /// Requesting user's agent
        /// </summary>
        /// <value></value>
        protected string UserAgent { get => Request?.GetUserAgent(); }

        #endregion Public Properties

        #region Results

        /// <summary>
        /// Responds with HTTP 202 Accepted
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        public AcceptedResult Accepted<T>(T value, IEnumerable<IError> errors)
            => base.Accepted(CreateResult(value, errors));

        /// <summary>
        /// Responds with HTTP 400 Bad Request
        /// </summary>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        public BadRequestObjectResult BadRequest<T>(IEnumerable<IError> errors)
            => base.BadRequest(CreateResult<object>(null, errors));

        /// <summary>
        /// Responds with HTTP 400 Bad Request
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        public BadRequestObjectResult BadRequest<T>(T value, IEnumerable<IError> errors)
            => base.BadRequest(CreateResult(value, errors));

        /// <summary>
        /// Responds with HTTP 400 Bad Request
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        public BadRequestObjectResult BadRequest<T>(T value, params IError[] errors)
            => base.BadRequest(CreateResult(value, errors));

        /// <summary>
        /// Responds with HTTP 400 Bad Request
        /// </summary>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        [ApiExplorerSettings(IgnoreApi = true)] // Tell swagger to ignore
        public BadRequestObjectResult BadRequest(string key, string message, ErrorType type = ErrorType.Error)
            => base.BadRequest(new List<Error>
            {
                new Error
                {
                    ErrorType = type,
                    Key       = key,
                    Message   = message
                }
            });

        /// <summary>
        /// Responds with HTTP 400 Bad Request
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <typeparam name="T"></typeparam>
        public BadRequestObjectResult BadRequest<T>(T value, string key, string message, ErrorType type = ErrorType.Error)
            => base.BadRequest(CreateResult(value, new List<Error>
            {
                new Error
                {
                    ErrorType = type,
                    Key       = key,
                    Message   = message
                }
            }));

        /// <summary>
        /// Responds with HTTP 409 Conflicted
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        public ObjectResult Conflict<T>(T value, IEnumerable<IError> errors)
            => StatusCode(StatusCodes.Status409Conflict, value, errors);

        /// <summary>
        /// Responds with HTTP 409 Conflicted
        /// </summary>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        public ObjectResult Conflict<T>(IEnumerable<IError> errors)
            => StatusCode(StatusCodes.Status409Conflict, default(T), errors);

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        public CreatedResult Created<T>(T value)
            => base.Created(string.Empty, CreateResult(value, null));

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="uriIdentifier"></param>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        public CreatedResult Created<T>(long uriIdentifier, T value)
            => base.Created(uriIdentifier.ToString(), CreateResult(value, null));

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        public CreatedResult Created<T>(string uri, T value)
            => base.Created(uri, CreateResult(value, null));

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        public CreatedResult Created<T>(string uri, T value, IEnumerable<IError> errors)
            => base.Created(uri, CreateResult(value, errors));

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        public CreatedResult Created<T>(Uri uri, T value, IEnumerable<IError> errors)
            => base.Created(uri, CreateResult(value, errors));

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="routeValues"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public CreatedAtActionResult CreatedAtAction<T>(string actionName, object routeValues, T value, IEnumerable<IError> errors)
            => base.CreatedAtAction(actionName, routeValues, CreateResult(value, errors));

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="controllerName"></param>
        /// <param name="routeValues"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public CreatedAtActionResult CreatedAtAction<T>(string actionName, string controllerName, object routeValues, T value, IEnumerable<IError> errors)
            => base.CreatedAtAction(actionName, controllerName, routeValues, CreateResult(value, errors));

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public CreatedAtActionResult CreatedAtAction<T>(string actionName, T value, IEnumerable<IError> errors)
            => base.CreatedAtAction(actionName, CreateResult(value, errors));

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="routeName"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public CreatedAtRouteResult CreatedAtRoute<T>(string routeName, T value, IEnumerable<IError> errors)
            => base.CreatedAtRoute(routeName, CreateResult(value, errors));

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="routeValues"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public CreatedAtRouteResult CreatedAtRoute<T>(object routeValues, T value, IEnumerable<IError> errors)
            => base.CreatedAtRoute(routeValues, CreateResult(value, errors));

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="routeName"></param>
        /// <param name="routeValues"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public CreatedAtRouteResult CreatedAtRoute<T>(string routeName, object routeValues, T value, IEnumerable<IError> errors)
            => base.CreatedAtRoute(routeName, routeValues, CreateResult(value, errors));

        /// <summary>
        /// Create a result object given the value and errors list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <returns></returns>
        public IResult<T> CreateResult<T>(T value, IEnumerable<IError> errors) => new Result<T>()
        {
            Errors = errors?.ToList(),
            ResultObject = value
        };

        /// <summary>
        /// Responds with HTTP 403 Forbidden
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public ObjectResult Forbidden<T>(T value, IEnumerable<IError> errors)
            => StatusCode(403, value, errors);

        /// <summary>
        /// Responds with HTTP 403 Forbidden
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public ObjectResult Forbidden<T>(T value, params IError[] errors)
            => StatusCode(403, value, errors);

        /// <summary>
        /// Responds with HTTP 403 Forbidden
        /// </summary>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public ObjectResult Forbidden<T>(IEnumerable<IError> errors)
            => StatusCode(403, default(T), errors);

        /// <summary>
        /// Responds with HTTP 403 Forbidden
        /// </summary>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public ObjectResult Forbidden<T>(params IError[] errors)
            => StatusCode(403, default(T), errors);

        /// <summary>
        /// Responds with HTTP 500 Internal Server Error
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <param name="logger"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public ObjectResult InternalError<T>(T value, IEnumerable<IError> errors, ILogger logger = null)
        {
            logger.LogErrors<T>(value, errors);

            return StatusCode(500, value, errors);
        }

        /// <summary>
        /// Responds with HTTP 500 Internal Server Error
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="logger"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public ObjectResult InternalError<T>(IEnumerable<IError> errors, ILogger logger = null)
            => InternalError(default(T), errors, logger);

        /// <summary>
        /// Responds with HTTP 500 Internal Server Error
        /// </summary>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="logger"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public ObjectResult InternalError<T>(string key, string message, ErrorType type = ErrorType.Error, ILogger logger = null)
            => InternalError(default(T), new List<Error>
            {
                new Error
                {
                    ErrorType = type,
                    Key       = key,
                    Message   = message
                }
            }, logger);

        /// <summary>
        /// Responds with HTTP 404 Not Found
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public NotFoundObjectResult NotFound<T>(T value, IEnumerable<IError> errors)
            => base.NotFound(CreateResult(value, errors));

        /// <summary>
        /// Responds with HTTP 404 Not Found
        /// </summary>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public NotFoundObjectResult NotFound<T>(IEnumerable<IError> errors)
            => base.NotFound(CreateResult(default(T), errors));

        /// <summary>
        /// Responds with HTTP 404 Not Found
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public NotFoundObjectResult NotFound<T>(T value, string key, string message, ErrorType type = ErrorType.Error)
            => base.NotFound(CreateResult(value, new List<Error>
            {
                new Error
                {
                    ErrorType = type,
                    Key       = key,
                    Message   = message
                }
            }));

        /// <summary>
        /// Responds with HTTP 404 Not Found
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public NotFoundObjectResult NotFound<T>()
            => base.NotFound(CreateResult(default(T), new List<IError> { GetResourceNotFoundError<T>() }));

        /// <summary>
        /// Responds with HTTP 200 Ok
        /// </summary>
        public new OkObjectResult Ok() => Ok<object>(value: null);

        /// <summary>
        /// Responds with HTTP 200 Ok
        /// </summary>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        public OkObjectResult Ok<T>(T value) => Ok<T>(value: value, errors: null);

        /// <summary>
        /// Responds with HTTP 200 Ok
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public OkObjectResult Ok<T>(T value, IEnumerable<IError> errors)
            => base.Ok(CreateResult(value, errors));

        /// <summary>
        /// Responds with HTTP supplied statusCode in our conventional IResult response.
        /// Mostly to be used in a pinch or very edge case.
        /// Ultimately we should continue to extend to offer wrapper methods around
        /// HTTP status codes we use.
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public ObjectResult StatusCode<T>(int statusCode, T value, IEnumerable<IError> errors)
            => base.StatusCode(statusCode, CreateResult(value, errors));

        #endregion Results

        #region Errors

        /// <summary>
        /// Constructors error object for ERROR_ID_MISMATCH_KEY
        /// </summary>
        /// <returns></returns>
        protected IError GetIdMismatchError()
            => GetNewError(ERROR_ID_MISMATCH, _localizer[ERROR_ID_MISMATCH]);

        /// <summary>
        /// Constructors error object for ERROR_ID_MISMATCH_KEY
        /// </summary>
        /// <param name="routeParameter"></param>
        /// <param name="dtoProperty"></param>
        /// <returns></returns>
        protected IError GetIdMismatchError(string routeParameter, string dtoProperty)
            => GetNewError(ERROR_ID_MISMATCH, _localizer[ERROR_ID_MISMATCH, routeParameter, dtoProperty]);

        /// <summary>
        /// Constructors error object
        /// </summary>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        protected IError GetNewError(string key, string message) => new Error
        {
            ErrorType = ErrorType.Error,
            Key = key,
            Message = message,
        };

        /// <summary>
        /// Constructors error object for ERROR_RESOURCE_NOT_FOUND_KEY
        /// </summary>
        /// <returns></returns>
        protected IError GetResourceNotFoundError()
            => GetNewError(ERROR_RESOURCE_NOT_FOUND, _localizer[ERROR_RESOURCE_NOT_FOUND]);

        /// <summary>
        /// Constructors error object for ERROR_RESOURCE_NOT_FOUND_KEY
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        protected IError GetResourceNotFoundError<T>()
            => GetNewError(ERROR_RESOURCE_NOT_FOUND, _localizer[ERROR_RESOURCE_NOT_FOUND, typeof(T).Name.Replace("Dto", string.Empty)]);

        /// <summary>
        /// Constructors error object for ERROR_RESOURCE_NOT_FOUND_KEY
        /// </summary>
        /// <param name="resourceName"></param>
        /// <returns></returns>
        protected IError GetResourceNotFoundError(string resourceName)
            => GetNewError(ERROR_RESOURCE_NOT_FOUND, _localizer[ERROR_RESOURCE_NOT_FOUND, resourceName]);

        #endregion Errors
    }
}
