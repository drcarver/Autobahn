//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefOrganizationTypeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefOrganizationType Interface Model
     /// </summary>
    public partial interface IRefOrganizationTypeModel : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationElementType"/> model
        /// </summary>
        Guid? RefOrganizationElementTypeId { get; set; }

    }
}
