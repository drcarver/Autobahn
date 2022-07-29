using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentItemResponseTheory")]
    public partial class AssessmentItemResponseTheory
    {
        public int AssessmentItemResponseTheoryId { get; set; }

        public int AssessmentItemId { get; set; }

        public int? ParameterA { get; set; }

        public int? ParameterB { get; set; }

        public int? ParameterC { get; set; }

        public int? ParameterD1 { get; set; }

        public int? ParameterD2 { get; set; }

        public int? ParameterD3 { get; set; }

        public int? ParameterD4 { get; set; }

        public int? ParameterD5 { get; set; }

        public int? ParameterD6 { get; set; }

        public int? PointBiserialCorrelationValue { get; set; }

        public int? DIFValue { get; set; }

        public int? KappaValue { get; set; }

        public int? RefItemResponseTheoryDifficultyCategoryId { get; set; }

        public int? RefItemResponseTheoryKappaAlgorithmId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentItem AssessmentItem { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefItemResponseTheoryDifficultyCategory RefItemResponseTheoryDifficultyCategory { get; set; }

        public virtual RefItemResponseTheoryKappaAlgorithm RefItemResponseTheoryKappaAlgorithm { get; set; }
    }
}
