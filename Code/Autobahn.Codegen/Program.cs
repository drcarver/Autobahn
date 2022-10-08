using Autobahn.Codegen.Models;
using SchemaOrg;
using System;
using System.Reflection;

namespace Autobahn.Codegen;

internal class Program
{
    /// <summary>
    /// In AUtobahn.Core or just extra stuff
    /// </summary>
    private static List<string> EntitiesToIgnore = new List<string>
        {
            "Application",
            "Authentication",
            "Authorization",
            "Autobahn",
            "Cedselement",
            "CedselementDetail",
            "CedsMapping",
            "CedstoNdsmapping",
            "Location",
            "LocationAddress",
            "Organization",
            "OrganizationPersonRole",
            "Person",
            "Role",
            "RefAuthorizerType",
            "RefCountry",
            "RefCounty",
            "RefErsruralUrbanContinuumCode",
            "RefLanguage",
            "RefRole",
            "RefSex",
            "RefState",
        };

    /// <summary>
    /// The adult education domain
    /// </summary>
    private static List<string> AdditionalAdultEducationTypes = new()
    {
        "RefCourseLevelType",
        "RefCareerCluster",
        "RefLevelOfInstitution",
        "RefHighSchoolDiplomaType",
        "RefProfessionalTechnicalCredentialType",
        "RefEmployedWhileEnrolled",
        "RefEmployedAfterExit",
        "RefGoalsForAttendingAdultEducation",
        "RefCorrectionalEducationFacilityType",
        "RefWorkbasedLearningOpportunityType",
        "RefAdultEducationProgramExitReason",
        "RefWorkbasedLearningOpportunityType",
};

    private static List<string> AdditionalAssessmentTypes = new()
    {
        "ApipInteraction",
        "Assessment",
        "AssessmentAccommodation",
        "AssessmentPersonalNeedsProfile",
        "AssessmentResult",
        "PersonAssessmentPersonalNeedsProfile",
        "RefAcademicSubject",
        "RefAccommodationType",
        "RefApipInteractionType",
        "RefAssessmentAccommodationCategory",
        "RefAssessmentAssetType",
        "RefAssessmentEldevelopmentalDomain",
        "RefAssessmentEldevelopmentalDomain",
        "RefAssessmentItemCharacteristicType",
        "RefAssessmentItemResponseScoreStatus",
        "RefAssessmentItemResponseStatus",
        "RefAssessmentItemType",
        "RefAssessmentNeedAlternativeRepresentationType",
        "RefAssessmentNeedBrailleGradeType",
        "RefAssessmentNeedBrailleMarkType",
        "RefAssessmentNeedBrailleStatusCellType",
        "RefAssessmentNeedHazardType",
        "RefAssessmentNeedIncreasedWhitespacingType",
        "RefAssessmentNeedLanguageLearnerType",
        "RefAssessmentNeedLinkIndicationType",
        "RefAssessmentNeedMaskingType",
        "RefAssessmentNeedSigningType",
        "RefAssessmentNeedSpokenSourcePreferenceType",
        "RefAssessmentNeedSupportTool",
        "RefAssessmentNeedUsageType",
        "RefAssessmentNeedUserSpokenPreferenceType",
        "RefAssessmentParticipationIndicator",
        "RefAssessmentPlatformType",
        "RefAssessmentPretestOutcome",
        "RefAssessmentPurpose",
        "RefAssessmentPurpose",
        "RefAssessmentPurpose",
        "RefAssessmentReasonNotCompleting",
        "RefAssessmentReasonNotTested",
        "RefAssessmentRegistrationCompletionStatus",
        "RefAssessmentReportingMethod",
        "RefAssessmentReportingMethod",
        "RefAssessmentResultDataType",
        "RefAssessmentResultScoreType",
        "RefAssessmentSessionSpecialCircumstanceType",
        "RefAssessmentSessionSpecialCircumstanceType",
        "RefAssessmentSessionStaffRoleType",
        "RefAssessmentSessionType",
        "RefAssessmentType",
        "RefContentStandardType",
        "RefEloutcomeMeasurementLevel",
        "RefGoalMeasurementType",
        "RefGoalStatusType",
        "RefItemResponseTheoryDifficultyCategory",
        "RefItemResponseTheoryKappaAlgorithm",
        "RefLearnerActionType",
        "RefLearnerActivityAddToGradeBookFlag",
        "RefLearnerActivityMaximumTimeAllowedUnit",
        "RefLearnerActivityType",
        "RefNaepAspectsOfReading",
        "RefNaepMathComplexityLevel",
        "RefOutcomeTimePoint",
        "RefProficiencyStatus",
        "RefScoreMetricType",
        "RefTextComplexitySystem",
    };

    private static List<string> AdditionalCompetenciesTypes = new()
    {
        "RefType",
        "RefLearningResourceCompetencyAlignmentType",
        "RefEducationLevel",
        "RubricCriterion",
        "Rubric",
    };

    private static List<string> AdditionalCredentialsTypes = new()
    {
        "RefCareerCluster",
        "RefCipCode",
        "RefOnetsococcupationType",
        "RefCtdlaudienceLevelType",
    };

    private static List<string> AdditionalCommonEducationTypes = new()
    {
        "Classroom",
        "CompetencyDefinition",
        "CompetencyFramework",
        "CompetencySet",
        "Course",
        "CourseSection",
        "FinancialAccount",
        "FinancialAccountProgram",
        "LearningResource",
        "OrganizationAccreditation",
        "OrganizationCalendarSession",
        "OrganizationFederalAccountability",
        "OrganizationFinancial",
        "OrganizationPopulationServed",
        "OrganizationProgramType",
        "OrganizationService",
        "OrganizationTechnicalAssistance",
        "RefAcademicSubject",
        "RefAcademicTermDesignator",
        "RefAccreditationAgency",
        "RefAdditionalCreditType",
        "RefAdditionalTargetedSupportAndImprovementStatus",
        "RefAdvancedPlacementCourseCode",
        "RefAypStatus",
        "RefBloomsTaxonomyDomain",
        "RefCompetencyDefNodeAccessibilityProfile",
        "RefCompetencyDefTestabilityType",
        "RefCompetencyFrameworkPublicationStatus",
        "RefComprehensiveSupportAndImprovementStatus",
        "RefCourseApplicableEducationLevel",
        "RefCourseCreditUnit",
        "RefCourseSectionDeliveryMode",
        "RefCreditTypeEarned",
        "RefCteGraduationRateInclusion",
        "RefElementaryMiddleAdditional",
        "RefFinancialAccountBalanceSheetCode",
        "RefFinancialAccountCategory",
        "RefFinancialAccountFundClassification",
        "RefFinancialAccountProgramCode",
        "RefFinancialAccountRevenueCode",
        "RefFinancialExpenditureFunctionCode",
        "RefFinancialExpenditureLevelOfInstructionCode",
        "RefFinancialExpenditureObjectCode",
        "RefGradeLevel",
        "RefGunFreeSchoolsActReportingStatus",
        "RefHighSchoolGraduationRateIndicator",
        "RefLearningResourceAccessApitype",
        "RefLearningResourceAccessHazardType",
        "RefLearningResourceAccessModeType",
        "RefLearningResourceAccessRightsUrl",
        "RefLearningResourceAuthorType",
        "RefLearningResourceBookFormatType",
        "RefLearningResourceControlFlexibilityType",
        "RefLearningResourceDigitalMediaSubType",
        "RefLearningResourceDigitalMediaType",
        "RefLearningResourceEducationalUse",
        "RefLearningResourceIntendedEndUserRole",
        "RefLearningResourceInteractionMode",
        "RefLearningResourceInteractivityType",
        "RefLearningResourceType",
        "RefMultipleIntelligenceType",
        "RefPopulationServed",
        "RefProgramType",
        "RefReconstitutedStatus",
        "RefSessionType",
        "RefSingleSexClassStatus",
        "RefStudentSupportServiceType",
        "RefTargetedSupportAndImprovementStatus",
        "RefTechnicalAssistanceDeliveryType",
        "RefTechnicalAssistanceType",
};

    private static List<string> AdditionalEarlyChildhoodTypes = new()
    {
    };

    private static List<string> AdditionalK12Types = new()
    {
        "AuthorizationDocument",
        "IEPAuthorization",
        "IEPAuthorizationRejected",
        "RefIEPAuthorizationDocumentType"
    };

    private static List<string> AdditionalLearningResourcesTypes = new()
    {
    };
    
