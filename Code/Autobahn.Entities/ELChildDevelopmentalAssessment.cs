using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELChildDevelopmentalAssessment")]
    public partial class ELChildDevelopmentalAssessment
    {
        public int ELChildDevelopmentalAssessmentId { get; set; }

        public int PersonId { get; set; }

        public int? RefChildDevelopmentalScreeningStatusId { get; set; }

        public int? RefDevelopmentalEvaluationFindingId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefChildDevelopmentalScreeningStatu RefChildDevelopmentalScreeningStatu { get; set; }

        public virtual RefDevelopmentalEvaluationFinding RefDevelopmentalEvaluationFinding { get; set; }
    }
}
