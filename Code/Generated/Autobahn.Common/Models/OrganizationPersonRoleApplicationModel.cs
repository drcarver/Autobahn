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
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.DateTime ApplicationDate { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
