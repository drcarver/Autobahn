using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentSubtestLevelsForWhichDesigned")]
    public partial class AssessmentSubtestLevelsForWhichDesigned
    {
        public int AssessmentSubtestLevelsForWhichDesignedId { get; set; }

        public int AssessmentSubTestId { get; set; }

        public int RefGradeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentSubtest AssessmentSubtest { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefGradeLevel RefGradeLevel { get; set; }
    }
}