    private static List<string> AdditionalOrganizationTypes = new()
    {
        "RefOrganizationEmailType",
        "RefOrganizationTelephoneNumberListedStatus",
        "OrganizationEmployeeBenefit",
        "RefEmployeeBenefit",
        "RefInstitutionTelephoneType",
        "RefTelephoneNumberListedStatus",
        "RefOperationalStatus",
        "Activity",
        "ActivityRecognition",
        "RefActivityRecognitionType",
    };

    private static List<string> AdditionalPersonTypes = new()
    {
        "AssessmentPersonalNeedsProfile",
        "Incident",
        "IncidentPerson",
        "PersonLearningDevice",
        "RefAccommodationsNeededType",
        "RefAllergySeverity",
        "RefAllergyType",
        "RefBarrierToInternetAccessInResidence",
        "RefCareerEducationPlanType",
        "RefCommunicationMethod",
        "RefCredentialType",
        "RefDegreeOrCertificateType",
        "RefDentalInsuranceCoverageType",
        "RefDentalScreeningStatus",
        "RefDisabilityConditionStatusCode",
        "RefDisabilityConditionType",
        "RefDisabilityDeterminationSourceType",
        "RefEducationVerificationMethod",
        "RefElprogramEligibility",
        "RefEmailType",
        "RefFamilyIncomeSource",
        "RefFirearmType",
        "RefHealthInsuranceCoverage",
        "RefHearingScreeningStatus",
        "RefHigherEducationInstitutionAccreditationStatus",
        "RefHomelessNighttimeResidence",
        "RefImmunizationType",
        "RefIncidentBehavior",
        "RefIncidentBehaviorSecondary",
        "RefIncidentInjuryType",
        "RefIncidentLocation",
        "RefIncidentMultipleOffenseType",
        "RefIncidentPerpetratorInjuryType",
        "RefIncidentReporterType",
        "RefIncidentTimeDescriptionCode",
        "RefIncomeCalculationMethod",
        "RefInternetAccessTypeInResidence",
        "RefInternetPerformanceInResidence",
        "RefLanguageUseType",
        "RefMedicalAlertIndicator",
        "RefMilitaryActiveStudentIndicator",
        "RefMilitaryBranch",
        "RefMilitaryConnectedStudentIndicator",
        "RefMilitaryVeteranStudentIndicator",
        "RefOtherNameType",
        "RefParticipationType",
        "RefPrimaryLearningDeviceAccess",
        "RefPrimaryLearningDeviceAwayFromSchool",
        "RefPrimaryLearningDeviceProvider",
        "RefProgramEntryReason",
        "RefProgramExitReason",
        "RefProofOfResidencyType",
        "RefRace",
        "RefReferralOutcome",
        "RefTelephoneNumberListedStatus",
        "RefTribalAffiliation",
        "RefTrimesterWhenPrenatalCareBegan",
        "RefUscitizenshipStatus",
        "RefVisaType",
        "RefVisionScreeningStatus",
        "RefWeaponType",
};

