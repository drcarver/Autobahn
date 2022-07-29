using System;

namespace Autobahn.Entities
{
    public partial class AssessmentForm_AssessmentFormSection
    {
        public int AssessmentForm_AssessmentFormSectionId { get; set; }

        public int AssessmentFormId { get; set; }

        public int AssessmentFormSectionId { get; set; }

        public int? SequenceNumber { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentForm AssessmentForm { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual AssessmentFormSection AssessmentFormSection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
