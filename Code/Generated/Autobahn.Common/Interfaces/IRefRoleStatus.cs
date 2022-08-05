//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefRoleStatus.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefRoleStatus Interface
     /// </summary>
    public partial interface IRefRoleStatus : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleStatusType"/> model
        /// </summary>
        Guid? RefRoleStatusTypeId { get; set; }

    }
}
