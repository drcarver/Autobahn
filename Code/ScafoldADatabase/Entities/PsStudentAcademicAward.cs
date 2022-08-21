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
    [Table("PsStudentAcademicAward")]
    public partial class PsStudentAcademicAward
    {
        /// <summary>
        /// Surrogate key.
        /// </summary>
        [Key]
        public int PsStudentAcademicAwardId { get; set; }
        /// <summary>
        /// Foreign key - OrganizationPersonRole.
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(14)]
        public string? AcademicAwardDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAcademicAwardLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(80)]
        public string? AcademicAwardTitle { get; set; }
        [Column("RequirementsURL")]
        [StringLength(512)]
        public string? RequirementsUrl { get; set; }
        public int? RefAcademicAwardPrerequisiteTypeId { get; set; }
        [Column("RefPESCAwardLevelTypeId")]
        public int? RefPescawardLevelTypeId { get; set; }
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
        [InverseProperty("PsStudentAcademicAwards")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("PsStudentAcademicAwards")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PsStudentAcademicAwards")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAcademicAwardLevelId")]
        [InverseProperty("PsStudentAcademicAwards")]
        public virtual RefAcademicAwardLevel? RefAcademicAwardLevel { get; set; }
        [ForeignKey("RefAcademicAwardPrerequisiteTypeId")]
        [InverseProperty("PsStudentAcademicAwards")]
        public virtual RefAcademicAwardPrerequisiteType? RefAcademicAwardPrerequisiteType { get; set; }
        [ForeignKey("RefPescawardLevelTypeId")]
        [InverseProperty("PsStudentAcademicAwards")]
        public virtual RefPescawardLevelType? RefPescawardLevelType { get; set; }
    }
}
