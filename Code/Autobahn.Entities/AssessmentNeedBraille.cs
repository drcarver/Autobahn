using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentNeedBraille")]
    public partial class AssessmentNeedBraille
    {
        public int AssessmentNeedBrailleId { get; set; }

        public int? AssessmentPersonalNeedsProfileDisplayId { get; set; }

        public int? RefAssessmentNeedUsageTypeId { get; set; }

        public int? RefAssessmentNeedBrailleGradeTypeId { get; set; }

        public int? RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

        public int? NumberOfBrailleCells { get; set; }

        public int? RefAssessmentNeedBrailleMarkTypeId { get; set; }

        public decimal? BrailleDotPressure { get; set; }

        public int? RefAssessmentNeedBrailleStatusCellTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual RefAssessmentNeedBrailleGradeType RefAssessmentNeedBrailleGradeType { get; set; }

        public virtual AssessmentPersonalNeedsProfileDisplay AssessmentPersonalNeedsProfileDisplay { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentNeedBrailleMarkType RefAssessmentNeedBrailleMarkType { get; set; }

        public virtual RefAssessmentNeedBrailleStatusCellType RefAssessmentNeedBrailleStatusCellType { get; set; }

        public virtual RefAssessmentNeedNumberOfBrailleDot RefAssessmentNeedNumberOfBrailleDot { get; set; }

        public virtual RefAssessmentNeedUsageType RefAssessmentNeedUsageType { get; set; }
    }
}
