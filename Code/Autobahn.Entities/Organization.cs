using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("Organization")]
    public partial class Organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization()
        {
            Activities = new HashSet<Activity>();
            AeProviders = new HashSet<AeProvider>();
            AssessmentAdministrationOrganization = new HashSet<AssessmentAdministrationOrganization>();
            AssessmentRegistrations = new HashSet<AssessmentRegistration>();
            AssessmentRegistrations1 = new HashSet<AssessmentRegistration>();
            AssessmentRegistrations2 = new HashSet<AssessmentRegistration>();
            AssessmentSessions = new HashSet<AssessmentSession>();
            AssessmentSessions1 = new HashSet<AssessmentSession>();
            AssessmentSessions2 = new HashSet<AssessmentSession>();
            Courses = new HashSet<Course>();
            CourseSections = new HashSet<CourseSection>();
            CredentialAwards = new HashSet<CredentialAward>();
            CredentialDefAgents = new HashSet<CredentialDefAgent>();
            CredentialIssuers = new HashSet<CredentialIssuer>();
            EarlyChildhoodProgramTypeOffereds = new HashSet<EarlyChildhoodProgramTypeOffered>();
            ELClassSections = new HashSet<ELClassSection>();
            ELFacilityLicensings = new HashSet<ELFacilityLicensing>();
            ELOrganizations = new HashSet<ELOrganization>();
            ELOrganizationAvailabilities = new HashSet<ELOrganizationAvailability>();
            ELOrganizationFunds = new HashSet<ELOrganizationFund>();
            ELOrganizationMonitorings = new HashSet<ELOrganizationMonitoring>();
            ELProgramLicensings = new HashSet<ELProgramLicensing>();
            ELQualityInitiatives = new HashSet<ELQualityInitiative>();
            ELQualityRatingImprovements = new HashSet<ELQualityRatingImprovement>();
            ELServicePartners = new HashSet<ELServicePartner>();
            Facilities = new HashSet<Facility>();
            K12CharterSchoolAuthorizerAgency = new HashSet<K12CharterSchoolAuthorizerAgency>();
            K12CharterSchoolManagementOrganization = new HashSet<K12CharterSchoolManagementOrganization>();
            K12Lea = new HashSet<K12Lea>();
            K12ProgramOrService = new HashSet<K12ProgramOrService>();
            K12School = new HashSet<K12School>();
            K12Sea = new HashSet<K12Sea>();
            K12TitleIIILanguageInstruction = new HashSet<K12TitleIIILanguageInstruction>();
            LearnerActivities = new HashSet<LearnerActivity>();
            LearnerActivities1 = new HashSet<LearnerActivity>();
            OrganizationRelationships = new HashSet<OrganizationRelationship>();
            OrganizationEmails = new HashSet<OrganizationEmail>();
            OrganizationAccreditations = new HashSet<OrganizationAccreditation>();
            OrganizationCalendars = new HashSet<OrganizationCalendar>();
            OrganizationCalendarCrisis = new HashSet<OrganizationCalendarCrisis>();
            OrganizationDetails = new HashSet<OrganizationDetail>();
            OrganizationEmployeeBenefits = new HashSet<OrganizationEmployeeBenefit>();
            OrganizationFederalAccountabilities = new HashSet<OrganizationFederalAccountability>();
            OrganizationIdentifiers = new HashSet<OrganizationIdentifier>();
            OrganizationImages = new HashSet<OrganizationImage>();
            OrganizationIndicators = new HashSet<OrganizationIndicator>();
            OrganizationLocations = new HashSet<OrganizationLocation>();
            OrganizationOperationalStatus = new HashSet<OrganizationOperationalStatu>();
            OrganizationPersonRoles = new HashSet<OrganizationPersonRole>();
            OrganizationPolicies = new HashSet<OrganizationPolicy>();
            OrganizationPopulationServeds = new HashSet<OrganizationPopulationServed>();
            OrganizationProgramTypes = new HashSet<OrganizationProgramType>();
            OrganizationRelationships1 = new HashSet<OrganizationRelationship>();
            OrganizationServices = new HashSet<OrganizationService>();
            OrganizationTechnicalAssistances = new HashSet<OrganizationTechnicalAssistance>();
            OrganizationTelephones = new HashSet<OrganizationTelephone>();
            OrganizationWebsites = new HashSet<OrganizationWebsite>();
            Programs = new HashSet<Program>();
            ProgramParticipationMigrants = new HashSet<ProgramParticipationMigrant>();
            PsInstitutions = new HashSet<PsInstitution>();
            PsPrograms = new HashSet<PsProgram>();
            RecordStatuses = new HashSet<RecordStatus>();
            RecordStatusHistories = new HashSet<RecordStatusHistory>();
            RefAbsentAttendanceCategories = new HashSet<RefAbsentAttendanceCategory>();
            RefAcademicAwardLevels = new HashSet<RefAcademicAwardLevel>();
            RefAcademicAwardPrerequisiteTypes = new HashSet<RefAcademicAwardPrerequisiteType>();
            RefAcademicHonorTypes = new HashSet<RefAcademicHonorType>();
            RefAcademicRanks = new HashSet<RefAcademicRank>();
            RefAcademicSubjects = new HashSet<RefAcademicSubject>();
            RefAcademicTermDesignators = new HashSet<RefAcademicTermDesignator>();
            RefAccommodationsNeededTypes = new HashSet<RefAccommodationsNeededType>();
            RefAccommodationTypes = new HashSet<RefAccommodationType>();
            RefAccreditationAgencies = new HashSet<RefAccreditationAgency>();
            RefActivityRecognitionTypes = new HashSet<RefActivityRecognitionType>();
            RefActivityTimeMeasurementTypes = new HashSet<RefActivityTimeMeasurementType>();
            RefAdditionalCreditTypes = new HashSet<RefAdditionalCreditType>();
            RefAdditionalTargetedSupportAndImprovementStatus = new HashSet<RefAdditionalTargetedSupportAndImprovementStatu>();
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
            RefAeStaffEmploymentStatus = new HashSet<RefAeStaffEmploymentStatu>();
            RefAllergySeverities = new HashSet<RefAllergySeverity>();
            RefAllergyTypes = new HashSet<RefAllergyType>();
            RefAlternateFundUses = new HashSet<RefAlternateFundUs>();
            RefAlternativeSchoolFocus = new HashSet<RefAlternativeSchoolFocu>();
            RefAltRouteToCertificationOrLicensures = new HashSet<RefAltRouteToCertificationOrLicensure>();
            RefAmaoAttainmentStatus = new HashSet<RefAmaoAttainmentStatu>();
            RefApipInteractionTypes = new HashSet<RefApipInteractionType>();
            RefAssessmentItemCharacteristicTypes = new HashSet<RefAssessmentItemCharacteristicType>();
            RefAssessmentItemResponseStatus = new HashSet<RefAssessmentItemResponseStatu>();
            RefAssessmentAssetIdentifierTypes = new HashSet<RefAssessmentAssetIdentifierType>();
            RefAssessmentAssetTypes = new HashSet<RefAssessmentAssetType>();
            RefAssessmentELDevelopmentalDomains = new HashSet<RefAssessmentELDevelopmentalDomain>();
            RefAssessmentFormSectionIdentificationSystems = new HashSet<RefAssessmentFormSectionIdentificationSystem>();
            RefAssessmentItemResponseScoreStatus = new HashSet<RefAssessmentItemResponseScoreStatu>();
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
            RefAssessmentPurposes = new HashSet<RefAssessmentPurpose>();
            RefAssessmentReasonNotCompletings = new HashSet<RefAssessmentReasonNotCompleting>();
            RefAssessmentReasonNotTesteds = new HashSet<RefAssessmentReasonNotTested>();
            RefAssessmentRegistrationCompletionStatus = new HashSet<RefAssessmentRegistrationCompletionStatu>();
            RefAssessmentReportingMethods = new HashSet<RefAssessmentReportingMethod>();
            RefAssessmentResultDataTypes = new HashSet<RefAssessmentResultDataType>();
            RefAssessmentResultScoreTypes = new HashSet<RefAssessmentResultScoreType>();
            RefAssessmentSessionSpecialCircumstanceTypes = new HashSet<RefAssessmentSessionSpecialCircumstanceType>();
            RefAssessmentSessionStaffRoleTypes = new HashSet<RefAssessmentSessionStaffRoleType>();
            RefAssessmentSessionTypes = new HashSet<RefAssessmentSessionType>();
            RefAssessmentPretestOutcomes = new HashSet<RefAssessmentPretestOutcome>();
            RefAssessmentTypes = new HashSet<RefAssessmentType>();
            RefAssessmentTypeChildrenWithDisabilities = new HashSet<RefAssessmentTypeChildrenWithDisability>();
            RefAssessmentSubtestIdentifierTypes = new HashSet<RefAssessmentSubtestIdentifierType>();
            RefEntityTypes = new HashSet<RefEntityType>();
            RefAttendanceEventTypes = new HashSet<RefAttendanceEventType>();
            RefAttendanceStatus = new HashSet<RefAttendanceStatu>();
            RefAuthorizerTypes = new HashSet<RefAuthorizerType>();
            RefAypStatus = new HashSet<RefAypStatu>();
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
            RefBuildingHistoricStatus = new HashSet<RefBuildingHistoricStatu>();
            RefBuildingHVACSystemTypes = new HashSet<RefBuildingHVACSystemType>();
            RefBuildingIndoorAthleticOrPhysEdSpaceTypes = new HashSet<RefBuildingIndoorAthleticOrPhysEdSpaceType>();
            RefBuildingInstructionalSpaceFactorTypes = new HashSet<RefBuildingInstructionalSpaceFactorType>();
            RefBuildingJointUseRationaleTypes = new HashSet<RefBuildingJointUseRationaleType>();
            RefBuildingJointUserTypes = new HashSet<RefBuildingJointUserType>();
            RefBuildingJointUseSchedulingTypes = new HashSet<RefBuildingJointUseSchedulingType>();
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
            RefCampusStatus = new HashSet<RefCampusStatu>();
            RefCampusTypes = new HashSet<RefCampusType>();
            RefCareerClusters = new HashSet<RefCareerCluster>();
            RefCareerEducationPlanTypes = new HashSet<RefCareerEducationPlanType>();
            RefCarnegieBasicClassifications = new HashSet<RefCarnegieBasicClassification>();
            RefCharterLeaStatus = new HashSet<RefCharterLeaStatu>();
            RefCharterSchoolAuthorizerTypes = new HashSet<RefCharterSchoolAuthorizerType>();
            RefCharterSchoolManagementOrganizationTypes = new HashSet<RefCharterSchoolManagementOrganizationType>();
            RefCharterSchoolTypes = new HashSet<RefCharterSchoolType>();
            RefChildDevelopmentAssociateTypes = new HashSet<RefChildDevelopmentAssociateType>();
            RefChildDevelopmentalScreeningStatus = new HashSet<RefChildDevelopmentalScreeningStatu>();
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
            RefCompetencyFrameworkPublicationStatus = new HashSet<RefCompetencyFrameworkPublicationStatu>();
            RefCompetencySetCompletionCriterias = new HashSet<RefCompetencySetCompletionCriteria>();
            RefComprehensiveAndTargetedSupports = new HashSet<RefComprehensiveAndTargetedSupport>();
            RefComprehensiveSupports = new HashSet<RefComprehensiveSupport>();
            RefComprehensiveSupportAndImprovementStatus = new HashSet<RefComprehensiveSupportAndImprovementStatu>();
            RefContentStandardTypes = new HashSet<RefContentStandardType>();
            RefContinuationOfServices = new HashSet<RefContinuationOfService>();
            RefControlOfInstitutions = new HashSet<RefControlOfInstitution>();
            RefCoreKnowledgeAreas = new HashSet<RefCoreKnowledgeArea>();
            RefCorrectionalEducationFacilityTypes = new HashSet<RefCorrectionalEducationFacilityType>();
            RefCorrectiveActionTypes = new HashSet<RefCorrectiveActionType>();
            RefCountries = new HashSet<RefCountry>();
            RefCounties = new HashSet<RefCounty>();
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
            RefCTDLAudienceLevelTypes = new HashSet<RefCTDLAudienceLevelType>();
            RefCTDLOrganizationTypes = new HashSet<RefCTDLOrganizationType>();
            RefCteGraduationRateInclusions = new HashSet<RefCteGraduationRateInclusion>();
            RefCteNonTraditionalGenderStatus = new HashSet<RefCteNonTraditionalGenderStatu>();
            RefCurriculumFrameworkTypes = new HashSet<RefCurriculumFrameworkType>();
            RefDataCollectionStatus = new HashSet<RefDataCollectionStatu>();
            RefDegreeOrCertificateTypes = new HashSet<RefDegreeOrCertificateType>();
            RefDentalScreeningStatus = new HashSet<RefDentalScreeningStatu>();
            RefDentalInsuranceCoverageTypes = new HashSet<RefDentalInsuranceCoverageType>();
            RefDependencyStatus = new HashSet<RefDependencyStatu>();
            RefDevelopmentalEducationReferralStatus = new HashSet<RefDevelopmentalEducationReferralStatu>();
            RefDevelopmentalEducationTypes = new HashSet<RefDevelopmentalEducationType>();
            RefDevelopmentalEvaluationFindings = new HashSet<RefDevelopmentalEvaluationFinding>();
            RefDirectoryInformationBlockStatus = new HashSet<RefDirectoryInformationBlockStatu>();
            RefDisabilityTypes = new HashSet<RefDisabilityType>();
            RefDisabilityConditionStatusCodes = new HashSet<RefDisabilityConditionStatusCode>();
            RefDisabilityConditionTypes = new HashSet<RefDisabilityConditionType>();
            RefDisabilityDeterminationSourceTypes = new HashSet<RefDisabilityDeterminationSourceType>();
            RefDisciplinaryActionTakens = new HashSet<RefDisciplinaryActionTaken>();
            RefDisciplineLengthDifferenceReasons = new HashSet<RefDisciplineLengthDifferenceReason>();
            RefDisciplineMethodFirearms = new HashSet<RefDisciplineMethodFirearm>();
            RefDisciplineMethodOfCwds = new HashSet<RefDisciplineMethodOfCwd>();
            RefDisciplineReasons = new HashSet<RefDisciplineReason>();
            RefDistanceEducationCourseEnrollments = new HashSet<RefDistanceEducationCourseEnrollment>();
            RefDoctoralExamsRequiredCodes = new HashSet<RefDoctoralExamsRequiredCode>();
            RefDQPCategoriesOfLearnings = new HashSet<RefDQPCategoriesOfLearning>();
            RefEarlyChildhoodCredentials = new HashSet<RefEarlyChildhoodCredential>();
            RefEarlyChildhoodProgramEnrollmentTypes = new HashSet<RefEarlyChildhoodProgramEnrollmentType>();
            RefEarlyChildhoodServices = new HashSet<RefEarlyChildhoodService>();
            RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypes = new HashSet<RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType>();
            RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypes = new HashSet<RefEdFactsAcademicOrCareerAndTechnicalOutcomeType>();
            RefEDFactsTeacherInexperiencedStatus = new HashSet<RefEDFactsTeacherInexperiencedStatu>();
            RefEducationLevels = new HashSet<RefEducationLevel>();
            RefEducationLevelTypes = new HashSet<RefEducationLevelType>();
            RefK12StaffClassification = new HashSet<RefK12StaffClassification>();
            RefEducationVerificationMethods = new HashSet<RefEducationVerificationMethod>();
            RefELEducationStaffClassifications = new HashSet<RefELEducationStaffClassification>();
            RefElementaryMiddleAdditionals = new HashSet<RefElementaryMiddleAdditional>();
            RefELEmploymentSeparationReasons = new HashSet<RefELEmploymentSeparationReason>();
            RefELFacilityLicensingStatus = new HashSet<RefELFacilityLicensingStatu>();
            RefELFederalFundingTypes = new HashSet<RefELFederalFundingType>();
            RefELGroupSizeStandardMets = new HashSet<RefELGroupSizeStandardMet>();
            RefELLevelOfSpecializations = new HashSet<RefELLevelOfSpecialization>();
            RefELLocalRevenueSources = new HashSet<RefELLocalRevenueSource>();
            RefELOtherFederalFundingSources = new HashSet<RefELOtherFederalFundingSource>();
            RefELOutcomeMeasurementLevels = new HashSet<RefELOutcomeMeasurementLevel>();
            RefELProfessionalDevelopmentTopicAreas = new HashSet<RefELProfessionalDevelopmentTopicArea>();
            RefELProgramEligibilities = new HashSet<RefELProgramEligibility>();
            RefELProgramEligibilityStatus = new HashSet<RefELProgramEligibilityStatu>();
            RefELProgramLicenseStatus = new HashSet<RefELProgramLicenseStatu>();
            RefELServiceProfessionalStaffClassifications = new HashSet<RefELServiceProfessionalStaffClassification>();
            RefELServiceTypes = new HashSet<RefELServiceType>();
            RefELStateRevenueSources = new HashSet<RefELStateRevenueSource>();
            RefELTrainerCoreKnowledgeAreas = new HashSet<RefELTrainerCoreKnowledgeArea>();
            RefEmailTypes = new HashSet<RefEmailType>();
            RefEmergencyOrProvisionalCredentialStatus = new HashSet<RefEmergencyOrProvisionalCredentialStatu>();
            RefEmployedAfterExits = new HashSet<RefEmployedAfterExit>();
            RefEmployedPriorToEnrollments = new HashSet<RefEmployedPriorToEnrollment>();
            RefEmployedWhileEnrolleds = new HashSet<RefEmployedWhileEnrolled>();
            RefEmployeeBenefits = new HashSet<RefEmployeeBenefit>();
            RefEmploymentContractTypes = new HashSet<RefEmploymentContractType>();
            RefEmploymentSeparationReasons = new HashSet<RefEmploymentSeparationReason>();
            RefEmploymentSeparationTypes = new HashSet<RefEmploymentSeparationType>();
            RefEmploymentStatus = new HashSet<RefEmploymentStatu>();
            RefEmploymentStatusWhileEnrolleds = new HashSet<RefEmploymentStatusWhileEnrolled>();
            RefEndOfTermStatus = new HashSet<RefEndOfTermStatu>();
            RefEnrollmentStatus = new HashSet<RefEnrollmentStatu>();
            RefEntryTypes = new HashSet<RefEntryType>();
            RefEnvironmentSettings = new HashSet<RefEnvironmentSetting>();
            RefERAdministrativeDataSources = new HashSet<RefERAdministrativeDataSource>();
            RefERSRuralUrbanContinuumCodes = new HashSet<RefERSRuralUrbanContinuumCode>();
            RefExitOrWithdrawalStatus = new HashSet<RefExitOrWithdrawalStatu>();
            RefExitOrWithdrawalTypes = new HashSet<RefExitOrWithdrawalType>();
            RefFacilitiesMandateAuthorityTypes = new HashSet<RefFacilitiesMandateAuthorityType>();
            RefFacilitiesMgmtEmergencyTypes = new HashSet<RefFacilitiesMgmtEmergencyType>();
            RefFacilitiesPlanTypes = new HashSet<RefFacilitiesPlanType>();
            RefFacilityApplicableFederalMandateTypes = new HashSet<RefFacilityApplicableFederalMandateType>();
            RefFacilityAuditTypes = new HashSet<RefFacilityAuditType>();
            RefFacilityCapitalProgramMgmtTypes = new HashSet<RefFacilityCapitalProgramMgmtType>();
            RefFacilityComplianceAgencyTypes = new HashSet<RefFacilityComplianceAgencyType>();
            RefFacilityComplianceStatus = new HashSet<RefFacilityComplianceStatu>();
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
            RefFinancialAccountCategories = new HashSet<RefFinancialAccountCategory>();
            RefFinancialAccountFundClassifications = new HashSet<RefFinancialAccountFundClassification>();
            RefFinancialAccountProgramCodes = new HashSet<RefFinancialAccountProgramCode>();
            RefFinancialAidApplicationTypes = new HashSet<RefFinancialAidApplicationType>();
            RefFinancialAidAwardStatus = new HashSet<RefFinancialAidAwardStatu>();
            RefFinancialAidAwardTypes = new HashSet<RefFinancialAidAwardType>();
            RefFinancialAidVeteransBenefitStatus = new HashSet<RefFinancialAidVeteransBenefitStatu>();
            RefFinancialAidVeteransBenefitTypes = new HashSet<RefFinancialAidVeteransBenefitType>();
            RefFinancialAccountBalanceSheetCodes = new HashSet<RefFinancialAccountBalanceSheetCode>();
            RefFinancialExpenditureFunctionCodes = new HashSet<RefFinancialExpenditureFunctionCode>();
            RefFinancialExpenditureLevelOfInstructionCodes = new HashSet<RefFinancialExpenditureLevelOfInstructionCode>();
            RefFinancialExpenditureObjectCodes = new HashSet<RefFinancialExpenditureObjectCode>();
            RefFinancialAccountRevenueCodes = new HashSet<RefFinancialAccountRevenueCode>();
            RefFirearmTypes = new HashSet<RefFirearmType>();
            RefFoodServiceEligibilities = new HashSet<RefFoodServiceEligibility>();
            RefFoodServiceParticipations = new HashSet<RefFoodServiceParticipation>();
            RefFrequencyOfServices = new HashSet<RefFrequencyOfService>();
            RefFrequencyUnits = new HashSet<RefFrequencyUnit>();
            RefFullTimeStatus = new HashSet<RefFullTimeStatu>();
            RefGoalMeasurementTypes = new HashSet<RefGoalMeasurementType>();
            RefGoalsForAttendingAdultEducations = new HashSet<RefGoalsForAttendingAdultEducation>();
            RefGoalStatusTypes = new HashSet<RefGoalStatusType>();
            RefGpaWeightedIndicators = new HashSet<RefGpaWeightedIndicator>();
            RefGradeLevels = new HashSet<RefGradeLevel>();
            RefGradeLevelsApproveds = new HashSet<RefGradeLevelsApproved>();
            RefGradeLevelTypes = new HashSet<RefGradeLevelType>();
            RefGradePointAverageDomains = new HashSet<RefGradePointAverageDomain>();
            RefGraduateAssistantIpedsCategories = new HashSet<RefGraduateAssistantIpedsCategory>();
            RefGraduateOrDoctoralExamResultsStatus = new HashSet<RefGraduateOrDoctoralExamResultsStatu>();
            RefGunFreeSchoolsActReportingStatus = new HashSet<RefGunFreeSchoolsActReportingStatu>();
            RefHearingScreeningStatus = new HashSet<RefHearingScreeningStatu>();
            RefHigherEducationInstitutionAccreditationStatus = new HashSet<RefHigherEducationInstitutionAccreditationStatu>();
            RefHighSchoolDiplomaTypes = new HashSet<RefHighSchoolDiplomaType>();
            RefHomelessNighttimeResidences = new HashSet<RefHomelessNighttimeResidence>();
            RefHighSchoolDiplomaDistinctionTypes = new HashSet<RefHighSchoolDiplomaDistinctionType>();
            RefHighSchoolGraduationRateIndicators = new HashSet<RefHighSchoolGraduationRateIndicator>();
            RefIDEADisabilityTypes = new HashSet<RefIDEADisabilityType>();
            RefIDEADisciplineMethodFirearms = new HashSet<RefIDEADisciplineMethodFirearm>();
            RefIDEAEducationalEnvironmentECs = new HashSet<RefIDEAEducationalEnvironmentEC>();
            RefIDEAEducationalEnvironmentSchoolAges = new HashSet<RefIDEAEducationalEnvironmentSchoolAge>();
            RefIDEAEligibilityEvaluationCategories = new HashSet<RefIDEAEligibilityEvaluationCategory>();
            RefIDEAEnvironmentELs = new HashSet<RefIDEAEnvironmentEL>();
            RefIDEAIEPStatus = new HashSet<RefIDEAIEPStatu>();
            RefIDEAInterimRemovals = new HashSet<RefIDEAInterimRemoval>();
            RefIDEAInterimRemovalReasons = new HashSet<RefIDEAInterimRemovalReason>();
            RefIDEAPartCEligibilityCategories = new HashSet<RefIDEAPartCEligibilityCategory>();
            RefOrganizationIdentificationSystems = new HashSet<RefOrganizationIdentificationSystem>();
            RefPersonIdentificationSystems = new HashSet<RefPersonIdentificationSystem>();
            RefIEPAuthorizationDocumentTypes = new HashSet<RefIEPAuthorizationDocumentType>();
            RefIEPEligibilityEvaluationTypes = new HashSet<RefIEPEligibilityEvaluationType>();
            RefIEPGoalTypes = new HashSet<RefIEPGoalType>();
            RefImmunizationTypes = new HashSet<RefImmunizationType>();
            RefIncidentBehaviors = new HashSet<RefIncidentBehavior>();
            RefIncidentBehaviorSecondaries = new HashSet<RefIncidentBehaviorSecondary>();
            RefIncidentInjuryTypes = new HashSet<RefIncidentInjuryType>();
            RefIncidentLocations = new HashSet<RefIncidentLocation>();
            RefIncidentMultipleOffenseTypes = new HashSet<RefIncidentMultipleOffenseType>();
            RefIncidentPerpetratorInjuryTypes = new HashSet<RefIncidentPerpetratorInjuryType>();
            RefIncidentPersonRoleTypes = new HashSet<RefIncidentPersonRoleType>();
            RefIncidentPersonTypes = new HashSet<RefIncidentPersonType>();
            RefIncidentReporterTypes = new HashSet<RefIncidentReporterType>();
            RefIncidentTimeDescriptionCodes = new HashSet<RefIncidentTimeDescriptionCode>();
            RefIncomeCalculationMethods = new HashSet<RefIncomeCalculationMethod>();
            RefIncomeCalculationMethods1 = new HashSet<RefIncomeCalculationMethod>();
            RefIncreasedLearningTimeTypes = new HashSet<RefIncreasedLearningTimeType>();
            RefIndicatorStateDefinedStatus = new HashSet<RefIndicatorStateDefinedStatu>();
            RefIndicatorStatusCustomTypes = new HashSet<RefIndicatorStatusCustomType>();
            RefIndicatorStatusSubgroupTypes = new HashSet<RefIndicatorStatusSubgroupType>();
            RefIndicatorStatusTypes = new HashSet<RefIndicatorStatusType>();
            RefIndividualizedProgramDateTypes = new HashSet<RefIndividualizedProgramDateType>();
            RefIndividualizedProgramLocations = new HashSet<RefIndividualizedProgramLocation>();
            RefIndividualizedProgramPlannedServiceTypes = new HashSet<RefIndividualizedProgramPlannedServiceType>();
            RefIndividualizedProgramTransitionTypes = new HashSet<RefIndividualizedProgramTransitionType>();
            RefIndividualizedProgramTypes = new HashSet<RefIndividualizedProgramType>();
            RefInstitutionTelephoneTypes = new HashSet<RefInstitutionTelephoneType>();
            RefInstructionalActivityHours = new HashSet<RefInstructionalActivityHour>();
            RefInstructionCreditTypes = new HashSet<RefInstructionCreditType>();
            RefInstructionLocationTypes = new HashSet<RefInstructionLocationType>();
            RefInstructionalStaffContractLengths = new HashSet<RefInstructionalStaffContractLength>();
            RefInstructionalStaffFacultyTenures = new HashSet<RefInstructionalStaffFacultyTenure>();
            RefHealthInsuranceCoverages = new HashSet<RefHealthInsuranceCoverage>();
            RefIntegratedTechnologyStatus = new HashSet<RefIntegratedTechnologyStatu>();
            RefInternetAccesses = new HashSet<RefInternetAccess>();
            RefInternetAccessTypeInResidences = new HashSet<RefInternetAccessTypeInResidence>();
            RefInternetPerformanceInResidences = new HashSet<RefInternetPerformanceInResidence>();
            RefIPEDSFASBFinancialPositions = new HashSet<RefIPEDSFASBFinancialPosition>();
            RefIPEDSFASBFunctionalExpenses = new HashSet<RefIPEDSFASBFunctionalExpense>();
            RefIPEDSFASBPellGrantTransactions = new HashSet<RefIPEDSFASBPellGrantTransaction>();
            RefIPEDSFASBRevenues = new HashSet<RefIPEDSFASBRevenue>();
            RefIPEDSFASBRevenueRestrictions = new HashSet<RefIPEDSFASBRevenueRestriction>();
            RefIPEDSFASBScholarshipsandFellowshipsRevenues = new HashSet<RefIPEDSFASBScholarshipsandFellowshipsRevenue>();
            RefIPEDSGASBFinancialPositions = new HashSet<RefIPEDSGASBFinancialPosition>();
            RefIPEDSGASBFunctionalExpenses = new HashSet<RefIPEDSGASBFunctionalExpense>();
            RefIPEDSGASBRevenues = new HashSet<RefIPEDSGASBRevenue>();
            RefIPEDSGASBScholarshipsandFellowshipsRevenues = new HashSet<RefIPEDSGASBScholarshipsandFellowshipsRevenue>();
            RefIPEDSIntercollegiateAthleticsExpenses = new HashSet<RefIPEDSIntercollegiateAthleticsExpens>();
            RefIPEDSNaturalExpenses = new HashSet<RefIPEDSNaturalExpense>();
            RefIpedsOccupationalCategories = new HashSet<RefIpedsOccupationalCategory>();
            RefIPSPProgressReportSchedules = new HashSet<RefIPSPProgressReportSchedule>();
            RefIPSPProgressReportTypes = new HashSet<RefIPSPProgressReportType>();
            RefItemResponseTheoryDifficultyCategories = new HashSet<RefItemResponseTheoryDifficultyCategory>();
            RefItemResponseTheoryKappaAlgorithms = new HashSet<RefItemResponseTheoryKappaAlgorithm>();
            RefISO6392Language = new HashSet<RefISO6392Language>();
            RefISO6393Language = new HashSet<RefISO6393Language>();
            RefISO6395LanguageFamily = new HashSet<RefISO6395LanguageFamily>();
            RefK12EndOfCourseRequirement = new HashSet<RefK12EndOfCourseRequirement>();
            RefK12LeaTitleISupportService = new HashSet<RefK12LeaTitleISupportService>();
            RefK12ResponsibilityType = new HashSet<RefK12ResponsibilityType>();
            RefLanguages = new HashSet<RefLanguage>();
            RefTitleIIILanguageInstructionProgramTypes = new HashSet<RefTitleIIILanguageInstructionProgramType>();
            RefLanguageUseTypes = new HashSet<RefLanguageUseType>();
            RefLeaFundsTransferTypes = new HashSet<RefLeaFundsTransferType>();
            RefLeaImprovementStatus = new HashSet<RefLeaImprovementStatu>();
            RefLearnerActionTypes = new HashSet<RefLearnerActionType>();
            RefLearnerActivityAddToGradeBookFlags = new HashSet<RefLearnerActivityAddToGradeBookFlag>();
            RefLearnerActivityTypes = new HashSet<RefLearnerActivityType>();
            RefLearningResourceAccessAPITypes = new HashSet<RefLearningResourceAccessAPIType>();
            RefLearningResourceAccessHazardTypes = new HashSet<RefLearningResourceAccessHazardType>();
            RefLearningResourceAccessModeTypes = new HashSet<RefLearningResourceAccessModeType>();
            RefLearningResourceAccessRightsUrls = new HashSet<RefLearningResourceAccessRightsUrl>();
            RefLearningResourceAuthorTypes = new HashSet<RefLearningResourceAuthorType>();
            RefLearningResourceBookFormatTypes = new HashSet<RefLearningResourceBookFormatType>();
            RefLearningResourceCompetencyAlignmentTypes = new HashSet<RefLearningResourceCompetencyAlignmentType>();
            RefLearningResourceControlFlexibilityTypes = new HashSet<RefLearningResourceControlFlexibilityType>();
            RefLearningResourceDigitalMediaSubTypes = new HashSet<RefLearningResourceDigitalMediaSubType>();
            RefLearningResourceDigitalMediaTypes = new HashSet<RefLearningResourceDigitalMediaType>();
            RefLearningResourceInteractionModes = new HashSet<RefLearningResourceInteractionMode>();
            RefLearningResourceMediaFeatureTypes = new HashSet<RefLearningResourceMediaFeatureType>();
            RefLearningResourcePhysicalMediaTypes = new HashSet<RefLearningResourcePhysicalMediaType>();
            RefLeaTypes = new HashSet<RefLeaType>();
            RefLeaveEventTypes = new HashSet<RefLeaveEventType>();
            RefLevelOfInstitutions = new HashSet<RefLevelOfInstitution>();
            RefLicenseExempts = new HashSet<RefLicenseExempt>();
            RefLiteracyAssessments = new HashSet<RefLiteracyAssessment>();
            RefLearningResourceEducationalUses = new HashSet<RefLearningResourceEducationalUse>();
            RefLearningResourceIntendedEndUserRoles = new HashSet<RefLearningResourceIntendedEndUserRole>();
            RefLearningResourceInteractivityTypes = new HashSet<RefLearningResourceInteractivityType>();
            RefLearningResourceTypes = new HashSet<RefLearningResourceType>();
            RefMagnetSpecialPrograms = new HashSet<RefMagnetSpecialProgram>();
            RefLearnerActivityMaximumTimeAllowedUnits = new HashSet<RefLearnerActivityMaximumTimeAllowedUnit>();
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
            RefNationalSchoolLunchProgramStatus = new HashSet<RefNationalSchoolLunchProgramStatu>();
            RefNCESCollegeCourseMapCodes = new HashSet<RefNCESCollegeCourseMapCode>();
            RefNeedDeterminationMethods = new HashSet<RefNeedDeterminationMethod>();
            RefNeglectedProgramTypes = new HashSet<RefNeglectedProgramType>();
            RefNonPromotionReasons = new HashSet<RefNonPromotionReason>();
            RefNonTraditionalGenderStatus = new HashSet<RefNonTraditionalGenderStatu>();
            RefNSLPStatus = new HashSet<RefNSLPStatu>();
            RefNumberOfDependentsTypes = new HashSet<RefNumberOfDependentsType>();
            RefONETSOCOccupationTypes = new HashSet<RefONETSOCOccupationType>();
            RefOperationalStatus = new HashSet<RefOperationalStatu>();
            RefOperationalStatusTypes = new HashSet<RefOperationalStatusType>();
            RefOrganizationElementTypes = new HashSet<RefOrganizationElementType>();
            RefOrganizationIdentifierTypes = new HashSet<RefOrganizationIdentifierType>();
            RefOrganizationIndicators = new HashSet<RefOrganizationIndicator>();
            RefOrganizationLocationTypes = new HashSet<RefOrganizationLocationType>();
            RefOrganizationMonitoringNotifications = new HashSet<RefOrganizationMonitoringNotification>();
            RefOrganizationRelationships = new HashSet<RefOrganizationRelationship>();
            RefOrganizationTypes = new HashSet<RefOrganizationType>();
            RefOtherNameTypes = new HashSet<RefOtherNameType>();
            RefOutcomeTimePoints = new HashSet<RefOutcomeTimePoint>();
            RefOutOfFieldStatus = new HashSet<RefOutOfFieldStatu>();
            RefParaprofessionalQualifications = new HashSet<RefParaprofessionalQualification>();
            RefParticipationStatusAyps = new HashSet<RefParticipationStatusAyp>();
            RefParticipationTypes = new HashSet<RefParticipationType>();
            RefPDActivityApprovedPurposes = new HashSet<RefPDActivityApprovedPurpose>();
            RefPDActivityCreditTypes = new HashSet<RefPDActivityCreditType>();
            RefPDActivityEducationLevelsAddresseds = new HashSet<RefPDActivityEducationLevelsAddressed>();
            RefPDActivityLevels = new HashSet<RefPDActivityLevel>();
            RefPDActivityTargetAudiences = new HashSet<RefPDActivityTargetAudience>();
            RefPDActivityTypes = new HashSet<RefPDActivityType>();
            RefPDAudienceTypes = new HashSet<RefPDAudienceType>();
            RefPDDeliveryMethods = new HashSet<RefPDDeliveryMethod>();
            RefPDInstructionalDeliveryModes = new HashSet<RefPDInstructionalDeliveryMode>();
            RefPDSessionStatus = new HashSet<RefPDSessionStatu>();
            RefPersonalInformationTypes = new HashSet<RefPersonalInformationType>();
            RefPersonalInformationVerifications = new HashSet<RefPersonalInformationVerification>();
            RefPersonIdentifierTypes = new HashSet<RefPersonIdentifierType>();
            RefPersonLocationTypes = new HashSet<RefPersonLocationType>();
            RefPersonStatusTypes = new HashSet<RefPersonStatusType>();
            RefPersonTelephoneNumberTypes = new HashSet<RefPersonTelephoneNumberType>();
            RefPESCAwardLevelTypes = new HashSet<RefPESCAwardLevelType>();
            RefPopulationServeds = new HashSet<RefPopulationServed>();
            RefPsLepTypes = new HashSet<RefPsLepType>();
            RefPreAndPostTestIndicators = new HashSet<RefPreAndPostTestIndicator>();
            RefPredominantCalendarSystems = new HashSet<RefPredominantCalendarSystem>();
            RefPreKEligibleAgesNonIDEAs = new HashSet<RefPreKEligibleAgesNonIDEA>();
            RefPrekindergartenEligibilities = new HashSet<RefPrekindergartenEligibility>();
            RefPresentAttendanceCategories = new HashSet<RefPresentAttendanceCategory>();
            RefPrimaryLearningDeviceAccesses = new HashSet<RefPrimaryLearningDeviceAccess>();
            RefPrimaryLearningDeviceAwayFromSchools = new HashSet<RefPrimaryLearningDeviceAwayFromSchool>();
            RefPrimaryLearningDeviceProviders = new HashSet<RefPrimaryLearningDeviceProvider>();
            RefProfessionalDevelopmentFinancialSupports = new HashSet<RefProfessionalDevelopmentFinancialSupport>();
            RefProfessionalEducationJobClassifications = new HashSet<RefProfessionalEducationJobClassification>();
            RefProficiencyStatus = new HashSet<RefProficiencyStatu>();
            RefProficiencyTargetAyps = new HashSet<RefProficiencyTargetAyp>();
            RefProfitStatus = new HashSet<RefProfitStatu>();
            RefProfessionalTechnicalCredentialTypes = new HashSet<RefProfessionalTechnicalCredentialType>();
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
            RefPsEnrollmentStatus = new HashSet<RefPsEnrollmentStatu>();
            RefPsEnrollmentTypes = new HashSet<RefPsEnrollmentType>();
            RefPSExitOrWithdrawalTypes = new HashSet<RefPSExitOrWithdrawalType>();
            RefPSProgramLevels = new HashSet<RefPSProgramLevel>();
            RefPsStudentLevels = new HashSet<RefPsStudentLevel>();
            RefPublicSchoolChoiceStatus = new HashSet<RefPublicSchoolChoiceStatu>();
            RefPublicSchoolResidences = new HashSet<RefPublicSchoolResidence>();
            RefPurposeOfMonitoringVisits = new HashSet<RefPurposeOfMonitoringVisit>();
            RefQrisParticipations = new HashSet<RefQrisParticipation>();
            RefRaces = new HashSet<RefRace>();
            RefReapAlternativeFundingStatus = new HashSet<RefReapAlternativeFundingStatu>();
            RefReasonDelayTransitionConfs = new HashSet<RefReasonDelayTransitionConf>();
            RefReconstitutedStatus = new HashSet<RefReconstitutedStatu>();
            RefRecordStatusCreatorEntities = new HashSet<RefRecordStatusCreatorEntity>();
            RefRecordStatusTypes = new HashSet<RefRecordStatusType>();
            RefReferralOutcomes = new HashSet<RefReferralOutcome>();
            RefReimbursementTypes = new HashSet<RefReimbursementType>();
            RefPersonRelationshipTypes = new HashSet<RefPersonRelationshipType>();
            RefRestructuringActions = new HashSet<RefRestructuringAction>();
            RefRlisProgramUses = new HashSet<RefRlisProgramUse>();
            RefRoles = new HashSet<RefRole>();
            RefRoleStatus = new HashSet<RefRoleStatus>();
            RefRoleStatusTypes = new HashSet<RefRoleStatusType>();
            RefSCEDCourseLevels = new HashSet<RefSCEDCourseLevel>();
            RefSCEDCourseSubjectAreas = new HashSet<RefSCEDCourseSubjectArea>();
            RefScheduledWellChildScreenings = new HashSet<RefScheduledWellChildScreening>();
            RefSchoolDangerousStatus = new HashSet<RefSchoolDangerousStatu>();
            RefSchoolFoodServicePrograms = new HashSet<RefSchoolFoodServiceProgram>();
            RefSchoolImprovementFunds = new HashSet<RefSchoolImprovementFund>();
            RefSchoolImprovementFunds1 = new HashSet<RefSchoolImprovementFund>();
            RefSchoolImprovementStatus = new HashSet<RefSchoolImprovementStatu>();
            RefSchoolLevels = new HashSet<RefSchoolLevel>();
            RefSchoolTypes = new HashSet<RefSchoolType>();
            RefScoreMetricTypes = new HashSet<RefScoreMetricType>();
            RefServiceFrequencies = new HashSet<RefServiceFrequency>();
            RefServiceOptions = new HashSet<RefServiceOption>();
            RefServices = new HashSet<RefService>();
            RefSessionTypes = new HashSet<RefSessionType>();
            RefSexes = new HashSet<RefSex>();
            RefSigInterventionTypes = new HashSet<RefSigInterventionType>();
            RefSingleSexClassStatus = new HashSet<RefSingleSexClassStatu>();
            RefSpaceUseTypes = new HashSet<RefSpaceUseType>();
            RefSpecialEducationAgeGroupTaughts = new HashSet<RefSpecialEducationAgeGroupTaught>();
            RefSpecialEducationExitReasons = new HashSet<RefSpecialEducationExitReason>();
            RefSpecialEducationStaffCategories = new HashSet<RefSpecialEducationStaffCategory>();
            RefStaffCompensationSourceTypes = new HashSet<RefStaffCompensationSourceType>();
            RefStaffPerformanceLevels = new HashSet<RefStaffPerformanceLevel>();
            RefStandardizedAdmissionTests = new HashSet<RefStandardizedAdmissionTest>();
            RefStates = new HashSet<RefState>();
            RefStateANSICodes = new HashSet<RefStateANSICode>();
            RefStatePovertyDesignations = new HashSet<RefStatePovertyDesignation>();
            RefStudentEnrollmentAccessTypes = new HashSet<RefStudentEnrollmentAccessType>();
            RefStudentSchoolAffiliationStateDefinedStatus = new HashSet<RefStudentSchoolAffiliationStateDefinedStatu>();
            RefStudentSupportServiceTypes = new HashSet<RefStudentSupportServiceType>();
            RefSupervisedClinicalExperiences = new HashSet<RefSupervisedClinicalExperience>();
            RefTargetedSupports = new HashSet<RefTargetedSupport>();
            RefTargetedSupportAndImprovementStatus = new HashSet<RefTargetedSupportAndImprovementStatu>();
            RefTeacherEducationCredentialExams = new HashSet<RefTeacherEducationCredentialExam>();
            RefTeacherEducationExamScoreTypes = new HashSet<RefTeacherEducationExamScoreType>();
            RefTeacherEducationTestCompanies = new HashSet<RefTeacherEducationTestCompany>();
            RefTeacherPrepCompleterStatus = new HashSet<RefTeacherPrepCompleterStatu>();
            RefTeacherPrepEnrollmentStatus = new HashSet<RefTeacherPrepEnrollmentStatu>();
            RefTeachingAssignmentRoles = new HashSet<RefTeachingAssignmentRole>();
            RefTeachingCredentialBasis = new HashSet<RefTeachingCredentialBasi>();
            RefTeachingCredentialTypes = new HashSet<RefTeachingCredentialType>();
            RefTechnicalAssistanceDeliveryTypes = new HashSet<RefTechnicalAssistanceDeliveryType>();
            RefTechnicalAssistanceTypes = new HashSet<RefTechnicalAssistanceType>();
            RefTechnologyLiteracyStatus = new HashSet<RefTechnologyLiteracyStatu>();
            RefTelephoneNumberListedStatus = new HashSet<RefTelephoneNumberListedStatu>();
            RefTelephoneNumberTypes = new HashSet<RefTelephoneNumberType>();
            RefTenureSystems = new HashSet<RefTenureSystem>();
            RefTextComplexitySystems = new HashSet<RefTextComplexitySystem>();
            RefTimeForCompletionUnits = new HashSet<RefTimeForCompletionUnit>();
            RefTitleISchoolStatus = new HashSet<RefTitleISchoolStatu>();
            RefTitleIIIAccountabilities = new HashSet<RefTitleIIIAccountability>();
            RefTitleIIIProfessionalDevelopmentTypes = new HashSet<RefTitleIIIProfessionalDevelopmentType>();
            RefTitleIIndicators = new HashSet<RefTitleIIndicator>();
            RefTitleIInstructionalServices = new HashSet<RefTitleIInstructionalService>();
            RefTitleIProgramStaffCategories = new HashSet<RefTitleIProgramStaffCategory>();
            RefTitleIProgramTypes = new HashSet<RefTitleIProgramType>();
            RefTransferOutIndicators = new HashSet<RefTransferOutIndicator>();
            RefTransferReadies = new HashSet<RefTransferReady>();
            RefTribalAffiliations = new HashSet<RefTribalAffiliation>();
            RefTrimesterWhenPrenatalCareBegans = new HashSet<RefTrimesterWhenPrenatalCareBegan>();
            RefTuitionResidencyTypes = new HashSet<RefTuitionResidencyType>();
            RefTuitionUnits = new HashSet<RefTuitionUnit>();
            RefUSCitizenshipStatus = new HashSet<RefUSCitizenshipStatu>();
            RefVirtualSchoolStatus = new HashSet<RefVirtualSchoolStatu>();
            RefVisaTypes = new HashSet<RefVisaType>();
            RefVisionScreeningStatus = new HashSet<RefVisionScreeningStatu>();
            RefWageCollectionMethods = new HashSet<RefWageCollectionMethod>();
            RefWageVerifications = new HashSet<RefWageVerification>();
            RefWeaponTypes = new HashSet<RefWeaponType>();
            RefWfProgramParticipations = new HashSet<RefWfProgramParticipation>();
            RefWIOABarrierstoEmployments = new HashSet<RefWIOABarrierstoEmployment>();
            RefWorkbasedLearningOpportunityTypes = new HashSet<RefWorkbasedLearningOpportunityType>();
            RequiredImmunizations = new HashSet<RequiredImmunization>();
            Roles = new HashSet<Role>();
            ServiceProviders = new HashSet<ServiceProvider>();
        }

        public int OrganizationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AeProvider> AeProviders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentAdministrationOrganization> AssessmentAdministrationOrganization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrations1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrations2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSession> AssessmentSessions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSession> AssessmentSessions1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSession> AssessmentSessions2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSection> CourseSections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialAward> CredentialAwards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialDefAgent> CredentialDefAgents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialIssuer> CredentialIssuers { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EarlyChildhoodProgramTypeOffered> EarlyChildhoodProgramTypeOffereds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELClassSection> ELClassSections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELFacilityLicensing> ELFacilityLicensings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELOrganization> ELOrganizations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELOrganizationAvailability> ELOrganizationAvailabilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELOrganizationFund> ELOrganizationFunds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELOrganizationMonitoring> ELOrganizationMonitorings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELProgramLicensing> ELProgramLicensings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELQualityInitiative> ELQualityInitiatives { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELQualityRatingImprovement> ELQualityRatingImprovements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELServicePartner> ELServicePartners { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facility> Facilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12CharterSchoolAuthorizerAgency> K12CharterSchoolAuthorizerAgency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12CharterSchoolManagementOrganization> K12CharterSchoolManagementOrganization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12Lea> K12Lea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12ProgramOrService> K12ProgramOrService { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12School> K12School { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12Sea> K12Sea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12TitleIIILanguageInstruction> K12TitleIIILanguageInstruction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerActivity> LearnerActivities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerActivity> LearnerActivities1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationRelationship> OrganizationRelationships { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationEmail> OrganizationEmails { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationAccreditation> OrganizationAccreditations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationCalendar> OrganizationCalendars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationCalendarCrisis> OrganizationCalendarCrisis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationDetail> OrganizationDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationEmployeeBenefit> OrganizationEmployeeBenefits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationFederalAccountability> OrganizationFederalAccountabilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationIdentifier> OrganizationIdentifiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationImage> OrganizationImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationIndicator> OrganizationIndicators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationLocation> OrganizationLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationOperationalStatu> OrganizationOperationalStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationPersonRole> OrganizationPersonRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationPolicy> OrganizationPolicies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationPopulationServed> OrganizationPopulationServeds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationProgramType> OrganizationProgramTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationRelationship> OrganizationRelationships1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationService> OrganizationServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationTechnicalAssistance> OrganizationTechnicalAssistances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationTelephone> OrganizationTelephones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationWebsite> OrganizationWebsites { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Program> Programs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramParticipationMigrant> ProgramParticipationMigrants { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PsInstitution> PsInstitutions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PsProgram> PsPrograms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecordStatus> RecordStatuses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecordStatusHistory> RecordStatusHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAbsentAttendanceCategory> RefAbsentAttendanceCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAcademicAwardLevel> RefAcademicAwardLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAcademicAwardPrerequisiteType> RefAcademicAwardPrerequisiteTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAcademicHonorType> RefAcademicHonorTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAcademicRank> RefAcademicRanks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAcademicSubject> RefAcademicSubjects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAcademicTermDesignator> RefAcademicTermDesignators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAccommodationsNeededType> RefAccommodationsNeededTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAccommodationType> RefAccommodationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAccreditationAgency> RefAccreditationAgencies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefActivityRecognitionType> RefActivityRecognitionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefActivityTimeMeasurementType> RefActivityTimeMeasurementTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAdditionalCreditType> RefAdditionalCreditTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAdditionalTargetedSupportAndImprovementStatu> RefAdditionalTargetedSupportAndImprovementStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAddressType> RefAddressTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAdministrativeFundingControl> RefAdministrativeFundingControls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAdmissionConsiderationLevel> RefAdmissionConsiderationLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAdmissionConsiderationType> RefAdmissionConsiderationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAdmittedStudent> RefAdmittedStudents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAdultEducationProgramExitReason> RefAdultEducationProgramExitReasons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAdvancedPlacementCourseCode> RefAdvancedPlacementCourseCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAeCertificationType> RefAeCertificationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAeFunctioningLevelAtIntake> RefAeFunctioningLevelAtIntakes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAeFunctioningLevelAtPosttest> RefAeFunctioningLevelAtPosttests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAeInstructionalProgramType> RefAeInstructionalProgramTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAePostsecondaryTransitionAction> RefAePostsecondaryTransitionActions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAeSpecialProgramType> RefAeSpecialProgramTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAeStaffClassification> RefAeStaffClassifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAeStaffEmploymentStatu> RefAeStaffEmploymentStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAllergySeverity> RefAllergySeverities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAllergyType> RefAllergyTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAlternateFundUs> RefAlternateFundUses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAlternativeSchoolFocu> RefAlternativeSchoolFocus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAltRouteToCertificationOrLicensure> RefAltRouteToCertificationOrLicensures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAmaoAttainmentStatu> RefAmaoAttainmentStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefApipInteractionType> RefApipInteractionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentItemCharacteristicType> RefAssessmentItemCharacteristicTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentItemResponseStatu> RefAssessmentItemResponseStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentAssetIdentifierType> RefAssessmentAssetIdentifierTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentAssetType> RefAssessmentAssetTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentELDevelopmentalDomain> RefAssessmentELDevelopmentalDomains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentFormSectionIdentificationSystem> RefAssessmentFormSectionIdentificationSystems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentItemResponseScoreStatu> RefAssessmentItemResponseScoreStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentItemType> RefAssessmentItemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedAlternativeRepresentationType> RefAssessmentNeedAlternativeRepresentationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedBrailleGradeType> RefAssessmentNeedBrailleGradeTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedBrailleMarkType> RefAssessmentNeedBrailleMarkTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedBrailleStatusCellType> RefAssessmentNeedBrailleStatusCellTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedHazardType> RefAssessmentNeedHazardTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedIncreasedWhitespacingType> RefAssessmentNeedIncreasedWhitespacingTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedLanguageLearnerType> RefAssessmentNeedLanguageLearnerTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedLinkIndicationType> RefAssessmentNeedLinkIndicationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedMaskingType> RefAssessmentNeedMaskingTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedNumberOfBrailleDot> RefAssessmentNeedNumberOfBrailleDots { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedSigningType> RefAssessmentNeedSigningTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedSpokenSourcePreferenceType> RefAssessmentNeedSpokenSourcePreferenceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedSupportTool> RefAssessmentNeedSupportTools { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedUsageType> RefAssessmentNeedUsageTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentNeedUserSpokenPreferenceType> RefAssessmentNeedUserSpokenPreferenceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentParticipationIndicator> RefAssessmentParticipationIndicators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentPlatformType> RefAssessmentPlatformTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentPurpose> RefAssessmentPurposes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentReasonNotCompleting> RefAssessmentReasonNotCompletings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentReasonNotTested> RefAssessmentReasonNotTesteds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentRegistrationCompletionStatu> RefAssessmentRegistrationCompletionStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentReportingMethod> RefAssessmentReportingMethods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentResultDataType> RefAssessmentResultDataTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentResultScoreType> RefAssessmentResultScoreTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentSessionSpecialCircumstanceType> RefAssessmentSessionSpecialCircumstanceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentSessionStaffRoleType> RefAssessmentSessionStaffRoleTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentSessionType> RefAssessmentSessionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentPretestOutcome> RefAssessmentPretestOutcomes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentType> RefAssessmentTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentTypeChildrenWithDisability> RefAssessmentTypeChildrenWithDisabilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAssessmentSubtestIdentifierType> RefAssessmentSubtestIdentifierTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEntityType> RefEntityTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAttendanceEventType> RefAttendanceEventTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAttendanceStatu> RefAttendanceStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAuthorizerType> RefAuthorizerTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefAypStatu> RefAypStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBarrierToEducatingHomeless> RefBarrierToEducatingHomelesses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBarrierToInternetAccessInResidence> RefBarrierToInternetAccessInResidences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBillableBasisType> RefBillableBasisTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBlendedLearningModelType> RefBlendedLearningModelTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBloomsTaxonomyDomain> RefBloomsTaxonomyDomains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingAdministrativeSpaceType> RefBuildingAdministrativeSpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingAirDistributionSystemType> RefBuildingAirDistributionSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingArtSpecialtySpaceType> RefBuildingArtSpecialtySpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingAssemblySpaceType> RefBuildingAssemblySpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingBasicClassroomDesignType> RefBuildingBasicClassroomDesignTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingCareerTechEducationSpaceType> RefBuildingCareerTechEducationSpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingCharterSchoolRealtyAccessType> RefBuildingCharterSchoolRealtyAccessTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingCirculationSpaceType> RefBuildingCirculationSpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingCleaningStandardType> RefBuildingCleaningStandardTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingCommMgmtComponentSystemType> RefBuildingCommMgmtComponentSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingCommunityUseSpaceType> RefBuildingCommunityUseSpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingCoolingGenerationSystemType> RefBuildingCoolingGenerationSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingDesignType> RefBuildingDesignTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingElectricalSystemType> RefBuildingElectricalSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingEnergyConservationMeasureType> RefBuildingEnergyConservationMeasureTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingEnergySourceType> RefBuildingEnergySourceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingEnvOrEnergyPerformanceRatingCat> RefBuildingEnvOrEnergyPerformanceRatingCats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingFireProtectionSystemType> RefBuildingFireProtectionSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingFoodServiceSpaceType> RefBuildingFoodServiceSpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingFullServiceKitchenType> RefBuildingFullServiceKitchenTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingHeatingGenerationSystemType> RefBuildingHeatingGenerationSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingHistoricStatu> RefBuildingHistoricStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingHVACSystemType> RefBuildingHVACSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingIndoorAthleticOrPhysEdSpaceType> RefBuildingIndoorAthleticOrPhysEdSpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingInstructionalSpaceFactorType> RefBuildingInstructionalSpaceFactorTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingJointUseRationaleType> RefBuildingJointUseRationaleTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingJointUserType> RefBuildingJointUserTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingJointUseSchedulingType> RefBuildingJointUseSchedulingTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingLibMediaCenterSpecialtySpaceType> RefBuildingLibMediaCenterSpecialtySpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingMechanicalConveyingSystemType> RefBuildingMechanicalConveyingSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingMechanicalSystemType> RefBuildingMechanicalSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingOperationsOrMaintSpaceType> RefBuildingOperationsOrMaintSpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingOutdoorAthleticOrPhysEdSpaceType> RefBuildingOutdoorAthleticOrPhysEdSpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingOutdoorOrNonathleticSpaceType> RefBuildingOutdoorOrNonathleticSpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingPerformingArtsSpecialtySpaceType> RefBuildingPerformingArtsSpecialtySpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingPlumbingSystemType> RefBuildingPlumbingSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingPrimaryUseType> RefBuildingPrimaryUseTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingSchoolDesignType> RefBuildingSchoolDesignTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingScienceSpecialtySpaceType> RefBuildingScienceSpecialtySpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingSecuritySystemType> RefBuildingSecuritySystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingSiteUseRestrictionsType> RefBuildingSiteUseRestrictionsTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingSpaceDesignType> RefBuildingSpaceDesignTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingSpecEdSpecialtySpaceType> RefBuildingSpecEdSpecialtySpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingStudentSupportSpaceType> RefBuildingStudentSupportSpaceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingSystemType> RefBuildingSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingTechnologyWiringSystemType> RefBuildingTechnologyWiringSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingUseType> RefBuildingUseTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefBuildingVerticalTransportationSystemType> RefBuildingVerticalTransportationSystemTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCalendarEventType> RefCalendarEventTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCampusResidencyType> RefCampusResidencyTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCampusStatu> RefCampusStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCampusType> RefCampusTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCareerCluster> RefCareerClusters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCareerEducationPlanType> RefCareerEducationPlanTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCarnegieBasicClassification> RefCarnegieBasicClassifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCharterLeaStatu> RefCharterLeaStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCharterSchoolAuthorizerType> RefCharterSchoolAuthorizerTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCharterSchoolManagementOrganizationType> RefCharterSchoolManagementOrganizationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCharterSchoolType> RefCharterSchoolTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefChildDevelopmentAssociateType> RefChildDevelopmentAssociateTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefChildDevelopmentalScreeningStatu> RefChildDevelopmentalScreeningStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefChildOutcomesSummaryRating> RefChildOutcomesSummaryRatings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCipCode> RefCipCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCipUse> RefCipUses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCipVersion> RefCipVersions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefClassroomPositionType> RefClassroomPositionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCohortExclusion> RefCohortExclusions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCommunicationMethod> RefCommunicationMethods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCommunityBasedType> RefCommunityBasedTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCompetencyDefAssociationType> RefCompetencyDefAssociationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCompetencyDefNodeAccessibilityProfile> RefCompetencyDefNodeAccessibilityProfiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCompetencyDefTestabilityType> RefCompetencyDefTestabilityTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCompetencyFrameworkPublicationStatu> RefCompetencyFrameworkPublicationStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCompetencySetCompletionCriteria> RefCompetencySetCompletionCriterias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefComprehensiveAndTargetedSupport> RefComprehensiveAndTargetedSupports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefComprehensiveSupport> RefComprehensiveSupports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefComprehensiveSupportAndImprovementStatu> RefComprehensiveSupportAndImprovementStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefContentStandardType> RefContentStandardTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefContinuationOfService> RefContinuationOfServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefControlOfInstitution> RefControlOfInstitutions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCoreKnowledgeArea> RefCoreKnowledgeAreas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCorrectionalEducationFacilityType> RefCorrectionalEducationFacilityTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCorrectiveActionType> RefCorrectiveActionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCountry> RefCountries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCounty> RefCounties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseAcademicGradeStatusCode> RefCourseAcademicGradeStatusCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseApplicableEducationLevel> RefCourseApplicableEducationLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseCreditBasisType> RefCourseCreditBasisTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseCreditLevelType> RefCourseCreditLevelTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseCreditUnit> RefCourseCreditUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseGpaApplicability> RefCourseGpaApplicabilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseHonorsType> RefCourseHonorsTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseInstructionMethod> RefCourseInstructionMethods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseInstructionSiteType> RefCourseInstructionSiteTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseInteractionMode> RefCourseInteractionModes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseLevelCharacteristic> RefCourseLevelCharacteristics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseLevelType> RefCourseLevelTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseRepeatCode> RefCourseRepeatCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseSectionAssessmentReportingMethod> RefCourseSectionAssessmentReportingMethods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseSectionDeliveryMode> RefCourseSectionDeliveryModes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseSectionEnrollmentStatusType> RefCourseSectionEnrollmentStatusTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseSectionEntryType> RefCourseSectionEntryTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCourseSectionExitType> RefCourseSectionExitTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCredentialDefAgentRoleType> RefCredentialDefAgentRoleTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCredentialDefAssessMethodType> RefCredentialDefAssessMethodTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCredentialDefIntendedPurposeType> RefCredentialDefIntendedPurposeTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCredentialDefStatusType> RefCredentialDefStatusTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCredentialDefVerificationType> RefCredentialDefVerificationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCredentialIdentifierSystem> RefCredentialIdentifierSystems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCredentialType> RefCredentialTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCreditHoursAppliedOtherProgram> RefCreditHoursAppliedOtherPrograms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCreditTypeEarned> RefCreditTypeEarneds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCriticalTeacherShortageCandidate> RefCriticalTeacherShortageCandidates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCTDLAudienceLevelType> RefCTDLAudienceLevelTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCTDLOrganizationType> RefCTDLOrganizationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCteGraduationRateInclusion> RefCteGraduationRateInclusions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCteNonTraditionalGenderStatu> RefCteNonTraditionalGenderStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefCurriculumFrameworkType> RefCurriculumFrameworkTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDataCollectionStatu> RefDataCollectionStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDegreeOrCertificateType> RefDegreeOrCertificateTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDentalScreeningStatu> RefDentalScreeningStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDentalInsuranceCoverageType> RefDentalInsuranceCoverageTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDependencyStatu> RefDependencyStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDevelopmentalEducationReferralStatu> RefDevelopmentalEducationReferralStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDevelopmentalEducationType> RefDevelopmentalEducationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDevelopmentalEvaluationFinding> RefDevelopmentalEvaluationFindings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDirectoryInformationBlockStatu> RefDirectoryInformationBlockStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDisabilityType> RefDisabilityTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDisabilityConditionStatusCode> RefDisabilityConditionStatusCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDisabilityConditionType> RefDisabilityConditionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDisabilityDeterminationSourceType> RefDisabilityDeterminationSourceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDisciplinaryActionTaken> RefDisciplinaryActionTakens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDisciplineLengthDifferenceReason> RefDisciplineLengthDifferenceReasons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDisciplineMethodFirearm> RefDisciplineMethodFirearms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDisciplineMethodOfCwd> RefDisciplineMethodOfCwds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDisciplineReason> RefDisciplineReasons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDistanceEducationCourseEnrollment> RefDistanceEducationCourseEnrollments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDoctoralExamsRequiredCode> RefDoctoralExamsRequiredCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefDQPCategoriesOfLearning> RefDQPCategoriesOfLearnings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEarlyChildhoodCredential> RefEarlyChildhoodCredentials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEarlyChildhoodProgramEnrollmentType> RefEarlyChildhoodProgramEnrollmentTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEarlyChildhoodService> RefEarlyChildhoodServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType> RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEdFactsAcademicOrCareerAndTechnicalOutcomeType> RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEDFactsTeacherInexperiencedStatu> RefEDFactsTeacherInexperiencedStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEducationLevel> RefEducationLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEducationLevelType> RefEducationLevelTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefK12StaffClassification> RefK12StaffClassification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEducationVerificationMethod> RefEducationVerificationMethods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELEducationStaffClassification> RefELEducationStaffClassifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefElementaryMiddleAdditional> RefElementaryMiddleAdditionals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELEmploymentSeparationReason> RefELEmploymentSeparationReasons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELFacilityLicensingStatu> RefELFacilityLicensingStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELFederalFundingType> RefELFederalFundingTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELGroupSizeStandardMet> RefELGroupSizeStandardMets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELLevelOfSpecialization> RefELLevelOfSpecializations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELLocalRevenueSource> RefELLocalRevenueSources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELOtherFederalFundingSource> RefELOtherFederalFundingSources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELOutcomeMeasurementLevel> RefELOutcomeMeasurementLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELProfessionalDevelopmentTopicArea> RefELProfessionalDevelopmentTopicAreas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELProgramEligibility> RefELProgramEligibilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELProgramEligibilityStatu> RefELProgramEligibilityStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELProgramLicenseStatu> RefELProgramLicenseStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELServiceProfessionalStaffClassification> RefELServiceProfessionalStaffClassifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELServiceType> RefELServiceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELStateRevenueSource> RefELStateRevenueSources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefELTrainerCoreKnowledgeArea> RefELTrainerCoreKnowledgeAreas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEmailType> RefEmailTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEmergencyOrProvisionalCredentialStatu> RefEmergencyOrProvisionalCredentialStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEmployedAfterExit> RefEmployedAfterExits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEmployedPriorToEnrollment> RefEmployedPriorToEnrollments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEmployedWhileEnrolled> RefEmployedWhileEnrolleds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEmployeeBenefit> RefEmployeeBenefits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEmploymentContractType> RefEmploymentContractTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEmploymentSeparationReason> RefEmploymentSeparationReasons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEmploymentSeparationType> RefEmploymentSeparationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEmploymentStatu> RefEmploymentStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEmploymentStatusWhileEnrolled> RefEmploymentStatusWhileEnrolleds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEndOfTermStatu> RefEndOfTermStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEnrollmentStatu> RefEnrollmentStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEntryType> RefEntryTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefEnvironmentSetting> RefEnvironmentSettings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefERAdministrativeDataSource> RefERAdministrativeDataSources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefERSRuralUrbanContinuumCode> RefERSRuralUrbanContinuumCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefExitOrWithdrawalStatu> RefExitOrWithdrawalStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefExitOrWithdrawalType> RefExitOrWithdrawalTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilitiesMandateAuthorityType> RefFacilitiesMandateAuthorityTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilitiesMgmtEmergencyType> RefFacilitiesMgmtEmergencyTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilitiesPlanType> RefFacilitiesPlanTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityApplicableFederalMandateType> RefFacilityApplicableFederalMandateTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityAuditType> RefFacilityAuditTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityCapitalProgramMgmtType> RefFacilityCapitalProgramMgmtTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityComplianceAgencyType> RefFacilityComplianceAgencyTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityComplianceStatu> RefFacilityComplianceStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityConstructionDateType> RefFacilityConstructionDateTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityConstructionMaterialType> RefFacilityConstructionMaterialTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityFederalMandateInterestType> RefFacilityFederalMandateInterestTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityFinancingFeeType> RefFacilityFinancingFeeTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityFurnishingsType> RefFacilityFurnishingsTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityHazardousMaterialsOrCondType> RefFacilityHazardousMaterialsOrCondTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityJointDevelopmentType> RefFacilityJointDevelopmentTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityLeaseAmountCategory> RefFacilityLeaseAmountCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityLeaseType> RefFacilityLeaseTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityMaintStandardType> RefFacilityMaintStandardTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityMortgageInterestType> RefFacilityMortgageInterestTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityMortgageType> RefFacilityMortgageTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityNaturallyOccurringHazardType> RefFacilityNaturallyOccurringHazardTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityOperationsMgmtType> RefFacilityOperationsMgmtTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilitySiteImprovementLocationType> RefFacilitySiteImprovementLocationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilitySiteOutdoorAreaType> RefFacilitySiteOutdoorAreaTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityStandardType> RefFacilityStandardTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityStateOrLocalMandateInterestType> RefFacilityStateOrLocalMandateInterestTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilitySystemOrComponentCondition> RefFacilitySystemOrComponentConditions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityUtilityProviderType> RefFacilityUtilityProviderTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFacilityUtilityType> RefFacilityUtilityTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFamilyIncomeSource> RefFamilyIncomeSources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFederalProgramFundingAllocationType> RefFederalProgramFundingAllocationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialAccountCategory> RefFinancialAccountCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialAccountFundClassification> RefFinancialAccountFundClassifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialAccountProgramCode> RefFinancialAccountProgramCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialAidApplicationType> RefFinancialAidApplicationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialAidAwardStatu> RefFinancialAidAwardStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialAidAwardType> RefFinancialAidAwardTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialAidVeteransBenefitStatu> RefFinancialAidVeteransBenefitStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialAidVeteransBenefitType> RefFinancialAidVeteransBenefitTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialAccountBalanceSheetCode> RefFinancialAccountBalanceSheetCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialExpenditureFunctionCode> RefFinancialExpenditureFunctionCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialExpenditureLevelOfInstructionCode> RefFinancialExpenditureLevelOfInstructionCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialExpenditureObjectCode> RefFinancialExpenditureObjectCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFinancialAccountRevenueCode> RefFinancialAccountRevenueCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFirearmType> RefFirearmTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFoodServiceEligibility> RefFoodServiceEligibilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFoodServiceParticipation> RefFoodServiceParticipations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFrequencyOfService> RefFrequencyOfServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFrequencyUnit> RefFrequencyUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefFullTimeStatu> RefFullTimeStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefGoalMeasurementType> RefGoalMeasurementTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefGoalsForAttendingAdultEducation> RefGoalsForAttendingAdultEducations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefGoalStatusType> RefGoalStatusTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefGpaWeightedIndicator> RefGpaWeightedIndicators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefGradeLevel> RefGradeLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefGradeLevelsApproved> RefGradeLevelsApproveds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefGradeLevelType> RefGradeLevelTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefGradePointAverageDomain> RefGradePointAverageDomains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefGraduateAssistantIpedsCategory> RefGraduateAssistantIpedsCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefGraduateOrDoctoralExamResultsStatu> RefGraduateOrDoctoralExamResultsStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefGunFreeSchoolsActReportingStatu> RefGunFreeSchoolsActReportingStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefHearingScreeningStatu> RefHearingScreeningStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefHigherEducationInstitutionAccreditationStatu> RefHigherEducationInstitutionAccreditationStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefHighSchoolDiplomaType> RefHighSchoolDiplomaTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefHomelessNighttimeResidence> RefHomelessNighttimeResidences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefHighSchoolDiplomaDistinctionType> RefHighSchoolDiplomaDistinctionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefHighSchoolGraduationRateIndicator> RefHighSchoolGraduationRateIndicators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIDEADisabilityType> RefIDEADisabilityTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIDEADisciplineMethodFirearm> RefIDEADisciplineMethodFirearms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIDEAEducationalEnvironmentEC> RefIDEAEducationalEnvironmentECs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIDEAEducationalEnvironmentSchoolAge> RefIDEAEducationalEnvironmentSchoolAges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIDEAEligibilityEvaluationCategory> RefIDEAEligibilityEvaluationCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIDEAEnvironmentEL> RefIDEAEnvironmentELs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIDEAIEPStatu> RefIDEAIEPStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIDEAInterimRemoval> RefIDEAInterimRemovals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIDEAInterimRemovalReason> RefIDEAInterimRemovalReasons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIDEAPartCEligibilityCategory> RefIDEAPartCEligibilityCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOrganizationIdentificationSystem> RefOrganizationIdentificationSystems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPersonIdentificationSystem> RefPersonIdentificationSystems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIEPAuthorizationDocumentType> RefIEPAuthorizationDocumentTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIEPEligibilityEvaluationType> RefIEPEligibilityEvaluationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIEPGoalType> RefIEPGoalTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefImmunizationType> RefImmunizationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncidentBehavior> RefIncidentBehaviors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncidentBehaviorSecondary> RefIncidentBehaviorSecondaries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncidentInjuryType> RefIncidentInjuryTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncidentLocation> RefIncidentLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncidentMultipleOffenseType> RefIncidentMultipleOffenseTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncidentPerpetratorInjuryType> RefIncidentPerpetratorInjuryTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncidentPersonRoleType> RefIncidentPersonRoleTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncidentPersonType> RefIncidentPersonTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncidentReporterType> RefIncidentReporterTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncidentTimeDescriptionCode> RefIncidentTimeDescriptionCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncomeCalculationMethod> RefIncomeCalculationMethods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncomeCalculationMethod> RefIncomeCalculationMethods1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIncreasedLearningTimeType> RefIncreasedLearningTimeTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIndicatorStateDefinedStatu> RefIndicatorStateDefinedStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIndicatorStatusCustomType> RefIndicatorStatusCustomTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIndicatorStatusSubgroupType> RefIndicatorStatusSubgroupTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIndicatorStatusType> RefIndicatorStatusTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIndividualizedProgramDateType> RefIndividualizedProgramDateTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIndividualizedProgramLocation> RefIndividualizedProgramLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIndividualizedProgramPlannedServiceType> RefIndividualizedProgramPlannedServiceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIndividualizedProgramTransitionType> RefIndividualizedProgramTransitionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIndividualizedProgramType> RefIndividualizedProgramTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefInstitutionTelephoneType> RefInstitutionTelephoneTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefInstructionalActivityHour> RefInstructionalActivityHours { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefInstructionCreditType> RefInstructionCreditTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefInstructionLocationType> RefInstructionLocationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefInstructionalStaffContractLength> RefInstructionalStaffContractLengths { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefInstructionalStaffFacultyTenure> RefInstructionalStaffFacultyTenures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefHealthInsuranceCoverage> RefHealthInsuranceCoverages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIntegratedTechnologyStatu> RefIntegratedTechnologyStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefInternetAccess> RefInternetAccesses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefInternetAccessTypeInResidence> RefInternetAccessTypeInResidences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefInternetPerformanceInResidence> RefInternetPerformanceInResidences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPEDSFASBFinancialPosition> RefIPEDSFASBFinancialPositions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPEDSFASBFunctionalExpense> RefIPEDSFASBFunctionalExpenses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPEDSFASBPellGrantTransaction> RefIPEDSFASBPellGrantTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPEDSFASBRevenue> RefIPEDSFASBRevenues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPEDSFASBRevenueRestriction> RefIPEDSFASBRevenueRestrictions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPEDSFASBScholarshipsandFellowshipsRevenue> RefIPEDSFASBScholarshipsandFellowshipsRevenues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPEDSGASBFinancialPosition> RefIPEDSGASBFinancialPositions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPEDSGASBFunctionalExpense> RefIPEDSGASBFunctionalExpenses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPEDSGASBRevenue> RefIPEDSGASBRevenues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPEDSGASBScholarshipsandFellowshipsRevenue> RefIPEDSGASBScholarshipsandFellowshipsRevenues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPEDSIntercollegiateAthleticsExpens> RefIPEDSIntercollegiateAthleticsExpenses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPEDSNaturalExpense> RefIPEDSNaturalExpenses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIpedsOccupationalCategory> RefIpedsOccupationalCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPSPProgressReportSchedule> RefIPSPProgressReportSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefIPSPProgressReportType> RefIPSPProgressReportTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefItemResponseTheoryDifficultyCategory> RefItemResponseTheoryDifficultyCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefItemResponseTheoryKappaAlgorithm> RefItemResponseTheoryKappaAlgorithms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefISO6392Language> RefISO6392Language { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefISO6393Language> RefISO6393Language { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefISO6395LanguageFamily> RefISO6395LanguageFamily { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefK12EndOfCourseRequirement> RefK12EndOfCourseRequirement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefK12LeaTitleISupportService> RefK12LeaTitleISupportService { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefK12ResponsibilityType> RefK12ResponsibilityType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLanguage> RefLanguages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTitleIIILanguageInstructionProgramType> RefTitleIIILanguageInstructionProgramTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLanguageUseType> RefLanguageUseTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLeaFundsTransferType> RefLeaFundsTransferTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLeaImprovementStatu> RefLeaImprovementStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearnerActionType> RefLearnerActionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearnerActivityAddToGradeBookFlag> RefLearnerActivityAddToGradeBookFlags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearnerActivityType> RefLearnerActivityTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceAccessAPIType> RefLearningResourceAccessAPITypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceAccessHazardType> RefLearningResourceAccessHazardTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceAccessModeType> RefLearningResourceAccessModeTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceAccessRightsUrl> RefLearningResourceAccessRightsUrls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceAuthorType> RefLearningResourceAuthorTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceBookFormatType> RefLearningResourceBookFormatTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceCompetencyAlignmentType> RefLearningResourceCompetencyAlignmentTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceControlFlexibilityType> RefLearningResourceControlFlexibilityTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceDigitalMediaSubType> RefLearningResourceDigitalMediaSubTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceDigitalMediaType> RefLearningResourceDigitalMediaTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceInteractionMode> RefLearningResourceInteractionModes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceMediaFeatureType> RefLearningResourceMediaFeatureTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourcePhysicalMediaType> RefLearningResourcePhysicalMediaTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLeaType> RefLeaTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLeaveEventType> RefLeaveEventTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLevelOfInstitution> RefLevelOfInstitutions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLicenseExempt> RefLicenseExempts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLiteracyAssessment> RefLiteracyAssessments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceEducationalUse> RefLearningResourceEducationalUses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceIntendedEndUserRole> RefLearningResourceIntendedEndUserRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceInteractivityType> RefLearningResourceInteractivityTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearningResourceType> RefLearningResourceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMagnetSpecialProgram> RefMagnetSpecialPrograms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefLearnerActivityMaximumTimeAllowedUnit> RefLearnerActivityMaximumTimeAllowedUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMedicalAlertIndicator> RefMedicalAlertIndicators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMepEnrollmentType> RefMepEnrollmentTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMepProjectBased> RefMepProjectBaseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMepProjectType> RefMepProjectTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMepServiceType> RefMepServiceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMepSessionType> RefMepSessionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMepStaffCategory> RefMepStaffCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMethodOfServiceDelivery> RefMethodOfServiceDeliveries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMilitaryActiveStudentIndicator> RefMilitaryActiveStudentIndicators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMilitaryBranch> RefMilitaryBranches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMilitaryConnectedStudentIndicator> RefMilitaryConnectedStudentIndicators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMilitaryVeteranStudentIndicator> RefMilitaryVeteranStudentIndicators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefMultipleIntelligenceType> RefMultipleIntelligenceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefNaepAspectsOfReading> RefNaepAspectsOfReadings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefNaepMathComplexityLevel> RefNaepMathComplexityLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefNationalSchoolLunchProgramStatu> RefNationalSchoolLunchProgramStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefNCESCollegeCourseMapCode> RefNCESCollegeCourseMapCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefNeedDeterminationMethod> RefNeedDeterminationMethods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefNeglectedProgramType> RefNeglectedProgramTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefNonPromotionReason> RefNonPromotionReasons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefNonTraditionalGenderStatu> RefNonTraditionalGenderStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefNSLPStatu> RefNSLPStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefNumberOfDependentsType> RefNumberOfDependentsTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefONETSOCOccupationType> RefONETSOCOccupationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOperationalStatu> RefOperationalStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOperationalStatusType> RefOperationalStatusTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOrganizationElementType> RefOrganizationElementTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOrganizationIdentifierType> RefOrganizationIdentifierTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOrganizationIndicator> RefOrganizationIndicators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOrganizationLocationType> RefOrganizationLocationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOrganizationMonitoringNotification> RefOrganizationMonitoringNotifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOrganizationRelationship> RefOrganizationRelationships { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOrganizationType> RefOrganizationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOtherNameType> RefOtherNameTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOutcomeTimePoint> RefOutcomeTimePoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefOutOfFieldStatu> RefOutOfFieldStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefParaprofessionalQualification> RefParaprofessionalQualifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefParticipationStatusAyp> RefParticipationStatusAyps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefParticipationType> RefParticipationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPDActivityApprovedPurpose> RefPDActivityApprovedPurposes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPDActivityCreditType> RefPDActivityCreditTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPDActivityEducationLevelsAddressed> RefPDActivityEducationLevelsAddresseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPDActivityLevel> RefPDActivityLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPDActivityTargetAudience> RefPDActivityTargetAudiences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPDActivityType> RefPDActivityTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPDAudienceType> RefPDAudienceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPDDeliveryMethod> RefPDDeliveryMethods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPDInstructionalDeliveryMode> RefPDInstructionalDeliveryModes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPDSessionStatu> RefPDSessionStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPersonalInformationType> RefPersonalInformationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPersonalInformationVerification> RefPersonalInformationVerifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPersonIdentifierType> RefPersonIdentifierTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPersonLocationType> RefPersonLocationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPersonStatusType> RefPersonStatusTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPersonTelephoneNumberType> RefPersonTelephoneNumberTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPESCAwardLevelType> RefPESCAwardLevelTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPopulationServed> RefPopulationServeds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPsLepType> RefPsLepTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPreAndPostTestIndicator> RefPreAndPostTestIndicators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPredominantCalendarSystem> RefPredominantCalendarSystems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPreKEligibleAgesNonIDEA> RefPreKEligibleAgesNonIDEAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPrekindergartenEligibility> RefPrekindergartenEligibilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPresentAttendanceCategory> RefPresentAttendanceCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPrimaryLearningDeviceAccess> RefPrimaryLearningDeviceAccesses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPrimaryLearningDeviceAwayFromSchool> RefPrimaryLearningDeviceAwayFromSchools { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPrimaryLearningDeviceProvider> RefPrimaryLearningDeviceProviders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProfessionalDevelopmentFinancialSupport> RefProfessionalDevelopmentFinancialSupports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProfessionalEducationJobClassification> RefProfessionalEducationJobClassifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProficiencyStatu> RefProficiencyStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProficiencyTargetAyp> RefProficiencyTargetAyps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProfitStatu> RefProfitStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProfessionalTechnicalCredentialType> RefProfessionalTechnicalCredentialTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProgramDayLength> RefProgramDayLengths { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProgramEntryReason> RefProgramEntryReasons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProgramExitReason> RefProgramExitReasons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProgramGiftedEligibility> RefProgramGiftedEligibilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProgramLengthHoursType> RefProgramLengthHoursTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProgramSponsorType> RefProgramSponsorTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProgramType> RefProgramTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProgressLevel> RefProgressLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPromotionReason> RefPromotionReasons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefProofOfResidencyType> RefProofOfResidencyTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPsEnrollmentAction> RefPsEnrollmentActions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPsEnrollmentAwardType> RefPsEnrollmentAwardTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPsEnrollmentStatu> RefPsEnrollmentStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPsEnrollmentType> RefPsEnrollmentTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPSExitOrWithdrawalType> RefPSExitOrWithdrawalTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPSProgramLevel> RefPSProgramLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPsStudentLevel> RefPsStudentLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPublicSchoolChoiceStatu> RefPublicSchoolChoiceStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPublicSchoolResidence> RefPublicSchoolResidences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPurposeOfMonitoringVisit> RefPurposeOfMonitoringVisits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefQrisParticipation> RefQrisParticipations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefRace> RefRaces { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefReapAlternativeFundingStatu> RefReapAlternativeFundingStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefReasonDelayTransitionConf> RefReasonDelayTransitionConfs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefReconstitutedStatu> RefReconstitutedStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefRecordStatusCreatorEntity> RefRecordStatusCreatorEntities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefRecordStatusType> RefRecordStatusTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefReferralOutcome> RefReferralOutcomes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefReimbursementType> RefReimbursementTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPersonRelationshipType> RefPersonRelationshipTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefRestructuringAction> RefRestructuringActions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefRlisProgramUse> RefRlisProgramUses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefRole> RefRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefRoleStatus> RefRoleStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefRoleStatusType> RefRoleStatusTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSCEDCourseLevel> RefSCEDCourseLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSCEDCourseSubjectArea> RefSCEDCourseSubjectAreas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefScheduledWellChildScreening> RefScheduledWellChildScreenings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSchoolDangerousStatu> RefSchoolDangerousStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSchoolFoodServiceProgram> RefSchoolFoodServicePrograms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSchoolImprovementFund> RefSchoolImprovementFunds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSchoolImprovementFund> RefSchoolImprovementFunds1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSchoolImprovementStatu> RefSchoolImprovementStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSchoolLevel> RefSchoolLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSchoolType> RefSchoolTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefScoreMetricType> RefScoreMetricTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefServiceFrequency> RefServiceFrequencies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefServiceOption> RefServiceOptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefService> RefServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSessionType> RefSessionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSex> RefSexes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSigInterventionType> RefSigInterventionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSingleSexClassStatu> RefSingleSexClassStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSpaceUseType> RefSpaceUseTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSpecialEducationAgeGroupTaught> RefSpecialEducationAgeGroupTaughts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSpecialEducationExitReason> RefSpecialEducationExitReasons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSpecialEducationStaffCategory> RefSpecialEducationStaffCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefStaffCompensationSourceType> RefStaffCompensationSourceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefStaffPerformanceLevel> RefStaffPerformanceLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefStandardizedAdmissionTest> RefStandardizedAdmissionTests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefState> RefStates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefStateANSICode> RefStateANSICodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefStatePovertyDesignation> RefStatePovertyDesignations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefStudentEnrollmentAccessType> RefStudentEnrollmentAccessTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefStudentSchoolAffiliationStateDefinedStatu> RefStudentSchoolAffiliationStateDefinedStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefStudentSupportServiceType> RefStudentSupportServiceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefSupervisedClinicalExperience> RefSupervisedClinicalExperiences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTargetedSupport> RefTargetedSupports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTargetedSupportAndImprovementStatu> RefTargetedSupportAndImprovementStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTeacherEducationCredentialExam> RefTeacherEducationCredentialExams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTeacherEducationExamScoreType> RefTeacherEducationExamScoreTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTeacherEducationTestCompany> RefTeacherEducationTestCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTeacherPrepCompleterStatu> RefTeacherPrepCompleterStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTeacherPrepEnrollmentStatu> RefTeacherPrepEnrollmentStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTeachingAssignmentRole> RefTeachingAssignmentRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTeachingCredentialBasi> RefTeachingCredentialBasis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTeachingCredentialType> RefTeachingCredentialTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTechnicalAssistanceDeliveryType> RefTechnicalAssistanceDeliveryTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTechnicalAssistanceType> RefTechnicalAssistanceTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTechnologyLiteracyStatu> RefTechnologyLiteracyStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTelephoneNumberListedStatu> RefTelephoneNumberListedStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTelephoneNumberType> RefTelephoneNumberTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTenureSystem> RefTenureSystems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTextComplexitySystem> RefTextComplexitySystems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTimeForCompletionUnit> RefTimeForCompletionUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTitleISchoolStatu> RefTitleISchoolStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTitleIIIAccountability> RefTitleIIIAccountabilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTitleIIIProfessionalDevelopmentType> RefTitleIIIProfessionalDevelopmentTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTitleIIndicator> RefTitleIIndicators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTitleIInstructionalService> RefTitleIInstructionalServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTitleIProgramStaffCategory> RefTitleIProgramStaffCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTitleIProgramType> RefTitleIProgramTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTransferOutIndicator> RefTransferOutIndicators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTransferReady> RefTransferReadies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTribalAffiliation> RefTribalAffiliations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTrimesterWhenPrenatalCareBegan> RefTrimesterWhenPrenatalCareBegans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTuitionResidencyType> RefTuitionResidencyTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefTuitionUnit> RefTuitionUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefUSCitizenshipStatu> RefUSCitizenshipStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefVirtualSchoolStatu> RefVirtualSchoolStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefVisaType> RefVisaTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefVisionScreeningStatu> RefVisionScreeningStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefWageCollectionMethod> RefWageCollectionMethods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefWageVerification> RefWageVerifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefWeaponType> RefWeaponTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefWfProgramParticipation> RefWfProgramParticipations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefWIOABarrierstoEmployment> RefWIOABarrierstoEmployments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefWorkbasedLearningOpportunityType> RefWorkbasedLearningOpportunityTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequiredImmunization> RequiredImmunizations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; }
    }
}
