using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("AssessmentParticipantSession")]
    public partial class AssessmentParticipantSession
    {
        public AssessmentParticipantSession()
        {
            AssessmentItemResponses = new HashSet<AssessmentItemResponse>();
            AssessmentParticipantSessionAccommodations = new HashSet<AssessmentParticipantSessionAccommodation>();
            AssessmentSessionStaffRoles = new HashSet<AssessmentSessionStaffRole>();
        }

        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int AssessmentParticipantSessionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ActualStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ActualEndDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? TimeAssessed { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentPlatformTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? DeliveryDeviceDetails { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? SecurityIssue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? SpecialEventDescription { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? LocationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLanguageId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentFormSection
        /// </summary>
        public int? AssessmentFormSectionId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentSession
        /// </summary>
        public int AssessmentSessionId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentRegistration
        /// </summary>
        public int? AssessmentRegistrationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? AssessmentParticipantSessionDatabaseName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("AssessmentParticipantSessionGUID")]
        [StringLength(40)]
        public string? AssessmentParticipantSessionGuid { get; set; }
        [StringLength(512)]
        public string? PlatformUserAgent { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("AssessmentFormSectionId")]
        [InverseProperty("AssessmentParticipantSessions")]
        public virtual AssessmentFormSection? AssessmentFormSection { get; set; }
        [ForeignKey("AssessmentRegistrationId")]
        [InverseProperty("AssessmentParticipantSessions")]
        public virtual AssessmentRegistration? AssessmentRegistration { get; set; }
        [ForeignKey("AssessmentSessionId")]
        [InverseProperty("AssessmentParticipantSessions")]
        public virtual AssessmentSession AssessmentSession { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentParticipantSessions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LocationId")]
        [InverseProperty("AssessmentParticipantSessions")]
        public virtual Location? Location { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentParticipantSessions")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentPlatformTypeId")]
        [InverseProperty("AssessmentParticipantSessions")]
        public virtual RefAssessmentPlatformType? RefAssessmentPlatformType { get; set; }
        [ForeignKey("RefAssessmentSessionSpecialCircumstanceTypeId")]
        [InverseProperty("AssessmentParticipantSessions")]
        public virtual RefAssessmentSessionSpecialCircumstanceType? RefAssessmentSessionSpecialCircumstanceType { get; set; }
        [ForeignKey("RefLanguageId")]
        [InverseProperty("AssessmentParticipantSessions")]
        public virtual RefLanguage? RefLanguage { get; set; }
        [InverseProperty("AssessmentParticipantSession")]
        public virtual ICollection<AssessmentItemResponse> AssessmentItemResponses { get; set; }
        [InverseProperty("AssessmentParticipantSession")]
        public virtual ICollection<AssessmentParticipantSessionAccommodation> AssessmentParticipantSessionAccommodations { get; set; }
        [InverseProperty("AssessmentParticipantSession")]
        public virtual ICollection<AssessmentSessionStaffRole> AssessmentSessionStaffRoles { get; set; }
    }
}
