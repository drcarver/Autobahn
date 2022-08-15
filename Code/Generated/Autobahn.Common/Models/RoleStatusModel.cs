//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleStatusModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RoleStatus Model
     /// </summary>
    public partial class RoleStatusModel : AutobahnBase, Interfaces.IRoleStatus
    {
        /// <summary>
        /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
        /// </summary>
        public Guid? RefRoleStatusId { get; set; }

    }
}
