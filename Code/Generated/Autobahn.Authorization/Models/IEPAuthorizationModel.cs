//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IEPAuthorizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The IEPAuthorization Model
     /// </summary>
    public partial class IEPAuthorizationModel : AutobahnBase, Interfaces.IIEPAuthorization
    {
        /// <summary>
        /// Type of Individualized Education Plan document authorized.
        /// </summary>
        public Guid AuthorizationDocumentId { get; set; }

        /// <summary>
        /// Type of Individualized Education Plan document authorized.
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Type of Individualized Education Plan document authorized.
        /// </summary>
        public Guid? RefIEPAuthorizationDocumentTypeId { get; set; }

    }
}
