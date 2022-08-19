using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentNeedApipDisplay")]
    public partial class AssessmentNeedApipDisplay
    {
        public int AssessmentNeedApipDisplayId { get; set; }

        public int AssessmentPersonalNeedsProfileDisplayId { get; set; }

        public bool? MaskingAssignedSupportIndicator { get; set; }

        public bool? MaskingActivateByDefaultIndicator { get; set; }

        public int? RefAssessmentNeedMaskingTypeId { get; set; }

        public bool? EncouragementAssignedSupportIndicator { get; set; }

        public bool? EncouragementActivateByDefaultIndicator { get; set; }

        [StringLength(4000)]
        public string EncouragementTextMessagingString { get; set; }

        [StringLength(512)]
        public string EncouragementSoundFileUrl { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentNeedMaskingType RefAssessmentNeedMaskingType { get; set; }

        public virtual AssessmentPersonalNeedsProfileDisplay AssessmentPersonalNeedsProfileDisplay { get; set; }
    }
}
