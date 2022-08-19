using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentParticipantSession")]
    public partial class AssessmentParticipantSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentParticipantSession()
        {
            AssessmentItemResponses = new HashSet<AssessmentItemResponse>();
            AssessmentSessionStaffRoles = new HashSet<AssessmentSessionStaffRole>();
            AssessmentParticipantSessionAccommodation = new HashSet<AssessmentParticipantSessionAccommodation>();
        }

        public int AssessmentParticipantSessionId { get; set; }

        public DateTime? ActualStartDateTime { get; set; }

        public DateTime? ActualEndDateTime { get; set; }

        [StringLength(30)]
        public string TimeAssessed { get; set; }

        public int? RefAssessmentPlatformTypeId { get; set; }

        [StringLength(300)]
        public string DeliveryDeviceDetails { get; set; }

        [StringLength(300)]
        public string SecurityIssue { get; set; }

        public int? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        [StringLength(60)]
        public string SpecialEventDescription { get; set; }

        public int? LocationId { get; set; }

        public int? RefLanguageId { get; set; }

        public int? AssessmentFormSectionId { get; set; }

        public int AssessmentSessionId { get; set; }

        public int? AssessmentRegistrationId { get; set; }

        [StringLength(300)]
        public string AssessmentParticipantSessionDatabaseName { get; set; }

        [StringLength(40)]
        public string AssessmentParticipantSessionGUID { get; set; }

        [StringLength(512)]
        public string PlatformUserAgent { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual AssessmentFormSection AssessmentFormSection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentItemResponse> AssessmentItemResponses { get; set; }

        public virtual AssessmentRegistration AssessmentRegistration { get; set; }

        public virtual AssessmentSession AssessmentSession { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Location Location { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSessionStaffRole> AssessmentSessionStaffRoles { get; set; }

        public virtual RefAssessmentPlatformType RefAssessmentPlatformType { get; set; }

        public virtual RefAssessmentSessionSpecialCircumstanceType RefAssessmentSessionSpecialCircumstanceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentParticipantSessionAccommodation> AssessmentParticipantSessionAccommodation { get; set; }
    }
}
