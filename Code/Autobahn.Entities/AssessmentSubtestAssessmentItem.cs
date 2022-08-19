using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentSubtestAssessmentItem")]
    public partial class AssessmentSubtestAssessmentItem
    {
        [Key]
        public int AssessmentSubtestItemId { get; set; }

        public int AssessmentSubtestId { get; set; }

        public int AssessmentItemId { get; set; }

        public decimal? ItemWeightCorrect { get; set; }

        public decimal? ItemWeightIncorrect { get; set; }

        public decimal? ItemWeightNotAttempted { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual AssessmentItem AssessmentItem { get; set; }

        public virtual AssessmentSubtest AssessmentSubtest { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
