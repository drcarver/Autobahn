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
    [Table("StaffProfessionalDevelopmentActivity")]
    public partial class StaffProfessionalDevelopmentActivity
    {
        public StaffProfessionalDevelopmentActivity()
        {
            CoreKnowledgeAreas = new HashSet<CoreKnowledgeArea>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int StaffProfessionalDevelopmentActivityId { get; set; }
        /// <summary>
        /// Foreign key - ProfessionaDevelopment.
        /// </summary>
        public int ProfessionalDevelopmentRequirementId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? ActivityTitle { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? ActivityIdentifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ActivityStartDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ActivityCompletionDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ScholarshipStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProfessionalDevelopmentFinancialSupportId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? NumberOfCreditsEarned { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseCreditUnitId { get; set; }
        public int ProfessionalDevelopmentActivityId { get; set; }
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// Foreign key - Professional Development Session
        /// </summary>
        public int ProfessionalDevelopmentSessionId { get; set; }
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
        [InverseProperty("StaffProfessionalDevelopmentActivities")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("StaffProfessionalDevelopmentActivities")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("ProfessionalDevelopmentActivityId")]
        [InverseProperty("StaffProfessionalDevelopmentActivities")]
        public virtual ProfessionalDevelopmentActivity ProfessionalDevelopmentActivity { get; set; } = null!;
        [ForeignKey("ProfessionalDevelopmentRequirementId")]
        [InverseProperty("StaffProfessionalDevelopmentActivities")]
        public virtual ProfessionalDevelopmentRequirement ProfessionalDevelopmentRequirement { get; set; } = null!;
        [ForeignKey("ProfessionalDevelopmentSessionId")]
        [InverseProperty("StaffProfessionalDevelopmentActivities")]
        public virtual ProfessionalDevelopmentSession ProfessionalDevelopmentSession { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("StaffProfessionalDevelopmentActivities")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCourseCreditUnitId")]
        [InverseProperty("StaffProfessionalDevelopmentActivities")]
        public virtual RefCourseCreditUnit? RefCourseCreditUnit { get; set; }
        [ForeignKey("RefProfessionalDevelopmentFinancialSupportId")]
        [InverseProperty("StaffProfessionalDevelopmentActivities")]
        public virtual RefProfessionalDevelopmentFinancialSupport? RefProfessionalDevelopmentFinancialSupport { get; set; }
        [InverseProperty("ProfessionalDevelopmentActivity")]
        public virtual ICollection<CoreKnowledgeArea> CoreKnowledgeAreas { get; set; }
    }
}
