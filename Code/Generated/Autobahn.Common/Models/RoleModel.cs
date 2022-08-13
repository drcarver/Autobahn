//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Role Model
     /// </summary>
    public partial class RoleModel : AutobahnBase, Interfaces.IRole
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefRoleId { get; set; }

    }
}
