//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPopulationServed.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPopulationServed
     /// </summary>
    public partial class OrganizationPopulationServed : AutobahnBase, Interfaces.IOrganizationPopulationServed
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationPopulationServed.AgeUnit non nullable property
        /// </summary>
        public System.String AgeUnit { get; set; }

        /// <summary>
        /// Defines the OrganizationPopulationServed.OldestAgeServed nullable property
        /// </summary>
        public System.Int32? OldestAgeServed { get; set; }

        /// <summary>
        /// Defines the OrganizationPopulationServed.YoungestAgeServed nullable property
        /// </summary>
        public System.Int32? YoungestAgeServed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPopulationServed"/> model
        /// </summary>
        public Guid? RefPopulationServedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
