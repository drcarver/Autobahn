//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDemographicRace.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDemographicRace
     /// </summary>
    public partial class PersonDemographicRace : IPersonDemographicRace
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefRace"/> model
        /// </summary>
        public Guid RefRaceId { get; set; }

        /// <summary>
        /// Defines the PersonDemographicRace.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDemographicRace.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDemographicRace.FederalRaceAndEthnicityDeclined nullable property
        /// </summary>
        public System.Boolean? FederalRaceAndEthnicityDeclined { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
