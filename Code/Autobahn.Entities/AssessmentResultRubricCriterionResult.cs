using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentResultRubricCriterionResult")]
    public partial class AssessmentResultRubricCriterionResult
    {
        public int AssessmentResultRubricCriterionResultId { get; set; }

        public int AssessmentResultId { get; set; }

        public int RubricCriterionLevelId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual AssessmentResult AssessmentResult { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RubricCriterionLevel RubricCriterionLevel { get; set; }
    }
}
