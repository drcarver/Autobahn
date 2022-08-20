using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationFederalAccountability", Schema = "Common")]
    public partial class OrganizationFederalAccountability
    {
        public int OrganizationFederalAccountabilityId { get; set; }

        public Guid OrganizationId { get; set; }

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

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RefAmaoAttainmentStatus RefAmaoAttainmentStatus { get; set; }

        public virtual RefAmaoAttainmentStatus RefAmaoAttainmentStatu1 { get; set; }

        public virtual RefAmaoAttainmentStatus RefAmaoAttainmentStatu2 { get; set; }

        public virtual RefCteGraduationRateInclusion RefCteGraduationRateInclusion { get; set; }

        public virtual RefElementaryMiddleAdditional RefElementaryMiddleAdditional { get; set; }

        public virtual RefHighSchoolGraduationRateIndicator RefHighSchoolGraduationRateIndicator { get; set; }

        public virtual RefAypStatus RefAypStatus { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAdditionalTargetedSupportAndImprovementStatus RefAdditionalTargetedSupportAndImprovementStatus { get; set; }

        public virtual RefComprehensiveSupportAndImprovementStatus RefComprehensiveSupportAndImprovementStatus { get; set; }

        public virtual RefGunFreeSchoolsActReportingStatus RefGunFreeSchoolsActReportingStatus { get; set; }

        public virtual RefParticipationStatusAyp RefParticipationStatusAyp { get; set; }

        public virtual RefParticipationStatusAyp RefParticipationStatusAyp1 { get; set; }

        public virtual RefProficiencyTargetAyp RefProficiencyTargetAyp { get; set; }

        public virtual RefProficiencyTargetAyp RefProficiencyTargetAyp1 { get; set; }

        public virtual RefReconstitutedStatus RefReconstitutedStatus { get; set; }

        public virtual RefTargetedSupportAndImprovementStatus RefTargetedSupportAndImprovementStatus { get; set; }
    }
}
