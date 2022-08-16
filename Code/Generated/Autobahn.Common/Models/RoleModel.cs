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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefRoleId { get; set; }

    }
}
