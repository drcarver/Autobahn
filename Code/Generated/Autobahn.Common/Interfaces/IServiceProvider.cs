//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IServiceProvider.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServiceProvider Interface
     /// </summary>
    public partial interface IServiceProvider : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IServiceProvided"/> model
        /// </summary>
        Guid ServiceProvidedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IServiceStaff"/> model
        /// </summary>
        Guid ServiceStaffId { get; set; }

    }
}
