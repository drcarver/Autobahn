using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentSubtestCompetencyDefinition")]
    public partial class AssessmentSubtestCompetencyDefinition
    {
        public int AssessmentSubtestCompetencyDefinitionId { get; set; }

        public int AssessmentSubtestId { get; set; }

        public int CompetencyDefinitionId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentSubtest AssessmentSubtest { get; set; }

        public virtual CompetencyDefinition CompetencyDefinition { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