    private static List<string> AdditionalRoleTypes = new()
    {
        "RefAttendanceEventType",
        "RefAttendanceStatus",
        "RefAbsentAttendanceCategory",
        "RefPresentAttendanceCategory",
        "RefLeaveEventType",
    };

//Error   CS0246 The type or namespace name 'AuthorizationDocumentEntity' could not be found(are you missing a using directive or an assembly reference?)	Autobahn.Education.Invalid C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Invalid\Autobahn.Education.Invalid\Entities\IepauthorizationEntity.g.cs	42	Active
//Error   CS0246 The type or namespace name 'EligibilityEvaluationEntity' could not be found(are you missing a using directive or an assembly reference?)	Autobahn.Education.Invalid C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Invalid\Autobahn.Education.Invalid\Entities\IdeaeligibilityEvaluationCategoryEntity.g.cs	36	Active
//Error   CS0246 The type or namespace name 'EligibilityEvaluationEntity' could not be found(are you missing a using directive or an assembly reference?)	Autobahn.Education.Invalid C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Invalid\Autobahn.Education.Invalid\Entities\IndividualizedProgramEligibilityEvaluationEntity.g.cs	42	Active
//Error   CS0246 The type or namespace name 'GoalEntity' could not be found(are you missing a using directive or an assembly reference?)	Autobahn.Education.Invalid C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Invalid\Autobahn.Education.Invalid\Entities\IndividualizedProgramGoalEntity.g.cs	42	Active
//Error   CS0246 The type or namespace name 'GoalPerformanceEntity' could not be found(are you missing a using directive or an assembly reference?)	Autobahn.Education.Invalid C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Invalid\Autobahn.Education.Invalid\Entities\IndividualizedProgramProgressGoalEntity.g.cs	36	Active
//Error   CS0246 The type or namespace name 'IndividualizedProgramEntity' could not be found(are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElchildIndividualizedProgramEntity.g.cs	47	Active
//Error   CS0246 The type or namespace name 'IndividualizedProgramEntity' could not be found(are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElchildTransitionPlanEntity.g.cs	55	Active
//Error   CS0246 The type or namespace name 'IndividualizedProgramEntity' could not be found(are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\IeppresentLevelEntity.g.cs	50	Active
//Error	CS0246	The type or namespace name 'K12staffAssignmentEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Invalid	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Invalid\Autobahn.Education.Invalid\Entities\TeacherStudentDataLinkExclusionEntity.g.cs	53	Active
//Error	CS0246	The type or namespace name 'K12studentCourseSectionEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Invalid	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Invalid\Autobahn.Education.Invalid\Entities\TeacherStudentDataLinkExclusionEntity.g.cs	45	Active
//Error	CS0246	The type or namespace name 'ProfessionalDevelopmentActivityEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\PdactivityEducationLevelEntity.g.cs	36	Active
//Error	CS0246	The type or namespace name 'RefAcademicAwardLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentAcademicAwardEntity.g.cs	96	Active
//Error	CS0246	The type or namespace name 'RefAcademicAwardPrerequisiteTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentAcademicAwardEntity.g.cs	107	Active
//Error	CS0246	The type or namespace name 'RefAcademicHonorTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentAcademicHonorEntity.g.cs	39	Active
//Error	CS0246	The type or namespace name 'RefAcademicRankEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStaffEmploymentEntity.g.cs	259	Active
//Error	CS0246	The type or namespace name 'RefAccommodationTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Invalid	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Invalid\Autobahn.Education.Invalid\Entities\IndividualizedProgramAccommodationEntity.g.cs	66	Active
//Error	CS0246	The type or namespace name 'RefActivityTimeMeasurementTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentActivityEntity.g.cs	37	Active
//Error	CS0246	The type or namespace name 'RefAdministrativeFundingControlEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolEntity.g.cs	129	Active
//Error	CS0246	The type or namespace name 'RefAdministrativeFundingControlEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsInstitutionEntity.g.cs	250	Active
//Error	CS0246	The type or namespace name 'RefAdmissionConsiderationLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsInstitutionEntity.g.cs	228	Active
//Error	CS0246	The type or namespace name 'RefAdmissionConsiderationTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsInstitutionEntity.g.cs	239	Active
//Error	CS0246	The type or namespace name 'RefAdmittedStudentEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentApplicationEntity.g.cs	165	Active
//Error	CS0246	The type or namespace name 'RefAeCertificationTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Invalid	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Invalid\Autobahn.Education.Invalid\Entities\StaffCredentialEntity.g.cs	214	Active
//Error	CS0246	The type or namespace name 'RefAlternativeSchoolFocusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	141	Active
//Error	CS0246	The type or namespace name 'RefBarrierToEducatingHomelessEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12leaFederalReportingEntity.g.cs	71	Active
//Error	CS0246	The type or namespace name 'RefBillableBasisTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElorganizationFundEntity.g.cs	96	Active
//Error	CS0246	The type or namespace name 'RefBlendedLearningModelTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12courseEntity.g.cs	177	Active
//Error	CS0246	The type or namespace name 'RefBlendedLearningModelTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	245	Active
//Error	CS0246	The type or namespace name 'RefCampusResidencyTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentDemographicEntity.g.cs	206	Active
//Error	CS0246	The type or namespace name 'RefCampusStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Facilities	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Facilities\Autobahn.Education.Facilities\Entities\FacilityEntity.g.cs	279	Active
//Error	CS0246	The type or namespace name 'RefCampusTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Facilities	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Facilities\Autobahn.Education.Facilities\Entities\FacilityEntity.g.cs	290	Active
//Error	CS0246	The type or namespace name 'RefCareerClusterEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.CTE	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.CTE\Autobahn.Education.CTE\Entities\CteCourseEntity.g.cs	225	Active
//Error	CS0246	The type or namespace name 'RefCareerClusterEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Credentials	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Credentials\Autobahn.Education.Credentials\Entities\CredentialDefinitionEntity.g.cs	242	Active
//Error	CS0246	The type or namespace name 'RefCareerClusterEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12courseEntity.g.cs	169	Active
//Error	CS0246	The type or namespace name 'RefCareerClusterEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsstudentProgramEntity.g.cs	91	Active
//Error	CS0246	The type or namespace name 'RefCarnegieBasicClassificationEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsInstitutionEntity.g.cs	173	Active
//Error	CS0246	The type or namespace name 'RefCharterLeaStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12leaEntity.g.cs	83	Active
//Error	CS0246	The type or namespace name 'RefCharterSchoolAuthorizerTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12charterSchoolAuthorizerAgencyEntity.g.cs	35	Active
//Error	CS0246	The type or namespace name 'RefCharterSchoolTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolEntity.g.cs	137	Active
//Error	CS0246	The type or namespace name 'RefChildDevelopmentalScreeningStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElchildDevelopmentalAssessmentEntity.g.cs	41	Active
//Error	CS0246	The type or namespace name 'RefChildDevelopmentAssociateTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElstaffEntity.g.cs	35	Active
//Error	CS0246	The type or namespace name 'RefCipCodeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Credentials	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Credentials\Autobahn.Education.Credentials\Entities\CredentialDefinitionEntity.g.cs	253	Active
//Error	CS0246	The type or namespace name 'RefCipCodeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsCourseEntity.g.cs	159	Active
//Error	CS0246	The type or namespace name 'RefCipCodeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsProgramEntity.g.cs	133	Active
//Error	CS0246	The type or namespace name 'RefCipCodeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsSectionEntity.g.cs	138	Active
//Error	CS0246	The type or namespace name 'RefCipUseEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsstudentProgramEntity.g.cs	59	Active
//Error	CS0246	The type or namespace name 'RefCipVersionEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsProgramEntity.g.cs	122	Active
//Error	CS0246	The type or namespace name 'RefClassroomPositionTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12staffAssignmentEntity.g.cs	137	Active
//Error	CS0246	The type or namespace name 'RefCohortExclusionEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentDemographicEntity.g.cs	228	Active
//Error	CS0246	The type or namespace name 'RefCommunityBasedTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\EarlyChildhoodProgramTypeOfferedEntity.g.cs	82	Active
//Error	CS0246	The type or namespace name 'RefComprehensiveAndTargetedSupportEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	205	Active
//Error	CS0246	The type or namespace name 'RefComprehensiveSupportEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	213	Active
//Error	CS0246	The type or namespace name 'RefControlOfInstitutionEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsInstitutionEntity.g.cs	184	Active
//Error	CS0246	The type or namespace name 'RefCorrectiveActionTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolCorrectiveActionEntity.g.cs	44	Active
//Error	CS0246	The type or namespace name 'RefCourseAcademicGradeStatusCodeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentCourseSectionMarkEntity.g.cs	81	Active
//Error	CS0246	The type or namespace name 'RefCourseAcademicGradeStatusCodeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentSectionEntity.g.cs	145	Active
//Error	CS0246	The type or namespace name 'RefCourseCreditBasisTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsCourseEntity.g.cs	129	Active
//Error	CS0246	The type or namespace name 'RefCourseCreditLevelTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsCourseEntity.g.cs	140	Active
//Error	CS0246	The type or namespace name 'RefCourseHonorsTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsSectionEntity.g.cs	149	Active
//Error	CS0246	The type or namespace name 'RefCourseInstructionMethodEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsSectionEntity.g.cs	160	Active
//Error	CS0246	The type or namespace name 'RefCourseInstructionSiteTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsSectionLocationEntity.g.cs	67	Active
//Error	CS0246	The type or namespace name 'RefCourseInteractionModeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12courseEntity.g.cs	185	Active
//Error	CS0246	The type or namespace name 'RefCourseLevelTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\CourseSectionLevelEntity.g.cs	54	Active
//Error	CS0246	The type or namespace name 'RefCourseLevelTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsSectionEntity.g.cs	171	Active
//Error	CS0246	The type or namespace name 'RefCourseRepeatCodeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentCourseSectionEntity.g.cs	111	Active
//Error	CS0246	The type or namespace name 'RefCourseRepeatCodeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentSectionEntity.g.cs	134	Active
//Error	CS0246	The type or namespace name 'RefCourseSectionEnrollmentStatusTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentCourseSectionEntity.g.cs	119	Active
//Error	CS0246	The type or namespace name 'RefCourseSectionEntryTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentCourseSectionEntity.g.cs	127	Active
//Error	CS0246	The type or namespace name 'RefCourseSectionExitTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentCourseSectionEntity.g.cs	135	Active
//Error	CS0246	The type or namespace name 'RefCreditHoursAppliedOtherProgramEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentAcademicRecordEntity.g.cs	220	Active
//Error	CS0246	The type or namespace name 'RefCtdlaudienceLevelTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Credentials	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Credentials\Autobahn.Education.Credentials\Entities\CredentialDefinitionEntity.g.cs	302	Active
//Error	CS0246	The type or namespace name 'RefCurriculumFrameworkTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.CTE	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.CTE\Autobahn.Education.CTE\Entities\CteCourseEntity.g.cs	198	Active
//Error	CS0246	The type or namespace name 'RefCurriculumFrameworkTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12courseEntity.g.cs	145	Active
//Error	CS0246	The type or namespace name 'RefDependencyStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentDemographicEntity.g.cs	184	Active
//Error	CS0246	The type or namespace name 'RefDevelopmentalEducationReferralStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentEnrollmentEntity.g.cs	479	Active
//Error	CS0246	The type or namespace name 'RefDevelopmentalEducationTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsSectionEntity.g.cs	182	Active
//Error	CS0246	The type or namespace name 'RefDevelopmentalEducationTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentEnrollmentEntity.g.cs	490	Active
//Error	CS0246	The type or namespace name 'RefDevelopmentalEvaluationFindingEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElchildDevelopmentalAssessmentEntity.g.cs	49	Active
//Error	CS0246	The type or namespace name 'RefDirectoryInformationBlockStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentEnrollmentEntity.g.cs	161	Active
//Error	CS0246	The type or namespace name 'RefDisciplinaryActionTakenEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentDisciplineEntity.g.cs	107	Active
//Error	CS0246	The type or namespace name 'RefDisciplineLengthDifferenceReasonEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentDisciplineEntity.g.cs	115	Active
//Error	CS0246	The type or namespace name 'RefDisciplineMethodOfCwdEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentDisciplineEntity.g.cs	131	Active
//Error	CS0246	The type or namespace name 'RefDisciplineReasonEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentDisciplineEntity.g.cs	99	Active
//Error	CS0246	The type or namespace name 'RefDistanceEducationCourseEnrollmentEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentEnrollmentEntity.g.cs	446	Active
//Error	CS0246	The type or namespace name 'RefDoctoralExamsRequiredCodeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentEnrollmentEntity.g.cs	457	Active
//Error	CS0246	The type or namespace name 'RefDqpcategoriesOfLearningEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsProgramEntity.g.cs	160	Active
//Error	CS0246	The type or namespace name 'RefEdfactsTeacherInexperiencedStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12staffAssignmentEntity.g.cs	177	Active
//Error	CS0246	The type or namespace name 'RefEloutcomeMeasurementLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Assessments	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Assessments\Autobahn.Education.Assessments\Entities\AssessmentResultEntity.g.cs	294	Active
//Error	CS0246	The type or namespace name 'RefEltrainerCoreKnowledgeAreaEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Invalid	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Invalid\Autobahn.Education.Invalid\Entities\ProfessionalDevelopmentSessionEntity.g.cs	272	Active
//Error	CS0246	The type or namespace name 'RefEmergencyOrProvisionalCredentialStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12staffAssignmentEntity.g.cs	185	Active
//Error	CS0246	The type or namespace name 'RefEmployedAfterExitEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentEmploymentEntity.g.cs	53	Active
//Error	CS0246	The type or namespace name 'RefEmployedAfterExitEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentEmploymentEntity.g.cs	96	Active
//Error	CS0246	The type or namespace name 'RefEmployedAfterExitEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Workforce	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Workforce\Autobahn.Education.Workforce\Entities\WorkforceEmploymentQuarterlyDatumEntity.g.cs	53	Active
//Error	CS0246	The type or namespace name 'RefEmployedWhileEnrolledEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentEmploymentEntity.g.cs	45	Active
//Error	CS0246	The type or namespace name 'RefEmployedWhileEnrolledEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentEmploymentEntity.g.cs	85	Active
//Error	CS0246	The type or namespace name 'RefEmployedWhileEnrolledEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Workforce	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Workforce\Autobahn.Education.Workforce\Entities\WorkforceEmploymentQuarterlyDatumEntity.g.cs	45	Active
//Error	CS0246	The type or namespace name 'RefEmploymentContractTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStaffEmploymentEntity.g.cs	215	Active
//Error	CS0246	The type or namespace name 'RefEmploymentStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElstaffEmploymentEntity.g.cs	81	Active
//Error	CS0246	The type or namespace name 'RefEmploymentStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12staffEmploymentEntity.g.cs	65	Active
//Error	CS0246	The type or namespace name 'RefEmploymentStatusWhileEnrolledEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentEmploymentEntity.g.cs	107	Active
//Error	CS0246	The type or namespace name 'RefEndOfTermStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentEnrollmentEntity.g.cs	129	Active
//Error	CS0246	The type or namespace name 'RefEnrollmentStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentEnrollmentEntity.g.cs	105	Active
//Error	CS0246	The type or namespace name 'RefEntityTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Competencies	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Competencies\Autobahn.Education.Competencies\Entities\CompetencyDefAssociationEntity.g.cs	150	Active
//Error	CS0246	The type or namespace name 'RefEnvironmentSettingEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElclassSectionEntity.g.cs	59	Active
//Error	CS0246	The type or namespace name 'RefEnvironmentSettingEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElorganizationAvailabilityEntity.g.cs	49	Active
//Error	CS0246	The type or namespace name 'RefExitOrWithdrawalStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentCourseSectionEntity.g.cs	143	Active
//Error	CS0246	The type or namespace name 'RefExitOrWithdrawalStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentEnrollmentEntity.g.cs	113	Active
//Error	CS0246	The type or namespace name 'RefExitOrWithdrawalTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentEnrollmentEntity.g.cs	121	Active
//Error	CS0246	The type or namespace name 'RefFacilitiesMandateAuthorityTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Facilities	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Facilities\Autobahn.Education.Facilities\Entities\FacilityMandateEntity.g.cs	106	Active
//Error	CS0246	The type or namespace name 'RefFacilitiesMgmtEmergencyTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Facilities	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Facilities\Autobahn.Education.Facilities\Entities\FacilityManagementPlanEntity.g.cs	91	Active
//Error	CS0246	The type or namespace name 'RefFacilitiesPlanTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Facilities	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Facilities\Autobahn.Education.Facilities\Entities\FacilityManagementPlanEntity.g.cs	80	Active
//Error	CS0246	The type or namespace name 'RefFederalProgramFundingAllocationTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12federalFundAllocationEntity.g.cs	73	Active
//Error	CS0246	The type or namespace name 'RefFinancialAidVeteransBenefitStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentFinancialAidEntity.g.cs	120	Active
//Error	CS0246	The type or namespace name 'RefFinancialAidVeteransBenefitTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentFinancialAidEntity.g.cs	131	Active
//Error	CS0246	The type or namespace name 'RefFoodServiceEligibilityEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentEnrollmentEntity.g.cs	153	Active
//Error	CS0246	The type or namespace name 'RefFoodServiceParticipationEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElenrollmentEntity.g.cs	67	Active
//Error	CS0246	The type or namespace name 'RefFrequencyOfServiceEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElclassSectionServiceEntity.g.cs	67	Active
//Error	CS0246	The type or namespace name 'RefFullTimeStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStaffEmploymentEntity.g.cs	204	Active
//Error	CS0246	The type or namespace name 'RefGpaWeightedIndicatorEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentAcademicRecordEntity.g.cs	95	Active
//Error	CS0246	The type or namespace name 'RefGpaWeightedIndicatorEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentApplicationEntity.g.cs	154	Active
//Error	CS0246	The type or namespace name 'RefGradePointAverageDomainEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentApplicationEntity.g.cs	143	Active
//Error	CS0246	The type or namespace name 'RefGraduateAssistantIpedsCategoryEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStaffEmploymentEntity.g.cs	281	Active
//Error	CS0246	The type or namespace name 'RefGraduateOrDoctoralExamResultsStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentEnrollmentEntity.g.cs	468	Active
//Error	CS0246	The type or namespace name 'RefHighSchoolDiplomaDistinctionTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentAcademicRecordEntity.g.cs	111	Active
//Error	CS0246	The type or namespace name 'RefHighSchoolDiplomaTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentAcademicRecordEntity.g.cs	103	Active
//Error	CS0246	The type or namespace name 'RefIncreasedLearningTimeTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolEntity.g.cs	145	Active
//Error	CS0246	The type or namespace name 'RefIncreasedLearningTimeTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsInstitutionEntity.g.cs	261	Active
//Error	CS0246	The type or namespace name 'RefIndicatorStateDefinedStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolIndicatorStatusEntity.g.cs	78	Active
//Error	CS0246	The type or namespace name 'RefIndicatorStatusCustomTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolIndicatorStatusEntity.g.cs	94	Active
//Error	CS0246	The type or namespace name 'RefIndicatorStatusSubgroupTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolIndicatorStatusEntity.g.cs	86	Active
//Error	CS0246	The type or namespace name 'RefIndicatorStatusTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolIndicatorStatusEntity.g.cs	70	Active
//Error	CS0246	The type or namespace name 'RefInstructionalStaffContractLengthEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStaffEmploymentEntity.g.cs	237	Active
//Error	CS0246	The type or namespace name 'RefInstructionalStaffFacultyTenureEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStaffEmploymentEntity.g.cs	248	Active
//Error	CS0246	The type or namespace name 'RefInstructionCreditTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStaffEmploymentEntity.g.cs	270	Active
//Error	CS0246	The type or namespace name 'RefIntegratedTechnologyStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12leaFederalReportingEntity.g.cs	79	Active
//Error	CS0246	The type or namespace name 'RefInternetAccessEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	149	Active
//Error	CS0246	The type or namespace name 'RefIpedsOccupationalCategoryEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStaffEmploymentEntity.g.cs	226	Active
//Error	CS0246	The type or namespace name 'RefLeaFundsTransferTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12federalFundAllocationEntity.g.cs	81	Active
//Error	CS0246	The type or namespace name 'RefLeaImprovementStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12leaEntity.g.cs	67	Active
//Error	CS0246	The type or namespace name 'RefLearningResourceCompetencyAlignmentTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Competencies	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Competencies\Autobahn.Education.Competencies\Entities\CompetencyDefAssociationEntity.g.cs	172	Active
//Error	CS0246	The type or namespace name 'RefLeaTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12leaEntity.g.cs	59	Active
//Error	CS0246	The type or namespace name 'RefLevelOfInstitutionEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsInstitutionEntity.g.cs	195	Active
//Error	CS0246	The type or namespace name 'RefLicenseExemptEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElfacilityLicensingEntity.g.cs	55	Active
//Error	CS0246	The type or namespace name 'RefLicenseExemptEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElprogramLicensingEntity.g.cs	61	Active
//Error	CS0246	The type or namespace name 'RefLiteracyAssessmentEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentLiteracyAssessmentEntity.g.cs	41	Active
//Error	CS0246	The type or namespace name 'RefMagnetSpecialProgramEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	133	Active
//Error	CS0246	The type or namespace name 'RefMepProjectTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12programOrServiceEntity.g.cs	89	Active
//Error	CS0246	The type or namespace name 'RefMepSessionTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12programOrServiceEntity.g.cs	81	Active
//Error	CS0246	The type or namespace name 'RefMepStaffCategoryEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12staffAssignmentEntity.g.cs	161	Active
//Error	CS0246	The type or namespace name 'RefNaepMathComplexityLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Assessments	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Assessments\Autobahn.Education.Assessments\Entities\AssessmentItemEntity.g.cs	309	Active
//Error	CS0246	The type or namespace name 'RefNationalSchoolLunchProgramStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	229	Active
//Error	CS0246	The type or namespace name 'RefNcescollegeCourseMapCodeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsCourseEntity.g.cs	148	Active
//Error	CS0246	The type or namespace name 'RefNeedDeterminationMethodEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentFinancialAidEntity.g.cs	109	Active
//Error	CS0246	The type or namespace name 'RefNonPromotionReasonEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentEnrollmentEntity.g.cs	145	Active
//Error	CS0246	The type or namespace name 'RefNonTraditionalGenderStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.CTE	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.CTE\Autobahn.Education.CTE\Entities\ProgramParticipationCteEntity.g.cs	174	Active
//Error	CS0246	The type or namespace name 'RefNslpstatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	173	Active
//Error	CS0246	The type or namespace name 'RefNumberOfDependentsTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentDemographicEntity.g.cs	239	Active
//Error	CS0246	The type or namespace name 'RefOnetsococcupationTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Credentials	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Credentials\Autobahn.Education.Credentials\Entities\CredentialDefinitionEntity.g.cs	294	Active
//Error	CS0246	The type or namespace name 'RefOutOfFieldStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12staffAssignmentEntity.g.cs	193	Active
//Error	CS0246	The type or namespace name 'RefPdactivityEducationLevelsAddressedEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\PdactivityEducationLevelEntity.g.cs	44	Active
//Error	CS0246	The type or namespace name 'RefPdactivityLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Invalid	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Invalid\Autobahn.Education.Invalid\Entities\ProfessionalDevelopmentActivityEntity.g.cs	283	Active
//Error	CS0246	The type or namespace name 'RefPescawardLevelTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentAcademicAwardEntity.g.cs	115	Active
//Error	CS0246	The type or namespace name 'RefPreAndPostTestIndicatorEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentAcademicRecordEntity.g.cs	135	Active
//Error	CS0246	The type or namespace name 'RefPreAndPostTestIndicatorEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentCourseSectionEntity.g.cs	167	Active
//Error	CS0246	The type or namespace name 'RefPredominantCalendarSystemEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsInstitutionEntity.g.cs	206	Active
//Error	CS0246	The type or namespace name 'RefPrekindergartenEligibilityEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12leaPreKeligibilityEntity.g.cs	51	Active
//Error	CS0246	The type or namespace name 'RefProfessionalEducationJobClassificationEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12staffAssignmentEntity.g.cs	121	Active
//Error	CS0246	The type or namespace name 'RefProfessionalTechnicalCredentialTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.CTE	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.CTE\Autobahn.Education.CTE\Entities\CteStudentAcademicRecordEntity.g.cs	83	Active
//Error	CS0246	The type or namespace name 'RefProfessionalTechnicalCredentialTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentAcademicRecordEntity.g.cs	143	Active
//Error	CS0246	The type or namespace name 'RefProfessionalTechnicalCredentialTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Workforce	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Workforce\Autobahn.Education.Workforce\Entities\WorkforceProgramParticipationEntity.g.cs	91	Active
//Error	CS0246	The type or namespace name 'RefProfitStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElorganizationEntity.g.cs	35	Active
//Error	CS0246	The type or namespace name 'RefProgramGiftedEligibilityEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12programOrServiceEntity.g.cs	73	Active
//Error	CS0246	The type or namespace name 'RefProgramLengthHoursTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsProgramEntity.g.cs	144	Active
//Error	CS0246	The type or namespace name 'RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	197	Active
//Error	CS0246	The type or namespace name 'RefProgressLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentAcademicRecordEntity.g.cs	151	Active
//Error	CS0246	The type or namespace name 'RefProgressLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentCourseSectionEntity.g.cs	175	Active
//Error	CS0246	The type or namespace name 'RefPromotionReasonEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentEnrollmentEntity.g.cs	137	Active
//Error	CS0246	The type or namespace name 'RefPsEnrollmentActionEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentAcademicRecordEntity.g.cs	127	Active
//Error	CS0246	The type or namespace name 'RefPsprogramLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsProgramEntity.g.cs	152	Active
//Error	CS0246	The type or namespace name 'RefPsStudentLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentEnrollmentEntity.g.cs	413	Active
//Error	CS0246	The type or namespace name 'RefPublicSchoolChoiceStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12leaEntity.g.cs	75	Active
//Error	CS0246	The type or namespace name 'RefPurposeOfMonitoringVisitEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElorganizationMonitoringEntity.g.cs	49	Active
//Error	CS0246	The type or namespace name 'RefQrisParticipationEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElqualityRatingImprovementEntity.g.cs	45	Active
//Error	CS0246	The type or namespace name 'RefReapAlternativeFundingStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12federalFundAllocationEntity.g.cs	89	Active
//Error	CS0246	The type or namespace name 'RefReasonDelayTransitionConfEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElchildTransitionPlanEntity.g.cs	63	Active
//Error	CS0246	The type or namespace name 'RefReimbursementTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElorganizationFundEntity.g.cs	104	Active
//Error	CS0246	The type or namespace name 'RefRestructuringActionEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	157	Active
//Error	CS0246	The type or namespace name 'RefRlisProgramUseEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12leaFederalFundEntity.g.cs	64	Active
//Error	CS0246	The type or namespace name 'RefScedcourseLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.CTE	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.CTE\Autobahn.Education.CTE\Entities\CteCourseEntity.g.cs	206	Active
//Error	CS0246	The type or namespace name 'RefScedcourseLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12courseEntity.g.cs	153	Active
//Error	CS0246	The type or namespace name 'RefScedcourseSubjectAreaEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.CTE	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.CTE\Autobahn.Education.CTE\Entities\CteCourseEntity.g.cs	214	Active
//Error	CS0246	The type or namespace name 'RefScedcourseSubjectAreaEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12courseEntity.g.cs	161	Active
//Error	CS0246	The type or namespace name 'RefScedcourseSubjectAreaEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentGraduationPlanEntity.g.cs	58	Active
//Error	CS0246	The type or namespace name 'RefScheduledWellChildScreeningEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElchildHealthEntity.g.cs	37	Active
//Error	CS0246	The type or namespace name 'RefSchoolDangerousStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	181	Active
//Error	CS0246	The type or namespace name 'RefSchoolImprovementStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolImprovementEntity.g.cs	57	Active
//Error	CS0246	The type or namespace name 'RefSchoolImprovementStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	189	Active
//Error	CS0246	The type or namespace name 'RefSchoolLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolEntity.g.cs	121	Active
//Error	CS0246	The type or namespace name 'RefSchoolTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolEntity.g.cs	113	Active
//Error	CS0246	The type or namespace name 'RefServiceOptionEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElclassSectionEntity.g.cs	51	Active
//Error	CS0246	The type or namespace name 'RefServiceOptionEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElenrollmentEntity.g.cs	75	Active
//Error	CS0246	The type or namespace name 'RefServiceOptionEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElorganizationAvailabilityEntity.g.cs	57	Active
//Error	CS0246	The type or namespace name 'RefSigInterventionTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolImprovementEntity.g.cs	65	Active
//Error	CS0246	The type or namespace name 'RefSpaceUseTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Facilities	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Facilities\Autobahn.Education.Facilities\Entities\BuildingSpaceEntity.g.cs	301	Active
//Error	CS0246	The type or namespace name 'RefSpecialEducationAgeGroupTaughtEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12staffAssignmentEntity.g.cs	153	Active
//Error	CS0246	The type or namespace name 'RefSpecialEducationStaffCategoryEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12staffAssignmentEntity.g.cs	145	Active
//Error	CS0246	The type or namespace name 'RefStaffPerformanceLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Invalid	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Invalid\Autobahn.Education.Invalid\Entities\StaffEvaluationEntity.g.cs	101	Active
//Error	CS0246	The type or namespace name 'RefStandardizedAdmissionTestEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentAdmissionTestEntity.g.cs	58	Active
//Error	CS0246	The type or namespace name 'RefStateAnsicodeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12seaEntity.g.cs	35	Active
//Error	CS0246	The type or namespace name 'RefStatePovertyDesignationEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolEntity.g.cs	153	Active
//Error	CS0246	The type or namespace name 'RefStudentEnrollmentAccessTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentEnrollmentEntity.g.cs	169	Active
//Error	CS0246	The type or namespace name 'RefStudentSchoolAffiliationStateDefinedStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12organizationStudentResponsibilityEntity.g.cs	50	Active
//Error	CS0246	The type or namespace name 'RefTargetedSupportEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	221	Active
//Error	CS0246	The type or namespace name 'RefTechnologyLiteracyStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentAcademicRecordEntity.g.cs	119	Active
//Error	CS0246	The type or namespace name 'RefTenureSystemEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsInstitutionEntity.g.cs	217	Active
//Error	CS0246	The type or namespace name 'RefTitleIiilanguageInstructionProgramTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12titleIiilanguageInstructionEntity.g.cs	36	Active
//Error	CS0246	The type or namespace name 'RefTitleIiiprofessionalDevelopmentTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12leaTitleIiiprofessionalDevelopmentEntity.g.cs	51	Active
//Error	CS0246	The type or namespace name 'RefTitleIprogramStaffCategoryEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12staffAssignmentEntity.g.cs	169	Active
//Error	CS0246	The type or namespace name 'RefTitleIprogramTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12programOrServiceEntity.g.cs	97	Active
//Error	CS0246	The type or namespace name 'RefTitleIschoolStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	165	Active
//Error	CS0246	The type or namespace name 'RefTransferOutIndicatorEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsstudentProgramEntity.g.cs	83	Active
//Error	CS0246	The type or namespace name 'RefTransferReadyEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentEnrollmentEntity.g.cs	435	Active
//Error	CS0246	The type or namespace name 'RefTuitionResidencyTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentDemographicEntity.g.cs	195	Active
//Error	CS0246	The type or namespace name 'RefTuitionUnitEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsPriceOfAttendanceEntity.g.cs	174	Active
//Error	CS0246	The type or namespace name 'RefVirtualSchoolStatusEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolStatusEntity.g.cs	237	Active
//Error	CS0246	The type or namespace name 'RefWageCollectionMethodEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElstaffEmploymentEntity.g.cs	89	Active
//Error	CS0246	The type or namespace name 'RefWageVerificationEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElstaffEmploymentEntity.g.cs	97	Active
//Error	CS0246	The type or namespace name 'RefWfProgramParticipationEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Workforce	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Workforce\Autobahn.Education.Workforce\Entities\WorkforceProgramParticipationEntity.g.cs	80	Active
//Error	CS0246	The type or namespace name 'RefWorkbasedLearningOpportunityTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.CTE	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.CTE\Autobahn.Education.CTE\Entities\ProgramParticipationCteEntity.g.cs	185	Active
//Error	CS0246	The type or namespace name 'RefWorkbasedLearningOpportunityTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12courseEntity.g.cs	201	Active
//Error	CS0246	The type or namespace name 'RefWorkbasedLearningOpportunityTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsSectionEntity.g.cs	193	Active
//Error	CS0246	The type or namespace name 'RefWorkbasedLearningOpportunityTypeEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsstudentProgramEntity.g.cs	75	Active
//Error	CS0246	The type or namespace name 'RubricCriterionEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Competencies	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Competencies\Autobahn.Education.Competencies\Entities\CompetencySetRubricCriterionEntity.g.cs	44	Active
//Error	CS0246	The type or namespace name 'RubricCriterionEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\RubricCriterionLevelEntity.g.cs	79	Active
//Error	CS0246	The type or namespace name 'RubricCriterionLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Assessments	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Assessments\Autobahn.Education.Assessments\Entities\AssessmentItemRubricCriterionResultEntity.g.cs	44	Active
//Error	CS0246	The type or namespace name 'RubricCriterionLevelEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Assessments	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Assessments\Autobahn.Education.Assessments\Entities\AssessmentResultRubricCriterionResultEntity.g.cs	44	Active
//Error	CS0246	The type or namespace name 'RubricEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Competencies	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Competencies\Autobahn.Education.Competencies\Entities\CompetencySetRubricEntity.g.cs	44	Active
//Error	CS0246	The type or namespace name 'StaffEmploymentEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.EarlyLearning	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\ElstaffEmploymentEntity.g.cs	73	Active
//Error	CS0246	The type or namespace name 'StaffEmploymentEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.K12	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12staffEmploymentEntity.g.cs	49	Active
//Error	CS0246	The type or namespace name 'StaffEmploymentEntity' could not be found (are you missing a using directive or an assembly reference?)	Autobahn.Education.Postsecondary	C:\Users\drcarver\Desktop\codegen\Autobahn\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStaffEmploymentEntity.g.cs	193	Active


