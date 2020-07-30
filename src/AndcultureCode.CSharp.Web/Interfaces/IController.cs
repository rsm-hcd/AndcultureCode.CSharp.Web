using System;
using System.Collections.Generic;
using AndcultureCode.CSharp.Core.Enumerations;
using AndcultureCode.CSharp.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AndcultureCode.CSharp.Web.Interfaces
{
    /// <summary>
    /// Application controller contract
    /// </summary>
    public interface IController
    {
        #region Properties

        /// <summary>
        /// Current request's i18n/l10n culture
        /// </summary>
        /// <value></value>
        ICulture CurrentCulture { get; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Responds with HTTP 202 Accepted
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        AcceptedResult Accepted<T>(T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 400 Bad Request
        /// </summary>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        BadRequestObjectResult BadRequest<T>(IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 400 Bad Request
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        BadRequestObjectResult BadRequest<T>(T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 400 Bad Request
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        BadRequestObjectResult BadRequest<T>(T value, params IError[] errors);

        /// <summary>
        /// Responds with HTTP 400 Bad Request
        /// </summary>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        BadRequestObjectResult BadRequest(string key, string message, ErrorType type = ErrorType.Error);

        /// <summary>
        /// Responds with HTTP 400 Bad Request
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <typeparam name="T"></typeparam>
        BadRequestObjectResult BadRequest<T>(T value, string key, string message, ErrorType type = ErrorType.Error);

        /// <summary>
        /// Responds with HTTP 409 Conflicted
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        ObjectResult Conflict<T>(T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 409 Conflicted
        /// </summary>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        ObjectResult Conflict<T>(IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        CreatedResult Created<T>(T value);

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="uriIdentifier"></param>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        CreatedResult Created<T>(long uriIdentifier, T value);

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        CreatedResult Created<T>(string uri, T value);

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        CreatedResult Created<T>(string uri, T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        CreatedResult Created<T>(Uri uri, T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="routeValues"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        CreatedAtActionResult CreatedAtAction<T>(string actionName, object routeValues, T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="controllerName"></param>
        /// <param name="routeValues"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        CreatedAtActionResult CreatedAtAction<T>(string actionName, string controllerName, object routeValues, T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        CreatedAtActionResult CreatedAtAction<T>(string actionName, T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="routeName"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        CreatedAtRouteResult CreatedAtRoute<T>(string routeName, T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="routeValues"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        CreatedAtRouteResult CreatedAtRoute<T>(object routeValues, T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 201 Created
        /// </summary>
        /// <param name="routeName"></param>
        /// <param name="routeValues"></param>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        CreatedAtRouteResult CreatedAtRoute<T>(string routeName, object routeValues, T value, IEnumerable<IError> errors);

        /// <summary>
        /// Constructs a response in the form of an IResult
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        IResult<T> CreateResult<T>(T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 403 Forbidden
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        ObjectResult Forbidden<T>(T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 403 Forbidden
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        ObjectResult Forbidden<T>(T value, params IError[] errors);

        /// <summary>
        /// Responds with HTTP 403 Forbidden
        /// </summary>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        ObjectResult Forbidden<T>(IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 403 Forbidden
        /// </summary>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        ObjectResult Forbidden<T>(params IError[] errors);

        /// <summary>
        /// Responds with HTTP 500 Internal Server Error
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <param name="logger"></param>
        /// <typeparam name="T"></typeparam>
        ObjectResult InternalError<T>(T value, IEnumerable<IError> errors, ILogger logger = null);

        /// <summary>
        /// Responds with HTTP 500 Internal Server Error
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="logger"></param>
        /// <typeparam name="T"></typeparam>
        ObjectResult InternalError<T>(IEnumerable<IError> errors, ILogger logger = null);

        /// <summary>
        /// Responds with HTTP 500 Internal Server Error
        /// </summary>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="logger"></param>
        /// <typeparam name="T"></typeparam>
        ObjectResult InternalError<T>(string key, string message, ErrorType type = ErrorType.Error, ILogger logger = null);

        /// <summary>
        /// Responds with HTTP 404 Not Found
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        NotFoundObjectResult NotFound<T>(T value, IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 404 Not Found
        /// </summary>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        NotFoundObjectResult NotFound<T>(IEnumerable<IError> errors);

        /// <summary>
        /// Responds with HTTP 404 Not Found
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <typeparam name="T"></typeparam>
        NotFoundObjectResult NotFound<T>(T value, string key, string message, ErrorType type = ErrorType.Error);

        /// <summary>
        /// Responds with HTTP 404 Not Found
        /// </summary>
        /// <typeparam name="T"></typeparam>
        NotFoundObjectResult NotFound<T>();

        /// <summary>
        /// Responds with HTTP 200 Ok
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errors"></param>
        /// <typeparam name="T"></typeparam>
        OkObjectResult Ok<T>(T value, IEnumerable<IError> errors);

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
        ObjectResult StatusCode<T>(int statusCode, T value, IEnumerable<IError> errors);

        #endregion Methods
    }
}
