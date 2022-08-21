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
    [Table("PsStudentDemographic")]
    public partial class PsStudentDemographic
    {
        [Key]
        public int PsStudentDemographicId { get; set; }
        /// <summary>
        /// Surrogate key from OrganizationPersonRole
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? NumberOfDependents { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDependencyStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTuitionResidencyTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCampusResidencyTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPsLepTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPaternalEducationLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefMaternalEducationLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCohortExclusionId { get; set; }
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
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ChildrenOfFallenHeroesIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? EmancipatedMinor { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? FirstGenerationCollegeStudent { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefNumberOfDependentsTypeId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("PsStudentDemographics")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("PsStudentDemographics")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PsStudentDemographics")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCampusResidencyTypeId")]
        [InverseProperty("PsStudentDemographics")]
        public virtual RefCampusResidencyType? RefCampusResidencyType { get; set; }
        [ForeignKey("RefCohortExclusionId")]
        [InverseProperty("PsStudentDemographics")]
        public virtual RefCohortExclusion? RefCohortExclusion { get; set; }
        [ForeignKey("RefDependencyStatusId")]
        [InverseProperty("PsStudentDemographics")]
        public virtual RefDependencyStatus? RefDependencyStatus { get; set; }
        [ForeignKey("RefMaternalEducationLevelId")]
        [InverseProperty("PsStudentDemographicRefMaternalEducationLevels")]
        public virtual RefEducationLevel? RefMaternalEducationLevel { get; set; }
        [ForeignKey("RefNumberOfDependentsTypeId")]
        [InverseProperty("PsStudentDemographics")]
        public virtual RefNumberOfDependentsType? RefNumberOfDependentsType { get; set; }
        [ForeignKey("RefPaternalEducationLevelId")]
        [InverseProperty("PsStudentDemographicRefPaternalEducationLevels")]
        public virtual RefEducationLevel? RefPaternalEducationLevel { get; set; }
        [ForeignKey("RefPsLepTypeId")]
        [InverseProperty("PsStudentDemographics")]
        public virtual RefPsLepType? RefPsLepType { get; set; }
        [ForeignKey("RefTuitionResidencyTypeId")]
        [InverseProperty("PsStudentDemographics")]
        public virtual RefTuitionResidencyType? RefTuitionResidencyType { get; set; }
    }
}
