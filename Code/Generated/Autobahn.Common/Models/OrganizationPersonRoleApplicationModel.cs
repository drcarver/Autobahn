//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRoleApplicationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleApplication Model
     /// </summary>
    public partial class OrganizationPersonRoleApplicationModel : AutobahnBase, Interfaces.IOrganizationPersonRoleApplicationModel
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
