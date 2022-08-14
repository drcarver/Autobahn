using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentPersonalNeedScreenReader")]
    public partial class AssessmentPersonalNeedScreenReader
    {
        public int AssessmentPersonalNeedScreenReaderId { get; set; }

        public int AssessmentPersonalNeedsProfileDisplayId { get; set; }

        public int? RefAssessmentNeedUsageTypeId { get; set; }

        public int? SpeechRate { get; set; }

        public decimal? Pitch { get; set; }

        public decimal? Volume { get; set; }

        public int? RefAssessmentNeedLinkIndicationTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentPersonalNeedsProfileDisplay AssessmentPersonalNeedsProfileDisplay { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentNeedLinkIndicationType RefAssessmentNeedLinkIndicationType { get; set; }

        public virtual RefAssessmentNeedUsageType RefAssessmentNeedUsageType { get; set; }
    }
}
