using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
    public partial class AssessmentSubtest_AssessmentItem
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

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentItem AssessmentItem { get; set; }

        public virtual AssessmentSubtest AssessmentSubtest { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
