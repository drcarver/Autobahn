using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentSessionStaffRole")]
    public partial class AssessmentSessionStaffRole
    {
        public int AssessmentSessionStaffRoleId { get; set; }

        public int? RefAssessmentSessionStaffRoleTypeId { get; set; }

        public int PersonId { get; set; }

        public int? AssessmentSessionId { get; set; }

        public int? AssessmentParticipantSessionId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentParticipantSession AssessmentParticipantSession { get; set; }

        public virtual AssessmentSession AssessmentSession { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentSessionStaffRoleType RefAssessmentSessionStaffRoleType { get; set; }
    }
}
