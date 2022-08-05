//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRole.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRole
     /// </summary>
    public partial class OrganizationPersonRole : AutobahnBase, Interfaces.IOrganizationPersonRole
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Role"/> model
        /// </summary>
        public Guid RoleId { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRole.EntryDate nullable property
        /// </summary>
        public System.DateTime? EntryDate { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRole.ExitDate nullable property
        /// </summary>
        public System.DateTime? ExitDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
