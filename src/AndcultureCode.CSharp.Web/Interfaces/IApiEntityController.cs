using AndcultureCode.CSharp.Core.Interfaces.Conductors;
using AndcultureCode.CSharp.Core.Models.Entities;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AndcultureCode.CSharp.Web.Interfaces
{
    /// <summary>
    /// Describes an ApiController that pertains to an Entity from the application's domain layer.
    /// </summary>
    public interface IApiEntityController<TController, TEntity> : IController
        where TController : class, IController
        where TEntity : Entity
    {
        /// <summary>
        /// Associated entity's repository conductor
        /// </summary>
        IRepositoryConductor<TEntity> Conductor { get; }

        /// <summary>
        /// Controller logger
        /// </summary>
        ILogger<TController> Logger { get; }

        /// <summary>
        /// Data mapping instance
        /// </summary>
        /// <value></value>
        IMapper Mapper { get; }
    }
}
