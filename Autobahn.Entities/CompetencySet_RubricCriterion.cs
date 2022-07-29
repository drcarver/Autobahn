using System;

namespace Autobahn.Entities
{
    public partial class CompetencySet_RubricCriterion
    {
        public int CompetencySet_RubricCriterionId { get; set; }

        public int CompetencySetId { get; set; }

        public int RubricCriterionId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual CompetencySet CompetencySet { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RubricCriterion RubricCriterion { get; set; }
    }
}
