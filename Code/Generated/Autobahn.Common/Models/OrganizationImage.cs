//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationImage.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationImage
     /// </summary>
    public partial class OrganizationImage : AutobahnBase, Interfaces.IOrganizationImage
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationImage.URL non nullable property
        /// </summary>
        public System.String URL { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
