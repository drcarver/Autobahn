//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefOrganizationIndicator.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefOrganizationIndicator Interface
     /// </summary>
    public partial interface IRefOrganizationIndicator : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationType"/> model
        /// </summary>
        Guid? RefOrganizationTypeId { get; set; }

    }
}
