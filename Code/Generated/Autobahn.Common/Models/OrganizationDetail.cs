//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationDetail.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationDetail
     /// </summary>
    public partial class OrganizationDetail : AutobahnBase, Interfaces.IOrganizationDetail
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationDetail.Name non nullable property
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Defines the OrganizationDetail.ShortName non nullable property
        /// </summary>
        public System.String ShortName { get; set; }

        /// <summary>
        /// Defines the OrganizationDetail.RegionGeoJSON non nullable property
        /// </summary>
        public System.String RegionGeoJSON { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationType"/> model
        /// </summary>
        public Guid? RefOrganizationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
