//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIEPAuthorizationRejected.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIEPAuthorizationRejected Interface
     /// </summary>
    public partial interface IIEPAuthorizationRejected : IAutobahnBase
    {
        /// <summary>
        /// Portion the authorizer does not want executed.
        /// </summary>
        System.String PortionDescription { get; set; }

    }
}
