//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefOrganizationTypeModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefOrganizationType Model
     /// </summary>
    public partial class RefOrganizationTypeModel : ReferenceModelBase, IRefOrganizationTypeModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationElementType"/> model
        /// </summary>
        public Guid? RefOrganizationElementTypeId { get; set; }

    }
}
