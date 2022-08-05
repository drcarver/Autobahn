//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefPersonLocationType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefPersonLocationType Interface
     /// </summary>
    public partial interface IRefPersonLocationType : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Role"/> model
        /// </summary>
        Guid? RoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAddressType"/> model
        /// </summary>
        Guid? RefAddressTypeId { get; set; }

    }
}
