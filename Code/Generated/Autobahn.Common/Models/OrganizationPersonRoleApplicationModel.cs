//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleApplicationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleApplication Model
     /// </summary>
    public partial class OrganizationPersonRoleApplicationModel : AutobahnBase, Interfaces.IOrganizationPersonRoleApplication
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? ApplicationDate { get; set; }

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
