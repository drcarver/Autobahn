using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("Organization")]
    public partial class Organization
    {
        public Organization()
        {
            Activities = new HashSet<Activity>();
            AeProviders = new HashSet<AeProvider>();
            AssessmentAdministrationOrganizations = new HashSet<AssessmentAdministrationOrganization>();
            AssessmentRegistrationLeaOrganizations = new HashSet<AssessmentRegistration>();
            AssessmentRegistrationOrganizations = new HashSet<AssessmentRegistration>();
            AssessmentRegistrationSchoolOrganizations = new HashSet<AssessmentRegistration>();
            AssessmentSessionLeaOrganizations = new HashSet<AssessmentSession>();
            AssessmentSessionOrganizations = new HashSet<AssessmentSession>();
            AssessmentSessionSchoolOrganizations = new HashSet<AssessmentSession>();
            CourseSections = new HashSet<CourseSection>();
            Courses = new HashSet<Course>();
            CredentialAwards = new HashSet<CredentialAward>();
            CredentialDefAgents = new HashSet<CredentialDefAgent>();
            CredentialIssuers = new HashSet<CredentialIssuer>();
            EarlyChildhoodProgramTypeOffereds = new HashSet<EarlyChildhoodProgramTypeOffered>();
            ElclassSections = new HashSet<ElclassSection>();
            ElfacilityLicensings = new HashSet<ElfacilityLicensing>();
            ElorganizationAvailabilities = new HashSet<ElorganizationAvailability>();
            ElorganizationFunds = new HashSet<ElorganizationFund>();
            ElorganizationMonitorings = new HashSet<ElorganizationMonitoring>();
            Elorganizations = new HashSet<Elorganization>();
            ElprogramLicensings = new HashSet<ElprogramLicensing>();
            ElqualityInitiatives = new HashSet<ElqualityInitiative>();
            ElqualityRatingImprovements = new HashSet<ElqualityRatingImprovement>();
            ElservicePartners = new HashSet<ElservicePartner>();
            Facilities = new HashSet<Facility>();
            K12charterSchoolAuthorizerAgencies = new HashSet<K12charterSchoolAuthorizerAgency>();
            K12charterSchoolManagementOrganizations = new HashSet<K12charterSchoolManagementOrganization>();
            K12leas = new HashSet<K12lea>();
            K12programOrServices = new HashSet<K12programOrService>();
            K12schools = new HashSet<K12school>();
            K12seas = new HashSet<K12sea>();
            K12titleIiilanguageInstructions = new HashSet<K12titleIiilanguageInstruction>();
            LearnerActivityLeaOrganizations = new HashSet<LearnerActivity>();
            LearnerActivitySchoolOrganizations = new HashSet<LearnerActivity>();
            OrganizationAccreditations = new HashSet<OrganizationAccreditation>();
            OrganizationCalendarCrises = new HashSet<OrganizationCalendarCrisis>();
            OrganizationCalendars = new HashSet<OrganizationCalendar>();
            OrganizationDetails = new HashSet<OrganizationDetail>();
            OrganizationEmails = new HashSet<OrganizationEmail>();
            OrganizationEmployeeBenefits = new HashSet<OrganizationEmployeeBenefit>();
            OrganizationFederalAccountabilities = new HashSet<OrganizationFederalAccountability>();
            OrganizationIdentifiers = new HashSet<OrganizationIdentifier>();
            OrganizationImages = new HashSet<OrganizationImage>();
            OrganizationIndicators = new HashSet<OrganizationIndicator>();
            OrganizationLocations = new HashSet<OrganizationLocation>();
            OrganizationOperationalStatuses = new HashSet<OrganizationOperationalStatus>();
            OrganizationPersonRoles = new HashSet<OrganizationPersonRole>();
            OrganizationPolicies = new HashSet<OrganizationPolicy>();
            OrganizationPopulationServeds = new HashSet<OrganizationPopulationServed>();
            OrganizationProgramTypes = new HashSet<OrganizationProgramType>();
            OrganizationRelationshipOrganizations = new HashSet<OrganizationRelationship>();
            OrganizationRelationshipParentOrganizations = new HashSet<OrganizationRelationship>();
            OrganizationServices = new HashSet<OrganizationService>();
            OrganizationTechnicalAssistances = new HashSet<OrganizationTechnicalAssistance>();
            OrganizationTelephones = new HashSet<OrganizationTelephone>();
            OrganizationWebsites = new HashSet<OrganizationWebsite>();
            ProgramParticipationMigrants = new HashSet<ProgramParticipationMigrant>();
            Programs = new HashSet<Program>();
            PsInstitutions = new HashSet<PsInstitution>();
            PsPrograms = new HashSet<PsProgram>();
            RecordStatusHistories = new HashSet<RecordStatusHistory>();
            RecordStatuses = new HashSet<RecordStatus>();
            RefAbsentAttendanceCategories = new HashSet<RefAbsentAttendanceCategory>();
            RefAcademicAwardLevels = new HashSet<RefAcademicAwardLevel>();
            RefAcademicAwardPrerequisiteTypes = new HashSet<RefAcademicAwardPrerequisiteType>();
            RefAcademicHonorTypes = new HashSet<RefAcademicHonorType>();
            RefAcademicRanks = new HashSet<RefAcademicRank>();
            RefAcademicSubjects = new HashSet<RefAcademicSubject>();
            RefAcademicTermDesignators = new HashSet<RefAcademicTermDesignator>();
            RefAccommodationTypes = new HashSet<RefAccommodationType>();
            RefAccommodationsNeededTypes = new HashSet<RefAccommodationsNeededType>();
            RefAccreditationAgencies = new HashSet<RefAccreditationAgency>();
            RefActivityRecognitionTypes = new HashSet<RefActivityRecognitionType>();
            RefActivityTimeMeasurementTypes = new HashSet<RefActivityTimeMeasurementType>();
            RefAdditionalCreditTypes = new HashSet<RefAdditionalCreditType>();
            RefAdditionalTargetedSupportAndImprovementStatuses = new HashSet<RefAdditionalTargetedSupportAndImprovementStatus>();
            RefAddressTypes = new HashSet<RefAddressType>();
            RefAdministrativeFundingControls = new HashSet<RefAdministrativeFundingControl>();
            RefAdmissionConsiderationLevels = new HashSet<RefAdmissionConsiderationLevel>();
            RefAdmissionConsiderationTypes = new HashSet<RefAdmissionConsiderationType>();
            RefAdmittedStudents = new HashSet<RefAdmittedStudent>();
            RefAdultEducationProgramExitReasons = new HashSet<RefAdultEducationProgramExitReason>();
            RefAdvancedPlacementCourseCodes = new HashSet<RefAdvancedPlacementCourseCode>();
            RefAeCertificationTypes = new HashSet<RefAeCertificationType>();
            RefAeFunctioningLevelAtIntakes = new HashSet<RefAeFunctioningLevelAtIntake>();
            RefAeFunctioningLevelAtPosttests = new HashSet<RefAeFunctioningLevelAtPosttest>();
            RefAeInstructionalProgramTypes = new HashSet<RefAeInstructionalProgramType>();
            RefAePostsecondaryTransitionActions = new HashSet<RefAePostsecondaryTransitionAction>();
            RefAeSpecialProgramTypes = new HashSet<RefAeSpecialProgramType>();
            RefAeStaffClassifications = new HashSet<RefAeStaffClassification>();
            RefAeStaffEmploymentStatuses = new HashSet<RefAeStaffEmploymentStatus>();
            RefAllergySeverities = new HashSet<RefAllergySeverity>();
            RefAllergyTypes = new HashSet<RefAllergyType>();
            RefAltRouteToCertificationOrLicensures = new HashSet<RefAltRouteToCertificationOrLicensure>();
            RefAlternateFundUses = new HashSet<RefAlternateFundUse>();
            RefAlternativeSchoolFoci = new HashSet<RefAlternativeSchoolFocus>();
            RefAmaoAttainmentStatuses = new HashSet<RefAmaoAttainmentStatus>();
            RefApipInteractionTypes = new HashSet<RefApipInteractionType>();
            RefAssessmentAssetIdentifierTypes = new HashSet<RefAssessmentAssetIdentifierType>();
            RefAssessmentAssetTypes = new HashSet<RefAssessmentAssetType>();
            RefAssessmentEldevelopmentalDomains = new HashSet<RefAssessmentEldevelopmentalDomain>();
            RefAssessmentFormSectionIdentificationSystems = new HashSet<RefAssessmentFormSectionIdentificationSystem>();
            RefAssessmentItemCharacteristicTypes = new HashSet<RefAssessmentItemCharacteristicType>();
            RefAssessmentItemResponseScoreStatuses = new HashSet<RefAssessmentItemResponseScoreStatus>();
            RefAssessmentItemResponseStatuses = new HashSet<RefAssessmentItemResponseStatus>();
            RefAssessmentItemTypes = new HashSet<RefAssessmentItemType>();
            RefAssessmentNeedAlternativeRepresentationTypes = new HashSet<RefAssessmentNeedAlternativeRepresentationType>();
            RefAssessmentNeedBrailleGradeTypes = new HashSet<RefAssessmentNeedBrailleGradeType>();
            RefAssessmentNeedBrailleMarkTypes = new HashSet<RefAssessmentNeedBrailleMarkType>();
            RefAssessmentNeedBrailleStatusCellTypes = new HashSet<RefAssessmentNeedBrailleStatusCellType>();
            RefAssessmentNeedHazardTypes = new HashSet<RefAssessmentNeedHazardType>();
            RefAssessmentNeedIncreasedWhitespacingTypes = new HashSet<RefAssessmentNeedIncreasedWhitespacingType>();
            RefAssessmentNeedLanguageLearnerTypes = new HashSet<RefAssessmentNeedLanguageLearnerType>();
            RefAssessmentNeedLinkIndicationTypes = new HashSet<RefAssessmentNeedLinkIndicationType>();
            RefAssessmentNeedMaskingTypes = new HashSet<RefAssessmentNeedMaskingType>();
            RefAssessmentNeedNumberOfBrailleDots = new HashSet<RefAssessmentNeedNumberOfBrailleDot>();
            RefAssessmentNeedSigningTypes = new HashSet<RefAssessmentNeedSigningType>();
            RefAssessmentNeedSpokenSourcePreferenceTypes = new HashSet<RefAssessmentNeedSpokenSourcePreferenceType>();
            RefAssessmentNeedSupportTools = new HashSet<RefAssessmentNeedSupportTool>();
            RefAssessmentNeedUsageTypes = new HashSet<RefAssessmentNeedUsageType>();
            RefAssessmentNeedUserSpokenPreferenceTypes = new HashSet<RefAssessmentNeedUserSpokenPreferenceType>();
            RefAssessmentParticipationIndicators = new HashSet<RefAssessmentParticipationIndicator>();
            RefAssessmentPlatformTypes = new HashSet<RefAssessmentPlatformType>();
            RefAssessmentPretestOutcomes = new HashSet<RefAssessmentPretestOutcome>();
            RefAssessmentPurposes = new HashSet<RefAssessmentPurpose>();
            RefAssessmentReasonNotCompletings = new HashSet<RefAssessmentReasonNotCompleting>();
            RefAssessmentReasonNotTesteds = new HashSet<RefAssessmentReasonNotTested>();
            RefAssessmentRegistrationCompletionStatuses = new HashSet<RefAssessmentRegistrationCompletionStatus>();
            RefAssessmentReportingMethods = new HashSet<RefAssessmentReportingMethod>();
            RefAssessmentResultDataTypes = new HashSet<RefAssessmentResultDataType>();
            RefAssessmentResultScoreTypes = new HashSet<RefAssessmentResultScoreType>();
            RefAssessmentSessionSpecialCircumstanceTypes = new HashSet<RefAssessmentSessionSpecialCircumstanceType>();
            RefAssessmentSessionStaffRoleTypes = new HashSet<RefAssessmentSessionStaffRoleType>();
            RefAssessmentSessionTypes = new HashSet<RefAssessmentSessionType>();
            RefAssessmentSubtestIdentifierTypes = new HashSet<RefAssessmentSubtestIdentifierType>();
            RefAssessmentTypeChildrenWithDisabilities = new HashSet<RefAssessmentTypeChildrenWithDisability>();
            RefAssessmentTypes = new HashSet<RefAssessmentType>();
            RefAttendanceEventTypes = new HashSet<RefAttendanceEventType>();
            RefAttendanceStatuses = new HashSet<RefAttendanceStatus>();
            RefAuthorizerTypes = new HashSet<RefAuthorizerType>();
            RefAypStatuses = new HashSet<RefAypStatus>();
            RefBarrierToEducatingHomelesses = new HashSet<RefBarrierToEducatingHomeless>();
            RefBarrierToInternetAccessInResidences = new HashSet<RefBarrierToInternetAccessInResidence>();
            RefBillableBasisTypes = new HashSet<RefBillableBasisType>();
            RefBlendedLearningModelTypes = new HashSet<RefBlendedLearningModelType>();
            RefBloomsTaxonomyDomains = new HashSet<RefBloomsTaxonomyDomain>();
            RefBuildingAdministrativeSpaceTypes = new HashSet<RefBuildingAdministrativeSpaceType>();
            RefBuildingAirDistributionSystemTypes = new HashSet<RefBuildingAirDistributionSystemType>();
            RefBuildingArtSpecialtySpaceTypes = new HashSet<RefBuildingArtSpecialtySpaceType>();
            RefBuildingAssemblySpaceTypes = new HashSet<RefBuildingAssemblySpaceType>();
            RefBuildingBasicClassroomDesignTypes = new HashSet<RefBuildingBasicClassroomDesignType>();
            RefBuildingCareerTechEducationSpaceTypes = new HashSet<RefBuildingCareerTechEducationSpaceType>();
            RefBuildingCharterSchoolRealtyAccessTypes = new HashSet<RefBuildingCharterSchoolRealtyAccessType>();
            RefBuildingCirculationSpaceTypes = new HashSet<RefBuildingCirculationSpaceType>();
            RefBuildingCleaningStandardTypes = new HashSet<RefBuildingCleaningStandardType>();
            RefBuildingCommMgmtComponentSystemTypes = new HashSet<RefBuildingCommMgmtComponentSystemType>();
            RefBuildingCommunityUseSpaceTypes = new HashSet<RefBuildingCommunityUseSpaceType>();
            RefBuildingCoolingGenerationSystemTypes = new HashSet<RefBuildingCoolingGenerationSystemType>();
            RefBuildingDesignTypes = new HashSet<RefBuildingDesignType>();
            RefBuildingElectricalSystemTypes = new HashSet<RefBuildingElectricalSystemType>();
            RefBuildingEnergyConservationMeasureTypes = new HashSet<RefBuildingEnergyConservationMeasureType>();
            RefBuildingEnergySourceTypes = new HashSet<RefBuildingEnergySourceType>();
            RefBuildingEnvOrEnergyPerformanceRatingCats = new HashSet<RefBuildingEnvOrEnergyPerformanceRatingCat>();
            RefBuildingFireProtectionSystemTypes = new HashSet<RefBuildingFireProtectionSystemType>();
            RefBuildingFoodServiceSpaceTypes = new HashSet<RefBuildingFoodServiceSpaceType>();
            RefBuildingFullServiceKitchenTypes = new HashSet<RefBuildingFullServiceKitchenType>();
            RefBuildingHeatingGenerationSystemTypes = new HashSet<RefBuildingHeatingGenerationSystemType>();
            RefBuildingHistoricStatuses = new HashSet<RefBuildingHistoricStatus>();
            RefBuildingHvacsystemTypes = new HashSet<RefBuildingHvacsystemType>();
            RefBuildingIndoorAthleticOrPhysEdSpaceTypes = new HashSet<RefBuildingIndoorAthleticOrPhysEdSpaceType>();
            RefBuildingInstructionalSpaceFactorTypes = new HashSet<RefBuildingInstructionalSpaceFactorType>();
            RefBuildingJointUseRationaleTypes = new HashSet<RefBuildingJointUseRationaleType>();
            RefBuildingJointUseSchedulingTypes = new HashSet<RefBuildingJointUseSchedulingType>();
            RefBuildingJointUserTypes = new HashSet<RefBuildingJointUserType>();
            RefBuildingLibMediaCenterSpecialtySpaceTypes = new HashSet<RefBuildingLibMediaCenterSpecialtySpaceType>();
            RefBuildingMechanicalConveyingSystemTypes = new HashSet<RefBuildingMechanicalConveyingSystemType>();
            RefBuildingMechanicalSystemTypes = new HashSet<RefBuildingMechanicalSystemType>();
            RefBuildingOperationsOrMaintSpaceTypes = new HashSet<RefBuildingOperationsOrMaintSpaceType>();
            RefBuildingOutdoorAthleticOrPhysEdSpaceTypes = new HashSet<RefBuildingOutdoorAthleticOrPhysEdSpaceType>();
            RefBuildingOutdoorOrNonathleticSpaceTypes = new HashSet<RefBuildingOutdoorOrNonathleticSpaceType>();
            RefBuildingPerformingArtsSpecialtySpaceTypes = new HashSet<RefBuildingPerformingArtsSpecialtySpaceType>();
            RefBuildingPlumbingSystemTypes = new HashSet<RefBuildingPlumbingSystemType>();
            RefBuildingPrimaryUseTypes = new HashSet<RefBuildingPrimaryUseType>();
            RefBuildingSchoolDesignTypes = new HashSet<RefBuildingSchoolDesignType>();
            RefBuildingScienceSpecialtySpaceTypes = new HashSet<RefBuildingScienceSpecialtySpaceType>();
            RefBuildingSecuritySystemTypes = new HashSet<RefBuildingSecuritySystemType>();
            RefBuildingSiteUseRestrictionsTypes = new HashSet<RefBuildingSiteUseRestrictionsType>();
            RefBuildingSpaceDesignTypes = new HashSet<RefBuildingSpaceDesignType>();
            RefBuildingSpecEdSpecialtySpaceTypes = new HashSet<RefBuildingSpecEdSpecialtySpaceType>();
            RefBuildingStudentSupportSpaceTypes = new HashSet<RefBuildingStudentSupportSpaceType>();
            RefBuildingSystemTypes = new HashSet<RefBuildingSystemType>();
            RefBuildingTechnologyWiringSystemTypes = new HashSet<RefBuildingTechnologyWiringSystemType>();
            RefBuildingUseTypes = new HashSet<RefBuildingUseType>();
            RefBuildingVerticalTransportationSystemTypes = new HashSet<RefBuildingVerticalTransportationSystemType>();
            RefCalendarEventTypes = new HashSet<RefCalendarEventType>();
            RefCampusResidencyTypes = new HashSet<RefCampusResidencyType>();
            RefCampusStatuses = new HashSet<RefCampusStatus>();
            RefCampusTypes = new HashSet<RefCampusType>();
            RefCareerClusters = new HashSet<RefCareerCluster>();
            RefCareerEducationPlanTypes = new HashSet<RefCareerEducationPlanType>();
            RefCarnegieBasicClassifications = new HashSet<RefCarnegieBasicClassification>();
            RefCharterLeaStatuses = new HashSet<RefCharterLeaStatus>();
            RefCharterSchoolAuthorizerTypes = new HashSet<RefCharterSchoolAuthorizerType>();
            RefCharterSchoolManagementOrganizationTypes = new HashSet<RefCharterSchoolManagementOrganizationType>();
            RefCharterSchoolTypes = new HashSet<RefCharterSchoolType>();
            RefChildDevelopmentAssociateTypes = new HashSet<RefChildDevelopmentAssociateType>();
            RefChildDevelopmentalScreeningStatuses = new HashSet<RefChildDevelopmentalScreeningStatus>();
            RefChildOutcomesSummaryRatings = new HashSet<RefChildOutcomesSummaryRating>();
            RefCipCodes = new HashSet<RefCipCode>();
            RefCipUses = new HashSet<RefCipUse>();
            RefCipVersions = new HashSet<RefCipVersion>();
            RefClassroomPositionTypes = new HashSet<RefClassroomPositionType>();
            RefCohortExclusions = new HashSet<RefCohortExclusion>();
            RefCommunicationMethods = new HashSet<RefCommunicationMethod>();
            RefCommunityBasedTypes = new HashSet<RefCommunityBasedType>();
            RefCompetencyDefAssociationTypes = new HashSet<RefCompetencyDefAssociationType>();
            RefCompetencyDefNodeAccessibilityProfiles = new HashSet<RefCompetencyDefNodeAccessibilityProfile>();
            RefCompetencyDefTestabilityTypes = new HashSet<RefCompetencyDefTestabilityType>();
            RefCompetencyFrameworkPublicationStatuses = new HashSet<RefCompetencyFrameworkPublicationStatus>();
            RefCompetencySetCompletionCriteria = new HashSet<RefCompetencySetCompletionCriterion>();
            RefComprehensiveAndTargetedSupports = new HashSet<RefComprehensiveAndTargetedSupport>();
            RefComprehensiveSupportAndImprovementStatuses = new HashSet<RefComprehensiveSupportAndImprovementStatus>();
            RefComprehensiveSupports = new HashSet<RefComprehensiveSupport>();
            RefContentStandardTypes = new HashSet<RefContentStandardType>();
            RefContinuationOfServices = new HashSet<RefContinuationOfService>();
            RefControlOfInstitutions = new HashSet<RefControlOfInstitution>();
            RefCoreKnowledgeAreas = new HashSet<RefCoreKnowledgeArea>();
            RefCorrectionalEducationFacilityTypes = new HashSet<RefCorrectionalEducationFacilityType>();
            RefCorrectiveActionTypes = new HashSet<RefCorrectiveActionType>();
            RefCounties = new HashSet<RefCounty>();
            RefCountries = new HashSet<RefCountry>();
            RefCourseAcademicGradeStatusCodes = new HashSet<RefCourseAcademicGradeStatusCode>();
            RefCourseApplicableEducationLevels = new HashSet<RefCourseApplicableEducationLevel>();
            RefCourseCreditBasisTypes = new HashSet<RefCourseCreditBasisType>();
            RefCourseCreditLevelTypes = new HashSet<RefCourseCreditLevelType>();
            RefCourseCreditUnits = new HashSet<RefCourseCreditUnit>();
            RefCourseGpaApplicabilities = new HashSet<RefCourseGpaApplicability>();
            RefCourseHonorsTypes = new HashSet<RefCourseHonorsType>();
            RefCourseInstructionMethods = new HashSet<RefCourseInstructionMethod>();
            RefCourseInstructionSiteTypes = new HashSet<RefCourseInstructionSiteType>();
            RefCourseInteractionModes = new HashSet<RefCourseInteractionMode>();
            RefCourseLevelCharacteristics = new HashSet<RefCourseLevelCharacteristic>();
            RefCourseLevelTypes = new HashSet<RefCourseLevelType>();
            RefCourseRepeatCodes = new HashSet<RefCourseRepeatCode>();
            RefCourseSectionAssessmentReportingMethods = new HashSet<RefCourseSectionAssessmentReportingMethod>();
            RefCourseSectionDeliveryModes = new HashSet<RefCourseSectionDeliveryMode>();
            RefCourseSectionEnrollmentStatusTypes = new HashSet<RefCourseSectionEnrollmentStatusType>();
            RefCourseSectionEntryTypes = new HashSet<RefCourseSectionEntryType>();
            RefCourseSectionExitTypes = new HashSet<RefCourseSectionExitType>();
            RefCredentialDefAgentRoleTypes = new HashSet<RefCredentialDefAgentRoleType>();
            RefCredentialDefAssessMethodTypes = new HashSet<RefCredentialDefAssessMethodType>();
            RefCredentialDefIntendedPurposeTypes = new HashSet<RefCredentialDefIntendedPurposeType>();
            RefCredentialDefStatusTypes = new HashSet<RefCredentialDefStatusType>();
            RefCredentialDefVerificationTypes = new HashSet<RefCredentialDefVerificationType>();
            RefCredentialIdentifierSystems = new HashSet<RefCredentialIdentifierSystem>();
            RefCredentialTypes = new HashSet<RefCredentialType>();
            RefCreditHoursAppliedOtherPrograms = new HashSet<RefCreditHoursAppliedOtherProgram>();
            RefCreditTypeEarneds = new HashSet<RefCreditTypeEarned>();
            RefCriticalTeacherShortageCandidates = new HashSet<RefCriticalTeacherShortageCandidate>();
            RefCtdlaudienceLevelTypes = new HashSet<RefCtdlaudienceLevelType>();
            RefCtdlorganizationTypes = new HashSet<RefCtdlorganizationType>();
            RefCteGraduationRateInclusions = new HashSet<RefCteGraduationRateInclusion>();
            RefCteNonTraditionalGenderStatuses = new HashSet<RefCteNonTraditionalGenderStatus>();
            RefCurriculumFrameworkTypes = new HashSet<RefCurriculumFrameworkType>();
            RefDataCollectionStatuses = new HashSet<RefDataCollectionStatus>();
            RefDegreeOrCertificateTypes = new HashSet<RefDegreeOrCertificateType>();
            RefDentalInsuranceCoverageTypes = new HashSet<RefDentalInsuranceCoverageType>();
            RefDentalScreeningStatuses = new HashSet<RefDentalScreeningStatus>();
            RefDependencyStatuses = new HashSet<RefDependencyStatus>();
            RefDevelopmentalEducationReferralStatuses = new HashSet<RefDevelopmentalEducationReferralStatus>();
            RefDevelopmentalEducationTypes = new HashSet<RefDevelopmentalEducationType>();
            RefDevelopmentalEvaluationFindings = new HashSet<RefDevelopmentalEvaluationFinding>();
            RefDirectoryInformationBlockStatuses = new HashSet<RefDirectoryInformationBlockStatus>();
            RefDisabilityConditionStatusCodes = new HashSet<RefDisabilityConditionStatusCode>();
            RefDisabilityConditionTypes = new HashSet<RefDisabilityConditionType>();
            RefDisabilityDeterminationSourceTypes = new HashSet<RefDisabilityDeterminationSourceType>();
            RefDisabilityTypes = new HashSet<RefDisabilityType>();
            RefDisciplinaryActionTakens = new HashSet<RefDisciplinaryActionTaken>();
            RefDisciplineLengthDifferenceReasons = new HashSet<RefDisciplineLengthDifferenceReason>();
            RefDisciplineMethodFirearms = new HashSet<RefDisciplineMethodFirearm>();
            RefDisciplineMethodOfCwds = new HashSet<RefDisciplineMethodOfCwd>();
            RefDisciplineReasons = new HashSet<RefDisciplineReason>();
            RefDistanceEducationCourseEnrollments = new HashSet<RefDistanceEducationCourseEnrollment>();
            RefDoctoralExamsRequiredCodes = new HashSet<RefDoctoralExamsRequiredCode>();
            RefDqpcategoriesOfLearnings = new HashSet<RefDqpcategoriesOfLearning>();
            RefEarlyChildhoodCredentials = new HashSet<RefEarlyChildhoodCredential>();
            RefEarlyChildhoodProgramEnrollmentTypes = new HashSet<RefEarlyChildhoodProgramEnrollmentType>();
            RefEarlyChildhoodServices = new HashSet<RefEarlyChildhoodService>();
            RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypes = new HashSet<RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType>();
            RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypes = new HashSet<RefEdFactsAcademicOrCareerAndTechnicalOutcomeType>();
            RefEdfactsTeacherInexperiencedStatuses = new HashSet<RefEdfactsTeacherInexperiencedStatus>();
            RefEducationLevelTypes = new HashSet<RefEducationLevelType>();
            RefEducationLevels = new HashSet<RefEducationLevel>();
            RefEducationVerificationMethods = new HashSet<RefEducationVerificationMethod>();
            RefEleducationStaffClassifications = new HashSet<RefEleducationStaffClassification>();
            RefElementaryMiddleAdditionals = new HashSet<RefElementaryMiddleAdditional>();
            RefElemploymentSeparationReasons = new HashSet<RefElemploymentSeparationReason>();
            RefElfacilityLicensingStatuses = new HashSet<RefElfacilityLicensingStatus>();
            RefElfederalFundingTypes = new HashSet<RefElfederalFundingType>();
            RefElgroupSizeStandardMets = new HashSet<RefElgroupSizeStandardMet>();
            RefEllevelOfSpecializations = new HashSet<RefEllevelOfSpecialization>();
            RefEllocalRevenueSources = new HashSet<RefEllocalRevenueSource>();
            RefElotherFederalFundingSources = new HashSet<RefElotherFederalFundingSource>();
            RefEloutcomeMeasurementLevels = new HashSet<RefEloutcomeMeasurementLevel>();
            RefElprofessionalDevelopmentTopicAreas = new HashSet<RefElprofessionalDevelopmentTopicArea>();
            RefElprogramEligibilities = new HashSet<RefElprogramEligibility>();
            RefElprogramEligibilityStatuses = new HashSet<RefElprogramEligibilityStatus>();
            RefElprogramLicenseStatuses = new HashSet<RefElprogramLicenseStatus>();
            RefElserviceProfessionalStaffClassifications = new HashSet<RefElserviceProfessionalStaffClassification>();
            RefElserviceTypes = new HashSet<RefElserviceType>();
            RefElstateRevenueSources = new HashSet<RefElstateRevenueSource>();
            RefEltrainerCoreKnowledgeAreas = new HashSet<RefEltrainerCoreKnowledgeArea>();
            RefEmailTypes = new HashSet<RefOrganizationEmailType>();
            RefEmergencyOrProvisionalCredentialStatuses = new HashSet<RefEmergencyOrProvisionalCredentialStatus>();
            RefEmployedAfterExits = new HashSet<RefEmployedAfterExit>();
            RefEmployedPriorToEnrollments = new HashSet<RefEmployedPriorToEnrollment>();
            RefEmployedWhileEnrolleds = new HashSet<RefEmployedWhileEnrolled>();
            RefEmployeeBenefits = new HashSet<RefEmployeeBenefit>();
            RefEmploymentContractTypes = new HashSet<RefEmploymentContractType>();
            RefEmploymentSeparationReasons = new HashSet<RefEmploymentSeparationReason>();
            RefEmploymentSeparationTypes = new HashSet<RefEmploymentSeparationType>();
            RefEmploymentStatusWhileEnrolleds = new HashSet<RefEmploymentStatusWhileEnrolled>();
            RefEmploymentStatuses = new HashSet<RefEmploymentStatus>();
            RefEndOfTermStatuses = new HashSet<RefEndOfTermStatus>();
            RefEnrollmentStatuses = new HashSet<RefEnrollmentStatus>();
            RefEntityTypes = new HashSet<RefEntityType>();
            RefEntryTypes = new HashSet<RefEntryType>();
            RefEnvironmentSettings = new HashSet<RefEnvironmentSetting>();
            RefEradministrativeDataSources = new HashSet<RefEradministrativeDataSource>();
            RefErsruralUrbanContinuumCodes = new HashSet<RefErsruralUrbanContinuumCode>();
            RefExitOrWithdrawalStatuses = new HashSet<RefExitOrWithdrawalStatus>();
            RefExitOrWithdrawalTypes = new HashSet<RefExitOrWithdrawalType>();
            RefFacilitiesMandateAuthorityTypes = new HashSet<RefFacilitiesMandateAuthorityType>();
            RefFacilitiesMgmtEmergencyTypes = new HashSet<RefFacilitiesMgmtEmergencyType>();
            RefFacilitiesPlanTypes = new HashSet<RefFacilitiesPlanType>();
            RefFacilityApplicableFederalMandateTypes = new HashSet<RefFacilityApplicableFederalMandateType>();
            RefFacilityAuditTypes = new HashSet<RefFacilityAuditType>();
            RefFacilityCapitalProgramMgmtTypes = new HashSet<RefFacilityCapitalProgramMgmtType>();
            RefFacilityComplianceAgencyTypes = new HashSet<RefFacilityComplianceAgencyType>();
            RefFacilityComplianceStatuses = new HashSet<RefFacilityComplianceStatus>();
            RefFacilityConstructionDateTypes = new HashSet<RefFacilityConstructionDateType>();
            RefFacilityConstructionMaterialTypes = new HashSet<RefFacilityConstructionMaterialType>();
            RefFacilityFederalMandateInterestTypes = new HashSet<RefFacilityFederalMandateInterestType>();
            RefFacilityFinancingFeeTypes = new HashSet<RefFacilityFinancingFeeType>();
            RefFacilityFurnishingsTypes = new HashSet<RefFacilityFurnishingsType>();
            RefFacilityHazardousMaterialsOrCondTypes = new HashSet<RefFacilityHazardousMaterialsOrCondType>();
            RefFacilityJointDevelopmentTypes = new HashSet<RefFacilityJointDevelopmentType>();
            RefFacilityLeaseAmountCategories = new HashSet<RefFacilityLeaseAmountCategory>();
            RefFacilityLeaseTypes = new HashSet<RefFacilityLeaseType>();
            RefFacilityMaintStandardTypes = new HashSet<RefFacilityMaintStandardType>();
            RefFacilityMortgageInterestTypes = new HashSet<RefFacilityMortgageInterestType>();
            RefFacilityMortgageTypes = new HashSet<RefFacilityMortgageType>();
            RefFacilityNaturallyOccurringHazardTypes = new HashSet<RefFacilityNaturallyOccurringHazardType>();
            RefFacilityOperationsMgmtTypes = new HashSet<RefFacilityOperationsMgmtType>();
            RefFacilitySiteImprovementLocationTypes = new HashSet<RefFacilitySiteImprovementLocationType>();
            RefFacilitySiteOutdoorAreaTypes = new HashSet<RefFacilitySiteOutdoorAreaType>();
            RefFacilityStandardTypes = new HashSet<RefFacilityStandardType>();
            RefFacilityStateOrLocalMandateInterestTypes = new HashSet<RefFacilityStateOrLocalMandateInterestType>();
            RefFacilitySystemOrComponentConditions = new HashSet<RefFacilitySystemOrComponentCondition>();
            RefFacilityUtilityProviderTypes = new HashSet<RefFacilityUtilityProviderType>();
            RefFacilityUtilityTypes = new HashSet<RefFacilityUtilityType>();
            RefFamilyIncomeSources = new HashSet<RefFamilyIncomeSource>();
            RefFederalProgramFundingAllocationTypes = new HashSet<RefFederalProgramFundingAllocationType>();
            RefFinancialAccountBalanceSheetCodes = new HashSet<RefFinancialAccountBalanceSheetCode>();
            RefFinancialAccountCategories = new HashSet<RefFinancialAccountCategory>();
            RefFinancialAccountFundClassifications = new HashSet<RefFinancialAccountFundClassification>();
            RefFinancialAccountProgramCodes = new HashSet<RefFinancialAccountProgramCode>();
            RefFinancialAccountRevenueCodes = new HashSet<RefFinancialAccountRevenueCode>();
            RefFinancialAidApplicationTypes = new HashSet<RefFinancialAidApplicationType>();
            RefFinancialAidAwardStatuses = new HashSet<RefFinancialAidAwardStatus>();
            RefFinancialAidAwardTypes = new HashSet<RefFinancialAidAwardType>();
            RefFinancialAidVeteransBenefitStatuses = new HashSet<RefFinancialAidVeteransBenefitStatus>();
            RefFinancialAidVeteransBenefitTypes = new HashSet<RefFinancialAidVeteransBenefitType>();
            RefFinancialExpenditureFunctionCodes = new HashSet<RefFinancialExpenditureFunctionCode>();
            RefFinancialExpenditureLevelOfInstructionCodes = new HashSet<RefFinancialExpenditureLevelOfInstructionCode>();
            RefFinancialExpenditureObjectCodes = new HashSet<RefFinancialExpenditureObjectCode>();
            RefFirearmTypes = new HashSet<RefFirearmType>();
            RefFoodServiceEligibilities = new HashSet<RefFoodServiceEligibility>();
            RefFoodServiceParticipations = new HashSet<RefFoodServiceParticipation>();
            RefFrequencyOfServices = new HashSet<RefFrequencyOfService>();
            RefFrequencyUnits = new HashSet<RefFrequencyUnit>();
            RefFullTimeStatuses = new HashSet<RefFullTimeStatus>();
            RefGoalMeasurementTypes = new HashSet<RefGoalMeasurementType>();
            RefGoalStatusTypes = new HashSet<RefGoalStatusType>();
            RefGoalsForAttendingAdultEducations = new HashSet<RefGoalsForAttendingAdultEducation>();
            RefGpaWeightedIndicators = new HashSet<RefGpaWeightedIndicator>();
            RefGradeLevelTypes = new HashSet<RefGradeLevelType>();
            RefGradeLevels = new HashSet<RefGradeLevel>();
            RefGradeLevelsApproveds = new HashSet<RefGradeLevelsApproved>();
            RefGradePointAverageDomains = new HashSet<RefGradePointAverageDomain>();
            RefGraduateAssistantIpedsCategories = new HashSet<RefGraduateAssistantIpedsCategory>();
            RefGraduateOrDoctoralExamResultsStatuses = new HashSet<RefGraduateOrDoctoralExamResultsStatus>();
            RefGunFreeSchoolsActReportingStatuses = new HashSet<RefGunFreeSchoolsActReportingStatus>();
            RefHealthInsuranceCoverages = new HashSet<RefHealthInsuranceCoverage>();
            RefHearingScreeningStatuses = new HashSet<RefHearingScreeningStatus>();
            RefHighSchoolDiplomaDistinctionTypes = new HashSet<RefHighSchoolDiplomaDistinctionType>();
            RefHighSchoolDiplomaTypes = new HashSet<RefHighSchoolDiplomaType>();
            RefHighSchoolGraduationRateIndicators = new HashSet<RefHighSchoolGraduationRateIndicator>();
            RefHigherEducationInstitutionAccreditationStatuses = new HashSet<RefHigherEducationInstitutionAccreditationStatus>();
            RefHomelessNighttimeResidences = new HashSet<RefHomelessNighttimeResidence>();
            RefIdeadisabilityTypes = new HashSet<RefIdeadisabilityType>();
            RefIdeadisciplineMethodFirearms = new HashSet<RefIdeadisciplineMethodFirearm>();
            RefIdeaeducationalEnvironmentEcs = new HashSet<RefIdeaeducationalEnvironmentEc>();
            RefIdeaeducationalEnvironmentSchoolAges = new HashSet<RefIdeaeducationalEnvironmentSchoolAge>();
            RefIdeaeligibilityEvaluationCategories = new HashSet<RefIdeaeligibilityEvaluationCategory>();
            RefIdeaenvironmentEls = new HashSet<RefIdeaenvironmentEl>();
            RefIdeaiepstatuses = new HashSet<RefIdeaiepstatus>();
            RefIdeainterimRemovalReasons = new HashSet<RefIdeainterimRemovalReason>();
            RefIdeainterimRemovals = new HashSet<RefIdeainterimRemoval>();
            RefIdeapartCeligibilityCategories = new HashSet<RefIdeapartCeligibilityCategory>();
            RefIepauthorizationDocumentTypes = new HashSet<RefIepauthorizationDocumentType>();
            RefIepeligibilityEvaluationTypes = new HashSet<RefIepeligibilityEvaluationType>();
            RefIepgoalTypes = new HashSet<RefIepgoalType>();
            RefImmunizationTypes = new HashSet<RefImmunizationType>();
            RefIncidentBehaviorSecondaries = new HashSet<RefIncidentBehaviorSecondary>();
            RefIncidentBehaviors = new HashSet<RefIncidentBehavior>();
            RefIncidentInjuryTypes = new HashSet<RefIncidentInjuryType>();
            RefIncidentLocations = new HashSet<RefIncidentLocation>();
            RefIncidentMultipleOffenseTypes = new HashSet<RefIncidentMultipleOffenseType>();
            RefIncidentPerpetratorInjuryTypes = new HashSet<RefIncidentPerpetratorInjuryType>();
            RefIncidentPersonRoleTypes = new HashSet<RefIncidentPersonRoleType>();
            RefIncidentPersonTypes = new HashSet<RefIncidentPersonType>();
            RefIncidentReporterTypes = new HashSet<RefIncidentReporterType>();
            RefIncidentTimeDescriptionCodes = new HashSet<RefIncidentTimeDescriptionCode>();
            RefIncomeCalculationMethods = new HashSet<RefIncomeCalculationMethod>();
            RefIncreasedLearningTimeTypes = new HashSet<RefIncreasedLearningTimeType>();
            RefIndicatorStateDefinedStatuses = new HashSet<RefIndicatorStateDefinedStatus>();
            RefIndicatorStatusCustomTypes = new HashSet<RefIndicatorStatusCustomType>();
            RefIndicatorStatusSubgroupTypes = new HashSet<RefIndicatorStatusSubgroupType>();
            RefIndicatorStatusTypes = new HashSet<RefIndicatorStatusType>();
            RefIndividualizedProgramDateTypes = new HashSet<RefIndividualizedProgramDateType>();
            RefIndividualizedProgramLocations = new HashSet<RefIndividualizedProgramLocation>();
            RefIndividualizedProgramPlannedServiceTypes = new HashSet<RefIndividualizedProgramPlannedServiceType>();
            RefIndividualizedProgramTransitionTypes = new HashSet<RefIndividualizedProgramTransitionType>();
            RefIndividualizedProgramTypes = new HashSet<RefIndividualizedProgramType>();
            RefInstitutionTelephoneTypes = new HashSet<RefInstitutionTelephoneType>();
            RefInstructionCreditTypes = new HashSet<RefInstructionCreditType>();
            RefInstructionLocationTypes = new HashSet<RefInstructionLocationType>();
            RefInstructionalActivityHours = new HashSet<RefInstructionalActivityHour>();
            RefInstructionalStaffContractLengths = new HashSet<RefInstructionalStaffContractLength>();
            RefInstructionalStaffFacultyTenures = new HashSet<RefInstructionalStaffFacultyTenure>();
            RefIntegratedTechnologyStatuses = new HashSet<RefIntegratedTechnologyStatus>();
            RefInternetAccessTypeInResidences = new HashSet<RefInternetAccessTypeInResidence>();
            RefInternetAccesses = new HashSet<RefInternetAccess>();
            RefInternetPerformanceInResidences = new HashSet<RefInternetPerformanceInResidence>();
            RefIpedsOccupationalCategories = new HashSet<RefIpedsOccupationalCategory>();
            RefIpedsfasbfinancialPositions = new HashSet<RefIpedsfasbfinancialPosition>();
            RefIpedsfasbfunctionalExpenses = new HashSet<RefIpedsfasbfunctionalExpense>();
            RefIpedsfasbpellGrantTransactions = new HashSet<RefIpedsfasbpellGrantTransaction>();
            RefIpedsfasbrevenueRestrictions = new HashSet<RefIpedsfasbrevenueRestriction>();
            RefIpedsfasbrevenues = new HashSet<RefIpedsfasbrevenue>();
            RefIpedsfasbscholarshipsandFellowshipsRevenues = new HashSet<RefIpedsfasbscholarshipsandFellowshipsRevenue>();
            RefIpedsgasbfinancialPositions = new HashSet<RefIpedsgasbfinancialPosition>();
            RefIpedsgasbfunctionalExpenses = new HashSet<RefIpedsgasbfunctionalExpense>();
            RefIpedsgasbrevenues = new HashSet<RefIpedsgasbrevenue>();
            RefIpedsgasbscholarshipsandFellowshipsRevenues = new HashSet<RefIpedsgasbscholarshipsandFellowshipsRevenue>();
            RefIpedsintercollegiateAthleticsExpenses = new HashSet<RefIpedsintercollegiateAthleticsExpense>();
            RefIpedsnaturalExpenses = new HashSet<RefIpedsnaturalExpense>();
            RefIpspprogressReportSchedules = new HashSet<RefIpspprogressReportSchedule>();
            RefIpspprogressReportTypes = new HashSet<RefIpspprogressReportType>();
            RefIso6392languages = new HashSet<RefIso6392language>();
            RefIso6393languages = new HashSet<RefIso6393language>();
            RefIso6395languageFamilies = new HashSet<RefIso6395languageFamily>();
            RefItemResponseTheoryDifficultyCategories = new HashSet<RefItemResponseTheoryDifficultyCategory>();
            RefItemResponseTheoryKappaAlgorithms = new HashSet<RefItemResponseTheoryKappaAlgorithm>();
            RefK12endOfCourseRequirements = new HashSet<RefK12endOfCourseRequirement>();
            RefK12leaTitleIsupportServices = new HashSet<RefK12leaTitleIsupportService>();
            RefK12responsibilityTypes = new HashSet<RefK12responsibilityType>();
            RefK12staffClassifications = new HashSet<RefK12staffClassification>();
            RefLanguageUseTypes = new HashSet<RefLanguageUseType>();
            RefLanguages = new HashSet<RefLanguage>();
            RefLeaFundsTransferTypes = new HashSet<RefLeaFundsTransferType>();
            RefLeaImprovementStatuses = new HashSet<RefLeaImprovementStatus>();
            RefLeaTypes = new HashSet<RefLeaType>();
            RefLearnerActionTypes = new HashSet<RefLearnerActionType>();
            RefLearnerActivityAddToGradeBookFlags = new HashSet<RefLearnerActivityAddToGradeBookFlag>();
            RefLearnerActivityMaximumTimeAllowedUnits = new HashSet<RefLearnerActivityMaximumTimeAllowedUnit>();
            RefLearnerActivityTypes = new HashSet<RefLearnerActivityType>();
            RefLearningResourceAccessApitypes = new HashSet<RefLearningResourceAccessApitype>();
            RefLearningResourceAccessHazardTypes = new HashSet<RefLearningResourceAccessHazardType>();
            RefLearningResourceAccessModeTypes = new HashSet<RefLearningResourceAccessModeType>();
            RefLearningResourceAccessRightsUrls = new HashSet<RefLearningResourceAccessRightsUrl>();
            RefLearningResourceAuthorTypes = new HashSet<RefLearningResourceAuthorType>();
            RefLearningResourceBookFormatTypes = new HashSet<RefLearningResourceBookFormatType>();
            RefLearningResourceCompetencyAlignmentTypes = new HashSet<RefLearningResourceCompetencyAlignmentType>();
            RefLearningResourceControlFlexibilityTypes = new HashSet<RefLearningResourceControlFlexibilityType>();
            RefLearningResourceDigitalMediaSubTypes = new HashSet<RefLearningResourceDigitalMediaSubType>();
            RefLearningResourceDigitalMediaTypes = new HashSet<RefLearningResourceDigitalMediaType>();
            RefLearningResourceEducationalUses = new HashSet<RefLearningResourceEducationalUse>();
            RefLearningResourceIntendedEndUserRoles = new HashSet<RefLearningResourceIntendedEndUserRole>();
            RefLearningResourceInteractionModes = new HashSet<RefLearningResourceInteractionMode>();
            RefLearningResourceInteractivityTypes = new HashSet<RefLearningResourceInteractivityType>();
            RefLearningResourceMediaFeatureTypes = new HashSet<RefLearningResourceMediaFeatureType>();
            RefLearningResourcePhysicalMediaTypes = new HashSet<RefLearningResourcePhysicalMediaType>();
            RefLearningResourceTypes = new HashSet<RefLearningResourceType>();
            RefLeaveEventTypes = new HashSet<RefLeaveEventType>();
            RefLevelOfInstitutions = new HashSet<RefLevelOfInstitution>();
            RefLicenseExempts = new HashSet<RefLicenseExempt>();
            RefLiteracyAssessments = new HashSet<RefLiteracyAssessment>();
            RefMagnetSpecialPrograms = new HashSet<RefMagnetSpecialProgram>();
            RefMedicalAlertIndicators = new HashSet<RefMedicalAlertIndicator>();
            RefMepEnrollmentTypes = new HashSet<RefMepEnrollmentType>();
            RefMepProjectBaseds = new HashSet<RefMepProjectBased>();
            RefMepProjectTypes = new HashSet<RefMepProjectType>();
            RefMepServiceTypes = new HashSet<RefMepServiceType>();
            RefMepSessionTypes = new HashSet<RefMepSessionType>();
            RefMepStaffCategories = new HashSet<RefMepStaffCategory>();
            RefMethodOfServiceDeliveries = new HashSet<RefMethodOfServiceDelivery>();
            RefMilitaryActiveStudentIndicators = new HashSet<RefMilitaryActiveStudentIndicator>();
            RefMilitaryBranches = new HashSet<RefMilitaryBranch>();
            RefMilitaryConnectedStudentIndicators = new HashSet<RefMilitaryConnectedStudentIndicator>();
            RefMilitaryVeteranStudentIndicators = new HashSet<RefMilitaryVeteranStudentIndicator>();
            RefMultipleIntelligenceTypes = new HashSet<RefMultipleIntelligenceType>();
            RefNaepAspectsOfReadings = new HashSet<RefNaepAspectsOfReading>();
            RefNaepMathComplexityLevels = new HashSet<RefNaepMathComplexityLevel>();
            RefNationalSchoolLunchProgramStatuses = new HashSet<RefNationalSchoolLunchProgramStatus>();
            RefNcescollegeCourseMapCodes = new HashSet<RefNcescollegeCourseMapCode>();
            RefNeedDeterminationMethods = new HashSet<RefNeedDeterminationMethod>();
            RefNeglectedProgramTypes = new HashSet<RefNeglectedProgramType>();
            RefNonPromotionReasons = new HashSet<RefNonPromotionReason>();
            RefNonTraditionalGenderStatuses = new HashSet<RefNonTraditionalGenderStatus>();
            RefNslpstatuses = new HashSet<RefNslpstatus>();
            RefNumberOfDependentsTypes = new HashSet<RefNumberOfDependentsType>();
            RefOnetsococcupationTypes = new HashSet<RefOnetsococcupationType>();
            RefOperationalStatusTypes = new HashSet<RefOperationalStatusType>();
            RefOperationalStatuses = new HashSet<RefOperationalStatus>();
            RefOrganizationElementTypes = new HashSet<RefOrganizationElementType>();
            RefOrganizationIdentificationSystems = new HashSet<RefOrganizationIdentificationSystem>();
            RefOrganizationIdentifierTypes = new HashSet<RefOrganizationIdentifierType>();
            RefOrganizationIndicators = new HashSet<RefOrganizationIndicator>();
            RefOrganizationLocationTypes = new HashSet<RefOrganizationLocationType>();
            RefOrganizationMonitoringNotifications = new HashSet<RefOrganizationMonitoringNotification>();
            RefOrganizationRelationships = new HashSet<RefOrganizationRelationship>();
            RefOrganizationTypes = new HashSet<RefOrganizationType>();
            RefOtherNameTypes = new HashSet<RefOtherNameType>();
            RefOutOfFieldStatuses = new HashSet<RefOutOfFieldStatus>();
            RefOutcomeTimePoints = new HashSet<RefOutcomeTimePoint>();
            RefParaprofessionalQualifications = new HashSet<RefParaprofessionalQualification>();
            RefParticipationStatusAyps = new HashSet<RefParticipationStatusAyp>();
            RefParticipationTypes = new HashSet<RefParticipationType>();
            RefPdactivityApprovedPurposes = new HashSet<RefPdactivityApprovedPurpose>();
            RefPdactivityCreditTypes = new HashSet<RefPdactivityCreditType>();
            RefPdactivityEducationLevelsAddresseds = new HashSet<RefPdactivityEducationLevelsAddressed>();
            RefPdactivityLevels = new HashSet<RefPdactivityLevel>();
            RefPdactivityTargetAudiences = new HashSet<RefPdactivityTargetAudience>();
            RefPdactivityTypes = new HashSet<RefPdactivityType>();
            RefPdaudienceTypes = new HashSet<RefPdaudienceType>();
            RefPddeliveryMethods = new HashSet<RefPddeliveryMethod>();
            RefPdinstructionalDeliveryModes = new HashSet<RefPdinstructionalDeliveryMode>();
            RefPdsessionStatuses = new HashSet<RefPdsessionStatus>();
            RefPersonIdentificationSystems = new HashSet<RefPersonIdentificationSystem>();
            RefPersonIdentifierTypes = new HashSet<RefPersonIdentifierType>();
            RefPersonLocationTypes = new HashSet<RefPersonLocationType>();
            RefPersonRelationshipTypes = new HashSet<RefPersonRelationshipType>();
            RefPersonStatusTypes = new HashSet<RefPersonStatusType>();
            RefPersonTelephoneNumberTypes = new HashSet<RefPersonTelephoneNumberType>();
            RefPersonalInformationTypes = new HashSet<RefPersonalInformationType>();
            RefPersonalInformationVerifications = new HashSet<RefPersonalInformationVerification>();
            RefPescawardLevelTypes = new HashSet<RefPescawardLevelType>();
            RefPopulationServeds = new HashSet<RefPopulationServed>();
            RefPreAndPostTestIndicators = new HashSet<RefPreAndPostTestIndicator>();
            RefPreKeligibleAgesNonIdeas = new HashSet<RefPreKeligibleAgesNonIdea>();
            RefPredominantCalendarSystems = new HashSet<RefPredominantCalendarSystem>();
            RefPrekindergartenEligibilities = new HashSet<RefPrekindergartenEligibility>();
            RefPresentAttendanceCategories = new HashSet<RefPresentAttendanceCategory>();
            RefPrimaryLearningDeviceAccesses = new HashSet<RefPrimaryLearningDeviceAccess>();
            RefPrimaryLearningDeviceAwayFromSchools = new HashSet<RefPrimaryLearningDeviceAwayFromSchool>();
            RefPrimaryLearningDeviceProviders = new HashSet<RefPrimaryLearningDeviceProvider>();
            RefProfessionalDevelopmentFinancialSupports = new HashSet<RefProfessionalDevelopmentFinancialSupport>();
            RefProfessionalEducationJobClassifications = new HashSet<RefProfessionalEducationJobClassification>();
            RefProfessionalTechnicalCredentialTypes = new HashSet<RefProfessionalTechnicalCredentialType>();
            RefProficiencyStatuses = new HashSet<RefProficiencyStatus>();
            RefProficiencyTargetAyps = new HashSet<RefProficiencyTargetAyp>();
            RefProfitStatuses = new HashSet<RefProfitStatus>();
            RefProgramDayLengths = new HashSet<RefProgramDayLength>();
            RefProgramEntryReasons = new HashSet<RefProgramEntryReason>();
            RefProgramExitReasons = new HashSet<RefProgramExitReason>();
            RefProgramGiftedEligibilities = new HashSet<RefProgramGiftedEligibility>();
            RefProgramLengthHoursTypes = new HashSet<RefProgramLengthHoursType>();
            RefProgramSponsorTypes = new HashSet<RefProgramSponsorType>();
            RefProgramTypes = new HashSet<RefProgramType>();
            RefProgressLevels = new HashSet<RefProgressLevel>();
            RefPromotionReasons = new HashSet<RefPromotionReason>();
            RefProofOfResidencyTypes = new HashSet<RefProofOfResidencyType>();
            RefPsEnrollmentActions = new HashSet<RefPsEnrollmentAction>();
            RefPsEnrollmentAwardTypes = new HashSet<RefPsEnrollmentAwardType>();
            RefPsEnrollmentStatuses = new HashSet<RefPsEnrollmentStatus>();
            RefPsEnrollmentTypes = new HashSet<RefPsEnrollmentType>();
            RefPsLepTypes = new HashSet<RefPsLepType>();
            RefPsStudentLevels = new HashSet<RefPsStudentLevel>();
            RefPsexitOrWithdrawalTypes = new HashSet<RefPsexitOrWithdrawalType>();
            RefPsprogramLevels = new HashSet<RefPsprogramLevel>();
            RefPublicSchoolChoiceStatuses = new HashSet<RefPublicSchoolChoiceStatus>();
            RefPublicSchoolResidences = new HashSet<RefPublicSchoolResidence>();
            RefPurposeOfMonitoringVisits = new HashSet<RefPurposeOfMonitoringVisit>();
            RefQrisParticipations = new HashSet<RefQrisParticipation>();
            RefRaces = new HashSet<RefRace>();
            RefReapAlternativeFundingStatuses = new HashSet<RefReapAlternativeFundingStatus>();
            RefReasonDelayTransitionConfs = new HashSet<RefReasonDelayTransitionConf>();
            RefReconstitutedStatuses = new HashSet<RefReconstitutedStatus>();
            RefRecordStatusCreatorEntities = new HashSet<RefRecordStatusCreatorEntity>();
            RefRecordStatusTypes = new HashSet<RefRecordStatusType>();
            RefReferralOutcomes = new HashSet<RefReferralOutcome>();
            RefReimbursementTypes = new HashSet<RefReimbursementType>();
            RefRestructuringActions = new HashSet<RefRestructuringAction>();
            RefRlisProgramUses = new HashSet<RefRlisProgramUse>();
            RefRoleStatusTypes = new HashSet<RefRoleStatusType>();
            RefRoleStatuses = new HashSet<RefRoleStatus>();
            RefRoles = new HashSet<RefRole>();
            RefScedcourseLevels = new HashSet<RefScedcourseLevel>();
            RefScedcourseSubjectAreas = new HashSet<RefScedcourseSubjectArea>();
            RefScheduledWellChildScreenings = new HashSet<RefScheduledWellChildScreening>();
            RefSchoolDangerousStatuses = new HashSet<RefSchoolDangerousStatus>();
            RefSchoolFoodServicePrograms = new HashSet<RefSchoolFoodServiceProgram>();
            RefSchoolImprovementFunds = new HashSet<RefSchoolImprovementFund>();
            RefSchoolImprovementStatuses = new HashSet<RefSchoolImprovementStatus>();
            RefSchoolLevels = new HashSet<RefSchoolLevel>();
            RefSchoolTypes = new HashSet<RefSchoolType>();
            RefScoreMetricTypes = new HashSet<RefScoreMetricType>();
            RefServiceFrequencies = new HashSet<RefServiceFrequency>();
            RefServiceOptions = new HashSet<RefServiceOption>();
            RefServices = new HashSet<RefService>();
            RefSessionTypes = new HashSet<RefSessionType>();
            RefSexes = new HashSet<RefSex>();
            RefSigInterventionTypes = new HashSet<RefSigInterventionType>();
            RefSingleSexClassStatuses = new HashSet<RefSingleSexClassStatus>();
            RefSpaceUseTypes = new HashSet<RefSpaceUseType>();
            RefSpecialEducationAgeGroupTaughts = new HashSet<RefSpecialEducationAgeGroupTaught>();
            RefSpecialEducationExitReasons = new HashSet<RefSpecialEducationExitReason>();
            RefSpecialEducationStaffCategories = new HashSet<RefSpecialEducationStaffCategory>();
            RefStaffCompensationSourceTypes = new HashSet<RefStaffCompensationSourceType>();
            RefStaffPerformanceLevels = new HashSet<RefStaffPerformanceLevel>();
            RefStandardizedAdmissionTests = new HashSet<RefStandardizedAdmissionTest>();
            RefStateAnsicodes = new HashSet<RefStateAnsicode>();
            RefStatePovertyDesignations = new HashSet<RefStatePovertyDesignation>();
            RefStates = new HashSet<RefState>();
            RefStudentEnrollmentAccessTypes = new HashSet<RefStudentEnrollmentAccessType>();
            RefStudentSchoolAffiliationStateDefinedStatuses = new HashSet<RefStudentSchoolAffiliationStateDefinedStatus>();
            RefStudentSupportServiceTypes = new HashSet<RefStudentSupportServiceType>();
            RefSupervisedClinicalExperiences = new HashSet<RefSupervisedClinicalExperience>();
            RefTargetedSupportAndImprovementStatuses = new HashSet<RefTargetedSupportAndImprovementStatus>();
            RefTargetedSupports = new HashSet<RefTargetedSupport>();
            RefTeacherEducationCredentialExams = new HashSet<RefTeacherEducationCredentialExam>();
            RefTeacherEducationExamScoreTypes = new HashSet<RefTeacherEducationExamScoreType>();
            RefTeacherEducationTestCompanies = new HashSet<RefTeacherEducationTestCompany>();
            RefTeacherPrepCompleterStatuses = new HashSet<RefTeacherPrepCompleterStatus>();
            RefTeacherPrepEnrollmentStatuses = new HashSet<RefTeacherPrepEnrollmentStatus>();
            RefTeachingAssignmentRoles = new HashSet<RefTeachingAssignmentRole>();
            RefTeachingCredentialBases = new HashSet<RefTeachingCredentialBasis>();
            RefTeachingCredentialTypes = new HashSet<RefTeachingCredentialType>();
            RefTechnicalAssistanceDeliveryTypes = new HashSet<RefTechnicalAssistanceDeliveryType>();
            RefTechnicalAssistanceTypes = new HashSet<RefTechnicalAssistanceType>();
            RefTechnologyLiteracyStatuses = new HashSet<RefTechnologyLiteracyStatus>();
            RefTelephoneNumberListedStatuses = new HashSet<RefTelephoneNumberListedStatus>();
            RefTelephoneNumberTypes = new HashSet<RefTelephoneNumberType>();
            RefTenureSystems = new HashSet<RefTenureSystem>();
            RefTextComplexitySystems = new HashSet<RefTextComplexitySystem>();
            RefTimeForCompletionUnits = new HashSet<RefTimeForCompletionUnit>();
            RefTitleIiiaccountabilities = new HashSet<RefTitleIiiaccountability>();
            RefTitleIiilanguageInstructionProgramTypes = new HashSet<RefTitleIiilanguageInstructionProgramType>();
            RefTitleIiiprofessionalDevelopmentTypes = new HashSet<RefTitleIiiprofessionalDevelopmentType>();
            RefTitleIindicators = new HashSet<RefTitleIindicator>();
            RefTitleIinstructionalServices = new HashSet<RefTitleIinstructionalService>();
            RefTitleIprogramStaffCategories = new HashSet<RefTitleIprogramStaffCategory>();
            RefTitleIprogramTypes = new HashSet<RefTitleIprogramType>();
            RefTitleIschoolStatuses = new HashSet<RefTitleIschoolStatus>();
            RefTransferOutIndicators = new HashSet<RefTransferOutIndicator>();
            RefTransferReadies = new HashSet<RefTransferReady>();
            RefTribalAffiliations = new HashSet<RefTribalAffiliation>();
            RefTrimesterWhenPrenatalCareBegans = new HashSet<RefTrimesterWhenPrenatalCareBegan>();
            RefTuitionResidencyTypes = new HashSet<RefTuitionResidencyType>();
            RefTuitionUnits = new HashSet<RefTuitionUnit>();
            RefUscitizenshipStatuses = new HashSet<RefUscitizenshipStatus>();
            RefVirtualSchoolStatuses = new HashSet<RefVirtualSchoolStatus>();
            RefVisaTypes = new HashSet<RefVisaType>();
            RefVisionScreeningStatuses = new HashSet<RefVisionScreeningStatus>();
            RefWageCollectionMethods = new HashSet<RefWageCollectionMethod>();
            RefWageVerifications = new HashSet<RefWageVerification>();
            RefWeaponTypes = new HashSet<RefWeaponType>();
            RefWfProgramParticipations = new HashSet<RefWfProgramParticipation>();
            RefWioabarrierstoEmployments = new HashSet<RefWioabarrierstoEmployment>();
            RefWorkbasedLearningOpportunityTypes = new HashSet<RefWorkbasedLearningOpportunityType>();
            RequiredImmunizations = new HashSet<RequiredImmunization>();
            Roles = new HashSet<Role>();
            ServiceProviders = new HashSet<ServiceProvider>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("Organizations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Organizations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<Activity> Activities { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<AeProvider> AeProviders { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<AssessmentAdministrationOrganization> AssessmentAdministrationOrganizations { get; set; }
        [InverseProperty("LeaOrganization")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrationLeaOrganizations { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrationOrganizations { get; set; }
        [InverseProperty("SchoolOrganization")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrationSchoolOrganizations { get; set; }
        [InverseProperty("LeaOrganization")]
        public virtual ICollection<AssessmentSession> AssessmentSessionLeaOrganizations { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<AssessmentSession> AssessmentSessionOrganizations { get; set; }
        [InverseProperty("SchoolOrganization")]
        public virtual ICollection<AssessmentSession> AssessmentSessionSchoolOrganizations { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<CourseSection> CourseSections { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<Course> Courses { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<CredentialAward> CredentialAwards { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<CredentialDefAgent> CredentialDefAgents { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<CredentialIssuer> CredentialIssuers { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<EarlyChildhoodProgramTypeOffered> EarlyChildhoodProgramTypeOffereds { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<ElclassSection> ElclassSections { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<ElfacilityLicensing> ElfacilityLicensings { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<ElorganizationAvailability> ElorganizationAvailabilities { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<ElorganizationFund> ElorganizationFunds { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<ElorganizationMonitoring> ElorganizationMonitorings { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<Elorganization> Elorganizations { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<ElprogramLicensing> ElprogramLicensings { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<ElqualityInitiative> ElqualityInitiatives { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<ElqualityRatingImprovement> ElqualityRatingImprovements { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<ElservicePartner> ElservicePartners { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<Facility> Facilities { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<K12charterSchoolAuthorizerAgency> K12charterSchoolAuthorizerAgencies { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<K12charterSchoolManagementOrganization> K12charterSchoolManagementOrganizations { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<K12lea> K12leas { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<K12programOrService> K12programOrServices { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<K12school> K12schools { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<K12sea> K12seas { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<K12titleIiilanguageInstruction> K12titleIiilanguageInstructions { get; set; }
        [InverseProperty("LeaOrganization")]
        public virtual ICollection<LearnerActivity> LearnerActivityLeaOrganizations { get; set; }
        [InverseProperty("SchoolOrganization")]
        public virtual ICollection<LearnerActivity> LearnerActivitySchoolOrganizations { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationAccreditation> OrganizationAccreditations { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationCalendarCrisis> OrganizationCalendarCrises { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationCalendar> OrganizationCalendars { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationDetail> OrganizationDetails { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationEmail> OrganizationEmails { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationEmployeeBenefit> OrganizationEmployeeBenefits { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationFederalAccountability> OrganizationFederalAccountabilities { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationIdentifier> OrganizationIdentifiers { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationImage> OrganizationImages { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationIndicator> OrganizationIndicators { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationLocation> OrganizationLocations { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationOperationalStatus> OrganizationOperationalStatuses { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationPersonRole> OrganizationPersonRoles { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationPolicy> OrganizationPolicies { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationPopulationServed> OrganizationPopulationServeds { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationProgramType> OrganizationProgramTypes { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationRelationship> OrganizationRelationshipOrganizations { get; set; }
        [InverseProperty("ParentOrganization")]
        public virtual ICollection<OrganizationRelationship> OrganizationRelationshipParentOrganizations { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationService> OrganizationServices { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationTechnicalAssistance> OrganizationTechnicalAssistances { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationTelephone> OrganizationTelephones { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<OrganizationWebsite> OrganizationWebsites { get; set; }
        [InverseProperty("DesignatedGraduationSchool")]
        public virtual ICollection<ProgramParticipationMigrant> ProgramParticipationMigrants { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<Program> Programs { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<PsInstitution> PsInstitutions { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<PsProgram> PsPrograms { get; set; }
        [InverseProperty("RecordStatusCreatorOrganization")]
        public virtual ICollection<RecordStatusHistory> RecordStatusHistories { get; set; }
        [InverseProperty("RecordStatusCreatorOrganization")]
        public virtual ICollection<RecordStatus> RecordStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAbsentAttendanceCategory> RefAbsentAttendanceCategories { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAcademicAwardLevel> RefAcademicAwardLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAcademicAwardPrerequisiteType> RefAcademicAwardPrerequisiteTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAcademicHonorType> RefAcademicHonorTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAcademicRank> RefAcademicRanks { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAcademicSubject> RefAcademicSubjects { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAcademicTermDesignator> RefAcademicTermDesignators { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAccommodationType> RefAccommodationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAccommodationsNeededType> RefAccommodationsNeededTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAccreditationAgency> RefAccreditationAgencies { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefActivityRecognitionType> RefActivityRecognitionTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefActivityTimeMeasurementType> RefActivityTimeMeasurementTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAdditionalCreditType> RefAdditionalCreditTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAdditionalTargetedSupportAndImprovementStatus> RefAdditionalTargetedSupportAndImprovementStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAddressType> RefAddressTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAdministrativeFundingControl> RefAdministrativeFundingControls { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAdmissionConsiderationLevel> RefAdmissionConsiderationLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAdmissionConsiderationType> RefAdmissionConsiderationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAdmittedStudent> RefAdmittedStudents { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAdultEducationProgramExitReason> RefAdultEducationProgramExitReasons { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAdvancedPlacementCourseCode> RefAdvancedPlacementCourseCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAeCertificationType> RefAeCertificationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAeFunctioningLevelAtIntake> RefAeFunctioningLevelAtIntakes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAeFunctioningLevelAtPosttest> RefAeFunctioningLevelAtPosttests { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAeInstructionalProgramType> RefAeInstructionalProgramTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAePostsecondaryTransitionAction> RefAePostsecondaryTransitionActions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAeSpecialProgramType> RefAeSpecialProgramTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAeStaffClassification> RefAeStaffClassifications { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAeStaffEmploymentStatus> RefAeStaffEmploymentStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAllergySeverity> RefAllergySeverities { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAllergyType> RefAllergyTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAltRouteToCertificationOrLicensure> RefAltRouteToCertificationOrLicensures { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAlternateFundUse> RefAlternateFundUses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAlternativeSchoolFocus> RefAlternativeSchoolFoci { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAmaoAttainmentStatus> RefAmaoAttainmentStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefApipInteractionType> RefApipInteractionTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentAssetIdentifierType> RefAssessmentAssetIdentifierTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentAssetType> RefAssessmentAssetTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentEldevelopmentalDomain> RefAssessmentEldevelopmentalDomains { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentFormSectionIdentificationSystem> RefAssessmentFormSectionIdentificationSystems { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentItemCharacteristicType> RefAssessmentItemCharacteristicTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentItemResponseScoreStatus> RefAssessmentItemResponseScoreStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentItemResponseStatus> RefAssessmentItemResponseStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentItemType> RefAssessmentItemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedAlternativeRepresentationType> RefAssessmentNeedAlternativeRepresentationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedBrailleGradeType> RefAssessmentNeedBrailleGradeTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedBrailleMarkType> RefAssessmentNeedBrailleMarkTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedBrailleStatusCellType> RefAssessmentNeedBrailleStatusCellTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedHazardType> RefAssessmentNeedHazardTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedIncreasedWhitespacingType> RefAssessmentNeedIncreasedWhitespacingTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedLanguageLearnerType> RefAssessmentNeedLanguageLearnerTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedLinkIndicationType> RefAssessmentNeedLinkIndicationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedMaskingType> RefAssessmentNeedMaskingTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedNumberOfBrailleDot> RefAssessmentNeedNumberOfBrailleDots { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedSigningType> RefAssessmentNeedSigningTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedSpokenSourcePreferenceType> RefAssessmentNeedSpokenSourcePreferenceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedSupportTool> RefAssessmentNeedSupportTools { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedUsageType> RefAssessmentNeedUsageTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentNeedUserSpokenPreferenceType> RefAssessmentNeedUserSpokenPreferenceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentParticipationIndicator> RefAssessmentParticipationIndicators { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentPlatformType> RefAssessmentPlatformTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentPretestOutcome> RefAssessmentPretestOutcomes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentPurpose> RefAssessmentPurposes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentReasonNotCompleting> RefAssessmentReasonNotCompletings { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentReasonNotTested> RefAssessmentReasonNotTesteds { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentRegistrationCompletionStatus> RefAssessmentRegistrationCompletionStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentReportingMethod> RefAssessmentReportingMethods { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentResultDataType> RefAssessmentResultDataTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentResultScoreType> RefAssessmentResultScoreTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentSessionSpecialCircumstanceType> RefAssessmentSessionSpecialCircumstanceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentSessionStaffRoleType> RefAssessmentSessionStaffRoleTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentSessionType> RefAssessmentSessionTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentSubtestIdentifierType> RefAssessmentSubtestIdentifierTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentTypeChildrenWithDisability> RefAssessmentTypeChildrenWithDisabilities { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAssessmentType> RefAssessmentTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAttendanceEventType> RefAttendanceEventTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAttendanceStatus> RefAttendanceStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAuthorizerType> RefAuthorizerTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefAypStatus> RefAypStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBarrierToEducatingHomeless> RefBarrierToEducatingHomelesses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBarrierToInternetAccessInResidence> RefBarrierToInternetAccessInResidences { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBillableBasisType> RefBillableBasisTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBlendedLearningModelType> RefBlendedLearningModelTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBloomsTaxonomyDomain> RefBloomsTaxonomyDomains { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingAdministrativeSpaceType> RefBuildingAdministrativeSpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingAirDistributionSystemType> RefBuildingAirDistributionSystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingArtSpecialtySpaceType> RefBuildingArtSpecialtySpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingAssemblySpaceType> RefBuildingAssemblySpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingBasicClassroomDesignType> RefBuildingBasicClassroomDesignTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingCareerTechEducationSpaceType> RefBuildingCareerTechEducationSpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingCharterSchoolRealtyAccessType> RefBuildingCharterSchoolRealtyAccessTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingCirculationSpaceType> RefBuildingCirculationSpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingCleaningStandardType> RefBuildingCleaningStandardTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingCommMgmtComponentSystemType> RefBuildingCommMgmtComponentSystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingCommunityUseSpaceType> RefBuildingCommunityUseSpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingCoolingGenerationSystemType> RefBuildingCoolingGenerationSystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingDesignType> RefBuildingDesignTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingElectricalSystemType> RefBuildingElectricalSystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingEnergyConservationMeasureType> RefBuildingEnergyConservationMeasureTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingEnergySourceType> RefBuildingEnergySourceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingEnvOrEnergyPerformanceRatingCat> RefBuildingEnvOrEnergyPerformanceRatingCats { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingFireProtectionSystemType> RefBuildingFireProtectionSystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingFoodServiceSpaceType> RefBuildingFoodServiceSpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingFullServiceKitchenType> RefBuildingFullServiceKitchenTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingHeatingGenerationSystemType> RefBuildingHeatingGenerationSystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingHistoricStatus> RefBuildingHistoricStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingHvacsystemType> RefBuildingHvacsystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingIndoorAthleticOrPhysEdSpaceType> RefBuildingIndoorAthleticOrPhysEdSpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingInstructionalSpaceFactorType> RefBuildingInstructionalSpaceFactorTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingJointUseRationaleType> RefBuildingJointUseRationaleTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingJointUseSchedulingType> RefBuildingJointUseSchedulingTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingJointUserType> RefBuildingJointUserTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingLibMediaCenterSpecialtySpaceType> RefBuildingLibMediaCenterSpecialtySpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingMechanicalConveyingSystemType> RefBuildingMechanicalConveyingSystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingMechanicalSystemType> RefBuildingMechanicalSystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingOperationsOrMaintSpaceType> RefBuildingOperationsOrMaintSpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingOutdoorAthleticOrPhysEdSpaceType> RefBuildingOutdoorAthleticOrPhysEdSpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingOutdoorOrNonathleticSpaceType> RefBuildingOutdoorOrNonathleticSpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingPerformingArtsSpecialtySpaceType> RefBuildingPerformingArtsSpecialtySpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingPlumbingSystemType> RefBuildingPlumbingSystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingPrimaryUseType> RefBuildingPrimaryUseTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingSchoolDesignType> RefBuildingSchoolDesignTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingScienceSpecialtySpaceType> RefBuildingScienceSpecialtySpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingSecuritySystemType> RefBuildingSecuritySystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingSiteUseRestrictionsType> RefBuildingSiteUseRestrictionsTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingSpaceDesignType> RefBuildingSpaceDesignTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingSpecEdSpecialtySpaceType> RefBuildingSpecEdSpecialtySpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingStudentSupportSpaceType> RefBuildingStudentSupportSpaceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingSystemType> RefBuildingSystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingTechnologyWiringSystemType> RefBuildingTechnologyWiringSystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingUseType> RefBuildingUseTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefBuildingVerticalTransportationSystemType> RefBuildingVerticalTransportationSystemTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCalendarEventType> RefCalendarEventTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCampusResidencyType> RefCampusResidencyTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCampusStatus> RefCampusStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCampusType> RefCampusTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCareerCluster> RefCareerClusters { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCareerEducationPlanType> RefCareerEducationPlanTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCarnegieBasicClassification> RefCarnegieBasicClassifications { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCharterLeaStatus> RefCharterLeaStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCharterSchoolAuthorizerType> RefCharterSchoolAuthorizerTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCharterSchoolManagementOrganizationType> RefCharterSchoolManagementOrganizationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCharterSchoolType> RefCharterSchoolTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefChildDevelopmentAssociateType> RefChildDevelopmentAssociateTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefChildDevelopmentalScreeningStatus> RefChildDevelopmentalScreeningStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefChildOutcomesSummaryRating> RefChildOutcomesSummaryRatings { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCipCode> RefCipCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCipUse> RefCipUses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCipVersion> RefCipVersions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefClassroomPositionType> RefClassroomPositionTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCohortExclusion> RefCohortExclusions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCommunicationMethod> RefCommunicationMethods { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCommunityBasedType> RefCommunityBasedTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCompetencyDefAssociationType> RefCompetencyDefAssociationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCompetencyDefNodeAccessibilityProfile> RefCompetencyDefNodeAccessibilityProfiles { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCompetencyDefTestabilityType> RefCompetencyDefTestabilityTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCompetencyFrameworkPublicationStatus> RefCompetencyFrameworkPublicationStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCompetencySetCompletionCriterion> RefCompetencySetCompletionCriteria { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefComprehensiveAndTargetedSupport> RefComprehensiveAndTargetedSupports { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefComprehensiveSupportAndImprovementStatus> RefComprehensiveSupportAndImprovementStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefComprehensiveSupport> RefComprehensiveSupports { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefContentStandardType> RefContentStandardTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefContinuationOfService> RefContinuationOfServices { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefControlOfInstitution> RefControlOfInstitutions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCoreKnowledgeArea> RefCoreKnowledgeAreas { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCorrectionalEducationFacilityType> RefCorrectionalEducationFacilityTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCorrectiveActionType> RefCorrectiveActionTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCounty> RefCounties { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCountry> RefCountries { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseAcademicGradeStatusCode> RefCourseAcademicGradeStatusCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseApplicableEducationLevel> RefCourseApplicableEducationLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseCreditBasisType> RefCourseCreditBasisTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseCreditLevelType> RefCourseCreditLevelTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseCreditUnit> RefCourseCreditUnits { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseGpaApplicability> RefCourseGpaApplicabilities { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseHonorsType> RefCourseHonorsTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseInstructionMethod> RefCourseInstructionMethods { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseInstructionSiteType> RefCourseInstructionSiteTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseInteractionMode> RefCourseInteractionModes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseLevelCharacteristic> RefCourseLevelCharacteristics { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseLevelType> RefCourseLevelTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseRepeatCode> RefCourseRepeatCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseSectionAssessmentReportingMethod> RefCourseSectionAssessmentReportingMethods { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseSectionDeliveryMode> RefCourseSectionDeliveryModes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseSectionEnrollmentStatusType> RefCourseSectionEnrollmentStatusTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseSectionEntryType> RefCourseSectionEntryTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCourseSectionExitType> RefCourseSectionExitTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCredentialDefAgentRoleType> RefCredentialDefAgentRoleTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCredentialDefAssessMethodType> RefCredentialDefAssessMethodTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCredentialDefIntendedPurposeType> RefCredentialDefIntendedPurposeTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCredentialDefStatusType> RefCredentialDefStatusTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCredentialDefVerificationType> RefCredentialDefVerificationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCredentialIdentifierSystem> RefCredentialIdentifierSystems { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCredentialType> RefCredentialTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCreditHoursAppliedOtherProgram> RefCreditHoursAppliedOtherPrograms { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCreditTypeEarned> RefCreditTypeEarneds { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCriticalTeacherShortageCandidate> RefCriticalTeacherShortageCandidates { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCtdlaudienceLevelType> RefCtdlaudienceLevelTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCtdlorganizationType> RefCtdlorganizationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCteGraduationRateInclusion> RefCteGraduationRateInclusions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCteNonTraditionalGenderStatus> RefCteNonTraditionalGenderStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefCurriculumFrameworkType> RefCurriculumFrameworkTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDataCollectionStatus> RefDataCollectionStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDegreeOrCertificateType> RefDegreeOrCertificateTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDentalInsuranceCoverageType> RefDentalInsuranceCoverageTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDentalScreeningStatus> RefDentalScreeningStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDependencyStatus> RefDependencyStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDevelopmentalEducationReferralStatus> RefDevelopmentalEducationReferralStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDevelopmentalEducationType> RefDevelopmentalEducationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDevelopmentalEvaluationFinding> RefDevelopmentalEvaluationFindings { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDirectoryInformationBlockStatus> RefDirectoryInformationBlockStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDisabilityConditionStatusCode> RefDisabilityConditionStatusCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDisabilityConditionType> RefDisabilityConditionTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDisabilityDeterminationSourceType> RefDisabilityDeterminationSourceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDisabilityType> RefDisabilityTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDisciplinaryActionTaken> RefDisciplinaryActionTakens { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDisciplineLengthDifferenceReason> RefDisciplineLengthDifferenceReasons { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDisciplineMethodFirearm> RefDisciplineMethodFirearms { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDisciplineMethodOfCwd> RefDisciplineMethodOfCwds { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDisciplineReason> RefDisciplineReasons { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDistanceEducationCourseEnrollment> RefDistanceEducationCourseEnrollments { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDoctoralExamsRequiredCode> RefDoctoralExamsRequiredCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefDqpcategoriesOfLearning> RefDqpcategoriesOfLearnings { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEarlyChildhoodCredential> RefEarlyChildhoodCredentials { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEarlyChildhoodProgramEnrollmentType> RefEarlyChildhoodProgramEnrollmentTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEarlyChildhoodService> RefEarlyChildhoodServices { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType> RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEdFactsAcademicOrCareerAndTechnicalOutcomeType> RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEdfactsTeacherInexperiencedStatus> RefEdfactsTeacherInexperiencedStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEducationLevelType> RefEducationLevelTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEducationLevel> RefEducationLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEducationVerificationMethod> RefEducationVerificationMethods { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEleducationStaffClassification> RefEleducationStaffClassifications { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElementaryMiddleAdditional> RefElementaryMiddleAdditionals { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElemploymentSeparationReason> RefElemploymentSeparationReasons { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElfacilityLicensingStatus> RefElfacilityLicensingStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElfederalFundingType> RefElfederalFundingTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElgroupSizeStandardMet> RefElgroupSizeStandardMets { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEllevelOfSpecialization> RefEllevelOfSpecializations { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEllocalRevenueSource> RefEllocalRevenueSources { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElotherFederalFundingSource> RefElotherFederalFundingSources { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEloutcomeMeasurementLevel> RefEloutcomeMeasurementLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElprofessionalDevelopmentTopicArea> RefElprofessionalDevelopmentTopicAreas { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElprogramEligibility> RefElprogramEligibilities { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElprogramEligibilityStatus> RefElprogramEligibilityStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElprogramLicenseStatus> RefElprogramLicenseStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElserviceProfessionalStaffClassification> RefElserviceProfessionalStaffClassifications { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElserviceType> RefElserviceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefElstateRevenueSource> RefElstateRevenueSources { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEltrainerCoreKnowledgeArea> RefEltrainerCoreKnowledgeAreas { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOrganizationEmailType> RefEmailTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEmergencyOrProvisionalCredentialStatus> RefEmergencyOrProvisionalCredentialStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEmployedAfterExit> RefEmployedAfterExits { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEmployedPriorToEnrollment> RefEmployedPriorToEnrollments { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEmployedWhileEnrolled> RefEmployedWhileEnrolleds { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEmployeeBenefit> RefEmployeeBenefits { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEmploymentContractType> RefEmploymentContractTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEmploymentSeparationReason> RefEmploymentSeparationReasons { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEmploymentSeparationType> RefEmploymentSeparationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEmploymentStatusWhileEnrolled> RefEmploymentStatusWhileEnrolleds { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEmploymentStatus> RefEmploymentStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEndOfTermStatus> RefEndOfTermStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEnrollmentStatus> RefEnrollmentStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEntityType> RefEntityTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEntryType> RefEntryTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEnvironmentSetting> RefEnvironmentSettings { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefEradministrativeDataSource> RefEradministrativeDataSources { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefErsruralUrbanContinuumCode> RefErsruralUrbanContinuumCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefExitOrWithdrawalStatus> RefExitOrWithdrawalStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefExitOrWithdrawalType> RefExitOrWithdrawalTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilitiesMandateAuthorityType> RefFacilitiesMandateAuthorityTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilitiesMgmtEmergencyType> RefFacilitiesMgmtEmergencyTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilitiesPlanType> RefFacilitiesPlanTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityApplicableFederalMandateType> RefFacilityApplicableFederalMandateTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityAuditType> RefFacilityAuditTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityCapitalProgramMgmtType> RefFacilityCapitalProgramMgmtTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityComplianceAgencyType> RefFacilityComplianceAgencyTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityComplianceStatus> RefFacilityComplianceStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityConstructionDateType> RefFacilityConstructionDateTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityConstructionMaterialType> RefFacilityConstructionMaterialTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityFederalMandateInterestType> RefFacilityFederalMandateInterestTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityFinancingFeeType> RefFacilityFinancingFeeTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityFurnishingsType> RefFacilityFurnishingsTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityHazardousMaterialsOrCondType> RefFacilityHazardousMaterialsOrCondTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityJointDevelopmentType> RefFacilityJointDevelopmentTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityLeaseAmountCategory> RefFacilityLeaseAmountCategories { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityLeaseType> RefFacilityLeaseTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityMaintStandardType> RefFacilityMaintStandardTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityMortgageInterestType> RefFacilityMortgageInterestTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityMortgageType> RefFacilityMortgageTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityNaturallyOccurringHazardType> RefFacilityNaturallyOccurringHazardTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityOperationsMgmtType> RefFacilityOperationsMgmtTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilitySiteImprovementLocationType> RefFacilitySiteImprovementLocationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilitySiteOutdoorAreaType> RefFacilitySiteOutdoorAreaTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityStandardType> RefFacilityStandardTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityStateOrLocalMandateInterestType> RefFacilityStateOrLocalMandateInterestTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilitySystemOrComponentCondition> RefFacilitySystemOrComponentConditions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityUtilityProviderType> RefFacilityUtilityProviderTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFacilityUtilityType> RefFacilityUtilityTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFamilyIncomeSource> RefFamilyIncomeSources { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFederalProgramFundingAllocationType> RefFederalProgramFundingAllocationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialAccountBalanceSheetCode> RefFinancialAccountBalanceSheetCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialAccountCategory> RefFinancialAccountCategories { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialAccountFundClassification> RefFinancialAccountFundClassifications { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialAccountProgramCode> RefFinancialAccountProgramCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialAccountRevenueCode> RefFinancialAccountRevenueCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialAidApplicationType> RefFinancialAidApplicationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialAidAwardStatus> RefFinancialAidAwardStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialAidAwardType> RefFinancialAidAwardTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialAidVeteransBenefitStatus> RefFinancialAidVeteransBenefitStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialAidVeteransBenefitType> RefFinancialAidVeteransBenefitTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialExpenditureFunctionCode> RefFinancialExpenditureFunctionCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialExpenditureLevelOfInstructionCode> RefFinancialExpenditureLevelOfInstructionCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFinancialExpenditureObjectCode> RefFinancialExpenditureObjectCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFirearmType> RefFirearmTypes { get; set; }
        [InverseProperty("RefJurisdictionNavigation")]
        public virtual ICollection<RefFoodServiceEligibility> RefFoodServiceEligibilities { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFoodServiceParticipation> RefFoodServiceParticipations { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFrequencyOfService> RefFrequencyOfServices { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFrequencyUnit> RefFrequencyUnits { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefFullTimeStatus> RefFullTimeStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefGoalMeasurementType> RefGoalMeasurementTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefGoalStatusType> RefGoalStatusTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefGoalsForAttendingAdultEducation> RefGoalsForAttendingAdultEducations { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefGpaWeightedIndicator> RefGpaWeightedIndicators { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefGradeLevelType> RefGradeLevelTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefGradeLevel> RefGradeLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefGradeLevelsApproved> RefGradeLevelsApproveds { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefGradePointAverageDomain> RefGradePointAverageDomains { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefGraduateAssistantIpedsCategory> RefGraduateAssistantIpedsCategories { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefGraduateOrDoctoralExamResultsStatus> RefGraduateOrDoctoralExamResultsStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefGunFreeSchoolsActReportingStatus> RefGunFreeSchoolsActReportingStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefHealthInsuranceCoverage> RefHealthInsuranceCoverages { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefHearingScreeningStatus> RefHearingScreeningStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefHighSchoolDiplomaDistinctionType> RefHighSchoolDiplomaDistinctionTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefHighSchoolDiplomaType> RefHighSchoolDiplomaTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefHighSchoolGraduationRateIndicator> RefHighSchoolGraduationRateIndicators { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefHigherEducationInstitutionAccreditationStatus> RefHigherEducationInstitutionAccreditationStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefHomelessNighttimeResidence> RefHomelessNighttimeResidences { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIdeadisabilityType> RefIdeadisabilityTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIdeadisciplineMethodFirearm> RefIdeadisciplineMethodFirearms { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIdeaeducationalEnvironmentEc> RefIdeaeducationalEnvironmentEcs { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIdeaeducationalEnvironmentSchoolAge> RefIdeaeducationalEnvironmentSchoolAges { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIdeaeligibilityEvaluationCategory> RefIdeaeligibilityEvaluationCategories { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIdeaenvironmentEl> RefIdeaenvironmentEls { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIdeaiepstatus> RefIdeaiepstatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIdeainterimRemovalReason> RefIdeainterimRemovalReasons { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIdeainterimRemoval> RefIdeainterimRemovals { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIdeapartCeligibilityCategory> RefIdeapartCeligibilityCategories { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIepauthorizationDocumentType> RefIepauthorizationDocumentTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIepeligibilityEvaluationType> RefIepeligibilityEvaluationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIepgoalType> RefIepgoalTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefImmunizationType> RefImmunizationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIncidentBehaviorSecondary> RefIncidentBehaviorSecondaries { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIncidentBehavior> RefIncidentBehaviors { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIncidentInjuryType> RefIncidentInjuryTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIncidentLocation> RefIncidentLocations { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIncidentMultipleOffenseType> RefIncidentMultipleOffenseTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIncidentPerpetratorInjuryType> RefIncidentPerpetratorInjuryTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIncidentPersonRoleType> RefIncidentPersonRoleTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIncidentPersonType> RefIncidentPersonTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIncidentReporterType> RefIncidentReporterTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIncidentTimeDescriptionCode> RefIncidentTimeDescriptionCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIncomeCalculationMethod> RefIncomeCalculationMethods { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIncreasedLearningTimeType> RefIncreasedLearningTimeTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIndicatorStateDefinedStatus> RefIndicatorStateDefinedStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIndicatorStatusCustomType> RefIndicatorStatusCustomTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIndicatorStatusSubgroupType> RefIndicatorStatusSubgroupTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIndicatorStatusType> RefIndicatorStatusTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIndividualizedProgramDateType> RefIndividualizedProgramDateTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIndividualizedProgramLocation> RefIndividualizedProgramLocations { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIndividualizedProgramPlannedServiceType> RefIndividualizedProgramPlannedServiceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIndividualizedProgramTransitionType> RefIndividualizedProgramTransitionTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIndividualizedProgramType> RefIndividualizedProgramTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefInstitutionTelephoneType> RefInstitutionTelephoneTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefInstructionCreditType> RefInstructionCreditTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefInstructionLocationType> RefInstructionLocationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefInstructionalActivityHour> RefInstructionalActivityHours { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefInstructionalStaffContractLength> RefInstructionalStaffContractLengths { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefInstructionalStaffFacultyTenure> RefInstructionalStaffFacultyTenures { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIntegratedTechnologyStatus> RefIntegratedTechnologyStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefInternetAccessTypeInResidence> RefInternetAccessTypeInResidences { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefInternetAccess> RefInternetAccesses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefInternetPerformanceInResidence> RefInternetPerformanceInResidences { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsOccupationalCategory> RefIpedsOccupationalCategories { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsfasbfinancialPosition> RefIpedsfasbfinancialPositions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsfasbfunctionalExpense> RefIpedsfasbfunctionalExpenses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsfasbpellGrantTransaction> RefIpedsfasbpellGrantTransactions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsfasbrevenueRestriction> RefIpedsfasbrevenueRestrictions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsfasbrevenue> RefIpedsfasbrevenues { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsfasbscholarshipsandFellowshipsRevenue> RefIpedsfasbscholarshipsandFellowshipsRevenues { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsgasbfinancialPosition> RefIpedsgasbfinancialPositions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsgasbfunctionalExpense> RefIpedsgasbfunctionalExpenses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsgasbrevenue> RefIpedsgasbrevenues { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsgasbscholarshipsandFellowshipsRevenue> RefIpedsgasbscholarshipsandFellowshipsRevenues { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsintercollegiateAthleticsExpense> RefIpedsintercollegiateAthleticsExpenses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpedsnaturalExpense> RefIpedsnaturalExpenses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpspprogressReportSchedule> RefIpspprogressReportSchedules { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIpspprogressReportType> RefIpspprogressReportTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIso6392language> RefIso6392languages { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIso6393language> RefIso6393languages { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefIso6395languageFamily> RefIso6395languageFamilies { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefItemResponseTheoryDifficultyCategory> RefItemResponseTheoryDifficultyCategories { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefItemResponseTheoryKappaAlgorithm> RefItemResponseTheoryKappaAlgorithms { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefK12endOfCourseRequirement> RefK12endOfCourseRequirements { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefK12leaTitleIsupportService> RefK12leaTitleIsupportServices { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefK12responsibilityType> RefK12responsibilityTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefK12staffClassification> RefK12staffClassifications { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLanguageUseType> RefLanguageUseTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLanguage> RefLanguages { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLeaFundsTransferType> RefLeaFundsTransferTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLeaImprovementStatus> RefLeaImprovementStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLeaType> RefLeaTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearnerActionType> RefLearnerActionTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearnerActivityAddToGradeBookFlag> RefLearnerActivityAddToGradeBookFlags { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearnerActivityMaximumTimeAllowedUnit> RefLearnerActivityMaximumTimeAllowedUnits { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearnerActivityType> RefLearnerActivityTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceAccessApitype> RefLearningResourceAccessApitypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceAccessHazardType> RefLearningResourceAccessHazardTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceAccessModeType> RefLearningResourceAccessModeTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceAccessRightsUrl> RefLearningResourceAccessRightsUrls { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceAuthorType> RefLearningResourceAuthorTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceBookFormatType> RefLearningResourceBookFormatTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceCompetencyAlignmentType> RefLearningResourceCompetencyAlignmentTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceControlFlexibilityType> RefLearningResourceControlFlexibilityTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceDigitalMediaSubType> RefLearningResourceDigitalMediaSubTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceDigitalMediaType> RefLearningResourceDigitalMediaTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceEducationalUse> RefLearningResourceEducationalUses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceIntendedEndUserRole> RefLearningResourceIntendedEndUserRoles { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceInteractionMode> RefLearningResourceInteractionModes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceInteractivityType> RefLearningResourceInteractivityTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceMediaFeatureType> RefLearningResourceMediaFeatureTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourcePhysicalMediaType> RefLearningResourcePhysicalMediaTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLearningResourceType> RefLearningResourceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLeaveEventType> RefLeaveEventTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLevelOfInstitution> RefLevelOfInstitutions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLicenseExempt> RefLicenseExempts { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefLiteracyAssessment> RefLiteracyAssessments { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMagnetSpecialProgram> RefMagnetSpecialPrograms { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMedicalAlertIndicator> RefMedicalAlertIndicators { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMepEnrollmentType> RefMepEnrollmentTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMepProjectBased> RefMepProjectBaseds { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMepProjectType> RefMepProjectTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMepServiceType> RefMepServiceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMepSessionType> RefMepSessionTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMepStaffCategory> RefMepStaffCategories { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMethodOfServiceDelivery> RefMethodOfServiceDeliveries { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMilitaryActiveStudentIndicator> RefMilitaryActiveStudentIndicators { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMilitaryBranch> RefMilitaryBranches { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMilitaryConnectedStudentIndicator> RefMilitaryConnectedStudentIndicators { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMilitaryVeteranStudentIndicator> RefMilitaryVeteranStudentIndicators { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefMultipleIntelligenceType> RefMultipleIntelligenceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefNaepAspectsOfReading> RefNaepAspectsOfReadings { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefNaepMathComplexityLevel> RefNaepMathComplexityLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefNationalSchoolLunchProgramStatus> RefNationalSchoolLunchProgramStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefNcescollegeCourseMapCode> RefNcescollegeCourseMapCodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefNeedDeterminationMethod> RefNeedDeterminationMethods { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefNeglectedProgramType> RefNeglectedProgramTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefNonPromotionReason> RefNonPromotionReasons { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefNonTraditionalGenderStatus> RefNonTraditionalGenderStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefNslpstatus> RefNslpstatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefNumberOfDependentsType> RefNumberOfDependentsTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOnetsococcupationType> RefOnetsococcupationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOperationalStatusType> RefOperationalStatusTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOperationalStatus> RefOperationalStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOrganizationElementType> RefOrganizationElementTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOrganizationIdentificationSystem> RefOrganizationIdentificationSystems { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOrganizationIdentifierType> RefOrganizationIdentifierTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOrganizationIndicator> RefOrganizationIndicators { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOrganizationLocationType> RefOrganizationLocationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOrganizationMonitoringNotification> RefOrganizationMonitoringNotifications { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOrganizationRelationship> RefOrganizationRelationships { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOrganizationType> RefOrganizationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOtherNameType> RefOtherNameTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOutOfFieldStatus> RefOutOfFieldStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefOutcomeTimePoint> RefOutcomeTimePoints { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefParaprofessionalQualification> RefParaprofessionalQualifications { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefParticipationStatusAyp> RefParticipationStatusAyps { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<RefParticipationType> RefParticipationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPdactivityApprovedPurpose> RefPdactivityApprovedPurposes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPdactivityCreditType> RefPdactivityCreditTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPdactivityEducationLevelsAddressed> RefPdactivityEducationLevelsAddresseds { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPdactivityLevel> RefPdactivityLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPdactivityTargetAudience> RefPdactivityTargetAudiences { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPdactivityType> RefPdactivityTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPdaudienceType> RefPdaudienceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPddeliveryMethod> RefPddeliveryMethods { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPdinstructionalDeliveryMode> RefPdinstructionalDeliveryModes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPdsessionStatus> RefPdsessionStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPersonIdentificationSystem> RefPersonIdentificationSystems { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPersonIdentifierType> RefPersonIdentifierTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPersonLocationType> RefPersonLocationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPersonRelationshipType> RefPersonRelationshipTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPersonStatusType> RefPersonStatusTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPersonTelephoneNumberType> RefPersonTelephoneNumberTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPersonalInformationType> RefPersonalInformationTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPersonalInformationVerification> RefPersonalInformationVerifications { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPescawardLevelType> RefPescawardLevelTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPopulationServed> RefPopulationServeds { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPreAndPostTestIndicator> RefPreAndPostTestIndicators { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPreKeligibleAgesNonIdea> RefPreKeligibleAgesNonIdeas { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPredominantCalendarSystem> RefPredominantCalendarSystems { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPrekindergartenEligibility> RefPrekindergartenEligibilities { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPresentAttendanceCategory> RefPresentAttendanceCategories { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPrimaryLearningDeviceAccess> RefPrimaryLearningDeviceAccesses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPrimaryLearningDeviceAwayFromSchool> RefPrimaryLearningDeviceAwayFromSchools { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPrimaryLearningDeviceProvider> RefPrimaryLearningDeviceProviders { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProfessionalDevelopmentFinancialSupport> RefProfessionalDevelopmentFinancialSupports { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProfessionalEducationJobClassification> RefProfessionalEducationJobClassifications { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProfessionalTechnicalCredentialType> RefProfessionalTechnicalCredentialTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProficiencyStatus> RefProficiencyStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProficiencyTargetAyp> RefProficiencyTargetAyps { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProfitStatus> RefProfitStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProgramDayLength> RefProgramDayLengths { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProgramEntryReason> RefProgramEntryReasons { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProgramExitReason> RefProgramExitReasons { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProgramGiftedEligibility> RefProgramGiftedEligibilities { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProgramLengthHoursType> RefProgramLengthHoursTypes { get; set; }
        [InverseProperty("RefJurisdictionNavigation")]
        public virtual ICollection<RefProgramSponsorType> RefProgramSponsorTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProgramType> RefProgramTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProgressLevel> RefProgressLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPromotionReason> RefPromotionReasons { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefProofOfResidencyType> RefProofOfResidencyTypes { get; set; }
        [InverseProperty("RefJurisdictionNavigation")]
        public virtual ICollection<RefPsEnrollmentAction> RefPsEnrollmentActions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPsEnrollmentAwardType> RefPsEnrollmentAwardTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPsEnrollmentStatus> RefPsEnrollmentStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPsEnrollmentType> RefPsEnrollmentTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPsLepType> RefPsLepTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPsStudentLevel> RefPsStudentLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPsexitOrWithdrawalType> RefPsexitOrWithdrawalTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPsprogramLevel> RefPsprogramLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPublicSchoolChoiceStatus> RefPublicSchoolChoiceStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPublicSchoolResidence> RefPublicSchoolResidences { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefPurposeOfMonitoringVisit> RefPurposeOfMonitoringVisits { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefQrisParticipation> RefQrisParticipations { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefRace> RefRaces { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefReapAlternativeFundingStatus> RefReapAlternativeFundingStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefReasonDelayTransitionConf> RefReasonDelayTransitionConfs { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefReconstitutedStatus> RefReconstitutedStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefRecordStatusCreatorEntity> RefRecordStatusCreatorEntities { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefRecordStatusType> RefRecordStatusTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefReferralOutcome> RefReferralOutcomes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefReimbursementType> RefReimbursementTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefRestructuringAction> RefRestructuringActions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefRlisProgramUse> RefRlisProgramUses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefRoleStatusType> RefRoleStatusTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefRoleStatus> RefRoleStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefRole> RefRoles { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefScedcourseLevel> RefScedcourseLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefScedcourseSubjectArea> RefScedcourseSubjectAreas { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefScheduledWellChildScreening> RefScheduledWellChildScreenings { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSchoolDangerousStatus> RefSchoolDangerousStatuses { get; set; }
        [InverseProperty("RefJurisdictionNavigation")]
        public virtual ICollection<RefSchoolFoodServiceProgram> RefSchoolFoodServicePrograms { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSchoolImprovementFund> RefSchoolImprovementFunds { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSchoolImprovementStatus> RefSchoolImprovementStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSchoolLevel> RefSchoolLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSchoolType> RefSchoolTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefScoreMetricType> RefScoreMetricTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefServiceFrequency> RefServiceFrequencies { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefServiceOption> RefServiceOptions { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefService> RefServices { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSessionType> RefSessionTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSex> RefSexes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSigInterventionType> RefSigInterventionTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSingleSexClassStatus> RefSingleSexClassStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSpaceUseType> RefSpaceUseTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSpecialEducationAgeGroupTaught> RefSpecialEducationAgeGroupTaughts { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSpecialEducationExitReason> RefSpecialEducationExitReasons { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSpecialEducationStaffCategory> RefSpecialEducationStaffCategories { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefStaffCompensationSourceType> RefStaffCompensationSourceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefStaffPerformanceLevel> RefStaffPerformanceLevels { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefStandardizedAdmissionTest> RefStandardizedAdmissionTests { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefStateAnsicode> RefStateAnsicodes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefStatePovertyDesignation> RefStatePovertyDesignations { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefState> RefStates { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefStudentEnrollmentAccessType> RefStudentEnrollmentAccessTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefStudentSchoolAffiliationStateDefinedStatus> RefStudentSchoolAffiliationStateDefinedStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefStudentSupportServiceType> RefStudentSupportServiceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefSupervisedClinicalExperience> RefSupervisedClinicalExperiences { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTargetedSupportAndImprovementStatus> RefTargetedSupportAndImprovementStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTargetedSupport> RefTargetedSupports { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTeacherEducationCredentialExam> RefTeacherEducationCredentialExams { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTeacherEducationExamScoreType> RefTeacherEducationExamScoreTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTeacherEducationTestCompany> RefTeacherEducationTestCompanies { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTeacherPrepCompleterStatus> RefTeacherPrepCompleterStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTeacherPrepEnrollmentStatus> RefTeacherPrepEnrollmentStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTeachingAssignmentRole> RefTeachingAssignmentRoles { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTeachingCredentialBasis> RefTeachingCredentialBases { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTeachingCredentialType> RefTeachingCredentialTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTechnicalAssistanceDeliveryType> RefTechnicalAssistanceDeliveryTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTechnicalAssistanceType> RefTechnicalAssistanceTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTechnologyLiteracyStatus> RefTechnologyLiteracyStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTelephoneNumberListedStatus> RefTelephoneNumberListedStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTelephoneNumberType> RefTelephoneNumberTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTenureSystem> RefTenureSystems { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTextComplexitySystem> RefTextComplexitySystems { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTimeForCompletionUnit> RefTimeForCompletionUnits { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTitleIiiaccountability> RefTitleIiiaccountabilities { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTitleIiilanguageInstructionProgramType> RefTitleIiilanguageInstructionProgramTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTitleIiiprofessionalDevelopmentType> RefTitleIiiprofessionalDevelopmentTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTitleIindicator> RefTitleIindicators { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTitleIinstructionalService> RefTitleIinstructionalServices { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTitleIprogramStaffCategory> RefTitleIprogramStaffCategories { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTitleIprogramType> RefTitleIprogramTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTitleIschoolStatus> RefTitleIschoolStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTransferOutIndicator> RefTransferOutIndicators { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTransferReady> RefTransferReadies { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTribalAffiliation> RefTribalAffiliations { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTrimesterWhenPrenatalCareBegan> RefTrimesterWhenPrenatalCareBegans { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTuitionResidencyType> RefTuitionResidencyTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefTuitionUnit> RefTuitionUnits { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefUscitizenshipStatus> RefUscitizenshipStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefVirtualSchoolStatus> RefVirtualSchoolStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefVisaType> RefVisaTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefVisionScreeningStatus> RefVisionScreeningStatuses { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefWageCollectionMethod> RefWageCollectionMethods { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefWageVerification> RefWageVerifications { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefWeaponType> RefWeaponTypes { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefWfProgramParticipation> RefWfProgramParticipations { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefWioabarrierstoEmployment> RefWioabarrierstoEmployments { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<RefWorkbasedLearningOpportunityType> RefWorkbasedLearningOpportunityTypes { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<RequiredImmunization> RequiredImmunizations { get; set; }
        [InverseProperty("RefJurisdiction")]
        public virtual ICollection<Role> Roles { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; }
    }
}
