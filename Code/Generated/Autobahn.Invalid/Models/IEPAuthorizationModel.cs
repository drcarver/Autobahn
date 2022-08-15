//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPAuthorizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IEPAuthorization Model
     /// </summary>
    public partial class IEPAuthorizationModel : AutobahnBase, Interfaces.IIEPAuthorization
    {
        /// <summary>
        /// Type of Individualized Education Plan document authorized.
        /// </summary>
        public Guid? RefIEPAuthorizationDocumentTypeId { get; set; }

    }
}
