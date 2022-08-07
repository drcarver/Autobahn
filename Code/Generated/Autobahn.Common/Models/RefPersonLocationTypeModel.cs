//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonLocationTypeModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefPersonLocationType Model
     /// </summary>
    public partial class RefPersonLocationTypeModel : ReferenceModelBase, IRefPersonLocationTypeModel
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
