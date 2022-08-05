//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationIndicator.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationIndicator
     /// </summary>
    public partial class OrganizationIndicator : AutobahnBase, Interfaces.IOrganizationIndicator
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationIndicator.IndicatorValue non nullable property
        /// </summary>
        public System.String IndicatorValue { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefOrganizationIndicator"/> model
        /// </summary>
        public Guid RefOrganizationIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