    /// <summary>
    /// Set the domain of the table based on it name
    /// </summary>
    /// <param name="autobahnDomains"></param>
    /// <param name="table"></param>
    static void SetTableDomain(List<AutobahnDomain> autobahnDomains, AutobahnEntity table)
    {
        // Set the domains in the tablesMetadata
        var comdom = autobahnDomains.First(d => d.Module == "Common");
        var assesdom = autobahnDomains.First(d => d.Module == "Assessments");
        var aedom = autobahnDomains.First(d => d.Module == "AdultEducation");
        var eldom = autobahnDomains.First(d => d.Module == "EarlyLearning");
        var lrdom = autobahnDomains.First(d => d.Module == "LearningResources");
        var k12dom = autobahnDomains.First(d => d.Module == "K12");
        var facdom = autobahnDomains.First(d => d.Module == "Facilities");
        var psdom = autobahnDomains.First(d => d.Module == "Postsecondary");
        var compdom = autobahnDomains.First(d => d.Module == "Competencies");
        var creddom = autobahnDomains.First(d => d.Module == "Credentials");
        var ctedom = autobahnDomains.First(d => d.Module == "CTE");
        var wfdom = autobahnDomains.First(d => d.Module == "Workforce");

        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("AE")
            || table.Name.ToUpper().EndsWith("AE")
            || table.Name.ToUpper().StartsWith("REFAE")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name)                )
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = aedom.Module;
                return;
            }
        }
        if (AdditionalAdultEducationTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = aedom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("EL")
            || table.Name.ToUpper().StartsWith("EARLYCHILDHOOD")
            || table.Name.ToUpper().EndsWith("EL")
            || table.Name.ToUpper().StartsWith("REFEL")
            || table.Name.ToUpper().IndexOf("EARLYCHILDHOOD") > 0))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = eldom.Module;
                return;
            }
        }
        if (AdditionalEarlyChildhoodTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = aedom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("ASSESSMENT")
            || table.Name.ToUpper().StartsWith("RUBRIC")
            || table.Name.ToUpper().StartsWith("GOAL")
            || table.Name.ToUpper().StartsWith("LEARNER")
            || table.Name.IndexOf("ASSESSMENT") > 0
            || table.Name.IndexOf("RUBRIC") > 0
            || table.Name.IndexOf("GOAL") > 0
            || table.Name.IndexOf("LEARNER") > 0))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = assesdom.Module;
                return;
            }
        }
        if (AdditionalAssessmentTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = assesdom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("Learning".ToUpper())
            || table.Name.ToUpper().StartsWith("Peer".ToUpper())
            || table.Name.ToUpper().IndexOf("Learning".ToUpper()) > 0
            || table.Name.ToUpper().IndexOf("Peer".ToUpper()) > 0))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = lrdom.Module;
                return;
            }
        }
        if (AdditionalLearningResourcesTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = assesdom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("K12")
            || table.Name.ToUpper().IndexOf("K12") > 0))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = k12dom.Module;
                return;
            }
        }
        if (AdditionalK12Types.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = assesdom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("Build")
            || table.Name.StartsWith("Facility")
            || table.Name.StartsWith("RefBuild")
            || table.Name.StartsWith("RefFacility")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = facdom.Module;
                return;
            }
        }

        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("Ps")
            || table.Name.StartsWith("PS")
            || table.Name.IndexOf("IPEDS", StringComparison.InvariantCulture) > -1
            || table.Name.StartsWith("RefPs")
            || table.Name.StartsWith("RefPS")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = psdom.Module;
                return;
            }
        }

        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("Competency")
            || table.Name.StartsWith("RefCompet")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = compdom.Module;
                return;
            }
        }
        if (AdditionalCompetenciesTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = compdom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("Credential")
            || table.Name.StartsWith("RefCred")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = creddom.Module;
                return;
            }
        }
        if (AdditionalCredentialsTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = compdom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("Cte")
            || table.Name.EndsWith("Cte")
            || table.Name.StartsWith("RefCte")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = ctedom.Module;
                return;
            }
        }

        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("App")
            || table.Name.StartsWith("Auth")
            || table.Name.StartsWith("RefApp")
            || table.Name.StartsWith("RefAuth")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = "Autorization";
                return;
            }
        }

        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("Workforce")
            || table.Name.StartsWith("RefWorkforce")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = wfdom.Module;
            }
        }

        if (AdditionalCommonEducationTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = comdom.Module;
            return;
        }

        if (table.Attributes?.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("Organization".ToUpper())
            || table.Name.ToUpper().IndexOf("Organization".ToUpper()) > 0))
       {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = "Organization";
                return;
            }
        }
        if (AdditionalOrganizationTypes.Contains(table.Name)
            && !AdditionalCommonEducationTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = "Organization";
            return;
        }

        if (table.Attributes?.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("Person".ToUpper())
            || table.Name.ToUpper().IndexOf("Person".ToUpper()) > 0))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = "Person";
                return;
            }
        }
        if (AdditionalPersonTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = "Person";
            return;
        }

        if (table.Attributes?.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("Role".ToUpper())
            || table.Name.ToUpper().IndexOf("Role".ToUpper()) > 0))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = "Role";
                return;
            }
        }
        if (AdditionalRoleTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = "Role";
            return;
        }
    }

    /// <summary>
    /// Return the list of autobahn entities from a list of types
    /// </summary>
    /// <returns>Return the list of Autobahn Entities</returns>
    private static List<AutobahnEntity> GetAutobahnEntities(
        List<Type> types, 
        List<AutobahnDomain> domains, 
        List<AutobahnTable> tables, 
        List<AutobahnElement> elements)
    {
        // iterate the known types and create a list of
        // autobahn types
        List<AutobahnEntity> autobahnEntities = new();

        foreach (var type in types)
        {
            if (!type.IsClass  
                || EntitiesToIgnore.Contains(type.Name))
            {
                continue;
            }

            var entity  = new AutobahnEntity(type);
            var globalId = tables.FirstOrDefault(t => t.TableName == entity.Name && string.IsNullOrEmpty(t.ColumnName.Trim()))?.GlobalId;
            entity.AutobahnElement = elements.FirstOrDefault(e => e.GlobalID == globalId);
            if (entity.Attributes.CommentAttribute == null)
            {
                if (!string.IsNullOrEmpty(entity.AutobahnElement?.Definition))
                {
                    entity.Attributes.CommentAttribute = new($"{entity.AutobahnElement?.Definition}");
                }
                else
                {
                    entity.Attributes.CommentAttribute = new($"The {entity.Name} ");
                }
            }
            SetTableDomain(domains, entity);
            foreach (var prop in entity.AutobahnProperties)
            {
                globalId = tables.FirstOrDefault(t => t.TableName == entity.Name && t.ColumnName == prop.Name)?.GlobalId;
                prop.AutobahnElement = elements.FirstOrDefault(e => e.GlobalID == globalId);
                if (!string.IsNullOrEmpty(prop.AutobahnElement?.Definition))
                {
                    prop.Attributes.CommentAttribute = new(prop.AutobahnElement.Definition);
                }
            }
            autobahnEntities.Add(entity);
        }

        foreach (var entity in autobahnEntities.Where(e => e.Attributes.TableAttribute.Schema == null))
        {
            entity.Attributes.TableAttribute.Schema = "Invalid";
        }

        var notcommon = autobahnEntities.Count(e => e.Attributes.TableAttribute.Schema != "Common");
        var common = autobahnEntities.Count(e => e.Attributes.TableAttribute.Schema == "Common");

        return autobahnEntities;
    }

    private static void SetDomain(List<AutobahnEntity> entities, AutobahnEntity entity, string module)
    {
        // If module != common the schema name is not the module name we
        // want to shift to then reset it and all of its foreign keys to 
        // common.  Basically if the  is in multiple domains move it
        // to common
        if (entity.Attributes?.TableAttribute.Schema != module)
        {
            entity.Attributes.TableAttribute.Schema = "Common";
        }

        // Put the domain and all of it's foreign keys into the same domain
        foreach (var prop in entity.AutobahnProperties.Where(p => p.Name.EndsWith("Id")))
        {
            var fkey = entities.FirstOrDefault(e => e.Name == prop.VirtualType);
            if (fkey != null)
            {
                if (fkey.Attributes.TableAttribute.Schema != module
                    && fkey.Attributes.TableAttribute.Schema != "Common")
                {
                    fkey.Attributes.TableAttribute.Schema = module;
                    SetDomain(entities, fkey, module);
                }
                prop.MapFKeyVirtualType();
            }
            else
            {
                if (!EntitiesToIgnore.Contains(prop.VirtualType))
                {
                    prop.Attributes.ObsoleteAttribute = new($"The {prop.VirtualType} property is obsolete and will be removed in a later version");
                }
            }
            prop.MapFKeyVirtualType();
        }
        entity.ResetEntityDomain();
    }

    static async Task Main(string[] args)
    {
        var csv = new CSVServices();
        var autobahnDomains = csv.ReadDomainsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnDomains.csv");
        var autobahnElements = csv.ReadAutobahnElementFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDSElements.csv");
        var autobahnTables = csv.ReadTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDStoNDSMapping.csv");

        // Autobahn Domains
        var autobahnEntites = GetAutobahnEntities(
            Assembly.GetExecutingAssembly().GetExportedTypes().OrderBy(o => o.Name).ToList(), 
            autobahnDomains, autobahnTables, autobahnElements);

        var schemaEntites = GetSchemaEntities(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\schemaorg-all-http.jsonld");

        var tickerlist = JsonConvert.DeserializeObject<List<Ticker>>(File.ReadAllText(@"C:\Users\drcarver\Desktop\codegen\FMP\Data\list.json"));
        int symbolLength = 0;
        int nameLength = 0;
        int exchangenameLength = 0;
        int exchangeshortnameLength = 0;
        List<string> tickertype = new();
        List<string> exchangeabbr = new();
        foreach (var ticker in tickerlist)
        {
            if (ticker.Symbol.Length > symbolLength) symbolLength = ticker.Symbol.Length;
            if (ticker.Name.Length > nameLength) nameLength = ticker.Name.Length;
            if (ticker.Exchange.Length > exchangenameLength) exchangenameLength = ticker.Exchange.Length;
            if (ticker.ExchangeShortName.Length > exchangeshortnameLength) exchangeshortnameLength = ticker.ExchangeShortName.Length;
            if (!tickertype.Contains(ticker.TickerType))
            {
                tickertype.Add(ticker.TickerType);
            }
            if (!exchangeabbr.Contains(ticker.Exchange))
            {
                exchangeabbr.Add(ticker.Exchange);
            }
        }

        Console.WriteLine($"TickerCount={tickerlist.Count()}");
        Console.WriteLine($"MaxSymbolLength={symbolLength}");
        Console.WriteLine($"MaxNameLength={nameLength}");
        Console.WriteLine($"MaxExchangeNameLength={exchangenameLength}");
        Console.WriteLine($"MaxExchangeShortNameLength={exchangeshortnameLength}");
        foreach (var item in tickertype)
        {
            Console.WriteLine($"{item}");
        }
        foreach (var item in exchangeabbr)
        {
            Console.WriteLine($"{item}");
        }

        //SeedOrganization();
        //SeedRefRecordStatusType();
        //SeedRefRecordStatusCreator();

        //var autobahnMarc = csv.ReadMarcReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\MarcRelator.csv");
        //            csv.WriteReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefMarcRelator.csv", autobahnMarc, false, "|");
        //var marc = autobahnTables.Where(t => t.TableName == "RefMarcRelator");
        //var RefAutobahnMarc = csv.ReadMarcReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefMarcRelator.csv").ToList();
        //var domainReferenceList = BuildTableListByProperty(autobahnTables);

        var location = $@"C:\Users\drcarver\Desktop\codegen\Autobahn\src\";
        MauiModule.GenerateModule(location, autobahnEntites, autobahnDomains);
    }

    private static List<AutobahnEntity> GetSchemaEntities(string location)
    {
        var domains = new Dictionary<string, List<string>>();
        Root SchemaOrg = JsonConvert.DeserializeObject<Root>(File.ReadAllText(location));

        // First build the list of entites and the domain
        // list that goes with them
        var graphlist = new List<AutobahnEntity>();
        foreach (var schema in SchemaOrg.Graph)
        {
            if (schema.SchemaType.Contains("rdfs:Class") && !schema.SchemaType.Contains("schema:DataType"))
            {
                var Name = FirstCharToUpper(schema.Id.Replace("schema:", string.Empty));
                var entity = graphlist.FirstOrDefault(e => e.Name == Name);
                if (entity == null)
                {
                    entity = new AutobahnEntity
                    {
                        Name = Name,
                    };
                    if (!string.IsNullOrEmpty(schema.RdfsComment))
                    {
                        entity.Attributes.CommentAttribute ??= new CommentAttribute(schema.RdfsComment);
                    }
                    if (schema.RdfsSubClassOf != null)
                    {
                        foreach (var subclass in schema.RdfsSubClassOf)
                        {
                            var subClassName = FirstCharToUpper(subclass.Id.Replace("schema:", string.Empty));
                            if (!entity.SubClass.Contains(subClassName) && subClassName != Name)
                            {
                                entity.SubClass.Add(subClassName);
                            }

                            // Update the domain map (entities that inherit from many others)
                            if (domains.ContainsKey(subClassName))
                            {
                                if (!domains[subClassName].Contains(Name))
                                {
                                    domains[subClassName].Add(Name);
                                }
                            }
                            else
                            {
                                domains.Add(subClassName, new List<string> { Name });
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(schema.RdfsLabel))
                    {
                        entity.Label = FirstCharToUpper(schema.RdfsLabel);
                    }
                    if (!entity.SubClass.Any())
                    {
                        entity.SubClass.Add("Base");
                    }
                    entity.Attributes.TableAttribute = new TableAttribute(entity.Name);
                    entity.SubClass.Add($"I{entity.Name}");
                    graphlist.Add(entity);
                }
            }
        }

        // Add the properties to the 
        foreach (var schema in SchemaOrg.Graph)
        {
            if (schema.SchemaType.Contains("rdf:Property"))
            {
                if (schema.SchemaDomainIncludes != null)
                {
                    foreach (var schemaName in schema.SchemaDomainIncludes)
                    {
                        var Name = FirstCharToUpper(schemaName.Id.Replace("schema:", string.Empty));
                        var entity = graphlist.FirstOrDefault(e => e.Name == Name);
                        if (entity != null)
                        {
                            var propName = FirstCharToUpper(schema.Id.Replace("schema:", string.Empty));
                            var prop = entity.AutobahnProperties.FirstOrDefault(p => p.Name == propName);
                            if (prop == null)
                            {
                                prop = new AutobahnProperty
                                {
                                    Name = propName,
                                    PropertyType = SchemaPropertyType(schema.SchemaRangeIncludes)

                                };
                                if (!string.IsNullOrEmpty(schema.RdfsComment))
                                {
                                    prop.Attributes.CommentAttribute ??= new CommentAttribute(schema.RdfsComment);
                                }
                                if (!string.IsNullOrEmpty(schema.RdfsLabel))
                                {
                                    entity.Label = FirstCharToUpper(schema.RdfsLabel);
                                }
                                var fk = graphlist.FirstOrDefault(e => e.Name == prop.PropertyType);
                                if (fk != null)
                                {
                                    var virtualProperty = new AutobahnProperty
                                    {
                                        Name = propName,
                                        PropertyType = propName,
                                        IsVirtual = true,
                                    };
                                    virtualProperty.Attributes.CommentAttribute = prop.Attributes.CommentAttribute;
                                    entity.AutobahnProperties.Add(virtualProperty);
                                    prop.Attributes.ForeignKeyAttribute = new ForeignKeyAttribute(prop.PropertyType);
                                    prop.Name = $"{prop.Name}Id";
                                    prop.PropertyType = "Guid";
                                }
                                entity.AutobahnProperties.Add(prop);
                            }
                        }
                    }
                }
            }
        }

        return graphlist;
    }

    private static AutobahnElement? GetMeta(string Name, 
        string propertyName, List<AutobahnTable> tables,
        List<AutobahnElement> elements)
    {
        AutobahnTable? tableMeta;
        if (string.IsNullOrEmpty(propertyName))
        {
            tableMeta = tables.FirstOrDefault(t => t.TableName == Name);
        }
        else
        {
            tableMeta = tables.FirstOrDefault(e => e.TableName == Name && e.ColumnName == propertyName);
        }
        AutobahnElement? element = null;
        if (!string.IsNullOrEmpty(tableMeta?.GlobalId))
        {
            foreach (var item in elements)
            {
                int intOut;
                Int32.TryParse(item.GlobalID, out intOut);
                if (intOut.ToString() == tableMeta?.GlobalId)
                {
                    return item;
                }
            }
        }
        return element;
    }

    private static string SchemaPropertyType(List<SchemaRangeIncludes> schemaRangeIncludes)
    {
        var nettype = string.Empty;
        foreach (var propType in schemaRangeIncludes)
        {
            switch (propType.Id)
            {
                case "schema:Text":
                    nettype = "string";
                    break;
                case "schema:Boolean":
                    nettype = "bool";
                    break;
                case "schema:Date":
                    nettype = "Date";
                    break;
                case "schema:DateTime":
                    nettype = "DateTime";
                    break;
                case "schema:Number":
                    nettype = "int";
                    break;
                case "schema:Time":
                    nettype = "Time";
                    break;
                default:
                    nettype = FirstCharToUpper(propType.Id.Replace("schema:", string.Empty));
                    break;
            }
        }
        return nettype;
    }

    //private static void SeedRefRecordStatusType()
    //{
    //    var csv = new CSVServices();
    //    using (var ctx = new AutobahnCommonContext())
    //    {
    //        var reftype = csv.ReadReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefRecordStatusType.csv");
    //        foreach (var item in reftype)
    //        {
    //            ctx.RefRecordStatusType.Add(new RefRecordStatusType
    //            {
    //                Id = item.Id, // ?? Guid.NewGuid(),
    //                Code = item.Code,
    //                Description = item.Description,
    //                Definition = item.Definition,
    //                SortOrder = item.SortOrder
    //            });
    //        }

    //        ctx.SaveChanges();
    //    }
    //}

    //private static void SeedRefRecordStatusCreator()
    //{
    //    var csv = new CSVServices();
    //    using (var ctx = new AutobahnCommonContext())
    //    {
    //        var reftype = csv.ReadReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefRecordStatusCreator.csv");
    //        foreach (var item in reftype)
    //        {
    //            ctx.RefRecordStatusCreator.Add(new RefRecordStatusCreator
    //            {
    //                Id = item.Id, // ?? Guid.NewGuid(),
    //                Code = item.Code,
    //                Description = item.Description,
    //                Definition = item.Definition,
    //                SortOrder = item.SortOrder
    //            });
    //        }

    //        ctx.SaveChanges();
    //    }
    //}

    //private static void SeedOrganization()
    //{
    //    using (var ctx = new AutobahnCommonContext())
    //    {
    //        // Autobahn
    //        var Organization = new Organization { Id = Guid.Parse("22B1FD25-AE5C-4B03-B463-284D0C1B49F5") };
    //        ctx.Organization.Add(Organization);

    //        // Project GutenBurg
    //        Organization = new Organization { Id = Guid.Parse("BC734F30-EADD-4456-9B34-8583ABC17CD0") };
    //        ctx.Organization.Add(Organization);

    //        ctx.SaveChanges();
    //    }
    //}

    //private static Dictionary<string, List<AutobahnTable>> BuildTableListByProperty(List<AutobahnTable> tables)
    //{
    //    var domainFiles = new Dictionary<string, List<AutobahnTable>>();
    //    foreach (var table in tables.Where(t => t.ColumnName.StartsWith("Ref") && t.ColumnName.EndsWith("Id")))
    //    {
    //        var columnKey = table.ColumnName.Replace("Id", string.Empty);
    //        if (columnKey.StartsWith("RefMarc"))
    //        {

    //        }
    //        if (domainFiles.ContainsKey(columnKey))
    //        {
    //            var exists = domainFiles.Values.Any(v => v.Any(t => t.TableName == table.TableName));
    //            if (!exists)
    //            {
    //                domainFiles[columnKey].Add(table);
    //            }
    //        }
    //        else
    //        {
    //            domainFiles.Add(columnKey, new List<AutobahnTable>());
    //            domainFiles[columnKey].Add(table);
    //        }
    //    }

    //    return  domainFiles;
    //}

    /// <summary>
    /// Convert a string to start with a upper case character
    /// </summary>
    /// <param name="value">The original string</param>
    /// <returns>The string with the first character converted to upper case</returns>
    public static string FirstCharToUpper(string value)
    {
        char[] array = value.ToCharArray();

        // Handle the first letter in the string.  
        if (array.Length >= 1)
        {
            if (char.IsLower(array[0]))
            {
                array[0] = char.ToUpper(array[0]);
            }
        }
        return new string(array);
    }

    /// <summary>
    /// Convert a string to start with a upper lower character
    /// </summary>
    /// <param name="value">The original string</param>
    /// <returns>The string with the first character converted to lower case</returns>
    public static string FirstCharToLower(string value)
    {
        char[] array = value.ToCharArray();

        // Handle the first letter in the string.  
        if (array.Length >= 1)
        {
            if (char.IsUpper(array[0]))
            {
                array[0] = char.ToLower(array[0]);
            }
        }
        return new string(array);
    }
}
