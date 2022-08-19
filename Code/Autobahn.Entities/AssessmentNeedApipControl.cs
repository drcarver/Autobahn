using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentNeedApipControl")]
    public partial class AssessmentNeedApipControl
    {
        public int AssessmentNeedApipControlId { get; set; }

        public int AssessmentPersonalNeedsProfileControlId { get; set; }

        [StringLength(9)]
        public string AssessmentNeedTimeMultiplier { get; set; }

        [StringLength(6)]
        public string LineReaderHighlightColor { get; set; }

        [StringLength(6)]
        public string OverlayColor { get; set; }

        [StringLength(6)]
        public string BackgroundColor { get; set; }

        public int? RefAssessmentNeedIncreasedWhitespacingTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual AssessmentPersonalNeedsProfileControl AssessmentPersonalNeedsProfileControl { get; set; }

        public virtual RefAssessmentNeedIncreasedWhitespacingType RefAssessmentNeedIncreasedWhitespacingType { get; set; }
    }
}
