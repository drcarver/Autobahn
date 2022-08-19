using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentParticipantSessionAccommodation")]
    public partial class AssessmentParticipantSessionAccommodation
    {
        public int AssessmentParticipantSessionAccommodationId { get; set; }

        public int AssessmentParticipantSessionId { get; set; }

        public int AssessmentAccommodationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual AssessmentAccommodation AssessmentAccommodation { get; set; }

        public virtual AssessmentParticipantSession AssessmentParticipantSession { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
