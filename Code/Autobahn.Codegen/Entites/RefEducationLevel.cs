using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
    /// </summary>
    [Table("RefEducationLevel")]
    public partial class RefEducationLevel
    {
        public RefEducationLevel()
        {
            CompetencyDefEducationLevels = new HashSet<CompetencyDefEducationLevel>();
            LearningResourceEducationLevels = new HashSet<LearningResourceEducationLevel>();
            PersonDetails = new HashSet<PersonDetail>();
            PersonFamilies = new HashSet<PersonFamily>();
            PsStudentDemographicRefMaternalEducationLevels = new HashSet<PsStudentDemographic>();
            PsStudentDemographicRefPaternalEducationLevels = new HashSet<PsStudentDemographic>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefEducationLevelId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(150)]
        public string Description { get; set; } = null!;
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(50)]
        public string? Code { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(4000)]
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        public int? RefEducationLevelTypeId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefEducationLevelTypeId")]
        [InverseProperty("RefEducationLevels")]
        public virtual RefEducationLevelType? RefEducationLevelType { get; set; }
        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefEducationLevels")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefEducationLevel")]
        public virtual ICollection<CompetencyDefEducationLevel> CompetencyDefEducationLevels { get; set; }
        [InverseProperty("RefEducationLevel")]
        public virtual ICollection<LearningResourceEducationLevel> LearningResourceEducationLevels { get; set; }
        [InverseProperty("RefHighestEducationLevelCompleted")]
        public virtual ICollection<PersonDetail> PersonDetails { get; set; }
        [InverseProperty("RefHighestEducationLevelCompleted")]
        public virtual ICollection<PersonFamily> PersonFamilies { get; set; }
        [InverseProperty("RefMaternalEducationLevel")]
        public virtual ICollection<PsStudentDemographic> PsStudentDemographicRefMaternalEducationLevels { get; set; }
        [InverseProperty("RefPaternalEducationLevel")]
        public virtual ICollection<PsStudentDemographic> PsStudentDemographicRefPaternalEducationLevels { get; set; }
    }
}
