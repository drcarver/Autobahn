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
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? FederalRaceAndEthnicityDeclined { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RefRaceId { get; set; }

    }
}
