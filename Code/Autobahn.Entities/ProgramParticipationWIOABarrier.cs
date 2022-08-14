using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProgramParticipationWIOABarriers")]
    public partial class ProgramParticipationWIOABarriers
    {
        [Key]
        public int ProgramParticipationWIOABarriersId { get; set; }

        public int ProgramParticipationWIOAId { get; set; }

        public int? RefWIOABarrierstoEmploymentId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual ProgramParticipationWIOA ProgramParticipationWIOA { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefWIOABarrierstoEmployment RefWIOABarrierstoEmployment { get; set; }
    }
}
