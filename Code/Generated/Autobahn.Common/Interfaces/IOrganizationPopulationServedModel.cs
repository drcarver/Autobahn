//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationPopulationServedModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPopulationServedModel Interface
     /// </summary>
    public partial interface IOrganizationPopulationServedModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationPopulationServed.AgeUnit non nullable property
        /// </summary>
        System.String AgeUnit { get; set; }

        /// <summary>
        /// Defines the OrganizationPopulationServed.OldestAgeServed nullable property
        /// </summary>
        System.Int32? OldestAgeServed { get; set; }

        /// <summary>
        /// Defines the OrganizationPopulationServed.YoungestAgeServed nullable property
        /// </summary>
        System.Int32? YoungestAgeServed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPopulationServed"/> model
        /// </summary>
        Guid? RefPopulationServedId { get; set; }

    }
}
