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
    [Table("K12StudentAcademicRecord")]
    public partial class K12studentAcademicRecord
    {
        [Key]
        [Column("K12StudentAcademicRecordId")]
        public int K12studentAcademicRecordId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? CreditsAttemptedCumulative { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? CreditsEarnedCumulative { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? GradePointsEarnedCumulative { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 4)")]
        public decimal? GradePointAverageCumulative { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ProjectedGraduationDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? HighSchoolStudentClassRank { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ClassRankingDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? TotalNumberInClass { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DiplomaOrCredentialAwardDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefGpaWeightedIndicatorId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefHighSchoolDiplomaTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefHighSchoolDiplomaDistinctionTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTechnologyLiteracyStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPsEnrollmentActionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPreAndPostTestIndicatorId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProfessionalTechnicalCredentialTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProgressLevelId { get; set; }
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
        [InverseProperty("K12studentAcademicRecords")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("K12studentAcademicRecords")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12studentAcademicRecords")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefGpaWeightedIndicatorId")]
        [InverseProperty("K12studentAcademicRecords")]
        public virtual RefGpaWeightedIndicator? RefGpaWeightedIndicator { get; set; }
        [ForeignKey("RefHighSchoolDiplomaDistinctionTypeId")]
        [InverseProperty("K12studentAcademicRecords")]
        public virtual RefHighSchoolDiplomaDistinctionType? RefHighSchoolDiplomaDistinctionType { get; set; }
        [ForeignKey("RefHighSchoolDiplomaTypeId")]
        [InverseProperty("K12studentAcademicRecords")]
        public virtual RefHighSchoolDiplomaType? RefHighSchoolDiplomaType { get; set; }
        [ForeignKey("RefPreAndPostTestIndicatorId")]
        [InverseProperty("K12studentAcademicRecords")]
        public virtual RefPreAndPostTestIndicator? RefPreAndPostTestIndicator { get; set; }
        [ForeignKey("RefProfessionalTechnicalCredentialTypeId")]
        [InverseProperty("K12studentAcademicRecords")]
        public virtual RefProfessionalTechnicalCredentialType? RefProfessionalTechnicalCredentialType { get; set; }
        [ForeignKey("RefProgressLevelId")]
        [InverseProperty("K12studentAcademicRecords")]
        public virtual RefProgressLevel? RefProgressLevel { get; set; }
        [ForeignKey("RefPsEnrollmentActionId")]
        [InverseProperty("K12studentAcademicRecords")]
        public virtual RefPsEnrollmentAction? RefPsEnrollmentAction { get; set; }
        [ForeignKey("RefTechnologyLiteracyStatusId")]
        [InverseProperty("K12studentAcademicRecords")]
        public virtual RefTechnologyLiteracyStatus? RefTechnologyLiteracyStatus { get; set; }
    }
}
