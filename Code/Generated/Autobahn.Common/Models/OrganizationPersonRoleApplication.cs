//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRoleApplication.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleApplication
     /// </summary>
    public partial class OrganizationPersonRoleApplication : AutobahnBase, Interfaces.IOrganizationPersonRoleApplication
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleApplication.ApplicationDate non nullable property
        /// </summary>
        public System.DateTime ApplicationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
