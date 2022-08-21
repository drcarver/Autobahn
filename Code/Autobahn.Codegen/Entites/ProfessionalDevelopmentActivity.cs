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
    [Table("ProfessionalDevelopmentActivity")]
    public partial class ProfessionalDevelopmentActivity
    {
        public ProfessionalDevelopmentActivity()
        {
            PdactivityEducationLevels = new HashSet<PdactivityEducationLevel>();
            ProfessionalDevelopmentSessions = new HashSet<ProfessionalDevelopmentSession>();
            StaffProfessionalDevelopmentActivities = new HashSet<StaffProfessionalDevelopmentActivity>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int ProfessionalDevelopmentActivityId { get; set; }
        /// <summary>
        /// Foreign key - ProfessionaDevelopmentRequirement.
        /// </summary>
        public int ProfessionalDevelopmentRequirementId { get; set; }
        /// <summary>
        /// Foreign key - Course.
        /// </summary>
        public int? CourseId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? Title { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? ActivityIdentifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(2000)]
        public string? Description { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(2000)]
        public string? Objective { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? ActivityCode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? ApprovalCode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? Cost { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? Credits { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ScholarshipStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? PublishIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ProfessionalDevelopmentActivityStateApprovedStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseCreditUnitId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProfessionalDevelopmentFinancialSupportId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefPDAudienceTypeId")]
        public int? RefPdaudienceTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefPDActivityApprovedPurposeId")]
        public int? RefPdactivityApprovedPurposeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefPDActivityCreditTypeId")]
        public int? RefPdactivityCreditTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefPDActivityLevelId")]
        public int? RefPdactivityLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefPDActivityTypeId")]
        public int? RefPdactivityTypeId { get; set; }
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

        [ForeignKey("CourseId")]
        [InverseProperty("ProfessionalDevelopmentActivities")]
        public virtual Course? Course { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("ProfessionalDevelopmentActivities")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("ProfessionalDevelopmentRequirementId")]
        [InverseProperty("ProfessionalDevelopmentActivities")]
        public virtual ProfessionalDevelopmentRequirement ProfessionalDevelopmentRequirement { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProfessionalDevelopmentActivities")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCourseCreditUnitId")]
        [InverseProperty("ProfessionalDevelopmentActivities")]
        public virtual RefCourseCreditUnit? RefCourseCreditUnit { get; set; }
        [ForeignKey("RefPdactivityApprovedPurposeId")]
        [InverseProperty("ProfessionalDevelopmentActivities")]
        public virtual RefPdactivityApprovedPurpose? RefPdactivityApprovedPurpose { get; set; }
        [ForeignKey("RefPdactivityCreditTypeId")]
        [InverseProperty("ProfessionalDevelopmentActivities")]
        public virtual RefPdactivityCreditType? RefPdactivityCreditType { get; set; }
        [ForeignKey("RefPdactivityLevelId")]
        [InverseProperty("ProfessionalDevelopmentActivities")]
        public virtual RefPdactivityLevel? RefPdactivityLevel { get; set; }
        [ForeignKey("RefPdactivityTypeId")]
        [InverseProperty("ProfessionalDevelopmentActivities")]
        public virtual RefPdactivityType? RefPdactivityType { get; set; }
        [ForeignKey("RefPdaudienceTypeId")]
        [InverseProperty("ProfessionalDevelopmentActivities")]
        public virtual RefPdaudienceType? RefPdaudienceType { get; set; }
        [ForeignKey("RefProfessionalDevelopmentFinancialSupportId")]
        [InverseProperty("ProfessionalDevelopmentActivities")]
        public virtual RefProfessionalDevelopmentFinancialSupport? RefProfessionalDevelopmentFinancialSupport { get; set; }
        [InverseProperty("ProfessionalDevelopmentActivity")]
        public virtual ICollection<PdactivityEducationLevel> PdactivityEducationLevels { get; set; }
        [InverseProperty("ProfessionalDevelopmentActivity")]
        public virtual ICollection<ProfessionalDevelopmentSession> ProfessionalDevelopmentSessions { get; set; }
        [InverseProperty("ProfessionalDevelopmentActivity")]
        public virtual ICollection<StaffProfessionalDevelopmentActivity> StaffProfessionalDevelopmentActivities { get; set; }
    }
}
