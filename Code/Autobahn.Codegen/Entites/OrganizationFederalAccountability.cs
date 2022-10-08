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
    [Table("OrganizationFederalAccountability", Schema = "K12")]
    public partial class OrganizationFederalAccountability
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int OrganizationFederalAccountabilityId { get; set; }
        /// <summary>
        /// Surrogate key from Organization.
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? AlternateAypApproachIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? AypAppealChangedDesignation { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? AypAppealProcessDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? AypAppealProcessDesignation { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? AmaoAypProgressAttainmentLepStudents { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? AmaoProficiencyAttainmentLepStudents { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? AmaoProgressAttainmentLepStudents { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? PersistentlyDangerousStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(80)]
        public string? AccountabilityReportTitle { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAypStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefGunFreeSchoolsActReportingStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefHighSchoolGraduationRateIndicatorId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefParticipationStatusMathId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefParticipationStatusRlaId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProficiencyTargetStatusMathId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProficiencyTargetStatusRLAId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefReconstitutedStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefElementaryMiddleAdditionalId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCteGraduationRateInclusionId { get; set; }
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
        public int? RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefComprehensiveSupportAndImprovementStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTargetedSupportAndImprovementStatusId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("AmaoAypProgressAttainmentLepStudents")]
        [InverseProperty("OrganizationFederalAccountabilityAmaoAypProgressAttainmentLepStudentsNavigations")]
        public virtual RefAmaoAttainmentStatus? AmaoAypProgressAttainmentLepStudentsNavigation { get; set; }
        [ForeignKey("AmaoProficiencyAttainmentLepStudents")]
        [InverseProperty("OrganizationFederalAccountabilityAmaoProficiencyAttainmentLepStudentsNavigations")]
        public virtual RefAmaoAttainmentStatus? AmaoProficiencyAttainmentLepStudentsNavigation { get; set; }
        [ForeignKey("AmaoProgressAttainmentLepStudents")]
        [InverseProperty("OrganizationFederalAccountabilityAmaoProgressAttainmentLepStudentsNavigations")]
        public virtual RefAmaoAttainmentStatus? AmaoProgressAttainmentLepStudentsNavigation { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("OrganizationFederalAccountabilities")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("OrganizationFederalAccountabilities")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("OrganizationFederalAccountabilities")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAdditionalTargetedSupportAndImprovementStatusId")]
        [InverseProperty("OrganizationFederalAccountabilities")]
        public virtual RefAdditionalTargetedSupportAndImprovementStatus? RefAdditionalTargetedSupportAndImprovementStatus { get; set; }
        [ForeignKey("RefAypStatusId")]
        [InverseProperty("OrganizationFederalAccountabilities")]
        public virtual RefAypStatus? RefAypStatus { get; set; }
        [ForeignKey("RefComprehensiveSupportAndImprovementStatusId")]
        [InverseProperty("OrganizationFederalAccountabilities")]
        public virtual RefComprehensiveSupportAndImprovementStatus? RefComprehensiveSupportAndImprovementStatus { get; set; }
        [ForeignKey("RefCteGraduationRateInclusionId")]
        [InverseProperty("OrganizationFederalAccountabilities")]
        public virtual RefCteGraduationRateInclusion? RefCteGraduationRateInclusion { get; set; }
        [ForeignKey("RefElementaryMiddleAdditionalId")]
        [InverseProperty("OrganizationFederalAccountabilities")]
        public virtual RefElementaryMiddleAdditional? RefElementaryMiddleAdditional { get; set; }
        [ForeignKey("RefGunFreeSchoolsActReportingStatusId")]
        [InverseProperty("OrganizationFederalAccountabilities")]
        public virtual RefGunFreeSchoolsActReportingStatus? RefGunFreeSchoolsActReportingStatus { get; set; }
        [ForeignKey("RefHighSchoolGraduationRateIndicatorId")]
        [InverseProperty("OrganizationFederalAccountabilities")]
        public virtual RefHighSchoolGraduationRateIndicator? RefHighSchoolGraduationRateIndicator { get; set; }
        [ForeignKey("RefParticipationStatusMathId")]
        [InverseProperty("OrganizationFederalAccountabilityRefParticipationStatusMaths")]
        public virtual RefParticipationStatusAyp? RefParticipationStatusMath { get; set; }
        [ForeignKey("RefParticipationStatusRlaId")]
        [InverseProperty("OrganizationFederalAccountabilityRefParticipationStatusRlas")]
        public virtual RefParticipationStatusAyp? RefParticipationStatusRla { get; set; }
        [ForeignKey("RefProficiencyTargetStatusMathId")]
        [InverseProperty("OrganizationFederalAccountabilityRefProficiencyTargetStatusMaths")]
        public virtual RefProficiencyTargetAyp? RefProficiencyTargetStatusMath { get; set; }
        [ForeignKey("RefProficiencyTargetStatusRlaid")]
        [InverseProperty("OrganizationFederalAccountabilityRefProficiencyTargetStatusRlas")]
        public virtual RefProficiencyTargetAyp? RefProficiencyTargetStatusRla { get; set; }
        [ForeignKey("RefReconstitutedStatusId")]
        [InverseProperty("OrganizationFederalAccountabilities")]
        public virtual RefReconstitutedStatus? RefReconstitutedStatus { get; set; }
        [ForeignKey("RefTargetedSupportAndImprovementStatusId")]
        [InverseProperty("OrganizationFederalAccountabilities")]
        public virtual RefTargetedSupportAndImprovementStatus? RefTargetedSupportAndImprovementStatus { get; set; }
    }
}
