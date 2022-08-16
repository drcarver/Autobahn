//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRole Model
     /// </summary>
    public partial class OrganizationPersonRoleModel : AutobahnBase, Interfaces.IOrganizationPersonRole
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? EntryDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ExitDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
