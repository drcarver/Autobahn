using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityLocation")]
    public partial class FacilityLocation
    {
        public int FacilityLocationId { get; set; }

        public int FacilityId { get; set; }

        public int LocationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual Location Location { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
