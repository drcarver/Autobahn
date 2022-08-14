using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityAudit")]
    public partial class FacilityAudit
    {
        public int FacilityAuditId { get; set; }

        public int FacilityId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FacilityAuditDate { get; set; }

        public int? RefFacilityAuditTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFacilityAuditType RefFacilityAuditType { get; set; }
    }
}
