using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentAssessmentAdministration")]
    public partial class AssessmentAssessmentAdministration
    {
        public int AssessmentAssessmentAdministrationId { get; set; }

        public int AssessmentId { get; set; }

        public int AssessmentAdministrationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual Assessment Assessment { get; set; }

        public virtual AssessmentAdministration AssessmentAdministration { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
