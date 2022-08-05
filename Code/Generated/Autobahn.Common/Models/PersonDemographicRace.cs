//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDemographicRace.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDemographicRace
     /// </summary>
    public partial class PersonDemographicRace : AutobahnBase, Interfaces.IPersonDemographicRace
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
        /// Defines the PersonDemographicRace.FederalRaceAndEthnicityDeclined nullable property
        /// </summary>
        public System.Boolean? FederalRaceAndEthnicityDeclined { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
