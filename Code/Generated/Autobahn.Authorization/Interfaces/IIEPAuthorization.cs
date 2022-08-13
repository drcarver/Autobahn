//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IIEPAuthorization.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IIEPAuthorization Interface
     /// </summary>
    public partial interface IIEPAuthorization : IAutobahnBase
    {
        /// <summary>
        /// Type of Individualized Education Plan document authorized.
        /// </summary>
        Guid AuthorizationDocumentId { get; set; }

        /// <summary>
        /// Type of Individualized Education Plan document authorized.
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Type of Individualized Education Plan document authorized.
        /// </summary>
        Guid? RefIEPAuthorizationDocumentTypeId { get; set; }

    }
}