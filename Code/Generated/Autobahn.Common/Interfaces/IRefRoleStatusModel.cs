//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefRoleStatusModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefRoleStatus Interface Model
     /// </summary>
    public partial interface IRefRoleStatusModel : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleStatusType"/> model
        /// </summary>
        Guid? RefRoleStatusTypeId { get; set; }

    }
}
