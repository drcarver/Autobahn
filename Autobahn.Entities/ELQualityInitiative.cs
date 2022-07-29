using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELQualityInitiative")]
    public partial class ELQualityInitiative
    {
        public int ELQualityInitiativeId { get; set; }

        public int OrganizationId { get; set; }

        [StringLength(30)]
        public string MaximumScore { get; set; }

        [StringLength(30)]
        public string MinimumScore { get; set; }

        [StringLength(30)]
        public string ScoreLevel { get; set; }

        public bool? ParticipationIndicator { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ParticipationStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ParticipationEndDate { get; set; }

        public bool? ProgramHeathSafetyChecklistUseStatus { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
