//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFederalAccountabilityViewModel.cs
//* Name:       Accountability Report Title
//* Definition: The title of the accountability report.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The title of the accountability report.
     /// </summary>
    public partial class OrganizationFederalAccountabilityViewModel : ViewModelBase, Interfaces.IOrganizationFederalAccountability
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationFederalAccountability";

        // AccountabilityReportTitle -- (backing property for Accountability Report Title)
        private System.String _AccountabilityReportTitle;

        // AlternateAypApproachIndicator -- (backing property for Alternate Adequate Yearly Progress Approach Indicator)
        private System.Boolean? _AlternateAypApproachIndicator;

        // AmaoAypProgressAttainmentLepStudents -- (backing property for Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students)
        private System.Int32? _AmaoAypProgressAttainmentLepStudents;

        // AmaoProficiencyAttainmentLepStudents -- (backing property for Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students)
        private System.Int32? _AmaoProficiencyAttainmentLepStudents;

        // AmaoProgressAttainmentLepStudents -- (backing property for Annual Measurable Achievement Objective Progress Attainment Status for LEP Students)
        private System.Int32? _AmaoProgressAttainmentLepStudents;

        // AypAppealChangedDesignation -- (backing property for Adequate Yearly Progress Appeal Changed Designation)
        private System.Boolean? _AypAppealChangedDesignation;

        // AypAppealProcessDate -- (backing property for Adequate Yearly Progress Appeal Process Date)
        private System.DateTime? _AypAppealProcessDate;

        // AypAppealProcessDesignation -- (backing property for Appealed Adequate Yearly Progress Designation)
        private System.Boolean? _AypAppealProcessDesignation;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // PersistentlyDangerousStatus -- (backing property for Persistently Dangerous Status)
        private System.Boolean? _PersistentlyDangerousStatus;

        // RefAdditionalTargetedSupportAndImprovementStatusId -- (backing property for Additional Targeted Support and Improvement Status)
        private Guid? _RefAdditionalTargetedSupportAndImprovementStatusId;

        // RefAypStatusId -- (backing property for Adequate Yearly Progress Status)
        private Guid? _RefAypStatusId;

        // RefComprehensiveSupportAndImprovementStatusId -- (backing property for Comprehensive Support and Improvement Status)
        private Guid? _RefComprehensiveSupportAndImprovementStatusId;

        // RefCteGraduationRateInclusionId -- (backing property for Career and Technical Education Graduation Rate Inclusion)
        private Guid? _RefCteGraduationRateInclusionId;

        // RefElementaryMiddleAdditionalId -- (backing property for Elementary-Middle Additional Indicator Status)
        private Guid? _RefElementaryMiddleAdditionalId;

        // RefGunFreeSchoolsActReportingStatusId -- (backing property for Gun Free Schools Act Reporting Status)
        private Guid? _RefGunFreeSchoolsActReportingStatusId;

        // RefHighSchoolGraduationRateIndicatorId -- (backing property for High School Graduation Rate Indicator Status)
        private Guid? _RefHighSchoolGraduationRateIndicatorId;

        // RefParticipationStatusMathId -- (backing property for Participation Status for Math)
        private Guid? _RefParticipationStatusMathId;

        // RefParticipationStatusRlaId -- (backing property for Participation Status for Reading and Language Arts)
        private Guid? _RefParticipationStatusRlaId;

        // RefProficiencyTargetStatusMathId -- (backing property for Proficiency Target Status for Math)
        private Guid? _RefProficiencyTargetStatusMathId;

        // RefProficiencyTargetStatusRLAId -- (backing property for Proficiency Target Status for Reading and Language Arts)
        private Guid? _RefProficiencyTargetStatusRLAId;

        // RefReconstitutedStatusId -- (backing property for Reconstituted Status)
        private Guid? _RefReconstitutedStatusId;

        // RefTargetedSupportAndImprovementStatusId -- (backing property for Targeted Support and Improvement Status)
        private Guid? _RefTargetedSupportAndImprovementStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Accountability Report Title
        /// <para>
        /// The title of the accountability report.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19005">Accountability Report Title</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AccountabilityReportTitle { get => _AccountabilityReportTitle; set => SetProperty(ref _AccountabilityReportTitle, value); }

        /// <summary>
        /// Alternate Adequate Yearly Progress Approach Indicator
        /// <para>
        /// An indication of whether the district or school used an approved alternate approach for calculating Adequate Yearly Progress (AYP).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19014">Alternate Adequate Yearly Progress Approach Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? AlternateAypApproachIndicator { get => _AlternateAypApproachIndicator; set => SetProperty(ref _AlternateAypApproachIndicator, value); }

        /// <summary>
        /// Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students
        /// <para>
        /// An indication of whether the state or district met the annual measurable objectives for the Limited English Proficient (LEP) student subgroup in mathematics and reading/language arts.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19572">Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? AmaoAypProgressAttainmentLepStudents { get => _AmaoAypProgressAttainmentLepStudents; set => SetProperty(ref _AmaoAypProgressAttainmentLepStudents, value); }

        /// <summary>
        /// Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students
        /// <para>
        /// An indication whether the state, district or school met the Annual Measurable Achievement Objectives (AMAO) for attaining English proficiency for limited English proficient (LEP) students under Title III of ESEA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19535">Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? AmaoProficiencyAttainmentLepStudents { get => _AmaoProficiencyAttainmentLepStudents; set => SetProperty(ref _AmaoProficiencyAttainmentLepStudents, value); }

        /// <summary>
        /// Annual Measurable Achievement Objective Progress Attainment Status for LEP Students
        /// <para>
        /// An indication whether the state, district, or school met the Annual Measurable Achievement Objective (AMAO) for making progress in learning English for limited English proficient (LEP) students under Title III of ESEA as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19545">Annual Measurable Achievement Objective Progress Attainment Status for LEP Students</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? AmaoProgressAttainmentLepStudents { get => _AmaoProgressAttainmentLepStudents; set => SetProperty(ref _AmaoProgressAttainmentLepStudents, value); }

        /// <summary>
        /// Adequate Yearly Progress Appeal Changed Designation
        /// <para>
        /// An indication that the appeal resulted in a change in a school or district's AYP designation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19433">Adequate Yearly Progress Appeal Changed Designation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? AypAppealChangedDesignation { get => _AypAppealChangedDesignation; set => SetProperty(ref _AypAppealChangedDesignation, value); }

        /// <summary>
        /// Adequate Yearly Progress Appeal Process Date
        /// <para>
        /// The last date that an appeal of an AYP designation was processed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19434">Adequate Yearly Progress Appeal Process Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? AypAppealProcessDate { get => _AypAppealProcessDate; set => SetProperty(ref _AypAppealProcessDate, value); }

        /// <summary>
        /// Appealed Adequate Yearly Progress Designation
        /// <para>
        /// An indication that a school or district appealed its AYP designation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19432">Appealed Adequate Yearly Progress Designation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? AypAppealProcessDesignation { get => _AypAppealProcessDesignation; set => SetProperty(ref _AypAppealProcessDesignation, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Persistently Dangerous Status
        /// <para>
        /// An indication of whether the school is identified as persistently dangerous in accordance with state definition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19210">Persistently Dangerous Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? PersistentlyDangerousStatus { get => _PersistentlyDangerousStatus; set => SetProperty(ref _PersistentlyDangerousStatus, value); }

        /// <summary>
        /// Additional Targeted Support and Improvement Status
        /// <para>
        /// The designation given to a school by the state for additional targeted support and improvement as part of its statewide system of annual meaningful differentiation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20902">Additional Targeted Support and Improvement Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAdditionalTargetedSupportAndImprovementStatusId { get => _RefAdditionalTargetedSupportAndImprovementStatusId; set => SetProperty(ref _RefAdditionalTargetedSupportAndImprovementStatusId, value); }

        /// <summary>
        /// Adequate Yearly Progress Status
        /// <para>
        /// An indication of whether the state, district, or school met the Adequate Yearly Progress (AYP) requirements for the school year, as determined by the state-established criteria.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19011">Adequate Yearly Progress Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAypStatusId { get => _RefAypStatusId; set => SetProperty(ref _RefAypStatusId, value); }

        /// <summary>
        /// Comprehensive Support and Improvement Status
        /// <para>
        /// The designation given to a school by the state for comprehensive support and improvement as part of its statewide system of annual meaningful differentiation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20904">Comprehensive Support and Improvement Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefComprehensiveSupportAndImprovementStatusId { get => _RefComprehensiveSupportAndImprovementStatusId; set => SetProperty(ref _RefComprehensiveSupportAndImprovementStatusId, value); }

        /// <summary>
        /// Career and Technical Education Graduation Rate Inclusion
        /// <para>
        /// An indication of how CTE concentrators are included in the state's computation of its graduation rate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19075">Career and Technical Education Graduation Rate Inclusion</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCteGraduationRateInclusionId { get => _RefCteGraduationRateInclusionId; set => SetProperty(ref _RefCteGraduationRateInclusionId, value); }

        /// <summary>
        /// Elementary-Middle Additional Indicator Status
        /// <para>
        ///  An indication of whether the school or district met the Elementary/Middle Additional Indicator requirement in accordance with state definition for the purpose of determining Adequate Yearly Progress (AYP).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19091">Elementary-Middle Additional Indicator Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefElementaryMiddleAdditionalId { get => _RefElementaryMiddleAdditionalId; set => SetProperty(ref _RefElementaryMiddleAdditionalId, value); }

        /// <summary>
        /// Gun Free Schools Act Reporting Status
        /// <para>
        /// An indication of whether the school or local education agency (LEA) submitted a Gun-Free Schools Act (GFSA) of 1994 report to the state, as defined by Title 18, Section 921.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19134">Gun Free Schools Act Reporting Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefGunFreeSchoolsActReportingStatusId { get => _RefGunFreeSchoolsActReportingStatusId; set => SetProperty(ref _RefGunFreeSchoolsActReportingStatusId, value); }

        /// <summary>
        /// High School Graduation Rate Indicator Status
        /// <para>
        /// An indication of whether the school or district met the High School Graduation Rate requirement in accordance with state definition for the purposes of determining AYP.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19140">High School Graduation Rate Indicator Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefHighSchoolGraduationRateIndicatorId { get => _RefHighSchoolGraduationRateIndicatorId; set => SetProperty(ref _RefHighSchoolGraduationRateIndicatorId, value); }

        /// <summary>
        /// Participation Status for Math
        /// <para>
        /// An indication of whether the school or district met the 95 percent participation requirement in the mathematics assessment in accordance with state definition for the purposes of determining AYP.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19208">Participation Status for Math</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefParticipationStatusMathId { get => _RefParticipationStatusMathId; set => SetProperty(ref _RefParticipationStatusMathId, value); }

        /// <summary>
        /// Participation Status for Reading and Language Arts
        /// <para>
        /// An indication of whether the school or district met the 95 percent participation requirement on the reading/language arts assessment in accordance with state definition for the purposes of determining AYP.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19209">Participation Status for Reading and Language Arts</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefParticipationStatusRlaId { get => _RefParticipationStatusRlaId; set => SetProperty(ref _RefParticipationStatusRlaId, value); }

        /// <summary>
        /// Proficiency Target Status for Math
        /// <para>
        /// An indication of whether the school or district met the math proficiency target in accordance with state definition for the purposes of determining AYP.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19221">Proficiency Target Status for Math</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProficiencyTargetStatusMathId { get => _RefProficiencyTargetStatusMathId; set => SetProperty(ref _RefProficiencyTargetStatusMathId, value); }

        /// <summary>
        /// Proficiency Target Status for Reading and Language Arts
        /// <para>
        /// An indication of whether the school or district met the reading/language arts proficiency target in accordance with state definition for the purposes of determining AYP.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19544">Proficiency Target Status for Reading and Language Arts</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProficiencyTargetStatusRLAId { get => _RefProficiencyTargetStatusRLAId; set => SetProperty(ref _RefProficiencyTargetStatusRLAId, value); }

        /// <summary>
        /// Reconstituted Status
        /// <para>
        /// An indication that the school was restructured, transformed or otherwise changed as a consequence of the state's accountability system under ESEA or as a result of School Improvement Grants (SIG).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19230">Reconstituted Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefReconstitutedStatusId { get => _RefReconstitutedStatusId; set => SetProperty(ref _RefReconstitutedStatusId, value); }

        /// <summary>
        /// Targeted Support and Improvement Status
        /// <para>
        /// The designation given to a school by the state for targeted support and improvement as part of its statewide system of annual meaningful differentiation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20910">Targeted Support and Improvement Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTargetedSupportAndImprovementStatusId { get => _RefTargetedSupportAndImprovementStatusId; set => SetProperty(ref _RefTargetedSupportAndImprovementStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationFederalAccountability model)
        {
            IsBusy = true;
            Id = model.Id;
            AccountabilityReportTitle = model.AccountabilityReportTitle; // Accountability Report Title
            AlternateAypApproachIndicator = model.AlternateAypApproachIndicator; // Alternate Adequate Yearly Progress Approach Indicator
            AmaoAypProgressAttainmentLepStudents = model.AmaoAypProgressAttainmentLepStudents; // Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students
            AmaoProficiencyAttainmentLepStudents = model.AmaoProficiencyAttainmentLepStudents; // Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students
            AmaoProgressAttainmentLepStudents = model.AmaoProgressAttainmentLepStudents; // Annual Measurable Achievement Objective Progress Attainment Status for LEP Students
            AypAppealChangedDesignation = model.AypAppealChangedDesignation; // Adequate Yearly Progress Appeal Changed Designation
            AypAppealProcessDate = model.AypAppealProcessDate; // Adequate Yearly Progress Appeal Process Date
            AypAppealProcessDesignation = model.AypAppealProcessDesignation; // Appealed Adequate Yearly Progress Designation
            OrganizationId = model.OrganizationId; // 
            PersistentlyDangerousStatus = model.PersistentlyDangerousStatus; // Persistently Dangerous Status
            RefAdditionalTargetedSupportAndImprovementStatusId = model.RefAdditionalTargetedSupportAndImprovementStatusId; // Additional Targeted Support and Improvement Status
            RefAypStatusId = model.RefAypStatusId; // Adequate Yearly Progress Status
            RefComprehensiveSupportAndImprovementStatusId = model.RefComprehensiveSupportAndImprovementStatusId; // Comprehensive Support and Improvement Status
            RefCteGraduationRateInclusionId = model.RefCteGraduationRateInclusionId; // Career and Technical Education Graduation Rate Inclusion
            RefElementaryMiddleAdditionalId = model.RefElementaryMiddleAdditionalId; // Elementary-Middle Additional Indicator Status
            RefGunFreeSchoolsActReportingStatusId = model.RefGunFreeSchoolsActReportingStatusId; // Gun Free Schools Act Reporting Status
            RefHighSchoolGraduationRateIndicatorId = model.RefHighSchoolGraduationRateIndicatorId; // High School Graduation Rate Indicator Status
            RefParticipationStatusMathId = model.RefParticipationStatusMathId; // Participation Status for Math
            RefParticipationStatusRlaId = model.RefParticipationStatusRlaId; // Participation Status for Reading and Language Arts
            RefProficiencyTargetStatusMathId = model.RefProficiencyTargetStatusMathId; // Proficiency Target Status for Math
            RefProficiencyTargetStatusRLAId = model.RefProficiencyTargetStatusRLAId; // Proficiency Target Status for Reading and Language Arts
            RefReconstitutedStatusId = model.RefReconstitutedStatusId; // Reconstituted Status
            RefTargetedSupportAndImprovementStatusId = model.RefTargetedSupportAndImprovementStatusId; // Targeted Support and Improvement Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefParticipationStatusMath List
        /// <summary>
        /// The complete Accountability Report Title List
        /// </summary>
        private static List<ReferenceModelBase> RefParticipationStatusMathList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefParticipationStatusRla List
        /// <summary>
        /// The complete Accountability Report Title List
        /// </summary>
        private static List<ReferenceModelBase> RefParticipationStatusRlaList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefProficiencyTargetStatusMath List
        /// <summary>
        /// The complete Accountability Report Title List
        /// </summary>
        private static List<ReferenceModelBase> RefProficiencyTargetStatusMathList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefProficiencyTargetStatusRLA List
        /// <summary>
        /// The complete Accountability Report Title List
        /// </summary>
        private static List<ReferenceModelBase> RefProficiencyTargetStatusRLAList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefReconstitutedStatus List
        /// <summary>
        /// The complete Accountability Report Title List
        /// </summary>
        private static List<ReferenceModelBase> RefReconstitutedStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("c2e0918c-6feb-4d04-ae43-d6e6064a40e7"), Code="Yes", Description="Reconstituted school", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("a5730f71-d357-4031-a443-94330663a8dd"), Code="No", Description="Not a reconstituted school", Definition="", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefTargetedSupportAndImprovementStatus List
        /// <summary>
        /// The complete Accountability Report Title List
        /// </summary>
        private static List<ReferenceModelBase> RefTargetedSupportAndImprovementStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("32d90db9-f759-459a-a75d-9e3e8dc297c2"), Code="NOTTSI", Description="Not targeted support and improvement", Definition="Not targeted support and improvement is the designation given to a school by the state for targeted support and improvement as part of its statewide system of annual meaningful differentiation.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("10b88824-51c4-4403-8c53-628fb1801d26"), Code="TSI", Description="Targeted support and improvement", Definition="Targeted support and improvement is the designation given to a school by the state for targeted support and improvement as part of its statewide system of annual meaningful differentiation.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("edb24f7d-f2c9-4dbe-abe8-855e89251f47"), Code="TSIEXIT", Description="Targeted support and improvement - exit status", Definition="Targeted support and improvement - exit status is the designation given to a school by the state for targeted support and improvement as part of its statewide system of annual meaningful differentiation.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}
