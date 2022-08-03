//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationPopulationServed.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPopulationServed
     /// </summary>
    public partial interface IOrganizationPopulationServed
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

        /// <summary>
        /// Defines the OrganizationPopulationServed.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationPopulationServed.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
