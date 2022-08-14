//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPAuthorizationRejectedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IEPAuthorizationRejected Model
     /// </summary>
    public partial class IEPAuthorizationRejectedModel : AutobahnBase, Interfaces.IIEPAuthorizationRejected
    {
        /// <summary>
        /// Portion the authorizer does not want executed.
        /// </summary>
        public Guid IEPAuthorizationId { get; set; }

        /// <summary>
        /// Portion the authorizer does not want executed.
        /// </summary>
        public System.String PortionDescription { get; set; }

        /// <summary>
        /// Portion the authorizer does not want executed.
        /// </summary>
        public System.String PortionExplanation { get; set; }

    }
}
