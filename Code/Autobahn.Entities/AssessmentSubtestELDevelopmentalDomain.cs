using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentSubtestELDevelopmentalDomain")]
    public partial class AssessmentSubtestELDevelopmentalDomain
    {
        public int AssessmentSubtestELDevelopmentalDomainId { get; set; }

        public int AssessmentSubtestId { get; set; }

        public int RefAssessmentELDevelopmentalDomainId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentSubtest AssessmentSubtest { get; set; }

        public virtual RefAssessmentELDevelopmentalDomain RefAssessmentELDevelopmentalDomain { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
