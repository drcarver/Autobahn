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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefRoleStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StatusEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StatusStartDate { get; set; }

    }
}
