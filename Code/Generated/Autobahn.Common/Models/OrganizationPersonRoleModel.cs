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
        /// The year, month and day on which the person began to participate in the activity.
        /// </summary>
        public System.DateTime? EntryDate { get; set; }

    }
}
