//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIEPAuthorization.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIEPAuthorization Interface
     /// </summary>
    public partial interface IIEPAuthorization : IAutobahnBase
    {
        /// <summary>
        /// Type of Individualized Education Plan document authorized.
        /// </summary>
        Guid? RefIEPAuthorizationDocumentTypeId { get; set; }

    }
}
