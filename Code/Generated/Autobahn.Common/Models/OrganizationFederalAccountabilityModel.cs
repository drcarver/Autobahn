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
        /// 
        /// </summary>
        public Guid? AccountabilityReportTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AlternateAypApproachIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AmaoAypProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AmaoProficiencyAttainmentLepStudents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AmaoProgressAttainmentLepStudents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AypAppealChangedDesignation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AypAppealProcessDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AypAppealProcessDesignation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PersistentlyDangerousStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAypStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefComprehensiveSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCteGraduationRateInclusionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefElementaryMiddleAdditionalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefGunFreeSchoolsActReportingStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefHighSchoolGraduationRateIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefParticipationStatusMathId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefParticipationStatusRlaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProficiencyTargetStatusMathId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProficiencyTargetStatusRLAId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefReconstitutedStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTargetedSupportAndImprovementStatusId { get; set; }

    }
}
