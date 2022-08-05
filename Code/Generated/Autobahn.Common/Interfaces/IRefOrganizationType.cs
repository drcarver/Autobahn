//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefOrganizationType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefOrganizationType Interface
     /// </summary>
    public partial interface IRefOrganizationType : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationElementType"/> model
        /// </summary>
        Guid? RefOrganizationElementTypeId { get; set; }

    }
}
