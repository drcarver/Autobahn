using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityRelationship")]
    public partial class FacilityRelationship
    {
        public int FacilityRelationshipId { get; set; }

        public int Parent_FacilityId { get; set; }

        public int FacilityId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual Facility Facility1 { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
