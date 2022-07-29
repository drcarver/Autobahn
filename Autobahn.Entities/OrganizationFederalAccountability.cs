using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationFederalAccountability")]
    public partial class OrganizationFederalAccountability
    {
        public int OrganizationFederalAccountabilityId { get; set; }

        public int OrganizationId { get; set; }

        public bool? AlternateAypApproachIndicator { get; set; }

        public bool? AypAppealChangedDesignation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AypAppealProcessDate { get; set; }

        public bool? AypAppealProcessDesignation { get; set; }

        public int? AmaoAypProgressAttainmentLepStudents { get; set; }

        public int? AmaoProficiencyAttainmentLepStudents { get; set; }

        public int? AmaoProgressAttainmentLepStudents { get; set; }

        public bool? PersistentlyDangerousStatus { get; set; }

        [StringLength(80)]
        public string AccountabilityReportTitle { get; set; }

        public int? RefAypStatusId { get; set; }

        public int? RefGunFreeSchoolsActReportingStatusId { get; set; }

        public int? RefHighSchoolGraduationRateIndicatorId { get; set; }

        public int? RefParticipationStatusMathId { get; set; }

        public int? RefParticipationStatusRlaId { get; set; }

        public int? RefProficiencyTargetStatusMathId { get; set; }

        public int? RefProficiencyTargetStatusRLAId { get; set; }

        public int? RefReconstitutedStatusId { get; set; }

        public int? RefElementaryMiddleAdditionalId { get; set; }

        public int? RefCteGraduationRateInclusionId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }

        public int? RefComprehensiveSupportAndImprovementStatusId { get; set; }

        public int? RefTargetedSupportAndImprovementStatusId { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RefAmaoAttainmentStatu RefAmaoAttainmentStatu { get; set; }

        public virtual RefAmaoAttainmentStatu RefAmaoAttainmentStatu1 { get; set; }

        public virtual RefAmaoAttainmentStatu RefAmaoAttainmentStatu2 { get; set; }

        public virtual RefCteGraduationRateInclusion RefCteGraduationRateInclusion { get; set; }

        public virtual RefElementaryMiddleAdditional RefElementaryMiddleAdditional { get; set; }

        public virtual RefHighSchoolGraduationRateIndicator RefHighSchoolGraduationRateIndicator { get; set; }

        public virtual RefAypStatu RefAypStatu { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAdditionalTargetedSupportAndImprovementStatu RefAdditionalTargetedSupportAndImprovementStatu { get; set; }

        public virtual RefComprehensiveSupportAndImprovementStatu RefComprehensiveSupportAndImprovementStatu { get; set; }

        public virtual RefGunFreeSchoolsActReportingStatu RefGunFreeSchoolsActReportingStatu { get; set; }

        public virtual RefParticipationStatusAyp RefParticipationStatusAyp { get; set; }

        public virtual RefParticipationStatusAyp RefParticipationStatusAyp1 { get; set; }

        public virtual RefProficiencyTargetAyp RefProficiencyTargetAyp { get; set; }

        public virtual RefProficiencyTargetAyp RefProficiencyTargetAyp1 { get; set; }

        public virtual RefReconstitutedStatu RefReconstitutedStatu { get; set; }

        public virtual RefTargetedSupportAndImprovementStatu RefTargetedSupportAndImprovementStatu { get; set; }
    }
}
