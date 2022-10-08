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
    [Table("AssessmentAdministration", Schema = "Assessment")]
    public partial class AssessmentAdministration
    {
        public AssessmentAdministration()
        {
            AssessmentAdministrationOrganizations = new HashSet<AssessmentAdministrationOrganization>();
            AssessmentAssessmentAdministrations = new HashSet<AssessmentAssessmentAdministration>();
            AssessmentRegistrations = new HashSet<AssessmentRegistration>();
            AssessmentSessions = new HashSet<AssessmentSession>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentAdministrationId { get; set; }
        /// <summary>
        /// Foreign key - Assessment
        /// </summary>
        public int? AssessmentId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Name { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Code { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? StartTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? FinishDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? FinishTime { get; set; }
        /// <summary>
        /// Foreign key - RefAssessmentReportingMethod
        /// </summary>
        public int? RefAssessmentReportingMethodId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? AssessmentSecureIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? AssessmentAdministrationPeriodDescription { get; set; }
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

        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentAdministrations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentAdministrations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentReportingMethodId")]
        [InverseProperty("AssessmentAdministrations")]
        public virtual RefAssessmentReportingMethod? RefAssessmentReportingMethod { get; set; }
        [InverseProperty("AssessmentAdministration")]
        public virtual ICollection<AssessmentAdministrationOrganization> AssessmentAdministrationOrganizations { get; set; }
        [InverseProperty("AssessmentAdministration")]
        public virtual ICollection<AssessmentAssessmentAdministration> AssessmentAssessmentAdministrations { get; set; }
        [InverseProperty("AssessmentAdministration")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrations { get; set; }
        [InverseProperty("AssessmentAdministration")]
        public virtual ICollection<AssessmentSession> AssessmentSessions { get; set; }
    }
}
