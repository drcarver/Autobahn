using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentSession")]
    public partial class AssessmentSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentSession()
        {
            AssessmentParticipantSessions = new HashSet<AssessmentParticipantSession>();
            AssessmentSessionStaffRoles = new HashSet<AssessmentSessionStaffRole>();
        }

        public int AssessmentSessionId { get; set; }

        public int? AssessmentAdministrationId { get; set; }

        public DateTime? ScheduledStartDateTime { get; set; }

        public DateTime? ScheduledEndDateTime { get; set; }

        public DateTime? ActualStartDateTime { get; set; }

        public DateTime? ActualEndDateTime { get; set; }

        public TimeSpan? AllottedTime { get; set; }

        public int? RefAssessmentSessionTypeId { get; set; }

        [StringLength(300)]
        public string SecurityIssue { get; set; }

        public int? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        [StringLength(60)]
        public string SpecialEventDescription { get; set; }

        [StringLength(45)]
        public string Location { get; set; }

        public Guid? OrganizationId { get; set; }

        public int? Lea_OrganizationId { get; set; }

        public int? School_OrganizationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual AssessmentAdministration AssessmentAdministration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentParticipantSession> AssessmentParticipantSessions { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Organization Organization1 { get; set; }

        public virtual Organization Organization2 { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentSessionSpecialCircumstanceType RefAssessmentSessionSpecialCircumstanceType { get; set; }

        public virtual RefAssessmentSessionType RefAssessmentSessionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSessionStaffRole> AssessmentSessionStaffRoles { get; set; }
    }
}
