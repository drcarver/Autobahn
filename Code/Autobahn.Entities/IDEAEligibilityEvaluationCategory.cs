using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IDEAEligibilityEvaluationCategory")]
    public partial class IDEAEligibilityEvaluationCategory
    {
        public int IDEAEligibilityEvaluationCategoryId { get; set; }

        public int EligibilityEvaluationId { get; set; }

        public int RefIDEAEligibilityEvaluationCategoryId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual EligibilityEvaluation EligibilityEvaluation { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefIDEAEligibilityEvaluationCategory RefIDEAEligibilityEvaluationCategory { get; set; }
    }
}
