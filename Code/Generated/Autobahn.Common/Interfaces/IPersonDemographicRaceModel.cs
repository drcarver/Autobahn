//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonDemographicRaceModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDemographicRaceModel Interface
     /// </summary>
    public partial interface IPersonDemographicRaceModel : IAutobahnBase
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
