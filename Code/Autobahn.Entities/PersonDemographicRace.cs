using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonDemographicRace")]
    public partial class PersonDemographicRace
    {
        public int PersonDemographicRaceId { get; set; }

        public int PersonId { get; set; }

        public int RefRaceId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public bool? FederalRaceAndEthnicityDeclined { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RefRace RefRace { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
