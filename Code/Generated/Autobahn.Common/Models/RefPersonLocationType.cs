//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonLocationType.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefPersonLocationType Model
     /// </summary>
    public partial class RefPersonLocationType : ReferenceModelBase, IRefPersonLocationType
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Role"/> model
        /// </summary>
        public Guid? RoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAddressType"/> model
        /// </summary>
        public Guid? RefAddressTypeId { get; set; }

    }
}
