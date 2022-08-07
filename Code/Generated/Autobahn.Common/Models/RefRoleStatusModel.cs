//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRoleStatusModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefRoleStatus Model
     /// </summary>
    public partial class RefRoleStatusModel : ReferenceModelBase, IRefRoleStatusModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleStatusType"/> model
        /// </summary>
        public Guid? RefRoleStatusTypeId { get; set; }

    }
}
