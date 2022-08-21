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
    [Table("ProfessionalDevelopmentRequirement")]
    public partial class ProfessionalDevelopmentRequirement
    {
        public ProfessionalDevelopmentRequirement()
        {
            ProfessionalDevelopmentActivities = new HashSet<ProfessionalDevelopmentActivity>();
            StaffProfessionalDevelopmentActivities = new HashSet<StaffProfessionalDevelopmentActivity>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int ProfessionalDevelopmentRequirementId { get; set; }
        /// <summary>
        /// Foreign key - OrganizationPersonRole
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? RequiredTrainingClockHours { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int? CompetencySetId { get; set; }
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

        [ForeignKey("CompetencySetId")]
        [InverseProperty("ProfessionalDevelopmentRequirements")]
        public virtual CompetencySet? CompetencySet { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("ProfessionalDevelopmentRequirements")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("ProfessionalDevelopmentRequirements")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProfessionalDevelopmentRequirements")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("ProfessionalDevelopmentRequirement")]
        public virtual ICollection<ProfessionalDevelopmentActivity> ProfessionalDevelopmentActivities { get; set; }
        [InverseProperty("ProfessionalDevelopmentRequirement")]
        public virtual ICollection<StaffProfessionalDevelopmentActivity> StaffProfessionalDevelopmentActivities { get; set; }
    }
}
