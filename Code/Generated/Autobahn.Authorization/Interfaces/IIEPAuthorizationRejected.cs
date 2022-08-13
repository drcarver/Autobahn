//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IIEPAuthorizationRejected.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IIEPAuthorizationRejected Interface
     /// </summary>
    public partial interface IIEPAuthorizationRejected : IAutobahnBase
    {
        /// <summary>
        /// Portion the authorizer does not want executed.
        /// </summary>
        Guid IEPAuthorizationId { get; set; }

        /// <summary>
        /// Portion the authorizer does not want executed.
        /// </summary>
        System.String PortionDescription { get; set; }

        /// <summary>
        /// Portion the authorizer does not want executed.
        /// </summary>
        System.String PortionExplanation { get; set; }

    }
}
