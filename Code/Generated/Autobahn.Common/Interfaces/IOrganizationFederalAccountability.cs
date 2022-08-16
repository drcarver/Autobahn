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
        /// 
        /// </summary>
        Guid? AccountabilityReportTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AlternateAypApproachIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AmaoAypProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AmaoProficiencyAttainmentLepStudents { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AmaoProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AypAppealChangedDesignation { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AypAppealProcessDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AypAppealProcessDesignation { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PersistentlyDangerousStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAypStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefComprehensiveSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCteGraduationRateInclusionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefElementaryMiddleAdditionalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefGunFreeSchoolsActReportingStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefHighSchoolGraduationRateIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefParticipationStatusMathId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefParticipationStatusRlaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProficiencyTargetStatusMathId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProficiencyTargetStatusRLAId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefReconstitutedStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTargetedSupportAndImprovementStatusId { get; set; }

    }
}
