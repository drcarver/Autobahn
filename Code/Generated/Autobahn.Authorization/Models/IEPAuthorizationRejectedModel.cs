//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IEPAuthorizationRejectedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
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
