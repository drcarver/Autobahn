//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDemographicRace.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDemographicRace Interface
     /// </summary>
    public partial interface IPersonDemographicRace : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         FederalRaceAndEthnicityDeclined { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

    }
}
