//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDemographicRaceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDemographicRace Model
     /// </summary>
    public partial class PersonDemographicRaceModel : AutobahnBase, Interfaces.IPersonDemographicRace
    {
        /// <summary>
        /// 
        /// </summary>
        public  FederalRaceAndEthnicityDeclined { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
