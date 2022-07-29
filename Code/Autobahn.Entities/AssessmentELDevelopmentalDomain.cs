using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentELDevelopmentalDomain")]
    public partial class AssessmentELDevelopmentalDomain
    {
        public int AssessmentELDevelopmentalDomainId { get; set; }

        public int AssessmentId { get; set; }

        public int RefAssessmentELDevelopmentalDomainId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual Assessment Assessment { get; set; }

        public virtual RefAssessmentELDevelopmentalDomain RefAssessmentELDevelopmentalDomain { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
