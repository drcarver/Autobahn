//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFederalAccountabilityModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationFederalAccountability Model
     /// </summary>
    public partial class OrganizationFederalAccountabilityModel : AutobahnBase, Interfaces.IOrganizationFederalAccountability
    {
        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.String AccountabilityReportTitle { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Boolean? AlternateAypApproachIndicator { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Int32? AmaoAypProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Int32? AmaoProficiencyAttainmentLepStudents { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Int32? AmaoProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Boolean? AypAppealChangedDesignation { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.DateTime? AypAppealProcessDate { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Boolean? AypAppealProcessDesignation { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Boolean? PersistentlyDangerousStatus { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefAypStatusId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefComprehensiveSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefCteGraduationRateInclusionId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefElementaryMiddleAdditionalId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefGunFreeSchoolsActReportingStatusId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefHighSchoolGraduationRateIndicatorId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefParticipationStatusMathId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefParticipationStatusRlaId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefProficiencyTargetStatusMathId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefProficiencyTargetStatusRLAId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefReconstitutedStatusId { get; set; }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public Guid? RefTargetedSupportAndImprovementStatusId { get; set; }

    }
}
