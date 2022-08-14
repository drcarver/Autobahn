using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IndividualizedProgramEligibilityEvaluation")]
    public partial class IndividualizedProgramEligibilityEvaluation
    {
        public int IndividualizedProgramEligibilityEvaluationId { get; set; }

        public int EligibilityEvaluationId { get; set; }

        public int IndividualizedProgramEligibilityId { get; set; }

        public int? RefIEPEligibilityEvaluationTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual EligibilityEvaluation EligibilityEvaluation { get; set; }

        public virtual IndividualizedProgramEligibility IndividualizedProgramEligibility { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefIEPEligibilityEvaluationType RefIEPEligibilityEvaluationType { get; set; }
    }
}
