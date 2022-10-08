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
    [Table("AssessmentSession", Schema = "Assessment")]
    public partial class AssessmentSession
    {
        public AssessmentSession()
        {
            AssessmentParticipantSessions = new HashSet<AssessmentParticipantSession>();
            AssessmentSessionStaffRoles = new HashSet<AssessmentSessionStaffRole>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentSessionId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentAdministration.
        /// </summary>
        public int? AssessmentAdministrationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ScheduledStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ScheduledEndDateTime { get; set; }
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
        public TimeSpan? AllottedTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentSessionTypeId { get; set; }
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
        [StringLength(45)]
        public string? Location { get; set; }
        /// <summary>
        /// Foreign key - Organization
        /// </summary>
        public int? OrganizationId { get; set; }
        /// <summary>
        /// Foreign key - Organization : Local Education Agency
        /// </summary>
        public int? LEAOrganizationId { get; set; }
        /// <summary>
        /// Foreign key - Organization : School
        /// </summary>
        public int? SchoolOrganizationId { get; set; }
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

        [ForeignKey("AssessmentAdministrationId")]
        [InverseProperty("AssessmentSessions")]
        public virtual AssessmentAdministration? AssessmentAdministration { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentSessions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LeaOrganizationId")]
        [InverseProperty("AssessmentSessionLeaOrganizations")]
        public virtual Organization? LeaOrganization { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("AssessmentSessionOrganizations")]
        public virtual Organization? Organization { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentSessions")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentSessionSpecialCircumstanceTypeId")]
        [InverseProperty("AssessmentSessions")]
        public virtual RefAssessmentSessionSpecialCircumstanceType? RefAssessmentSessionSpecialCircumstanceType { get; set; }
        [ForeignKey("RefAssessmentSessionTypeId")]
        [InverseProperty("AssessmentSessions")]
        public virtual RefAssessmentSessionType? RefAssessmentSessionType { get; set; }
        [ForeignKey("SchoolOrganizationId")]
        [InverseProperty("AssessmentSessionSchoolOrganizations")]
        public virtual Organization? SchoolOrganization { get; set; }
        [InverseProperty("AssessmentSession")]
        public virtual ICollection<AssessmentParticipantSession> AssessmentParticipantSessions { get; set; }
        [InverseProperty("AssessmentSession")]
        public virtual ICollection<AssessmentSessionStaffRole> AssessmentSessionStaffRoles { get; set; }
    }
}
