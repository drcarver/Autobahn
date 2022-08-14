using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELChildHealth")]
    public partial class ELChildHealth
    {
        public int ELChildHealthId { get; set; }

        public int PersonId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WellChildScreeningReceivedDate { get; set; }

        public int? RefScheduledWellChildScreeningId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefScheduledWellChildScreening RefScheduledWellChildScreening { get; set; }
    }
}
