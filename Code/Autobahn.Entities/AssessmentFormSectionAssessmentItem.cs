using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentFormSectionAssessmentItem")]
    public partial class AssessmentFormSectionAssessmentItem
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
