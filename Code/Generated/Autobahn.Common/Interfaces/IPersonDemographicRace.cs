//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonDemographicRace.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDemographicRace
     /// </summary>
    public partial interface IPersonDemographicRace : IAutobahnBase
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
        /// Defines the PersonDemographicRace.FederalRaceAndEthnicityDeclined nullable property
        /// </summary>
        System.Boolean? FederalRaceAndEthnicityDeclined { get; set; }

    }
}
