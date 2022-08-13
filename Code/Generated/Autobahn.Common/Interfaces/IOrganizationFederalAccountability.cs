//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationFederalAccountability.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationFederalAccountability Interface
     /// </summary>
    public partial interface IOrganizationFederalAccountability : IAutobahnBase
    {
        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        System.String AccountabilityReportTitle { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        System.Boolean? AlternateAypApproachIndicator { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        System.Int32? AmaoAypProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        System.Int32? AmaoProficiencyAttainmentLepStudents { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        System.Int32? AmaoProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        System.Boolean? AypAppealChangedDesignation { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        System.DateTime? AypAppealProcessDate { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        System.Boolean? AypAppealProcessDesignation { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        System.Boolean? PersistentlyDangerousStatus { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefAypStatusId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefComprehensiveSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefCteGraduationRateInclusionId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefElementaryMiddleAdditionalId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefGunFreeSchoolsActReportingStatusId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefHighSchoolGraduationRateIndicatorId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefParticipationStatusMathId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefParticipationStatusRlaId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefProficiencyTargetStatusMathId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefProficiencyTargetStatusRLAId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefReconstitutedStatusId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        Guid? RefTargetedSupportAndImprovementStatusId { get; set; }

    }
}
