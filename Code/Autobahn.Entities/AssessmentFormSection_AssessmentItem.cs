using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
    public partial class AssessmentFormSection_AssessmentItem
    {
        [Key]
        public int AssessmentFormSectionItemId { get; set; }

        public int SequenceNumber { get; set; }

        public int AssessmentFormSectionId { get; set; }

        public int AssessmentItemId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentFormSection AssessmentFormSection { get; set; }

        public virtual AssessmentItem AssessmentItem { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
