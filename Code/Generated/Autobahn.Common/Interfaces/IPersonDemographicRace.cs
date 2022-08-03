//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonDemographicRace.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDemographicRace
     /// </summary>
    public partial interface IPersonDemographicRace
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefRace"/> model
        /// </summary>
        Guid RefRaceId { get; set; }

        /// <summary>
        /// Defines the PersonDemographicRace.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDemographicRace.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDemographicRace.FederalRaceAndEthnicityDeclined nullable property
        /// </summary>
        System.Boolean? FederalRaceAndEthnicityDeclined { get; set; }

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
