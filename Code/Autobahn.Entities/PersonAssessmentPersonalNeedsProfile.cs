using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonAssessmentPersonalNeedsProfile")]
    public partial class PersonAssessmentPersonalNeedsProfile
    {
        public int PersonAssessmentPersonalNeedsProfileId { get; set; }

        public int PersonId { get; set; }

        public int AssessmentPersonalNeedsProfileId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentPersonalNeedsProfile AssessmentPersonalNeedsProfile { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
