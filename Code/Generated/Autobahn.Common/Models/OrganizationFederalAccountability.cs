//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationFederalAccountability.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationFederalAccountability
     /// </summary>
    public partial class OrganizationFederalAccountability : IOrganizationFederalAccountability
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AlternateAypApproachIndicator nullable property
        /// </summary>
        public System.Boolean? AlternateAypApproachIndicator { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AypAppealChangedDesignation nullable property
        /// </summary>
        public System.Boolean? AypAppealChangedDesignation { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AypAppealProcessDate nullable property
        /// </summary>
        public System.DateTime? AypAppealProcessDate { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AypAppealProcessDesignation nullable property
        /// </summary>
        public System.Boolean? AypAppealProcessDesignation { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AmaoAypProgressAttainmentLepStudents nullable property
        /// </summary>
        public System.Int32? AmaoAypProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AmaoProficiencyAttainmentLepStudents nullable property
        /// </summary>
        public System.Int32? AmaoProficiencyAttainmentLepStudents { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AmaoProgressAttainmentLepStudents nullable property
        /// </summary>
        public System.Int32? AmaoProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.PersistentlyDangerousStatus nullable property
        /// </summary>
        public System.Boolean? PersistentlyDangerousStatus { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.AccountabilityReportTitle non nullable property
        /// </summary>
        public System.String AccountabilityReportTitle { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAypStatus"/> model
        /// </summary>
        public Guid? RefAypStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGunFreeSchoolsActReportingStatus"/> model
        /// </summary>
        public Guid? RefGunFreeSchoolsActReportingStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolGraduationRateIndicator"/> model
        /// </summary>
        public Guid? RefHighSchoolGraduationRateIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationStatusMath"/> model
        /// </summary>
        public Guid? RefParticipationStatusMathId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationStatusRla"/> model
        /// </summary>
        public Guid? RefParticipationStatusRlaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyTargetStatusMath"/> model
        /// </summary>
        public Guid? RefProficiencyTargetStatusMathId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyTargetStatusRLA"/> model
        /// </summary>
        public Guid? RefProficiencyTargetStatusRLAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReconstitutedStatus"/> model
        /// </summary>
        public Guid? RefReconstitutedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefElementaryMiddleAdditional"/> model
        /// </summary>
        public Guid? RefElementaryMiddleAdditionalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCteGraduationRateInclusion"/> model
        /// </summary>
        public Guid? RefCteGraduationRateInclusionId { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationFederalAccountability.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        public Guid? RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveSupportAndImprovementStatus"/> model
        /// </summary>
        public Guid? RefComprehensiveSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        public Guid? RefTargetedSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
