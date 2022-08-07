//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationWebsiteModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationWebsite Model
     /// </summary>
    public partial class OrganizationWebsiteModel : AutobahnBase, Interfaces.IOrganizationWebsiteModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationWebsite.Website non nullable property
        /// </summary>
        public System.String Website { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
