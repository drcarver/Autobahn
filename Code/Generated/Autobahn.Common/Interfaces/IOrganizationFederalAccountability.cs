//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationFederalAccountability.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationFederalAccountability
     /// </summary>
    public partial interface IOrganizationFederalAccountability
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AlternateAypApproachIndicator nullable property
        /// </summary>
        System.Boolean? AlternateAypApproachIndicator { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AypAppealChangedDesignation nullable property
        /// </summary>
        System.Boolean? AypAppealChangedDesignation { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AypAppealProcessDate nullable property
        /// </summary>
        System.DateTime? AypAppealProcessDate { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AypAppealProcessDesignation nullable property
        /// </summary>
        System.Boolean? AypAppealProcessDesignation { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AmaoAypProgressAttainmentLepStudents nullable property
        /// </summary>
        System.Int32? AmaoAypProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AmaoProficiencyAttainmentLepStudents nullable property
        /// </summary>
        System.Int32? AmaoProficiencyAttainmentLepStudents { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AmaoProgressAttainmentLepStudents nullable property
        /// </summary>
        System.Int32? AmaoProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.PersistentlyDangerousStatus nullable property
        /// </summary>
        System.Boolean? PersistentlyDangerousStatus { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AccountabilityReportTitle non nullable property
        /// </summary>
        System.String AccountabilityReportTitle { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAypStatus"/> model
        /// </summary>
        Guid? RefAypStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGunFreeSchoolsActReportingStatus"/> model
        /// </summary>
        Guid? RefGunFreeSchoolsActReportingStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolGraduationRateIndicator"/> model
        /// </summary>
        Guid? RefHighSchoolGraduationRateIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationStatusMath"/> model
        /// </summary>
        Guid? RefParticipationStatusMathId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationStatusRla"/> model
        /// </summary>
        Guid? RefParticipationStatusRlaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyTargetStatusMath"/> model
        /// </summary>
        Guid? RefProficiencyTargetStatusMathId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyTargetStatusRLA"/> model
        /// </summary>
        Guid? RefProficiencyTargetStatusRLAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReconstitutedStatus"/> model
        /// </summary>
        Guid? RefReconstitutedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefElementaryMiddleAdditional"/> model
        /// </summary>
        Guid? RefElementaryMiddleAdditionalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCteGraduationRateInclusion"/> model
        /// </summary>
        Guid? RefCteGraduationRateInclusionId { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        Guid? RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveSupportAndImprovementStatus"/> model
        /// </summary>
        Guid? RefComprehensiveSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        Guid? RefTargetedSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
