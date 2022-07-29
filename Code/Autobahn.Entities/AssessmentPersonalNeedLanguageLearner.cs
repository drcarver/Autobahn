using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentPersonalNeedLanguageLearner")]
    public partial class AssessmentPersonalNeedLanguageLearner
    {
        public int AssessmentPersonalNeedLanguageLearnerId { get; set; }

        public int AssessmentNeedsProfileContentId { get; set; }

        public bool? AssignedSupport { get; set; }

        public bool? ActivateByDefault { get; set; }

        public int RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentPersonalNeedsProfileContent AssessmentPersonalNeedsProfileContent { get; set; }

        public virtual RefAssessmentNeedLanguageLearnerType RefAssessmentNeedLanguageLearnerType { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
