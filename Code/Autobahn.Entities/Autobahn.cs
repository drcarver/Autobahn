using System.Data.Entity;

namespace Autobahn.Entities
{
    public partial class Autobahn : DbContext
    {
        public Autobahn()
            : base("name=Autobahn")
        {
        }

        public virtual DbSet<C_CEDSElements> C_CEDSElements { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<ActivityRecognition> ActivityRecognitions { get; set; }
        public virtual DbSet<AeCourse> AeCourses { get; set; }
        public virtual DbSet<AeProvider> AeProviders { get; set; }
        public virtual DbSet<AeStaff> AeStaffs { get; set; }
        public virtual DbSet<AeStudentAcademicRecord> AeStudentAcademicRecords { get; set; }
        public virtual DbSet<AeStudentEmployment> AeStudentEmployments { get; set; }
        public virtual DbSet<ApipInteraction> ApipInteractions { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Assessment> Assessments { get; set; }
        public virtual DbSet<Assessment_AssessmentAdministration> Assessment_AssessmentAdministration { get; set; }
        public virtual DbSet<AssessmentAccommodation> AssessmentAccommodations { get; set; }
        public virtual DbSet<AssessmentAdministration> AssessmentAdministrations { get; set; }
        public virtual DbSet<AssessmentAdministration_Organization> AssessmentAdministration_Organization { get; set; }
        public virtual DbSet<AssessmentAsset> AssessmentAssets { get; set; }
        public virtual DbSet<AssessmentELDevelopmentalDomain> AssessmentELDevelopmentalDomains { get; set; }
        public virtual DbSet<AssessmentForm> AssessmentForms { get; set; }
        public virtual DbSet<AssessmentForm_AssessmentAsset> AssessmentForm_AssessmentAsset { get; set; }
        public virtual DbSet<AssessmentForm_AssessmentFormSection> AssessmentForm_AssessmentFormSection { get; set; }
        public virtual DbSet<AssessmentFormSection> AssessmentFormSections { get; set; }
        public virtual DbSet<AssessmentFormSection_AssessmentAsset> AssessmentFormSection_AssessmentAsset { get; set; }
        public virtual DbSet<AssessmentFormSection_AssessmentItem> AssessmentFormSection_AssessmentItem { get; set; }
        public virtual DbSet<AssessmentItem> AssessmentItems { get; set; }
        public virtual DbSet<AssessmentItemApip> AssessmentItemApips { get; set; }
        public virtual DbSet<AssessmentItemApipDescription> AssessmentItemApipDescriptions { get; set; }
        public virtual DbSet<AssessmentItemCharacteristic> AssessmentItemCharacteristics { get; set; }
        public virtual DbSet<AssessmentItemPossibleResponse> AssessmentItemPossibleResponses { get; set; }
        public virtual DbSet<AssessmentItemResponse> AssessmentItemResponses { get; set; }
        public virtual DbSet<AssessmentItemResponseTheory> AssessmentItemResponseTheories { get; set; }
        public virtual DbSet<AssessmentItemRubricCriterionResult> AssessmentItemRubricCriterionResults { get; set; }
        public virtual DbSet<AssessmentLanguage> AssessmentLanguages { get; set; }
        public virtual DbSet<AssessmentLevelsForWhichDesigned> AssessmentLevelsForWhichDesigneds { get; set; }
        public virtual DbSet<AssessmentNeedApipContent> AssessmentNeedApipContents { get; set; }
        public virtual DbSet<AssessmentNeedApipControl> AssessmentNeedApipControls { get; set; }
        public virtual DbSet<AssessmentNeedApipDisplay> AssessmentNeedApipDisplays { get; set; }
        public virtual DbSet<AssessmentNeedBraille> AssessmentNeedBrailles { get; set; }
        public virtual DbSet<AssessmentNeedScreenEnhancement> AssessmentNeedScreenEnhancements { get; set; }
        public virtual DbSet<AssessmentParticipantSession> AssessmentParticipantSessions { get; set; }
        public virtual DbSet<AssessmentParticipantSession_Accommodation> AssessmentParticipantSession_Accommodation { get; set; }
        public virtual DbSet<AssessmentPerformanceLevel> AssessmentPerformanceLevels { get; set; }
        public virtual DbSet<AssessmentPersonalNeedLanguageLearner> AssessmentPersonalNeedLanguageLearners { get; set; }
        public virtual DbSet<AssessmentPersonalNeedScreenReader> AssessmentPersonalNeedScreenReaders { get; set; }
        public virtual DbSet<AssessmentPersonalNeedsProfile> AssessmentPersonalNeedsProfiles { get; set; }
        public virtual DbSet<AssessmentPersonalNeedsProfileContent> AssessmentPersonalNeedsProfileContents { get; set; }
        public virtual DbSet<AssessmentPersonalNeedsProfileControl> AssessmentPersonalNeedsProfileControls { get; set; }
        public virtual DbSet<AssessmentPersonalNeedsProfileDisplay> AssessmentPersonalNeedsProfileDisplays { get; set; }
        public virtual DbSet<AssessmentPersonalNeedsProfileScreenEnhancement> AssessmentPersonalNeedsProfileScreenEnhancements { get; set; }
        public virtual DbSet<AssessmentRegistration> AssessmentRegistrations { get; set; }
        public virtual DbSet<AssessmentRegistration_Accommodation> AssessmentRegistration_Accommodation { get; set; }
        public virtual DbSet<AssessmentResult> AssessmentResults { get; set; }
        public virtual DbSet<AssessmentResult_PerformanceLevel> AssessmentResult_PerformanceLevel { get; set; }
        public virtual DbSet<AssessmentResultRubricCriterionResult> AssessmentResultRubricCriterionResults { get; set; }
        public virtual DbSet<AssessmentSession> AssessmentSessions { get; set; }
        public virtual DbSet<AssessmentSessionStaffRole> AssessmentSessionStaffRoles { get; set; }
        public virtual DbSet<AssessmentSubtest> AssessmentSubtests { get; set; }
        public virtual DbSet<AssessmentSubtest_AssessmentItem> AssessmentSubtest_AssessmentItem { get; set; }
        public virtual DbSet<AssessmentSubtest_CompetencyDefinition> AssessmentSubtest_CompetencyDefinition { get; set; }
        public virtual DbSet<AssessmentSubtestELDevelopmentalDomain> AssessmentSubtestELDevelopmentalDomains { get; set; }
        public virtual DbSet<AssessmentSubtestLevelsForWhichDesigned> AssessmentSubtestLevelsForWhichDesigneds { get; set; }
        public virtual DbSet<Authentication> Authentications { get; set; }
        public virtual DbSet<Authorization> Authorizations { get; set; }
        public virtual DbSet<AuthorizationDocument> AuthorizationDocuments { get; set; }
        public virtual DbSet<BuildingSpace> BuildingSpaces { get; set; }
        public virtual DbSet<BuildingSpaceUtilization> BuildingSpaceUtilizations { get; set; }
        public virtual DbSet<BuildingSystemCategory> BuildingSystemCategories { get; set; }
        public virtual DbSet<BuildingSystemComponent> BuildingSystemComponents { get; set; }
        public virtual DbSet<BuildingSystemComponentService> BuildingSystemComponentServices { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<CompetencyDefAssociation> CompetencyDefAssociations { get; set; }
        public virtual DbSet<CompetencyDefEducationLevel> CompetencyDefEducationLevels { get; set; }
        public virtual DbSet<CompetencyDefinition> CompetencyDefinitions { get; set; }
        public virtual DbSet<CompetencyDefinition_CompetencySet> CompetencyDefinition_CompetencySet { get; set; }
        public virtual DbSet<CompetencyFramework> CompetencyFrameworks { get; set; }
        public virtual DbSet<CompetencySet> CompetencySets { get; set; }
        public virtual DbSet<CompetencySet_Rubric> CompetencySet_Rubric { get; set; }
        public virtual DbSet<CompetencySet_RubricCriterion> CompetencySet_RubricCriterion { get; set; }
        public virtual DbSet<CoreKnowledgeArea> CoreKnowledgeAreas { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSection> CourseSections { get; set; }
        public virtual DbSet<CourseSectionAssessmentReporting> CourseSectionAssessmentReportings { get; set; }
        public virtual DbSet<CourseSectionLevel> CourseSectionLevels { get; set; }
        public virtual DbSet<CourseSectionLocation> CourseSectionLocations { get; set; }
        public virtual DbSet<CourseSectionSchedule> CourseSectionSchedules { get; set; }
        public virtual DbSet<CredentialAward> CredentialAwards { get; set; }
        public virtual DbSet<CredentialAwardCredit> CredentialAwardCredits { get; set; }
        public virtual DbSet<CredentialAwardEvidence> CredentialAwardEvidences { get; set; }
        public virtual DbSet<CredentialCriteriaCourse> CredentialCriteriaCourses { get; set; }
        public virtual DbSet<CredentialDefAgent> CredentialDefAgents { get; set; }
        public virtual DbSet<CredentialDefAgentCredential> CredentialDefAgentCredentials { get; set; }
        public virtual DbSet<CredentialDefCategory> CredentialDefCategories { get; set; }
        public virtual DbSet<CredentialDefCriteria> CredentialDefCriterias { get; set; }
        public virtual DbSet<CredentialDefIdentifier> CredentialDefIdentifiers { get; set; }
        public virtual DbSet<CredentialDefinition> CredentialDefinitions { get; set; }
        public virtual DbSet<CredentialIssuer> CredentialIssuers { get; set; }
        public virtual DbSet<CredentialOffered> CredentialOffereds { get; set; }
        public virtual DbSet<CteCourse> CteCourses { get; set; }
        public virtual DbSet<CteStudentAcademicRecord> CteStudentAcademicRecords { get; set; }
        public virtual DbSet<DataCollection> DataCollections { get; set; }
        public virtual DbSet<EarlyChildhoodCredential> EarlyChildhoodCredentials { get; set; }
        public virtual DbSet<EarlyChildhoodProgramTypeOffered> EarlyChildhoodProgramTypeOffereds { get; set; }
        public virtual DbSet<ELChildDemographic> ELChildDemographics { get; set; }
        public virtual DbSet<ELChildDevelopmentalAssessment> ELChildDevelopmentalAssessments { get; set; }
        public virtual DbSet<ELChildHealth> ELChildHealths { get; set; }
        public virtual DbSet<ELChildIndividualizedProgram> ELChildIndividualizedPrograms { get; set; }
        public virtual DbSet<ELChildOutcomeSummary> ELChildOutcomeSummaries { get; set; }
        public virtual DbSet<ELChildProgramEligibility> ELChildProgramEligibilities { get; set; }
        public virtual DbSet<ELChildService> ELChildServices { get; set; }
        public virtual DbSet<ELChildServicesApplication> ELChildServicesApplications { get; set; }
        public virtual DbSet<ELChildTransitionPlan> ELChildTransitionPlans { get; set; }
        public virtual DbSet<ELClassSection> ELClassSections { get; set; }
        public virtual DbSet<ELClassSectionService> ELClassSectionServices { get; set; }
        public virtual DbSet<ELEnrollment> ELEnrollments { get; set; }
        public virtual DbSet<ELEnrollmentOtherFunding> ELEnrollmentOtherFundings { get; set; }
        public virtual DbSet<ELFacilityLicensing> ELFacilityLicensings { get; set; }
        public virtual DbSet<EligibilityEvaluation> EligibilityEvaluations { get; set; }
        public virtual DbSet<ELOrganization> ELOrganizations { get; set; }
        public virtual DbSet<ELOrganizationAvailability> ELOrganizationAvailabilities { get; set; }
        public virtual DbSet<ELOrganizationFund> ELOrganizationFunds { get; set; }
        public virtual DbSet<ELOrganizationMonitoring> ELOrganizationMonitorings { get; set; }
        public virtual DbSet<ELProgramLicensing> ELProgramLicensings { get; set; }
        public virtual DbSet<ELQualityInitiative> ELQualityInitiatives { get; set; }
        public virtual DbSet<ELQualityRatingImprovement> ELQualityRatingImprovements { get; set; }
        public virtual DbSet<ELServicePartner> ELServicePartners { get; set; }
        public virtual DbSet<ELStaff> ELStaffs { get; set; }
        public virtual DbSet<ELStaffAssignment> ELStaffAssignments { get; set; }
        public virtual DbSet<ELStaffEducation> ELStaffEducations { get; set; }
        public virtual DbSet<ELStaffEmployment> ELStaffEmployments { get; set; }
        public virtual DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<FacilityAudit> FacilityAudits { get; set; }
        public virtual DbSet<FacilityCompliance> FacilityCompliances { get; set; }
        public virtual DbSet<FacilityDesign> FacilityDesigns { get; set; }
        public virtual DbSet<FacilityDesignConstruction> FacilityDesignConstructions { get; set; }
        public virtual DbSet<FacilityEnergy> FacilityEnergies { get; set; }
        public virtual DbSet<FacilityFinance> FacilityFinances { get; set; }
        public virtual DbSet<FacilityFinancial> FacilityFinancials { get; set; }
        public virtual DbSet<FacilityHazard> FacilityHazards { get; set; }
        public virtual DbSet<FacilityJointUse> FacilityJointUses { get; set; }
        public virtual DbSet<FacilityLease> FacilityLeases { get; set; }
        public virtual DbSet<FacilityLocation> FacilityLocations { get; set; }
        public virtual DbSet<FacilityManagement> FacilityManagements { get; set; }
        public virtual DbSet<FacilityManagementPlan> FacilityManagementPlans { get; set; }
        public virtual DbSet<FacilityMandate> FacilityMandates { get; set; }
        public virtual DbSet<FacilityMortgage> FacilityMortgages { get; set; }
        public virtual DbSet<FacilityMortgageFee> FacilityMortgageFees { get; set; }
        public virtual DbSet<FacilityRelationship> FacilityRelationships { get; set; }
        public virtual DbSet<FacilitySchoolDesign> FacilitySchoolDesigns { get; set; }
        public virtual DbSet<FacilitySite> FacilitySites { get; set; }
        public virtual DbSet<FacilityUtilization> FacilityUtilizations { get; set; }
        public virtual DbSet<FinancialAccount> FinancialAccounts { get; set; }
        public virtual DbSet<FinancialAccountProgram> FinancialAccountPrograms { get; set; }
        public virtual DbSet<FinancialAidApplication> FinancialAidApplications { get; set; }
        public virtual DbSet<FinancialAidAward> FinancialAidAwards { get; set; }
        public virtual DbSet<Goal> Goals { get; set; }
        public virtual DbSet<GoalMeasurement> GoalMeasurements { get; set; }
        public virtual DbSet<GoalMeasurementCriterion> GoalMeasurementCriterions { get; set; }
        public virtual DbSet<GoalPerformance> GoalPerformances { get; set; }
        public virtual DbSet<IDEAEligibilityEvaluationCategory> IDEAEligibilityEvaluationCategories { get; set; }
        public virtual DbSet<IDSVersion> IDSVersions { get; set; }
        public virtual DbSet<IEPAuthorization> IEPAuthorizations { get; set; }
        public virtual DbSet<IEPAuthorizationRejected> IEPAuthorizationRejecteds { get; set; }
        public virtual DbSet<IEPPresentLevel> IEPPresentLevels { get; set; }
        public virtual DbSet<Incident> Incidents { get; set; }
        public virtual DbSet<IncidentPerson> IncidentPersons { get; set; }
        public virtual DbSet<IndividualizedProgram> IndividualizedPrograms { get; set; }
        public virtual DbSet<IndividualizedProgramAccommodation> IndividualizedProgramAccommodations { get; set; }
        public virtual DbSet<IndividualizedProgramAccommodationSubject> IndividualizedProgramAccommodationSubjects { get; set; }
        public virtual DbSet<IndividualizedProgramAmendment> IndividualizedProgramAmendments { get; set; }
        public virtual DbSet<IndividualizedProgramAssessment> IndividualizedProgramAssessments { get; set; }
        public virtual DbSet<IndividualizedProgramAssessmentAccommodation> IndividualizedProgramAssessmentAccommodations { get; set; }
        public virtual DbSet<IndividualizedProgramEligibility> IndividualizedProgramEligibilities { get; set; }
        public virtual DbSet<IndividualizedProgramEligibilityEvaluation> IndividualizedProgramEligibilityEvaluations { get; set; }
        public virtual DbSet<IndividualizedProgramGoal> IndividualizedProgramGoals { get; set; }
        public virtual DbSet<IndividualizedProgramMeeting> IndividualizedProgramMeetings { get; set; }
        public virtual DbSet<IndividualizedProgramMeetingAttendee> IndividualizedProgramMeetingAttendees { get; set; }
        public virtual DbSet<IndividualizedProgramProgressGoal> IndividualizedProgramProgressGoals { get; set; }
        public virtual DbSet<IndividualizedProgramProgressReport> IndividualizedProgramProgressReports { get; set; }
        public virtual DbSet<IndividualizedProgramProgressReportPlan> IndividualizedProgramProgressReportPlans { get; set; }
        public virtual DbSet<IndividualizedProgramService> IndividualizedProgramServices { get; set; }
        public virtual DbSet<IndividualizedProgramServicesReceived> IndividualizedProgramServicesReceiveds { get; set; }
        public virtual DbSet<IPEDSFinance> IPEDSFinances { get; set; }
        public virtual DbSet<K12CharterSchoolAuthorizerAgency> K12CharterSchoolAuthorizerAgency { get; set; }
        public virtual DbSet<K12CharterSchoolManagementOrganization> K12CharterSchoolManagementOrganization { get; set; }
        public virtual DbSet<K12Course> K12Course { get; set; }
        public virtual DbSet<K12FederalFundAllocation> K12FederalFundAllocation { get; set; }
        public virtual DbSet<K12Lea> K12Lea { get; set; }
        public virtual DbSet<K12LeaFederalFunds> K12LeaFederalFunds { get; set; }
        public virtual DbSet<K12LeaFederalReporting> K12LeaFederalReporting { get; set; }
        public virtual DbSet<K12LeaGradeLevelsApproved> K12LeaGradeLevelsApproved { get; set; }
        public virtual DbSet<K12LeaGradeOffered> K12LeaGradeOffered { get; set; }
        public virtual DbSet<K12LeaPreKEligibility> K12LeaPreKEligibility { get; set; }
        public virtual DbSet<K12LeaPreKEligibleAgesIDEA> K12LeaPreKEligibleAgesIDEA { get; set; }
        public virtual DbSet<K12LeaSafeDrugFree> K12LeaSafeDrugFree { get; set; }
        public virtual DbSet<K12LeaTitleIIIProfessionalDevelopment> K12LeaTitleIIIProfessionalDevelopment { get; set; }
        public virtual DbSet<K12LeaTitleISupportService> K12LeaTitleISupportService { get; set; }
        public virtual DbSet<K12OrganizationStudentResponsibility> K12OrganizationStudentResponsibility { get; set; }
        public virtual DbSet<K12ProgramOrService> K12ProgramOrService { get; set; }
        public virtual DbSet<K12School> K12School { get; set; }
        public virtual DbSet<K12SchoolCorrectiveAction> K12SchoolCorrectiveAction { get; set; }
        public virtual DbSet<K12SchoolGradeLevelsApproved> K12SchoolGradeLevelsApproved { get; set; }
        public virtual DbSet<K12SchoolGradeOffered> K12SchoolGradeOffered { get; set; }
        public virtual DbSet<K12SchoolImprovement> K12SchoolImprovement { get; set; }
        public virtual DbSet<K12SchoolIndicatorStatus> K12SchoolIndicatorStatus { get; set; }
        public virtual DbSet<K12SchoolStatus> K12SchoolStatus { get; set; }
        public virtual DbSet<K12Sea> K12Sea { get; set; }
        public virtual DbSet<K12SeaAlternateFundUse> K12SeaAlternateFundUse { get; set; }
        public virtual DbSet<K12SeaFederalFunds> K12SeaFederalFunds { get; set; }
        public virtual DbSet<K12StaffAssignment> K12StaffAssignment { get; set; }
        public virtual DbSet<K12StaffEmployment> K12StaffEmployment { get; set; }
        public virtual DbSet<K12StudentAcademicHonor> K12StudentAcademicHonor { get; set; }
        public virtual DbSet<K12StudentAcademicRecord> K12StudentAcademicRecord { get; set; }
        public virtual DbSet<K12StudentActivity> K12StudentActivity { get; set; }
        public virtual DbSet<K12StudentCohort> K12StudentCohort { get; set; }
        public virtual DbSet<K12StudentCourseSection> K12StudentCourseSection { get; set; }
        public virtual DbSet<K12StudentCourseSectionMark> K12StudentCourseSectionMark { get; set; }
        public virtual DbSet<K12StudentDiscipline> K12StudentDiscipline { get; set; }
        public virtual DbSet<K12StudentEmployment> K12StudentEmployment { get; set; }
        public virtual DbSet<K12StudentEnrollment> K12StudentEnrollment { get; set; }
        public virtual DbSet<K12StudentGraduationPlan> K12StudentGraduationPlan { get; set; }
        public virtual DbSet<K12StudentHomeLanguageSurvey> K12StudentHomeLanguageSurvey { get; set; }
        public virtual DbSet<K12StudentLiteracyAssessment> K12StudentLiteracyAssessment { get; set; }
        public virtual DbSet<K12StudentSession> K12StudentSession { get; set; }
        public virtual DbSet<K12TitleIIILanguageInstruction> K12TitleIIILanguageInstruction { get; set; }
        public virtual DbSet<LearnerAction> LearnerActions { get; set; }
        public virtual DbSet<LearnerActivity> LearnerActivities { get; set; }
        public virtual DbSet<LearnerActivity_LearningResource> LearnerActivity_LearningResource { get; set; }
        public virtual DbSet<LearningResource> LearningResources { get; set; }
        public virtual DbSet<LearningResourceAdaptation> LearningResourceAdaptations { get; set; }
        public virtual DbSet<LearningResourceEducationLevel> LearningResourceEducationLevels { get; set; }
        public virtual DbSet<LearningResourceMediaFeature> LearningResourceMediaFeatures { get; set; }
        public virtual DbSet<LearningResourcePeerRating> LearningResourcePeerRatings { get; set; }
        public virtual DbSet<LearningResourcePhysicalMedia> LearningResourcePhysicalMedias { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationAddress> LocationAddresses { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<OrganizationAccreditation> OrganizationAccreditations { get; set; }
        public virtual DbSet<OrganizationCalendar> OrganizationCalendars { get; set; }
        public virtual DbSet<OrganizationCalendarCrisi> OrganizationCalendarCrisis { get; set; }
        public virtual DbSet<OrganizationCalendarDay> OrganizationCalendarDays { get; set; }
        public virtual DbSet<OrganizationCalendarEvent> OrganizationCalendarEvents { get; set; }
        public virtual DbSet<OrganizationCalendarSession> OrganizationCalendarSessions { get; set; }
        public virtual DbSet<OrganizationDetail> OrganizationDetails { get; set; }
        public virtual DbSet<OrganizationEmail> OrganizationEmails { get; set; }
        public virtual DbSet<OrganizationEmployeeBenefit> OrganizationEmployeeBenefits { get; set; }
        public virtual DbSet<OrganizationFederalAccountability> OrganizationFederalAccountabilities { get; set; }
        public virtual DbSet<OrganizationFinancial> OrganizationFinancials { get; set; }
        public virtual DbSet<OrganizationIdentifier> OrganizationIdentifiers { get; set; }
        public virtual DbSet<OrganizationImage> OrganizationImages { get; set; }
        public virtual DbSet<OrganizationIndicator> OrganizationIndicators { get; set; }
        public virtual DbSet<OrganizationLocation> OrganizationLocations { get; set; }
        public virtual DbSet<OrganizationOperationalStatu> OrganizationOperationalStatus { get; set; }
        public virtual DbSet<OrganizationPersonRole> OrganizationPersonRoles { get; set; }
        public virtual DbSet<OrganizationPersonRoleApplication> OrganizationPersonRoleApplications { get; set; }
        public virtual DbSet<OrganizationPersonRoleFTE> OrganizationPersonRoleFTEs { get; set; }
        public virtual DbSet<OrganizationPersonRoleRelationship> OrganizationPersonRoleRelationships { get; set; }
        public virtual DbSet<OrganizationPolicy> OrganizationPolicies { get; set; }
        public virtual DbSet<OrganizationPopulationServed> OrganizationPopulationServeds { get; set; }
        public virtual DbSet<OrganizationProgramType> OrganizationProgramTypes { get; set; }
        public virtual DbSet<OrganizationRelationship> OrganizationRelationships { get; set; }
        public virtual DbSet<OrganizationService> OrganizationServices { get; set; }
        public virtual DbSet<OrganizationTechnicalAssistance> OrganizationTechnicalAssistances { get; set; }
        public virtual DbSet<OrganizationTelephone> OrganizationTelephones { get; set; }
        public virtual DbSet<OrganizationWebsite> OrganizationWebsites { get; set; }
        public virtual DbSet<PDActivityEducationLevel> PDActivityEducationLevels { get; set; }
        public virtual DbSet<PeerRatingSystem> PeerRatingSystems { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Person_AssessmentPersonalNeedsProfile> Person_AssessmentPersonalNeedsProfile { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }
        public virtual DbSet<PersonAddressNcesSide> PersonAddressNcesSides { get; set; }
        public virtual DbSet<PersonAllergy> PersonAllergies { get; set; }
        public virtual DbSet<PersonBirthplace> PersonBirthplaces { get; set; }
        public virtual DbSet<PersonCareerEducationPlan> PersonCareerEducationPlans { get; set; }
        public virtual DbSet<PersonCredential> PersonCredentials { get; set; }
        public virtual DbSet<PersonDegreeOrCertificate> PersonDegreeOrCertificates { get; set; }
        public virtual DbSet<PersonDemographicRace> PersonDemographicRaces { get; set; }
        public virtual DbSet<PersonDetail> PersonDetails { get; set; }
        public virtual DbSet<PersonDigitalAccess> PersonDigitalAccesses { get; set; }
        public virtual DbSet<PersonDigitalAccessSpeed> PersonDigitalAccessSpeeds { get; set; }
        public virtual DbSet<PersonDisability> PersonDisabilities { get; set; }
        public virtual DbSet<PersonEmailAddress> PersonEmailAddresses { get; set; }
        public virtual DbSet<PersonFamily> PersonFamilies { get; set; }
        public virtual DbSet<PersonHealth> PersonHealths { get; set; }
        public virtual DbSet<PersonHealthBirth> PersonHealthBirths { get; set; }
        public virtual DbSet<PersonHomelessness> PersonHomelessnesses { get; set; }
        public virtual DbSet<PersonIdentifier> PersonIdentifiers { get; set; }
        public virtual DbSet<PersonImmunization> PersonImmunizations { get; set; }
        public virtual DbSet<PersonLanguage> PersonLanguages { get; set; }
        public virtual DbSet<PersonLearningDevice> PersonLearningDevices { get; set; }
        public virtual DbSet<PersonMaster> PersonMasters { get; set; }
        public virtual DbSet<PersonMilitary> PersonMilitaries { get; set; }
        public virtual DbSet<PersonOtherName> PersonOtherNames { get; set; }
        public virtual DbSet<PersonPersonalInformationVerification> PersonPersonalInformationVerifications { get; set; }
        public virtual DbSet<PersonProgramParticipation> PersonProgramParticipations { get; set; }
        public virtual DbSet<PersonReferral> PersonReferrals { get; set; }
        public virtual DbSet<PersonRelationship> PersonRelationships { get; set; }
        public virtual DbSet<PersonStatu> PersonStatus { get; set; }
        public virtual DbSet<PersonTelephone> PersonTelephones { get; set; }
        public virtual DbSet<ProfessionalDevelopmentActivity> ProfessionalDevelopmentActivities { get; set; }
        public virtual DbSet<ProfessionalDevelopmentRequirement> ProfessionalDevelopmentRequirements { get; set; }
        public virtual DbSet<ProfessionalDevelopmentSession> ProfessionalDevelopmentSessions { get; set; }
        public virtual DbSet<ProfessionalDevelopmentSessionInstructor> ProfessionalDevelopmentSessionInstructors { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<ProgramParticipationAE> ProgramParticipationAEs { get; set; }
        public virtual DbSet<ProgramParticipationAttainment> ProgramParticipationAttainments { get; set; }
        public virtual DbSet<ProgramParticipationCte> ProgramParticipationCtes { get; set; }
        public virtual DbSet<ProgramParticipationFoodService> ProgramParticipationFoodServices { get; set; }
        public virtual DbSet<ProgramParticipationMigrant> ProgramParticipationMigrants { get; set; }
        public virtual DbSet<ProgramParticipationNeglected> ProgramParticipationNeglecteds { get; set; }
        public virtual DbSet<ProgramParticipationSpecialEducation> ProgramParticipationSpecialEducations { get; set; }
        public virtual DbSet<ProgramParticipationTeacherPrep> ProgramParticipationTeacherPreps { get; set; }
        public virtual DbSet<ProgramParticipationTitleI> ProgramParticipationTitleIs { get; set; }
        public virtual DbSet<ProgramParticipationTitleIIILep> ProgramParticipationTitleIIILeps { get; set; }
        public virtual DbSet<ProgramParticipationWIOA> ProgramParticipationWIOAs { get; set; }
        public virtual DbSet<ProgramParticipationWIOABarrier> ProgramParticipationWIOABarriers { get; set; }
        public virtual DbSet<PsCourse> PsCourses { get; set; }
        public virtual DbSet<PsInstitution> PsInstitutions { get; set; }
        public virtual DbSet<PsPriceOfAttendance> PsPriceOfAttendances { get; set; }
        public virtual DbSet<PsProgram> PsPrograms { get; set; }
        public virtual DbSet<PsSection> PsSections { get; set; }
        public virtual DbSet<PsSectionLocation> PsSectionLocations { get; set; }
        public virtual DbSet<PsStaffEmployment> PsStaffEmployments { get; set; }
        public virtual DbSet<PsStudentAcademicAward> PsStudentAcademicAwards { get; set; }
        public virtual DbSet<PsStudentAcademicRecord> PsStudentAcademicRecords { get; set; }
        public virtual DbSet<PsStudentAdmissionTest> PsStudentAdmissionTests { get; set; }
        public virtual DbSet<PsStudentApplication> PsStudentApplications { get; set; }
        public virtual DbSet<PsStudentCohort> PsStudentCohorts { get; set; }
        public virtual DbSet<PsStudentCourseSectionMark> PsStudentCourseSectionMarks { get; set; }
        public virtual DbSet<PsStudentDemographic> PsStudentDemographics { get; set; }
        public virtual DbSet<PsStudentEmployment> PsStudentEmployments { get; set; }
        public virtual DbSet<PsStudentEnrollment> PsStudentEnrollments { get; set; }
        public virtual DbSet<PsStudentFinancialAid> PsStudentFinancialAids { get; set; }
        public virtual DbSet<PSStudentProgram> PSStudentPrograms { get; set; }
        public virtual DbSet<PsStudentSection> PsStudentSections { get; set; }
        public virtual DbSet<QuarterlyEmploymentRecord> QuarterlyEmploymentRecords { get; set; }
        public virtual DbSet<RecordStatus> RecordStatus { get; set; }
        public virtual DbSet<RecordStatusHistory> RecordStatusHistories { get; set; }
        public virtual DbSet<RefAbsentAttendanceCategory> RefAbsentAttendanceCategories { get; set; }
        public virtual DbSet<RefAcademicAwardLevel> RefAcademicAwardLevels { get; set; }
        public virtual DbSet<RefAcademicAwardPrerequisiteType> RefAcademicAwardPrerequisiteTypes { get; set; }
        public virtual DbSet<RefAcademicHonorType> RefAcademicHonorTypes { get; set; }
        public virtual DbSet<RefAcademicRank> RefAcademicRanks { get; set; }
        public virtual DbSet<RefAcademicSubject> RefAcademicSubjects { get; set; }
        public virtual DbSet<RefAcademicTermDesignator> RefAcademicTermDesignators { get; set; }
        public virtual DbSet<RefAccommodationsNeededType> RefAccommodationsNeededTypes { get; set; }
        public virtual DbSet<RefAccommodationType> RefAccommodationTypes { get; set; }
        public virtual DbSet<RefAccreditationAgency> RefAccreditationAgencies { get; set; }
        public virtual DbSet<RefActivityRecognitionType> RefActivityRecognitionTypes { get; set; }
        public virtual DbSet<RefActivityTimeMeasurementType> RefActivityTimeMeasurementTypes { get; set; }
        public virtual DbSet<RefAdditionalCreditType> RefAdditionalCreditTypes { get; set; }
        public virtual DbSet<RefAdditionalTargetedSupportAndImprovementStatu> RefAdditionalTargetedSupportAndImprovementStatus { get; set; }
        public virtual DbSet<RefAddressType> RefAddressTypes { get; set; }
        public virtual DbSet<RefAdministrativeFundingControl> RefAdministrativeFundingControls { get; set; }
        public virtual DbSet<RefAdmissionConsiderationLevel> RefAdmissionConsiderationLevels { get; set; }
        public virtual DbSet<RefAdmissionConsiderationType> RefAdmissionConsiderationTypes { get; set; }
        public virtual DbSet<RefAdmittedStudent> RefAdmittedStudents { get; set; }
        public virtual DbSet<RefAdultEducationProgramExitReason> RefAdultEducationProgramExitReasons { get; set; }
        public virtual DbSet<RefAdvancedPlacementCourseCode> RefAdvancedPlacementCourseCodes { get; set; }
        public virtual DbSet<RefAeCertificationType> RefAeCertificationTypes { get; set; }
        public virtual DbSet<RefAeFunctioningLevelAtIntake> RefAeFunctioningLevelAtIntakes { get; set; }
        public virtual DbSet<RefAeFunctioningLevelAtPosttest> RefAeFunctioningLevelAtPosttests { get; set; }
        public virtual DbSet<RefAeInstructionalProgramType> RefAeInstructionalProgramTypes { get; set; }
        public virtual DbSet<RefAePostsecondaryTransitionAction> RefAePostsecondaryTransitionActions { get; set; }
        public virtual DbSet<RefAeSpecialProgramType> RefAeSpecialProgramTypes { get; set; }
        public virtual DbSet<RefAeStaffClassification> RefAeStaffClassifications { get; set; }
        public virtual DbSet<RefAeStaffEmploymentStatu> RefAeStaffEmploymentStatus { get; set; }
        public virtual DbSet<RefAllergySeverity> RefAllergySeverities { get; set; }
        public virtual DbSet<RefAllergyType> RefAllergyTypes { get; set; }
        public virtual DbSet<RefAlternateFundUs> RefAlternateFundUses { get; set; }
        public virtual DbSet<RefAlternativeSchoolFocu> RefAlternativeSchoolFocus { get; set; }
        public virtual DbSet<RefAltRouteToCertificationOrLicensure> RefAltRouteToCertificationOrLicensures { get; set; }
        public virtual DbSet<RefAmaoAttainmentStatu> RefAmaoAttainmentStatus { get; set; }
        public virtual DbSet<RefApipInteractionType> RefApipInteractionTypes { get; set; }
        public virtual DbSet<RefAssessmentAccommodationCategory> RefAssessmentAccommodationCategories { get; set; }
        public virtual DbSet<RefAssessmentAssetIdentifierType> RefAssessmentAssetIdentifierTypes { get; set; }
        public virtual DbSet<RefAssessmentAssetType> RefAssessmentAssetTypes { get; set; }
        public virtual DbSet<RefAssessmentELDevelopmentalDomain> RefAssessmentELDevelopmentalDomains { get; set; }
        public virtual DbSet<RefAssessmentFormSectionIdentificationSystem> RefAssessmentFormSectionIdentificationSystems { get; set; }
        public virtual DbSet<RefAssessmentItemCharacteristicType> RefAssessmentItemCharacteristicTypes { get; set; }
        public virtual DbSet<RefAssessmentItemResponseScoreStatu> RefAssessmentItemResponseScoreStatus { get; set; }
        public virtual DbSet<RefAssessmentItemResponseStatu> RefAssessmentItemResponseStatus { get; set; }
        public virtual DbSet<RefAssessmentItemType> RefAssessmentItemTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedAlternativeRepresentationType> RefAssessmentNeedAlternativeRepresentationTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedBrailleGradeType> RefAssessmentNeedBrailleGradeTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedBrailleMarkType> RefAssessmentNeedBrailleMarkTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedBrailleStatusCellType> RefAssessmentNeedBrailleStatusCellTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedHazardType> RefAssessmentNeedHazardTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedIncreasedWhitespacingType> RefAssessmentNeedIncreasedWhitespacingTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedLanguageLearnerType> RefAssessmentNeedLanguageLearnerTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedLinkIndicationType> RefAssessmentNeedLinkIndicationTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedMaskingType> RefAssessmentNeedMaskingTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedNumberOfBrailleDot> RefAssessmentNeedNumberOfBrailleDots { get; set; }
        public virtual DbSet<RefAssessmentNeedSigningType> RefAssessmentNeedSigningTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedSpokenSourcePreferenceType> RefAssessmentNeedSpokenSourcePreferenceTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedSupportTool> RefAssessmentNeedSupportTools { get; set; }
        public virtual DbSet<RefAssessmentNeedUsageType> RefAssessmentNeedUsageTypes { get; set; }
        public virtual DbSet<RefAssessmentNeedUserSpokenPreferenceType> RefAssessmentNeedUserSpokenPreferenceTypes { get; set; }
        public virtual DbSet<RefAssessmentParticipationIndicator> RefAssessmentParticipationIndicators { get; set; }
        public virtual DbSet<RefAssessmentPlatformType> RefAssessmentPlatformTypes { get; set; }
        public virtual DbSet<RefAssessmentPretestOutcome> RefAssessmentPretestOutcomes { get; set; }
        public virtual DbSet<RefAssessmentPurpose> RefAssessmentPurposes { get; set; }
        public virtual DbSet<RefAssessmentReasonNotCompleting> RefAssessmentReasonNotCompletings { get; set; }
        public virtual DbSet<RefAssessmentReasonNotTested> RefAssessmentReasonNotTesteds { get; set; }
        public virtual DbSet<RefAssessmentRegistrationCompletionStatu> RefAssessmentRegistrationCompletionStatus { get; set; }
        public virtual DbSet<RefAssessmentReportingMethod> RefAssessmentReportingMethods { get; set; }
        public virtual DbSet<RefAssessmentResultDataType> RefAssessmentResultDataTypes { get; set; }
        public virtual DbSet<RefAssessmentResultScoreType> RefAssessmentResultScoreTypes { get; set; }
        public virtual DbSet<RefAssessmentSessionSpecialCircumstanceType> RefAssessmentSessionSpecialCircumstanceTypes { get; set; }
        public virtual DbSet<RefAssessmentSessionStaffRoleType> RefAssessmentSessionStaffRoleTypes { get; set; }
        public virtual DbSet<RefAssessmentSessionType> RefAssessmentSessionTypes { get; set; }
        public virtual DbSet<RefAssessmentSubtestIdentifierType> RefAssessmentSubtestIdentifierTypes { get; set; }
        public virtual DbSet<RefAssessmentType> RefAssessmentTypes { get; set; }
        public virtual DbSet<RefAssessmentTypeChildrenWithDisability> RefAssessmentTypeChildrenWithDisabilities { get; set; }
        public virtual DbSet<RefAttendanceEventType> RefAttendanceEventTypes { get; set; }
        public virtual DbSet<RefAttendanceStatu> RefAttendanceStatus { get; set; }
        public virtual DbSet<RefAuthorizerType> RefAuthorizerTypes { get; set; }
        public virtual DbSet<RefAypStatu> RefAypStatus { get; set; }
        public virtual DbSet<RefBarrierToEducatingHomeless> RefBarrierToEducatingHomelesses { get; set; }
        public virtual DbSet<RefBarrierToInternetAccessInResidence> RefBarrierToInternetAccessInResidences { get; set; }
        public virtual DbSet<RefBillableBasisType> RefBillableBasisTypes { get; set; }
        public virtual DbSet<RefBlendedLearningModelType> RefBlendedLearningModelTypes { get; set; }
        public virtual DbSet<RefBloomsTaxonomyDomain> RefBloomsTaxonomyDomains { get; set; }
        public virtual DbSet<RefBuildingAdministrativeSpaceType> RefBuildingAdministrativeSpaceTypes { get; set; }
        public virtual DbSet<RefBuildingAirDistributionSystemType> RefBuildingAirDistributionSystemTypes { get; set; }
        public virtual DbSet<RefBuildingArtSpecialtySpaceType> RefBuildingArtSpecialtySpaceTypes { get; set; }
        public virtual DbSet<RefBuildingAssemblySpaceType> RefBuildingAssemblySpaceTypes { get; set; }
        public virtual DbSet<RefBuildingBasicClassroomDesignType> RefBuildingBasicClassroomDesignTypes { get; set; }
        public virtual DbSet<RefBuildingCareerTechEducationSpaceType> RefBuildingCareerTechEducationSpaceTypes { get; set; }
        public virtual DbSet<RefBuildingCharterSchoolRealtyAccessType> RefBuildingCharterSchoolRealtyAccessTypes { get; set; }
        public virtual DbSet<RefBuildingCirculationSpaceType> RefBuildingCirculationSpaceTypes { get; set; }
        public virtual DbSet<RefBuildingCleaningStandardType> RefBuildingCleaningStandardTypes { get; set; }
        public virtual DbSet<RefBuildingCommMgmtComponentSystemType> RefBuildingCommMgmtComponentSystemTypes { get; set; }
        public virtual DbSet<RefBuildingCommunityUseSpaceType> RefBuildingCommunityUseSpaceTypes { get; set; }
        public virtual DbSet<RefBuildingCoolingGenerationSystemType> RefBuildingCoolingGenerationSystemTypes { get; set; }
        public virtual DbSet<RefBuildingDesignType> RefBuildingDesignTypes { get; set; }
        public virtual DbSet<RefBuildingElectricalSystemType> RefBuildingElectricalSystemTypes { get; set; }
        public virtual DbSet<RefBuildingEnergyConservationMeasureType> RefBuildingEnergyConservationMeasureTypes { get; set; }
        public virtual DbSet<RefBuildingEnergySourceType> RefBuildingEnergySourceTypes { get; set; }
        public virtual DbSet<RefBuildingEnvOrEnergyPerformanceRatingCat> RefBuildingEnvOrEnergyPerformanceRatingCats { get; set; }
        public virtual DbSet<RefBuildingFireProtectionSystemType> RefBuildingFireProtectionSystemTypes { get; set; }
        public virtual DbSet<RefBuildingFoodServiceSpaceType> RefBuildingFoodServiceSpaceTypes { get; set; }
        public virtual DbSet<RefBuildingFullServiceKitchenType> RefBuildingFullServiceKitchenTypes { get; set; }
        public virtual DbSet<RefBuildingHeatingGenerationSystemType> RefBuildingHeatingGenerationSystemTypes { get; set; }
        public virtual DbSet<RefBuildingHistoricStatu> RefBuildingHistoricStatus { get; set; }
        public virtual DbSet<RefBuildingHVACSystemType> RefBuildingHVACSystemTypes { get; set; }
        public virtual DbSet<RefBuildingIndoorAthleticOrPhysEdSpaceType> RefBuildingIndoorAthleticOrPhysEdSpaceTypes { get; set; }
        public virtual DbSet<RefBuildingInstructionalSpaceFactorType> RefBuildingInstructionalSpaceFactorTypes { get; set; }
        public virtual DbSet<RefBuildingJointUseRationaleType> RefBuildingJointUseRationaleTypes { get; set; }
        public virtual DbSet<RefBuildingJointUserType> RefBuildingJointUserTypes { get; set; }
        public virtual DbSet<RefBuildingJointUseSchedulingType> RefBuildingJointUseSchedulingTypes { get; set; }
        public virtual DbSet<RefBuildingLibMediaCenterSpecialtySpaceType> RefBuildingLibMediaCenterSpecialtySpaceTypes { get; set; }
        public virtual DbSet<RefBuildingMechanicalConveyingSystemType> RefBuildingMechanicalConveyingSystemTypes { get; set; }
        public virtual DbSet<RefBuildingMechanicalSystemType> RefBuildingMechanicalSystemTypes { get; set; }
        public virtual DbSet<RefBuildingOperationsOrMaintSpaceType> RefBuildingOperationsOrMaintSpaceTypes { get; set; }
        public virtual DbSet<RefBuildingOutdoorAthleticOrPhysEdSpaceType> RefBuildingOutdoorAthleticOrPhysEdSpaceTypes { get; set; }
        public virtual DbSet<RefBuildingOutdoorOrNonathleticSpaceType> RefBuildingOutdoorOrNonathleticSpaceTypes { get; set; }
        public virtual DbSet<RefBuildingPerformingArtsSpecialtySpaceType> RefBuildingPerformingArtsSpecialtySpaceTypes { get; set; }
        public virtual DbSet<RefBuildingPlumbingSystemType> RefBuildingPlumbingSystemTypes { get; set; }
        public virtual DbSet<RefBuildingPrimaryUseType> RefBuildingPrimaryUseTypes { get; set; }
        public virtual DbSet<RefBuildingSchoolDesignType> RefBuildingSchoolDesignTypes { get; set; }
        public virtual DbSet<RefBuildingScienceSpecialtySpaceType> RefBuildingScienceSpecialtySpaceTypes { get; set; }
        public virtual DbSet<RefBuildingSecuritySystemType> RefBuildingSecuritySystemTypes { get; set; }
        public virtual DbSet<RefBuildingSiteUseRestrictionsType> RefBuildingSiteUseRestrictionsTypes { get; set; }
        public virtual DbSet<RefBuildingSpaceDesignType> RefBuildingSpaceDesignTypes { get; set; }
        public virtual DbSet<RefBuildingSpecEdSpecialtySpaceType> RefBuildingSpecEdSpecialtySpaceTypes { get; set; }
        public virtual DbSet<RefBuildingStudentSupportSpaceType> RefBuildingStudentSupportSpaceTypes { get; set; }
        public virtual DbSet<RefBuildingSystemType> RefBuildingSystemTypes { get; set; }
        public virtual DbSet<RefBuildingTechnologyWiringSystemType> RefBuildingTechnologyWiringSystemTypes { get; set; }
        public virtual DbSet<RefBuildingUseType> RefBuildingUseTypes { get; set; }
        public virtual DbSet<RefBuildingVerticalTransportationSystemType> RefBuildingVerticalTransportationSystemTypes { get; set; }
        public virtual DbSet<RefCalendarEventType> RefCalendarEventTypes { get; set; }
        public virtual DbSet<RefCampusResidencyType> RefCampusResidencyTypes { get; set; }
        public virtual DbSet<RefCampusStatu> RefCampusStatus { get; set; }
        public virtual DbSet<RefCampusType> RefCampusTypes { get; set; }
        public virtual DbSet<RefCareerCluster> RefCareerClusters { get; set; }
        public virtual DbSet<RefCareerEducationPlanType> RefCareerEducationPlanTypes { get; set; }
        public virtual DbSet<RefCarnegieBasicClassification> RefCarnegieBasicClassifications { get; set; }
        public virtual DbSet<RefCharterLeaStatu> RefCharterLeaStatus { get; set; }
        public virtual DbSet<RefCharterSchoolAuthorizerType> RefCharterSchoolAuthorizerTypes { get; set; }
        public virtual DbSet<RefCharterSchoolManagementOrganizationType> RefCharterSchoolManagementOrganizationTypes { get; set; }
        public virtual DbSet<RefCharterSchoolType> RefCharterSchoolTypes { get; set; }
        public virtual DbSet<RefChildDevelopmentalScreeningStatu> RefChildDevelopmentalScreeningStatus { get; set; }
        public virtual DbSet<RefChildDevelopmentAssociateType> RefChildDevelopmentAssociateTypes { get; set; }
        public virtual DbSet<RefChildOutcomesSummaryRating> RefChildOutcomesSummaryRatings { get; set; }
        public virtual DbSet<RefCipCode> RefCipCodes { get; set; }
        public virtual DbSet<RefCipUse> RefCipUses { get; set; }
        public virtual DbSet<RefCipVersion> RefCipVersions { get; set; }
        public virtual DbSet<RefClassroomPositionType> RefClassroomPositionTypes { get; set; }
        public virtual DbSet<RefCohortExclusion> RefCohortExclusions { get; set; }
        public virtual DbSet<RefCommunicationMethod> RefCommunicationMethods { get; set; }
        public virtual DbSet<RefCommunityBasedType> RefCommunityBasedTypes { get; set; }
        public virtual DbSet<RefCompetencyDefAssociationType> RefCompetencyDefAssociationTypes { get; set; }
        public virtual DbSet<RefCompetencyDefNodeAccessibilityProfile> RefCompetencyDefNodeAccessibilityProfiles { get; set; }
        public virtual DbSet<RefCompetencyDefTestabilityType> RefCompetencyDefTestabilityTypes { get; set; }
        public virtual DbSet<RefCompetencyFrameworkPublicationStatu> RefCompetencyFrameworkPublicationStatus { get; set; }
        public virtual DbSet<RefCompetencySetCompletionCriteria> RefCompetencySetCompletionCriterias { get; set; }
        public virtual DbSet<RefComprehensiveAndTargetedSupport> RefComprehensiveAndTargetedSupports { get; set; }
        public virtual DbSet<RefComprehensiveSupport> RefComprehensiveSupports { get; set; }
        public virtual DbSet<RefComprehensiveSupportAndImprovementStatu> RefComprehensiveSupportAndImprovementStatus { get; set; }
        public virtual DbSet<RefContentStandardType> RefContentStandardTypes { get; set; }
        public virtual DbSet<RefContinuationOfService> RefContinuationOfServices { get; set; }
        public virtual DbSet<RefControlOfInstitution> RefControlOfInstitutions { get; set; }
        public virtual DbSet<RefCoreKnowledgeArea> RefCoreKnowledgeAreas { get; set; }
        public virtual DbSet<RefCorrectionalEducationFacilityType> RefCorrectionalEducationFacilityTypes { get; set; }
        public virtual DbSet<RefCorrectiveActionType> RefCorrectiveActionTypes { get; set; }
        public virtual DbSet<RefCountry> RefCountries { get; set; }
        public virtual DbSet<RefCounty> RefCounties { get; set; }
        public virtual DbSet<RefCourseAcademicGradeStatusCode> RefCourseAcademicGradeStatusCodes { get; set; }
        public virtual DbSet<RefCourseApplicableEducationLevel> RefCourseApplicableEducationLevels { get; set; }
        public virtual DbSet<RefCourseCreditBasisType> RefCourseCreditBasisTypes { get; set; }
        public virtual DbSet<RefCourseCreditLevelType> RefCourseCreditLevelTypes { get; set; }
        public virtual DbSet<RefCourseCreditUnit> RefCourseCreditUnits { get; set; }
        public virtual DbSet<RefCourseGpaApplicability> RefCourseGpaApplicabilities { get; set; }
        public virtual DbSet<RefCourseHonorsType> RefCourseHonorsTypes { get; set; }
        public virtual DbSet<RefCourseInstructionMethod> RefCourseInstructionMethods { get; set; }
        public virtual DbSet<RefCourseInstructionSiteType> RefCourseInstructionSiteTypes { get; set; }
        public virtual DbSet<RefCourseInteractionMode> RefCourseInteractionModes { get; set; }
        public virtual DbSet<RefCourseLevelCharacteristic> RefCourseLevelCharacteristics { get; set; }
        public virtual DbSet<RefCourseLevelType> RefCourseLevelTypes { get; set; }
        public virtual DbSet<RefCourseRepeatCode> RefCourseRepeatCodes { get; set; }
        public virtual DbSet<RefCourseSectionAssessmentReportingMethod> RefCourseSectionAssessmentReportingMethods { get; set; }
        public virtual DbSet<RefCourseSectionDeliveryMode> RefCourseSectionDeliveryModes { get; set; }
        public virtual DbSet<RefCourseSectionEnrollmentStatusType> RefCourseSectionEnrollmentStatusTypes { get; set; }
        public virtual DbSet<RefCourseSectionEntryType> RefCourseSectionEntryTypes { get; set; }
        public virtual DbSet<RefCourseSectionExitType> RefCourseSectionExitTypes { get; set; }
        public virtual DbSet<RefCredentialDefAgentRoleType> RefCredentialDefAgentRoleTypes { get; set; }
        public virtual DbSet<RefCredentialDefAssessMethodType> RefCredentialDefAssessMethodTypes { get; set; }
        public virtual DbSet<RefCredentialDefIntendedPurposeType> RefCredentialDefIntendedPurposeTypes { get; set; }
        public virtual DbSet<RefCredentialDefStatusType> RefCredentialDefStatusTypes { get; set; }
        public virtual DbSet<RefCredentialDefVerificationType> RefCredentialDefVerificationTypes { get; set; }
        public virtual DbSet<RefCredentialIdentifierSystem> RefCredentialIdentifierSystems { get; set; }
        public virtual DbSet<RefCredentialType> RefCredentialTypes { get; set; }
        public virtual DbSet<RefCreditHoursAppliedOtherProgram> RefCreditHoursAppliedOtherPrograms { get; set; }
        public virtual DbSet<RefCreditTypeEarned> RefCreditTypeEarneds { get; set; }
        public virtual DbSet<RefCriticalTeacherShortageCandidate> RefCriticalTeacherShortageCandidates { get; set; }
        public virtual DbSet<RefCTDLAudienceLevelType> RefCTDLAudienceLevelTypes { get; set; }
        public virtual DbSet<RefCTDLOrganizationType> RefCTDLOrganizationTypes { get; set; }
        public virtual DbSet<RefCteGraduationRateInclusion> RefCteGraduationRateInclusions { get; set; }
        public virtual DbSet<RefCteNonTraditionalGenderStatu> RefCteNonTraditionalGenderStatus { get; set; }
        public virtual DbSet<RefCurriculumFrameworkType> RefCurriculumFrameworkTypes { get; set; }
        public virtual DbSet<RefDataCollectionStatu> RefDataCollectionStatus { get; set; }
        public virtual DbSet<RefDegreeOrCertificateType> RefDegreeOrCertificateTypes { get; set; }
        public virtual DbSet<RefDentalInsuranceCoverageType> RefDentalInsuranceCoverageTypes { get; set; }
        public virtual DbSet<RefDentalScreeningStatu> RefDentalScreeningStatus { get; set; }
        public virtual DbSet<RefDependencyStatu> RefDependencyStatus { get; set; }
        public virtual DbSet<RefDevelopmentalEducationReferralStatu> RefDevelopmentalEducationReferralStatus { get; set; }
        public virtual DbSet<RefDevelopmentalEducationType> RefDevelopmentalEducationTypes { get; set; }
        public virtual DbSet<RefDevelopmentalEvaluationFinding> RefDevelopmentalEvaluationFindings { get; set; }
        public virtual DbSet<RefDirectoryInformationBlockStatu> RefDirectoryInformationBlockStatus { get; set; }
        public virtual DbSet<RefDisabilityConditionStatusCode> RefDisabilityConditionStatusCodes { get; set; }
        public virtual DbSet<RefDisabilityConditionType> RefDisabilityConditionTypes { get; set; }
        public virtual DbSet<RefDisabilityDeterminationSourceType> RefDisabilityDeterminationSourceTypes { get; set; }
        public virtual DbSet<RefDisabilityType> RefDisabilityTypes { get; set; }
        public virtual DbSet<RefDisciplinaryActionTaken> RefDisciplinaryActionTakens { get; set; }
        public virtual DbSet<RefDisciplineLengthDifferenceReason> RefDisciplineLengthDifferenceReasons { get; set; }
        public virtual DbSet<RefDisciplineMethodFirearm> RefDisciplineMethodFirearms { get; set; }
        public virtual DbSet<RefDisciplineMethodOfCwd> RefDisciplineMethodOfCwds { get; set; }
        public virtual DbSet<RefDisciplineReason> RefDisciplineReasons { get; set; }
        public virtual DbSet<RefDistanceEducationCourseEnrollment> RefDistanceEducationCourseEnrollments { get; set; }
        public virtual DbSet<RefDoctoralExamsRequiredCode> RefDoctoralExamsRequiredCodes { get; set; }
        public virtual DbSet<RefDQPCategoriesOfLearning> RefDQPCategoriesOfLearnings { get; set; }
        public virtual DbSet<RefEarlyChildhoodCredential> RefEarlyChildhoodCredentials { get; set; }
        public virtual DbSet<RefEarlyChildhoodProgramEnrollmentType> RefEarlyChildhoodProgramEnrollmentTypes { get; set; }
        public virtual DbSet<RefEarlyChildhoodService> RefEarlyChildhoodServices { get; set; }
        public virtual DbSet<RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType> RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypes { get; set; }
        public virtual DbSet<RefEdFactsAcademicOrCareerAndTechnicalOutcomeType> RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypes { get; set; }
        public virtual DbSet<RefEDFactsTeacherInexperiencedStatu> RefEDFactsTeacherInexperiencedStatus { get; set; }
        public virtual DbSet<RefEducationLevel> RefEducationLevels { get; set; }
        public virtual DbSet<RefEducationLevelType> RefEducationLevelTypes { get; set; }
        public virtual DbSet<RefEducationVerificationMethod> RefEducationVerificationMethods { get; set; }
        public virtual DbSet<RefELEducationStaffClassification> RefELEducationStaffClassifications { get; set; }
        public virtual DbSet<RefElementaryMiddleAdditional> RefElementaryMiddleAdditionals { get; set; }
        public virtual DbSet<RefELEmploymentSeparationReason> RefELEmploymentSeparationReasons { get; set; }
        public virtual DbSet<RefELFacilityLicensingStatu> RefELFacilityLicensingStatus { get; set; }
        public virtual DbSet<RefELFederalFundingType> RefELFederalFundingTypes { get; set; }
        public virtual DbSet<RefELGroupSizeStandardMet> RefELGroupSizeStandardMets { get; set; }
        public virtual DbSet<RefELLevelOfSpecialization> RefELLevelOfSpecializations { get; set; }
        public virtual DbSet<RefELLocalRevenueSource> RefELLocalRevenueSources { get; set; }
        public virtual DbSet<RefELOtherFederalFundingSource> RefELOtherFederalFundingSources { get; set; }
        public virtual DbSet<RefELOutcomeMeasurementLevel> RefELOutcomeMeasurementLevels { get; set; }
        public virtual DbSet<RefELProfessionalDevelopmentTopicArea> RefELProfessionalDevelopmentTopicAreas { get; set; }
        public virtual DbSet<RefELProgramEligibility> RefELProgramEligibilities { get; set; }
        public virtual DbSet<RefELProgramEligibilityStatu> RefELProgramEligibilityStatus { get; set; }
        public virtual DbSet<RefELProgramLicenseStatu> RefELProgramLicenseStatus { get; set; }
        public virtual DbSet<RefELServiceProfessionalStaffClassification> RefELServiceProfessionalStaffClassifications { get; set; }
        public virtual DbSet<RefELServiceType> RefELServiceTypes { get; set; }
        public virtual DbSet<RefELStateRevenueSource> RefELStateRevenueSources { get; set; }
        public virtual DbSet<RefELTrainerCoreKnowledgeArea> RefELTrainerCoreKnowledgeAreas { get; set; }
        public virtual DbSet<RefEmailType> RefEmailTypes { get; set; }
        public virtual DbSet<RefEmergencyOrProvisionalCredentialStatu> RefEmergencyOrProvisionalCredentialStatus { get; set; }
        public virtual DbSet<RefEmployedAfterExit> RefEmployedAfterExits { get; set; }
        public virtual DbSet<RefEmployedPriorToEnrollment> RefEmployedPriorToEnrollments { get; set; }
        public virtual DbSet<RefEmployedWhileEnrolled> RefEmployedWhileEnrolleds { get; set; }
        public virtual DbSet<RefEmployeeBenefit> RefEmployeeBenefits { get; set; }
        public virtual DbSet<RefEmploymentContractType> RefEmploymentContractTypes { get; set; }
        public virtual DbSet<RefEmploymentLocation> RefEmploymentLocations { get; set; }
        public virtual DbSet<RefEmploymentSeparationReason> RefEmploymentSeparationReasons { get; set; }
        public virtual DbSet<RefEmploymentSeparationType> RefEmploymentSeparationTypes { get; set; }
        public virtual DbSet<RefEmploymentStatu> RefEmploymentStatus { get; set; }
        public virtual DbSet<RefEmploymentStatusWhileEnrolled> RefEmploymentStatusWhileEnrolleds { get; set; }
        public virtual DbSet<RefEndOfTermStatu> RefEndOfTermStatus { get; set; }
        public virtual DbSet<RefEnrollmentStatu> RefEnrollmentStatus { get; set; }
        public virtual DbSet<RefEntityType> RefEntityTypes { get; set; }
        public virtual DbSet<RefEntryType> RefEntryTypes { get; set; }
        public virtual DbSet<RefEnvironmentSetting> RefEnvironmentSettings { get; set; }
        public virtual DbSet<RefERAdministrativeDataSource> RefERAdministrativeDataSources { get; set; }
        public virtual DbSet<RefERSRuralUrbanContinuumCode> RefERSRuralUrbanContinuumCodes { get; set; }
        public virtual DbSet<RefExitOrWithdrawalStatu> RefExitOrWithdrawalStatus { get; set; }
        public virtual DbSet<RefExitOrWithdrawalType> RefExitOrWithdrawalTypes { get; set; }
        public virtual DbSet<RefFacilitiesMandateAuthorityType> RefFacilitiesMandateAuthorityTypes { get; set; }
        public virtual DbSet<RefFacilitiesMgmtEmergencyType> RefFacilitiesMgmtEmergencyTypes { get; set; }
        public virtual DbSet<RefFacilitiesPlanType> RefFacilitiesPlanTypes { get; set; }
        public virtual DbSet<RefFacilityApplicableFederalMandateType> RefFacilityApplicableFederalMandateTypes { get; set; }
        public virtual DbSet<RefFacilityAuditType> RefFacilityAuditTypes { get; set; }
        public virtual DbSet<RefFacilityCapitalProgramMgmtType> RefFacilityCapitalProgramMgmtTypes { get; set; }
        public virtual DbSet<RefFacilityComplianceAgencyType> RefFacilityComplianceAgencyTypes { get; set; }
        public virtual DbSet<RefFacilityComplianceStatu> RefFacilityComplianceStatus { get; set; }
        public virtual DbSet<RefFacilityConstructionDateType> RefFacilityConstructionDateTypes { get; set; }
        public virtual DbSet<RefFacilityConstructionMaterialType> RefFacilityConstructionMaterialTypes { get; set; }
        public virtual DbSet<RefFacilityFederalMandateInterestType> RefFacilityFederalMandateInterestTypes { get; set; }
        public virtual DbSet<RefFacilityFinancingFeeType> RefFacilityFinancingFeeTypes { get; set; }
        public virtual DbSet<RefFacilityFurnishingsType> RefFacilityFurnishingsTypes { get; set; }
        public virtual DbSet<RefFacilityHazardousMaterialsOrCondType> RefFacilityHazardousMaterialsOrCondTypes { get; set; }
        public virtual DbSet<RefFacilityJointDevelopmentType> RefFacilityJointDevelopmentTypes { get; set; }
        public virtual DbSet<RefFacilityLeaseAmountCategory> RefFacilityLeaseAmountCategories { get; set; }
        public virtual DbSet<RefFacilityLeaseType> RefFacilityLeaseTypes { get; set; }
        public virtual DbSet<RefFacilityMaintStandardType> RefFacilityMaintStandardTypes { get; set; }
        public virtual DbSet<RefFacilityMortgageInterestType> RefFacilityMortgageInterestTypes { get; set; }
        public virtual DbSet<RefFacilityMortgageType> RefFacilityMortgageTypes { get; set; }
        public virtual DbSet<RefFacilityNaturallyOccurringHazardType> RefFacilityNaturallyOccurringHazardTypes { get; set; }
        public virtual DbSet<RefFacilityOperationsMgmtType> RefFacilityOperationsMgmtTypes { get; set; }
        public virtual DbSet<RefFacilitySiteImprovementLocationType> RefFacilitySiteImprovementLocationTypes { get; set; }
        public virtual DbSet<RefFacilitySiteOutdoorAreaType> RefFacilitySiteOutdoorAreaTypes { get; set; }
        public virtual DbSet<RefFacilityStandardType> RefFacilityStandardTypes { get; set; }
        public virtual DbSet<RefFacilityStateOrLocalMandateInterestType> RefFacilityStateOrLocalMandateInterestTypes { get; set; }
        public virtual DbSet<RefFacilitySystemOrComponentCondition> RefFacilitySystemOrComponentConditions { get; set; }
        public virtual DbSet<RefFacilityUtilityProviderType> RefFacilityUtilityProviderTypes { get; set; }
        public virtual DbSet<RefFacilityUtilityType> RefFacilityUtilityTypes { get; set; }
        public virtual DbSet<RefFamilyIncomeSource> RefFamilyIncomeSources { get; set; }
        public virtual DbSet<RefFederalProgramFundingAllocationType> RefFederalProgramFundingAllocationTypes { get; set; }
        public virtual DbSet<RefFinancialAccountBalanceSheetCode> RefFinancialAccountBalanceSheetCodes { get; set; }
        public virtual DbSet<RefFinancialAccountCategory> RefFinancialAccountCategories { get; set; }
        public virtual DbSet<RefFinancialAccountFundClassification> RefFinancialAccountFundClassifications { get; set; }
        public virtual DbSet<RefFinancialAccountProgramCode> RefFinancialAccountProgramCodes { get; set; }
        public virtual DbSet<RefFinancialAccountRevenueCode> RefFinancialAccountRevenueCodes { get; set; }
        public virtual DbSet<RefFinancialAidApplicationType> RefFinancialAidApplicationTypes { get; set; }
        public virtual DbSet<RefFinancialAidAwardStatu> RefFinancialAidAwardStatus { get; set; }
        public virtual DbSet<RefFinancialAidAwardType> RefFinancialAidAwardTypes { get; set; }
        public virtual DbSet<RefFinancialAidVeteransBenefitStatu> RefFinancialAidVeteransBenefitStatus { get; set; }
        public virtual DbSet<RefFinancialAidVeteransBenefitType> RefFinancialAidVeteransBenefitTypes { get; set; }
        public virtual DbSet<RefFinancialExpenditureFunctionCode> RefFinancialExpenditureFunctionCodes { get; set; }
        public virtual DbSet<RefFinancialExpenditureLevelOfInstructionCode> RefFinancialExpenditureLevelOfInstructionCodes { get; set; }
        public virtual DbSet<RefFinancialExpenditureObjectCode> RefFinancialExpenditureObjectCodes { get; set; }
        public virtual DbSet<RefFirearmType> RefFirearmTypes { get; set; }
        public virtual DbSet<RefFoodServiceEligibility> RefFoodServiceEligibilities { get; set; }
        public virtual DbSet<RefFoodServiceParticipation> RefFoodServiceParticipations { get; set; }
        public virtual DbSet<RefFrequencyOfService> RefFrequencyOfServices { get; set; }
        public virtual DbSet<RefFrequencyUnit> RefFrequencyUnits { get; set; }
        public virtual DbSet<RefFullTimeStatu> RefFullTimeStatus { get; set; }
        public virtual DbSet<RefGoalMeasurementType> RefGoalMeasurementTypes { get; set; }
        public virtual DbSet<RefGoalsForAttendingAdultEducation> RefGoalsForAttendingAdultEducations { get; set; }
        public virtual DbSet<RefGoalStatusType> RefGoalStatusTypes { get; set; }
        public virtual DbSet<RefGpaWeightedIndicator> RefGpaWeightedIndicators { get; set; }
        public virtual DbSet<RefGradeLevel> RefGradeLevels { get; set; }
        public virtual DbSet<RefGradeLevelsApproved> RefGradeLevelsApproveds { get; set; }
        public virtual DbSet<RefGradeLevelType> RefGradeLevelTypes { get; set; }
        public virtual DbSet<RefGradePointAverageDomain> RefGradePointAverageDomains { get; set; }
        public virtual DbSet<RefGraduateAssistantIpedsCategory> RefGraduateAssistantIpedsCategories { get; set; }
        public virtual DbSet<RefGraduateOrDoctoralExamResultsStatu> RefGraduateOrDoctoralExamResultsStatus { get; set; }
        public virtual DbSet<RefGunFreeSchoolsActReportingStatu> RefGunFreeSchoolsActReportingStatus { get; set; }
        public virtual DbSet<RefHealthInsuranceCoverage> RefHealthInsuranceCoverages { get; set; }
        public virtual DbSet<RefHearingScreeningStatu> RefHearingScreeningStatus { get; set; }
        public virtual DbSet<RefHigherEducationInstitutionAccreditationStatu> RefHigherEducationInstitutionAccreditationStatus { get; set; }
        public virtual DbSet<RefHighSchoolDiplomaDistinctionType> RefHighSchoolDiplomaDistinctionTypes { get; set; }
        public virtual DbSet<RefHighSchoolDiplomaType> RefHighSchoolDiplomaTypes { get; set; }
        public virtual DbSet<RefHighSchoolGraduationRateIndicator> RefHighSchoolGraduationRateIndicators { get; set; }
        public virtual DbSet<RefHomelessNighttimeResidence> RefHomelessNighttimeResidences { get; set; }
        public virtual DbSet<RefIDEADisabilityType> RefIDEADisabilityTypes { get; set; }
        public virtual DbSet<RefIDEADisciplineMethodFirearm> RefIDEADisciplineMethodFirearms { get; set; }
        public virtual DbSet<RefIDEAEducationalEnvironmentEC> RefIDEAEducationalEnvironmentECs { get; set; }
        public virtual DbSet<RefIDEAEducationalEnvironmentSchoolAge> RefIDEAEducationalEnvironmentSchoolAges { get; set; }
        public virtual DbSet<RefIDEAEligibilityEvaluationCategory> RefIDEAEligibilityEvaluationCategories { get; set; }
        public virtual DbSet<RefIDEAEnvironmentEL> RefIDEAEnvironmentELs { get; set; }
        public virtual DbSet<RefIDEAIEPStatu> RefIDEAIEPStatus { get; set; }
        public virtual DbSet<RefIDEAInterimRemoval> RefIDEAInterimRemovals { get; set; }
        public virtual DbSet<RefIDEAInterimRemovalReason> RefIDEAInterimRemovalReasons { get; set; }
        public virtual DbSet<RefIDEAPartCEligibilityCategory> RefIDEAPartCEligibilityCategories { get; set; }
        public virtual DbSet<RefIEPAuthorizationDocumentType> RefIEPAuthorizationDocumentTypes { get; set; }
        public virtual DbSet<RefIEPEligibilityEvaluationType> RefIEPEligibilityEvaluationTypes { get; set; }
        public virtual DbSet<RefIEPGoalType> RefIEPGoalTypes { get; set; }
        public virtual DbSet<RefImmunizationType> RefImmunizationTypes { get; set; }
        public virtual DbSet<RefIncidentBehavior> RefIncidentBehaviors { get; set; }
        public virtual DbSet<RefIncidentBehaviorSecondary> RefIncidentBehaviorSecondaries { get; set; }
        public virtual DbSet<RefIncidentInjuryType> RefIncidentInjuryTypes { get; set; }
        public virtual DbSet<RefIncidentLocation> RefIncidentLocations { get; set; }
        public virtual DbSet<RefIncidentMultipleOffenseType> RefIncidentMultipleOffenseTypes { get; set; }
        public virtual DbSet<RefIncidentPerpetratorInjuryType> RefIncidentPerpetratorInjuryTypes { get; set; }
        public virtual DbSet<RefIncidentPersonRoleType> RefIncidentPersonRoleTypes { get; set; }
        public virtual DbSet<RefIncidentPersonType> RefIncidentPersonTypes { get; set; }
        public virtual DbSet<RefIncidentReporterType> RefIncidentReporterTypes { get; set; }
        public virtual DbSet<RefIncidentTimeDescriptionCode> RefIncidentTimeDescriptionCodes { get; set; }
        public virtual DbSet<RefIncomeCalculationMethod> RefIncomeCalculationMethods { get; set; }
        public virtual DbSet<RefIncreasedLearningTimeType> RefIncreasedLearningTimeTypes { get; set; }
        public virtual DbSet<RefIndicatorStateDefinedStatu> RefIndicatorStateDefinedStatus { get; set; }
        public virtual DbSet<RefIndicatorStatusCustomType> RefIndicatorStatusCustomTypes { get; set; }
        public virtual DbSet<RefIndicatorStatusSubgroupType> RefIndicatorStatusSubgroupTypes { get; set; }
        public virtual DbSet<RefIndicatorStatusType> RefIndicatorStatusTypes { get; set; }
        public virtual DbSet<RefIndividualizedProgramDateType> RefIndividualizedProgramDateTypes { get; set; }
        public virtual DbSet<RefIndividualizedProgramLocation> RefIndividualizedProgramLocations { get; set; }
        public virtual DbSet<RefIndividualizedProgramPlannedServiceType> RefIndividualizedProgramPlannedServiceTypes { get; set; }
        public virtual DbSet<RefIndividualizedProgramTransitionType> RefIndividualizedProgramTransitionTypes { get; set; }
        public virtual DbSet<RefIndividualizedProgramType> RefIndividualizedProgramTypes { get; set; }
        public virtual DbSet<RefInstitutionTelephoneType> RefInstitutionTelephoneTypes { get; set; }
        public virtual DbSet<RefInstructionalActivityHour> RefInstructionalActivityHours { get; set; }
        public virtual DbSet<RefInstructionalStaffContractLength> RefInstructionalStaffContractLengths { get; set; }
        public virtual DbSet<RefInstructionalStaffFacultyTenure> RefInstructionalStaffFacultyTenures { get; set; }
        public virtual DbSet<RefInstructionCreditType> RefInstructionCreditTypes { get; set; }
        public virtual DbSet<RefInstructionLocationType> RefInstructionLocationTypes { get; set; }
        public virtual DbSet<RefIntegratedTechnologyStatu> RefIntegratedTechnologyStatus { get; set; }
        public virtual DbSet<RefInternetAccess> RefInternetAccesses { get; set; }
        public virtual DbSet<RefInternetAccessTypeInResidence> RefInternetAccessTypeInResidences { get; set; }
        public virtual DbSet<RefInternetPerformanceInResidence> RefInternetPerformanceInResidences { get; set; }
        public virtual DbSet<RefIPEDSFASBFinancialPosition> RefIPEDSFASBFinancialPositions { get; set; }
        public virtual DbSet<RefIPEDSFASBFunctionalExpense> RefIPEDSFASBFunctionalExpenses { get; set; }
        public virtual DbSet<RefIPEDSFASBPellGrantTransaction> RefIPEDSFASBPellGrantTransactions { get; set; }
        public virtual DbSet<RefIPEDSFASBRevenue> RefIPEDSFASBRevenues { get; set; }
        public virtual DbSet<RefIPEDSFASBRevenueRestriction> RefIPEDSFASBRevenueRestrictions { get; set; }
        public virtual DbSet<RefIPEDSFASBScholarshipsandFellowshipsRevenue> RefIPEDSFASBScholarshipsandFellowshipsRevenues { get; set; }
        public virtual DbSet<RefIPEDSGASBFinancialPosition> RefIPEDSGASBFinancialPositions { get; set; }
        public virtual DbSet<RefIPEDSGASBFunctionalExpense> RefIPEDSGASBFunctionalExpenses { get; set; }
        public virtual DbSet<RefIPEDSGASBRevenue> RefIPEDSGASBRevenues { get; set; }
        public virtual DbSet<RefIPEDSGASBScholarshipsandFellowshipsRevenue> RefIPEDSGASBScholarshipsandFellowshipsRevenues { get; set; }
        public virtual DbSet<RefIPEDSIntercollegiateAthleticsExpens> RefIPEDSIntercollegiateAthleticsExpenses { get; set; }
        public virtual DbSet<RefIPEDSNaturalExpense> RefIPEDSNaturalExpenses { get; set; }
        public virtual DbSet<RefIpedsOccupationalCategory> RefIpedsOccupationalCategories { get; set; }
        public virtual DbSet<RefIPSPProgressReportSchedule> RefIPSPProgressReportSchedules { get; set; }
        public virtual DbSet<RefIPSPProgressReportType> RefIPSPProgressReportTypes { get; set; }
        public virtual DbSet<RefISO6392Language> RefISO6392Language { get; set; }
        public virtual DbSet<RefISO6393Language> RefISO6393Language { get; set; }
        public virtual DbSet<RefISO6395LanguageFamily> RefISO6395LanguageFamily { get; set; }
        public virtual DbSet<RefItemResponseTheoryDifficultyCategory> RefItemResponseTheoryDifficultyCategories { get; set; }
        public virtual DbSet<RefItemResponseTheoryKappaAlgorithm> RefItemResponseTheoryKappaAlgorithms { get; set; }
        public virtual DbSet<RefK12EndOfCourseRequirement> RefK12EndOfCourseRequirement { get; set; }
        public virtual DbSet<RefK12LeaTitleISupportService> RefK12LeaTitleISupportService { get; set; }
        public virtual DbSet<RefK12ResponsibilityType> RefK12ResponsibilityType { get; set; }
        public virtual DbSet<RefK12StaffClassification> RefK12StaffClassification { get; set; }
        public virtual DbSet<RefLanguage> RefLanguages { get; set; }
        public virtual DbSet<RefLanguageUseType> RefLanguageUseTypes { get; set; }
        public virtual DbSet<RefLeaFundsTransferType> RefLeaFundsTransferTypes { get; set; }
        public virtual DbSet<RefLeaImprovementStatu> RefLeaImprovementStatus { get; set; }
        public virtual DbSet<RefLearnerActionType> RefLearnerActionTypes { get; set; }
        public virtual DbSet<RefLearnerActivityAddToGradeBookFlag> RefLearnerActivityAddToGradeBookFlags { get; set; }
        public virtual DbSet<RefLearnerActivityMaximumTimeAllowedUnit> RefLearnerActivityMaximumTimeAllowedUnits { get; set; }
        public virtual DbSet<RefLearnerActivityType> RefLearnerActivityTypes { get; set; }
        public virtual DbSet<RefLearningResourceAccessAPIType> RefLearningResourceAccessAPITypes { get; set; }
        public virtual DbSet<RefLearningResourceAccessHazardType> RefLearningResourceAccessHazardTypes { get; set; }
        public virtual DbSet<RefLearningResourceAccessModeType> RefLearningResourceAccessModeTypes { get; set; }
        public virtual DbSet<RefLearningResourceAccessRightsUrl> RefLearningResourceAccessRightsUrls { get; set; }
        public virtual DbSet<RefLearningResourceAuthorType> RefLearningResourceAuthorTypes { get; set; }
        public virtual DbSet<RefLearningResourceBookFormatType> RefLearningResourceBookFormatTypes { get; set; }
        public virtual DbSet<RefLearningResourceCompetencyAlignmentType> RefLearningResourceCompetencyAlignmentTypes { get; set; }
        public virtual DbSet<RefLearningResourceControlFlexibilityType> RefLearningResourceControlFlexibilityTypes { get; set; }
        public virtual DbSet<RefLearningResourceDigitalMediaSubType> RefLearningResourceDigitalMediaSubTypes { get; set; }
        public virtual DbSet<RefLearningResourceDigitalMediaType> RefLearningResourceDigitalMediaTypes { get; set; }
        public virtual DbSet<RefLearningResourceEducationalUse> RefLearningResourceEducationalUses { get; set; }
        public virtual DbSet<RefLearningResourceIntendedEndUserRole> RefLearningResourceIntendedEndUserRoles { get; set; }
        public virtual DbSet<RefLearningResourceInteractionMode> RefLearningResourceInteractionModes { get; set; }
        public virtual DbSet<RefLearningResourceInteractivityType> RefLearningResourceInteractivityTypes { get; set; }
        public virtual DbSet<RefLearningResourceMediaFeatureType> RefLearningResourceMediaFeatureTypes { get; set; }
        public virtual DbSet<RefLearningResourcePhysicalMediaType> RefLearningResourcePhysicalMediaTypes { get; set; }
        public virtual DbSet<RefLearningResourceType> RefLearningResourceTypes { get; set; }
        public virtual DbSet<RefLeaType> RefLeaTypes { get; set; }
        public virtual DbSet<RefLeaveEventType> RefLeaveEventTypes { get; set; }
        public virtual DbSet<RefLevelOfInstitution> RefLevelOfInstitutions { get; set; }
        public virtual DbSet<RefLicenseExempt> RefLicenseExempts { get; set; }
        public virtual DbSet<RefLiteracyAssessment> RefLiteracyAssessments { get; set; }
        public virtual DbSet<RefMagnetSpecialProgram> RefMagnetSpecialPrograms { get; set; }
        public virtual DbSet<RefMedicalAlertIndicator> RefMedicalAlertIndicators { get; set; }
        public virtual DbSet<RefMepEnrollmentType> RefMepEnrollmentTypes { get; set; }
        public virtual DbSet<RefMepProjectBased> RefMepProjectBaseds { get; set; }
        public virtual DbSet<RefMepProjectType> RefMepProjectTypes { get; set; }
        public virtual DbSet<RefMepServiceType> RefMepServiceTypes { get; set; }
        public virtual DbSet<RefMepSessionType> RefMepSessionTypes { get; set; }
        public virtual DbSet<RefMepStaffCategory> RefMepStaffCategories { get; set; }
        public virtual DbSet<RefMethodOfServiceDelivery> RefMethodOfServiceDeliveries { get; set; }
        public virtual DbSet<RefMilitaryActiveStudentIndicator> RefMilitaryActiveStudentIndicators { get; set; }
        public virtual DbSet<RefMilitaryBranch> RefMilitaryBranches { get; set; }
        public virtual DbSet<RefMilitaryConnectedStudentIndicator> RefMilitaryConnectedStudentIndicators { get; set; }
        public virtual DbSet<RefMilitaryVeteranStudentIndicator> RefMilitaryVeteranStudentIndicators { get; set; }
        public virtual DbSet<RefMultipleIntelligenceType> RefMultipleIntelligenceTypes { get; set; }
        public virtual DbSet<RefNaepAspectsOfReading> RefNaepAspectsOfReadings { get; set; }
        public virtual DbSet<RefNaepMathComplexityLevel> RefNaepMathComplexityLevels { get; set; }
        public virtual DbSet<RefNationalSchoolLunchProgramStatu> RefNationalSchoolLunchProgramStatus { get; set; }
        public virtual DbSet<RefNCESCollegeCourseMapCode> RefNCESCollegeCourseMapCodes { get; set; }
        public virtual DbSet<RefNeedDeterminationMethod> RefNeedDeterminationMethods { get; set; }
        public virtual DbSet<RefNeglectedProgramType> RefNeglectedProgramTypes { get; set; }
        public virtual DbSet<RefNonPromotionReason> RefNonPromotionReasons { get; set; }
        public virtual DbSet<RefNonTraditionalGenderStatu> RefNonTraditionalGenderStatus { get; set; }
        public virtual DbSet<RefNSLPStatu> RefNSLPStatus { get; set; }
        public virtual DbSet<RefNumberOfDependentsType> RefNumberOfDependentsTypes { get; set; }
        public virtual DbSet<RefONETSOCOccupationType> RefONETSOCOccupationTypes { get; set; }
        public virtual DbSet<RefOperationalStatu> RefOperationalStatus { get; set; }
        public virtual DbSet<RefOperationalStatusType> RefOperationalStatusTypes { get; set; }
        public virtual DbSet<RefOrganizationElementType> RefOrganizationElementTypes { get; set; }
        public virtual DbSet<RefOrganizationIdentificationSystem> RefOrganizationIdentificationSystems { get; set; }
        public virtual DbSet<RefOrganizationIdentifierType> RefOrganizationIdentifierTypes { get; set; }
        public virtual DbSet<RefOrganizationIndicator> RefOrganizationIndicators { get; set; }
        public virtual DbSet<RefOrganizationLocationType> RefOrganizationLocationTypes { get; set; }
        public virtual DbSet<RefOrganizationMonitoringNotification> RefOrganizationMonitoringNotifications { get; set; }
        public virtual DbSet<RefOrganizationRelationship> RefOrganizationRelationships { get; set; }
        public virtual DbSet<RefOrganizationType> RefOrganizationTypes { get; set; }
        public virtual DbSet<RefOtherNameType> RefOtherNameTypes { get; set; }
        public virtual DbSet<RefOutcomeTimePoint> RefOutcomeTimePoints { get; set; }
        public virtual DbSet<RefOutOfFieldStatu> RefOutOfFieldStatus { get; set; }
        public virtual DbSet<RefParaprofessionalQualification> RefParaprofessionalQualifications { get; set; }
        public virtual DbSet<RefParticipationStatusAyp> RefParticipationStatusAyps { get; set; }
        public virtual DbSet<RefParticipationType> RefParticipationTypes { get; set; }
        public virtual DbSet<RefPDActivityApprovedPurpose> RefPDActivityApprovedPurposes { get; set; }
        public virtual DbSet<RefPDActivityCreditType> RefPDActivityCreditTypes { get; set; }
        public virtual DbSet<RefPDActivityEducationLevelsAddressed> RefPDActivityEducationLevelsAddresseds { get; set; }
        public virtual DbSet<RefPDActivityLevel> RefPDActivityLevels { get; set; }
        public virtual DbSet<RefPDActivityTargetAudience> RefPDActivityTargetAudiences { get; set; }
        public virtual DbSet<RefPDActivityType> RefPDActivityTypes { get; set; }
        public virtual DbSet<RefPDAudienceType> RefPDAudienceTypes { get; set; }
        public virtual DbSet<RefPDDeliveryMethod> RefPDDeliveryMethods { get; set; }
        public virtual DbSet<RefPDInstructionalDeliveryMode> RefPDInstructionalDeliveryModes { get; set; }
        public virtual DbSet<RefPDSessionStatu> RefPDSessionStatus { get; set; }
        public virtual DbSet<RefPersonalInformationType> RefPersonalInformationTypes { get; set; }
        public virtual DbSet<RefPersonalInformationVerification> RefPersonalInformationVerifications { get; set; }
        public virtual DbSet<RefPersonIdentificationSystem> RefPersonIdentificationSystems { get; set; }
        public virtual DbSet<RefPersonIdentifierType> RefPersonIdentifierTypes { get; set; }
        public virtual DbSet<RefPersonLocationType> RefPersonLocationTypes { get; set; }
        public virtual DbSet<RefPersonRelationshipType> RefPersonRelationshipTypes { get; set; }
        public virtual DbSet<RefPersonStatusType> RefPersonStatusTypes { get; set; }
        public virtual DbSet<RefPersonTelephoneNumberType> RefPersonTelephoneNumberTypes { get; set; }
        public virtual DbSet<RefPESCAwardLevelType> RefPESCAwardLevelTypes { get; set; }
        public virtual DbSet<RefPopulationServed> RefPopulationServeds { get; set; }
        public virtual DbSet<RefPreAndPostTestIndicator> RefPreAndPostTestIndicators { get; set; }
        public virtual DbSet<RefPredominantCalendarSystem> RefPredominantCalendarSystems { get; set; }
        public virtual DbSet<RefPreKEligibleAgesNonIDEA> RefPreKEligibleAgesNonIDEAs { get; set; }
        public virtual DbSet<RefPrekindergartenEligibility> RefPrekindergartenEligibilities { get; set; }
        public virtual DbSet<RefPresentAttendanceCategory> RefPresentAttendanceCategories { get; set; }
        public virtual DbSet<RefPrimaryLearningDeviceAccess> RefPrimaryLearningDeviceAccesses { get; set; }
        public virtual DbSet<RefPrimaryLearningDeviceAwayFromSchool> RefPrimaryLearningDeviceAwayFromSchools { get; set; }
        public virtual DbSet<RefPrimaryLearningDeviceProvider> RefPrimaryLearningDeviceProviders { get; set; }
        public virtual DbSet<RefProfessionalDevelopmentFinancialSupport> RefProfessionalDevelopmentFinancialSupports { get; set; }
        public virtual DbSet<RefProfessionalEducationJobClassification> RefProfessionalEducationJobClassifications { get; set; }
        public virtual DbSet<RefProfessionalTechnicalCredentialType> RefProfessionalTechnicalCredentialTypes { get; set; }
        public virtual DbSet<RefProficiencyStatu> RefProficiencyStatus { get; set; }
        public virtual DbSet<RefProficiencyTargetAyp> RefProficiencyTargetAyps { get; set; }
        public virtual DbSet<RefProfitStatu> RefProfitStatus { get; set; }
        public virtual DbSet<RefProgramDayLength> RefProgramDayLengths { get; set; }
        public virtual DbSet<RefProgramEntryReason> RefProgramEntryReasons { get; set; }
        public virtual DbSet<RefProgramExitReason> RefProgramExitReasons { get; set; }
        public virtual DbSet<RefProgramGiftedEligibility> RefProgramGiftedEligibilities { get; set; }
        public virtual DbSet<RefProgramLengthHoursType> RefProgramLengthHoursTypes { get; set; }
        public virtual DbSet<RefProgramSponsorType> RefProgramSponsorTypes { get; set; }
        public virtual DbSet<RefProgramType> RefProgramTypes { get; set; }
        public virtual DbSet<RefProgressAchievingEnglishLanguageProficiencyIndicatorStatu> RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus { get; set; }
        public virtual DbSet<RefProgressLevel> RefProgressLevels { get; set; }
        public virtual DbSet<RefPromotionReason> RefPromotionReasons { get; set; }
        public virtual DbSet<RefProofOfResidencyType> RefProofOfResidencyTypes { get; set; }
        public virtual DbSet<RefPsEnrollmentAction> RefPsEnrollmentActions { get; set; }
        public virtual DbSet<RefPsEnrollmentAwardType> RefPsEnrollmentAwardTypes { get; set; }
        public virtual DbSet<RefPsEnrollmentStatu> RefPsEnrollmentStatus { get; set; }
        public virtual DbSet<RefPsEnrollmentType> RefPsEnrollmentTypes { get; set; }
        public virtual DbSet<RefPSExitOrWithdrawalType> RefPSExitOrWithdrawalTypes { get; set; }
        public virtual DbSet<RefPsLepType> RefPsLepTypes { get; set; }
        public virtual DbSet<RefPSProgramLevel> RefPSProgramLevels { get; set; }
        public virtual DbSet<RefPsStudentLevel> RefPsStudentLevels { get; set; }
        public virtual DbSet<RefPublicSchoolChoiceStatu> RefPublicSchoolChoiceStatus { get; set; }
        public virtual DbSet<RefPublicSchoolResidence> RefPublicSchoolResidences { get; set; }
        public virtual DbSet<RefPurposeOfMonitoringVisit> RefPurposeOfMonitoringVisits { get; set; }
        public virtual DbSet<RefQrisParticipation> RefQrisParticipations { get; set; }
        public virtual DbSet<RefRace> RefRaces { get; set; }
        public virtual DbSet<RefReapAlternativeFundingStatu> RefReapAlternativeFundingStatus { get; set; }
        public virtual DbSet<RefReasonDelayTransitionConf> RefReasonDelayTransitionConfs { get; set; }
        public virtual DbSet<RefReconstitutedStatu> RefReconstitutedStatus { get; set; }
        public virtual DbSet<RefRecordStatusCreatorEntity> RefRecordStatusCreatorEntities { get; set; }
        public virtual DbSet<RefRecordStatusType> RefRecordStatusTypes { get; set; }
        public virtual DbSet<RefReferralOutcome> RefReferralOutcomes { get; set; }
        public virtual DbSet<RefReimbursementType> RefReimbursementTypes { get; set; }
        public virtual DbSet<RefRestructuringAction> RefRestructuringActions { get; set; }
        public virtual DbSet<RefRlisProgramUse> RefRlisProgramUses { get; set; }
        public virtual DbSet<RefRole> RefRoles { get; set; }
        public virtual DbSet<RefRoleStatus> RefRoleStatus { get; set; }
        public virtual DbSet<RefRoleStatusType> RefRoleStatusTypes { get; set; }
        public virtual DbSet<RefSCEDCourseLevel> RefSCEDCourseLevels { get; set; }
        public virtual DbSet<RefSCEDCourseSubjectArea> RefSCEDCourseSubjectAreas { get; set; }
        public virtual DbSet<RefScheduledWellChildScreening> RefScheduledWellChildScreenings { get; set; }
        public virtual DbSet<RefSchoolDangerousStatu> RefSchoolDangerousStatus { get; set; }
        public virtual DbSet<RefSchoolFoodServiceProgram> RefSchoolFoodServicePrograms { get; set; }
        public virtual DbSet<RefSchoolImprovementFund> RefSchoolImprovementFunds { get; set; }
        public virtual DbSet<RefSchoolImprovementStatu> RefSchoolImprovementStatus { get; set; }
        public virtual DbSet<RefSchoolLevel> RefSchoolLevels { get; set; }
        public virtual DbSet<RefSchoolType> RefSchoolTypes { get; set; }
        public virtual DbSet<RefScoreMetricType> RefScoreMetricTypes { get; set; }
        public virtual DbSet<RefServiceFrequency> RefServiceFrequencies { get; set; }
        public virtual DbSet<RefServiceOption> RefServiceOptions { get; set; }
        public virtual DbSet<RefService> RefServices { get; set; }
        public virtual DbSet<RefSessionType> RefSessionTypes { get; set; }
        public virtual DbSet<RefSex> RefSexes { get; set; }
        public virtual DbSet<RefSigInterventionType> RefSigInterventionTypes { get; set; }
        public virtual DbSet<RefSingleSexClassStatu> RefSingleSexClassStatus { get; set; }
        public virtual DbSet<RefSpaceUseType> RefSpaceUseTypes { get; set; }
        public virtual DbSet<RefSpecialEducationAgeGroupTaught> RefSpecialEducationAgeGroupTaughts { get; set; }
        public virtual DbSet<RefSpecialEducationExitReason> RefSpecialEducationExitReasons { get; set; }
        public virtual DbSet<RefSpecialEducationStaffCategory> RefSpecialEducationStaffCategories { get; set; }
        public virtual DbSet<RefStaffCompensationSourceType> RefStaffCompensationSourceTypes { get; set; }
        public virtual DbSet<RefStaffPerformanceLevel> RefStaffPerformanceLevels { get; set; }
        public virtual DbSet<RefStandardizedAdmissionTest> RefStandardizedAdmissionTests { get; set; }
        public virtual DbSet<RefState> RefStates { get; set; }
        public virtual DbSet<RefStateANSICode> RefStateANSICodes { get; set; }
        public virtual DbSet<RefStatePovertyDesignation> RefStatePovertyDesignations { get; set; }
        public virtual DbSet<RefStudentEnrollmentAccessType> RefStudentEnrollmentAccessTypes { get; set; }
        public virtual DbSet<RefStudentSchoolAffiliationStateDefinedStatu> RefStudentSchoolAffiliationStateDefinedStatus { get; set; }
        public virtual DbSet<RefStudentSupportServiceType> RefStudentSupportServiceTypes { get; set; }
        public virtual DbSet<RefSupervisedClinicalExperience> RefSupervisedClinicalExperiences { get; set; }
        public virtual DbSet<RefTargetedSupport> RefTargetedSupports { get; set; }
        public virtual DbSet<RefTargetedSupportAndImprovementStatu> RefTargetedSupportAndImprovementStatus { get; set; }
        public virtual DbSet<RefTeacherEducationCredentialExam> RefTeacherEducationCredentialExams { get; set; }
        public virtual DbSet<RefTeacherEducationExamScoreType> RefTeacherEducationExamScoreTypes { get; set; }
        public virtual DbSet<RefTeacherEducationTestCompany> RefTeacherEducationTestCompanies { get; set; }
        public virtual DbSet<RefTeacherPrepCompleterStatu> RefTeacherPrepCompleterStatus { get; set; }
        public virtual DbSet<RefTeacherPrepEnrollmentStatu> RefTeacherPrepEnrollmentStatus { get; set; }
        public virtual DbSet<RefTeachingAssignmentRole> RefTeachingAssignmentRoles { get; set; }
        public virtual DbSet<RefTeachingCredentialBasi> RefTeachingCredentialBasis { get; set; }
        public virtual DbSet<RefTeachingCredentialType> RefTeachingCredentialTypes { get; set; }
        public virtual DbSet<RefTechnicalAssistanceDeliveryType> RefTechnicalAssistanceDeliveryTypes { get; set; }
        public virtual DbSet<RefTechnicalAssistanceType> RefTechnicalAssistanceTypes { get; set; }
        public virtual DbSet<RefTechnologyLiteracyStatu> RefTechnologyLiteracyStatus { get; set; }
        public virtual DbSet<RefTelephoneNumberListedStatu> RefTelephoneNumberListedStatus { get; set; }
        public virtual DbSet<RefTelephoneNumberType> RefTelephoneNumberTypes { get; set; }
        public virtual DbSet<RefTenureSystem> RefTenureSystems { get; set; }
        public virtual DbSet<RefTextComplexitySystem> RefTextComplexitySystems { get; set; }
        public virtual DbSet<RefTimeForCompletionUnit> RefTimeForCompletionUnits { get; set; }
        public virtual DbSet<RefTitleIIIAccountability> RefTitleIIIAccountabilities { get; set; }
        public virtual DbSet<RefTitleIIILanguageInstructionProgramType> RefTitleIIILanguageInstructionProgramTypes { get; set; }
        public virtual DbSet<RefTitleIIIProfessionalDevelopmentType> RefTitleIIIProfessionalDevelopmentTypes { get; set; }
        public virtual DbSet<RefTitleIIndicator> RefTitleIIndicators { get; set; }
        public virtual DbSet<RefTitleIInstructionalService> RefTitleIInstructionalServices { get; set; }
        public virtual DbSet<RefTitleIProgramStaffCategory> RefTitleIProgramStaffCategories { get; set; }
        public virtual DbSet<RefTitleIProgramType> RefTitleIProgramTypes { get; set; }
        public virtual DbSet<RefTitleISchoolStatu> RefTitleISchoolStatus { get; set; }
        public virtual DbSet<RefTransferOutIndicator> RefTransferOutIndicators { get; set; }
        public virtual DbSet<RefTransferReady> RefTransferReadies { get; set; }
        public virtual DbSet<RefTribalAffiliation> RefTribalAffiliations { get; set; }
        public virtual DbSet<RefTrimesterWhenPrenatalCareBegan> RefTrimesterWhenPrenatalCareBegans { get; set; }
        public virtual DbSet<RefTuitionResidencyType> RefTuitionResidencyTypes { get; set; }
        public virtual DbSet<RefTuitionUnit> RefTuitionUnits { get; set; }
        public virtual DbSet<RefUSCitizenshipStatu> RefUSCitizenshipStatus { get; set; }
        public virtual DbSet<RefVirtualSchoolStatu> RefVirtualSchoolStatus { get; set; }
        public virtual DbSet<RefVisaType> RefVisaTypes { get; set; }
        public virtual DbSet<RefVisionScreeningStatu> RefVisionScreeningStatus { get; set; }
        public virtual DbSet<RefWageCollectionMethod> RefWageCollectionMethods { get; set; }
        public virtual DbSet<RefWageVerification> RefWageVerifications { get; set; }
        public virtual DbSet<RefWeaponType> RefWeaponTypes { get; set; }
        public virtual DbSet<RefWfProgramParticipation> RefWfProgramParticipations { get; set; }
        public virtual DbSet<RefWIOABarrierstoEmployment> RefWIOABarrierstoEmployments { get; set; }
        public virtual DbSet<RefWorkbasedLearningOpportunityType> RefWorkbasedLearningOpportunityTypes { get; set; }
        public virtual DbSet<RequiredImmunization> RequiredImmunizations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleAttendance> RoleAttendances { get; set; }
        public virtual DbSet<RoleAttendanceEvent> RoleAttendanceEvents { get; set; }
        public virtual DbSet<RoleStatus> RoleStatus { get; set; }
        public virtual DbSet<Rubric> Rubrics { get; set; }
        public virtual DbSet<RubricCriterion> RubricCriterions { get; set; }
        public virtual DbSet<RubricCriterionLevel> RubricCriterionLevels { get; set; }
        public virtual DbSet<ServiceFrequency> ServiceFrequencies { get; set; }
        public virtual DbSet<ServicePlan> ServicePlans { get; set; }
        public virtual DbSet<ServiceProvided> ServiceProvideds { get; set; }
        public virtual DbSet<ServiceProvider> ServiceProviders { get; set; }
        public virtual DbSet<ServicesReceived> ServicesReceiveds { get; set; }
        public virtual DbSet<ServiceStaff> ServiceStaffs { get; set; }
        public virtual DbSet<StaffCompensation> StaffCompensations { get; set; }
        public virtual DbSet<StaffCredential> StaffCredentials { get; set; }
        public virtual DbSet<StaffEmployment> StaffEmployments { get; set; }
        public virtual DbSet<StaffEvaluation> StaffEvaluations { get; set; }
        public virtual DbSet<StaffEvaluationPart> StaffEvaluationParts { get; set; }
        public virtual DbSet<StaffExperience> StaffExperiences { get; set; }
        public virtual DbSet<StaffProfessionalDevelopmentActivity> StaffProfessionalDevelopmentActivities { get; set; }
        public virtual DbSet<StaffTechnicalAssistance> StaffTechnicalAssistances { get; set; }
        public virtual DbSet<TeacherEducationCredentialExam> TeacherEducationCredentialExams { get; set; }
        public virtual DbSet<TeacherStudentDataLinkExclusion> TeacherStudentDataLinkExclusions { get; set; }
        public virtual DbSet<WorkforceEmploymentQuarterlyData> WorkforceEmploymentQuarterlyDatas { get; set; }
        public virtual DbSet<WorkforceProgramParticipantCohort> WorkforceProgramParticipantCohorts { get; set; }
        public virtual DbSet<WorkforceProgramParticipation> WorkforceProgramParticipations { get; set; }
        public virtual DbSet<C_CEDStoNDSMapping> C_CEDStoNDSMapping { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_CEDSElements>()
                .Property(e => e.GlobalID)
                .IsUnicode(false);

            modelBuilder.Entity<C_CEDSElements>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<C_CEDSElements>()
                .Property(e => e.AltName)
                .IsUnicode(false);

            modelBuilder.Entity<C_CEDSElements>()
                .Property(e => e.Definition)
                .IsUnicode(false);

            modelBuilder.Entity<C_CEDSElements>()
                .Property(e => e.Format)
                .IsUnicode(false);

            modelBuilder.Entity<C_CEDSElements>()
                .Property(e => e.UsageNotes)
                .IsUnicode(false);

            modelBuilder.Entity<C_CEDSElements>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<C_CEDSElements>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<C_CEDSElements>()
                .Property(e => e.ChangedInThisVersionInd)
                .IsUnicode(false);

            modelBuilder.Entity<C_CEDSElements>()
                .Property(e => e.ChangeNotes)
                .IsUnicode(false);

            modelBuilder.Entity<AeStaff>()
                .Property(e => e.YearsOfPriorAeTeachingExperience)
                .HasPrecision(4, 2);

            modelBuilder.Entity<AeStudentAcademicRecord>()
                .Property(e => e.DiplomaOrCredentialAwardDate)
                .IsFixedLength();

            modelBuilder.Entity<AeStudentEmployment>()
                .Property(e => e.EmploymentNaicsCode)
                .IsFixedLength();

            modelBuilder.Entity<ApipInteraction>()
                .Property(e => e.APIPInteractionSequenceNumber)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Assessment>()
                .HasMany(e => e.Assessment_AssessmentAdministration)
                .WithRequired(e => e.Assessment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Assessment>()
                .HasMany(e => e.AssessmentELDevelopmentalDomains)
                .WithRequired(e => e.Assessment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Assessment>()
                .HasMany(e => e.AssessmentLevelsForWhichDesigneds)
                .WithRequired(e => e.Assessment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Assessment>()
                .HasMany(e => e.AssessmentForms)
                .WithRequired(e => e.Assessment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Assessment>()
                .HasMany(e => e.AssessmentLanguages)
                .WithRequired(e => e.Assessment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Assessment>()
                .HasMany(e => e.IndividualizedProgramAssessments)
                .WithRequired(e => e.Assessment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentAccommodation>()
                .HasMany(e => e.AssessmentParticipantSession_Accommodation)
                .WithRequired(e => e.AssessmentAccommodation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentAccommodation>()
                .HasMany(e => e.AssessmentRegistration_Accommodation)
                .WithRequired(e => e.AssessmentAccommodation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentAccommodation>()
                .HasMany(e => e.IndividualizedProgramAssessmentAccommodations)
                .WithRequired(e => e.AssessmentAccommodation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentAdministration>()
                .HasMany(e => e.Assessment_AssessmentAdministration)
                .WithRequired(e => e.AssessmentAdministration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentAdministration>()
                .HasMany(e => e.AssessmentAdministration_Organization)
                .WithRequired(e => e.AssessmentAdministration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentAsset>()
                .HasMany(e => e.AssessmentForm_AssessmentAsset)
                .WithRequired(e => e.AssessmentAsset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentAsset>()
                .HasMany(e => e.AssessmentFormSection_AssessmentAsset)
                .WithRequired(e => e.AssessmentAsset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentForm>()
                .HasMany(e => e.AssessmentForm_AssessmentAsset)
                .WithRequired(e => e.AssessmentForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentForm>()
                .HasMany(e => e.AssessmentForm_AssessmentFormSection)
                .WithRequired(e => e.AssessmentForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentForm>()
                .HasMany(e => e.AssessmentRegistrations)
                .WithRequired(e => e.AssessmentForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentFormSection>()
                .HasMany(e => e.AssessmentForm_AssessmentFormSection)
                .WithRequired(e => e.AssessmentFormSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentFormSection>()
                .HasMany(e => e.AssessmentFormSection_AssessmentAsset)
                .WithRequired(e => e.AssessmentFormSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentFormSection>()
                .HasMany(e => e.AssessmentFormSection_AssessmentItem)
                .WithRequired(e => e.AssessmentFormSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentFormSection>()
                .HasMany(e => e.AssessmentFormSection1)
                .WithOptional(e => e.AssessmentFormSection2)
                .HasForeignKey(e => e.ChildOf_FormSectionId);

            modelBuilder.Entity<AssessmentItem>()
                .Property(e => e.Difficulty)
                .HasPrecision(5, 2);

            modelBuilder.Entity<AssessmentItem>()
                .HasMany(e => e.AssessmentFormSection_AssessmentItem)
                .WithRequired(e => e.AssessmentItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentItem>()
                .HasMany(e => e.AssessmentItemApips)
                .WithRequired(e => e.AssessmentItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentItem>()
                .HasMany(e => e.AssessmentItemPossibleResponses)
                .WithRequired(e => e.AssessmentItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentItem>()
                .HasMany(e => e.AssessmentItemResponses)
                .WithRequired(e => e.AssessmentItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentItem>()
                .HasMany(e => e.AssessmentItemResponseTheories)
                .WithRequired(e => e.AssessmentItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentItem>()
                .HasMany(e => e.AssessmentSubtest_AssessmentItem)
                .WithRequired(e => e.AssessmentItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentItem>()
                .HasMany(e => e.AssessmentItemCharacteristics)
                .WithRequired(e => e.AssessmentItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentItemApip>()
                .HasMany(e => e.ApipInteractions)
                .WithRequired(e => e.AssessmentItemApip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentItemApip>()
                .HasMany(e => e.AssessmentItemApipDescriptions)
                .WithRequired(e => e.AssessmentItemApip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentItemResponse>()
                .HasMany(e => e.AssessmentItemRubricCriterionResults)
                .WithRequired(e => e.AssessmentItemResponse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentNeedApipControl>()
                .Property(e => e.LineReaderHighlightColor)
                .IsFixedLength();

            modelBuilder.Entity<AssessmentNeedApipControl>()
                .Property(e => e.OverlayColor)
                .IsFixedLength();

            modelBuilder.Entity<AssessmentNeedApipControl>()
                .Property(e => e.BackgroundColor)
                .IsFixedLength();

            modelBuilder.Entity<AssessmentNeedBraille>()
                .Property(e => e.BrailleDotPressure)
                .HasPrecision(10, 4);

            modelBuilder.Entity<AssessmentNeedScreenEnhancement>()
                .Property(e => e.Magnification)
                .HasPrecision(10, 4);

            modelBuilder.Entity<AssessmentNeedScreenEnhancement>()
                .Property(e => e.ForegroundColor)
                .IsFixedLength();

            modelBuilder.Entity<AssessmentParticipantSession>()
                .HasMany(e => e.AssessmentItemResponses)
                .WithRequired(e => e.AssessmentParticipantSession)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentParticipantSession>()
                .HasMany(e => e.AssessmentParticipantSession_Accommodation)
                .WithRequired(e => e.AssessmentParticipantSession)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentPerformanceLevel>()
                .HasMany(e => e.AssessmentResult_PerformanceLevel)
                .WithRequired(e => e.AssessmentPerformanceLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentPersonalNeedScreenReader>()
                .Property(e => e.Pitch)
                .HasPrecision(10, 4);

            modelBuilder.Entity<AssessmentPersonalNeedScreenReader>()
                .Property(e => e.Volume)
                .HasPrecision(10, 4);

            modelBuilder.Entity<AssessmentPersonalNeedsProfile>()
                .HasMany(e => e.AssessmentPersonalNeedsProfileScreenEnhancements)
                .WithRequired(e => e.AssessmentPersonalNeedsProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentPersonalNeedsProfile>()
                .HasMany(e => e.AssessmentPersonalNeedsProfileContents)
                .WithRequired(e => e.AssessmentPersonalNeedsProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentPersonalNeedsProfile>()
                .HasMany(e => e.AssessmentPersonalNeedsProfileControls)
                .WithRequired(e => e.AssessmentPersonalNeedsProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentPersonalNeedsProfile>()
                .HasMany(e => e.AssessmentPersonalNeedsProfileDisplays)
                .WithRequired(e => e.AssessmentPersonalNeedsProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentPersonalNeedsProfile>()
                .HasMany(e => e.Person_AssessmentPersonalNeedsProfile)
                .WithRequired(e => e.AssessmentPersonalNeedsProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentPersonalNeedsProfileContent>()
                .HasMany(e => e.AssessmentNeedApipContents)
                .WithRequired(e => e.AssessmentPersonalNeedsProfileContent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentPersonalNeedsProfileContent>()
                .HasMany(e => e.AssessmentPersonalNeedLanguageLearners)
                .WithRequired(e => e.AssessmentPersonalNeedsProfileContent)
                .HasForeignKey(e => e.AssessmentNeedsProfileContentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentPersonalNeedsProfileControl>()
                .HasMany(e => e.AssessmentNeedApipControls)
                .WithRequired(e => e.AssessmentPersonalNeedsProfileControl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentPersonalNeedsProfileDisplay>()
                .HasMany(e => e.AssessmentNeedApipDisplays)
                .WithRequired(e => e.AssessmentPersonalNeedsProfileDisplay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentPersonalNeedsProfileDisplay>()
                .HasMany(e => e.AssessmentNeedScreenEnhancements)
                .WithRequired(e => e.AssessmentPersonalNeedsProfileDisplay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentPersonalNeedsProfileDisplay>()
                .HasMany(e => e.AssessmentPersonalNeedScreenReaders)
                .WithRequired(e => e.AssessmentPersonalNeedsProfileDisplay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentRegistration>()
                .HasMany(e => e.AssessmentRegistration_Accommodation)
                .WithRequired(e => e.AssessmentRegistration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentRegistration>()
                .HasMany(e => e.AssessmentResults)
                .WithRequired(e => e.AssessmentRegistration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentResult>()
                .Property(e => e.AssessmentResultScoreStandardError)
                .HasPrecision(9, 2);

            modelBuilder.Entity<AssessmentResult>()
                .HasMany(e => e.AssessmentResult_PerformanceLevel)
                .WithRequired(e => e.AssessmentResult)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentResult>()
                .HasMany(e => e.AssessmentResultRubricCriterionResults)
                .WithRequired(e => e.AssessmentResult)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentSession>()
                .HasMany(e => e.AssessmentParticipantSessions)
                .WithRequired(e => e.AssessmentSession)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentSubtest>()
                .HasMany(e => e.AssessmentResults)
                .WithRequired(e => e.AssessmentSubtest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentSubtest>()
                .HasMany(e => e.AssessmentSubtestELDevelopmentalDomains)
                .WithRequired(e => e.AssessmentSubtest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentSubtest>()
                .HasMany(e => e.AssessmentSubtest1)
                .WithOptional(e => e.AssessmentSubtest2)
                .HasForeignKey(e => e.ChildOf_AssessmentSubtestId);

            modelBuilder.Entity<AssessmentSubtest>()
                .HasMany(e => e.AssessmentSubtest_CompetencyDefinition)
                .WithRequired(e => e.AssessmentSubtest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentSubtest>()
                .HasMany(e => e.AssessmentSubtest_AssessmentItem)
                .WithRequired(e => e.AssessmentSubtest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentSubtest>()
                .HasMany(e => e.AssessmentSubtestLevelsForWhichDesigneds)
                .WithRequired(e => e.AssessmentSubtest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssessmentSubtest_AssessmentItem>()
                .Property(e => e.ItemWeightCorrect)
                .HasPrecision(3, 2);

            modelBuilder.Entity<AssessmentSubtest_AssessmentItem>()
                .Property(e => e.ItemWeightIncorrect)
                .HasPrecision(3, 2);

            modelBuilder.Entity<AssessmentSubtest_AssessmentItem>()
                .Property(e => e.ItemWeightNotAttempted)
                .HasPrecision(3, 2);

            modelBuilder.Entity<AuthorizationDocument>()
                .HasMany(e => e.IEPAuthorizations)
                .WithRequired(e => e.AuthorizationDocument)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BuildingSpace>()
                .HasMany(e => e.BuildingSpaceUtilizations)
                .WithRequired(e => e.BuildingSpace)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BuildingSpaceUtilization>()
                .Property(e => e.BuildingSpaceUtilizationArea)
                .HasPrecision(9, 2);

            modelBuilder.Entity<BuildingSystemComponent>()
                .Property(e => e.InstallationDate)
                .IsFixedLength();

            modelBuilder.Entity<BuildingSystemComponent>()
                .Property(e => e.LifecycleCost)
                .HasPrecision(9, 2);

            modelBuilder.Entity<BuildingSystemComponent>()
                .HasMany(e => e.BuildingSystemCategories)
                .WithRequired(e => e.BuildingSystemComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BuildingSystemComponent>()
                .HasMany(e => e.BuildingSystemComponentServices)
                .WithRequired(e => e.BuildingSystemComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Classroom>()
                .HasMany(e => e.CourseSectionLocations)
                .WithRequired(e => e.Classroom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetencyDefAssociation>()
                .Property(e => e.Weight)
                .HasPrecision(9, 3);

            modelBuilder.Entity<CompetencyDefinition>()
                .Property(e => e.TextComplexityMinimumValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CompetencyDefinition>()
                .Property(e => e.TextComplexityMaximumValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CompetencyDefinition>()
                .HasMany(e => e.AssessmentSubtest_CompetencyDefinition)
                .WithRequired(e => e.CompetencyDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetencyDefinition>()
                .HasMany(e => e.CompetencyDefAssociations)
                .WithRequired(e => e.CompetencyDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetencyDefinition>()
                .HasMany(e => e.CompetencyDefEducationLevels)
                .WithRequired(e => e.CompetencyDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetencyDefinition>()
                .HasMany(e => e.CompetencyDefinition1)
                .WithOptional(e => e.CompetencyDefinition2)
                .HasForeignKey(e => e.ChildOf_CompetencyDefinitionId);

            modelBuilder.Entity<CompetencyDefinition>()
                .HasMany(e => e.CompetencyDefinition_CompetencySet)
                .WithRequired(e => e.CompetencyDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetencyFramework>()
                .HasMany(e => e.CompetencyDefinitions)
                .WithRequired(e => e.CompetencyFramework)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetencySet>()
                .HasMany(e => e.CompetencyDefinition_CompetencySet)
                .WithRequired(e => e.CompetencySet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetencySet>()
                .HasMany(e => e.CompetencySet1)
                .WithOptional(e => e.CompetencySet2)
                .HasForeignKey(e => e.ChildOf_CompetencySet);

            modelBuilder.Entity<CompetencySet>()
                .HasMany(e => e.CompetencySet_Rubric)
                .WithRequired(e => e.CompetencySet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetencySet>()
                .HasMany(e => e.CompetencySet_RubricCriterion)
                .WithRequired(e => e.CompetencySet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.CreditValue)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.CourseSections)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.CredentialCriteriaCourses)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.CteCourses)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.K12Course)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.PsCourses)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CourseSection>()
                .Property(e => e.AvailableCarnegieUnitCredit)
                .HasPrecision(9, 2);

            modelBuilder.Entity<CourseSection>()
                .Property(e => e.TimeRequiredForCompletion)
                .HasPrecision(9, 0);

            modelBuilder.Entity<CourseSection>()
                .HasMany(e => e.CourseSectionLevels)
                .WithRequired(e => e.CourseSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CourseSection>()
                .HasMany(e => e.CourseSectionLocations)
                .WithRequired(e => e.CourseSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CourseSection>()
                .HasMany(e => e.CourseSectionSchedules)
                .WithRequired(e => e.CourseSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CourseSection>()
                .HasMany(e => e.PsSections)
                .WithRequired(e => e.CourseSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CredentialAward>()
                .HasMany(e => e.CredentialAwardCredits)
                .WithRequired(e => e.CredentialAward)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CredentialAward>()
                .HasMany(e => e.CredentialAwardEvidences)
                .WithRequired(e => e.CredentialAward)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CredentialDefAgent>()
                .HasMany(e => e.CredentialDefAgentCredentials)
                .WithRequired(e => e.CredentialDefAgent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CredentialDefCriteria>()
                .Property(e => e.EstimatedDuration)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CredentialDefCriteria>()
                .Property(e => e.MaximumDuration)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CredentialDefCriteria>()
                .Property(e => e.MinimumDuration)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CredentialDefCriteria>()
                .HasMany(e => e.CredentialCriteriaCourses)
                .WithRequired(e => e.CredentialDefCriteria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CredentialDefinition>()
                .Property(e => e.Version)
                .HasPrecision(9, 2);

            modelBuilder.Entity<CredentialDefinition>()
                .HasMany(e => e.CredentialAwards)
                .WithRequired(e => e.CredentialDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CredentialDefinition>()
                .HasMany(e => e.CredentialDefAgentCredentials)
                .WithRequired(e => e.CredentialDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CredentialDefinition>()
                .HasMany(e => e.CredentialDefCategories)
                .WithRequired(e => e.CredentialDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CredentialDefinition>()
                .HasMany(e => e.CredentialDefCriterias)
                .WithRequired(e => e.CredentialDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CredentialDefinition>()
                .HasMany(e => e.CredentialDefIdentifiers)
                .WithRequired(e => e.CredentialDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CredentialDefinition>()
                .HasMany(e => e.CredentialOffereds)
                .WithRequired(e => e.CredentialDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CredentialIssuer>()
                .HasMany(e => e.CredentialAwards)
                .WithRequired(e => e.CredentialIssuer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CredentialIssuer>()
                .HasMany(e => e.CredentialOffereds)
                .WithRequired(e => e.CredentialIssuer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CteCourse>()
                .Property(e => e.AvailableCarnegieUnitCredit)
                .HasPrecision(9, 2);

            modelBuilder.Entity<CteCourse>()
                .Property(e => e.SCEDCourseCode)
                .IsFixedLength();

            modelBuilder.Entity<CteStudentAcademicRecord>()
                .Property(e => e.CreditsAttemptedCumulative)
                .HasPrecision(9, 2);

            modelBuilder.Entity<CteStudentAcademicRecord>()
                .Property(e => e.CreditsEarnedCumulative)
                .HasPrecision(9, 2);

            modelBuilder.Entity<CteStudentAcademicRecord>()
                .Property(e => e.DiplomaOrCredentialAwardDate)
                .IsFixedLength();

            modelBuilder.Entity<ELClassSection>()
                .Property(e => e.HoursAvailablePerDay)
                .HasPrecision(4, 2);

            modelBuilder.Entity<ELClassSection>()
                .HasMany(e => e.ELClassSectionServices)
                .WithRequired(e => e.ELClassSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ELEnrollment>()
                .Property(e => e.NumberOfDaysInAttendance)
                .HasPrecision(8, 2);

            modelBuilder.Entity<EligibilityEvaluation>()
                .HasMany(e => e.IDEAEligibilityEvaluationCategories)
                .WithRequired(e => e.EligibilityEvaluation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EligibilityEvaluation>()
                .HasMany(e => e.IndividualizedProgramEligibilityEvaluations)
                .WithRequired(e => e.EligibilityEvaluation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ELOrganizationAvailability>()
                .Property(e => e.HoursAvailablePerDay)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ELStaff>()
                .HasMany(e => e.ELStaffEducations)
                .WithRequired(e => e.ELStaff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ELStaffEducation>()
                .Property(e => e.TotalCollegeCreditsEarned)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ELStaffEducation>()
                .Property(e => e.TotalApprovedECCreditsEarned)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ELStaffEducation>()
                .Property(e => e.SchoolAgeEducationPSCredits)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ELStaffEmployment>()
                .Property(e => e.HoursWorkedPerWeek)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ELStaffEmployment>()
                .Property(e => e.HourlyWage)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.BuildingSpaces)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.BuildingSystemComponents)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityAudits)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityDesigns)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityEnergies)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityFinances)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityHazards)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityJointUses)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityLeases)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityLocations)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityManagements)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityMandates)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityMortgages)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityRelationships)
                .WithRequired(e => e.Facility)
                .HasForeignKey(e => e.FacilityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityRelationships1)
                .WithRequired(e => e.Facility1)
                .HasForeignKey(e => e.Parent_FacilityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilitySites)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityUtilizations)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FacilityCompliance>()
                .Property(e => e.FacilityEstimatedCostToEliminateDeferredMaint)
                .HasPrecision(9, 2);

            modelBuilder.Entity<FacilityDesign>()
                .HasMany(e => e.FacilityDesignConstructions)
                .WithRequired(e => e.FacilityDesign)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FacilityDesign>()
                .HasMany(e => e.FacilitySchoolDesigns)
                .WithRequired(e => e.FacilityDesign)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FacilityDesignConstruction>()
                .Property(e => e.FacilityConstructionYear)
                .IsFixedLength();

            modelBuilder.Entity<FacilityDesignConstruction>()
                .Property(e => e.FacilityAdditionYear)
                .IsFixedLength();

            modelBuilder.Entity<FacilityFinance>()
                .Property(e => e.FacilityReplacementValue)
                .HasPrecision(9, 2);

            modelBuilder.Entity<FacilityFinance>()
                .Property(e => e.IndebtednessAmountAllowed)
                .HasPrecision(9, 2);

            modelBuilder.Entity<FacilityFinance>()
                .Property(e => e.InsuranceDeductible)
                .HasPrecision(9, 2);

            modelBuilder.Entity<FacilityFinance>()
                .Property(e => e.PublicEducationMillRate)
                .HasPrecision(9, 8);

            modelBuilder.Entity<FacilityLease>()
                .Property(e => e.FacilityLeaseAmount)
                .HasPrecision(9, 2);

            modelBuilder.Entity<FacilityManagement>()
                .HasMany(e => e.FacilityManagementPlans)
                .WithRequired(e => e.FacilityManagement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FacilityMortgage>()
                .Property(e => e.FacilityMortgageInterestAmount)
                .HasPrecision(9, 2);

            modelBuilder.Entity<FacilityMortgage>()
                .Property(e => e.FacilityTotalAssessedValue)
                .HasPrecision(9, 2);

            modelBuilder.Entity<FacilityMortgage>()
                .HasMany(e => e.FacilityMortgageFees)
                .WithRequired(e => e.FacilityMortgage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FacilitySite>()
                .Property(e => e.FacilitySiteArea)
                .HasPrecision(9, 1);

            modelBuilder.Entity<FacilityUtilization>()
                .Property(e => e.BuildingNetAreaOfInstructionalSpace)
                .HasPrecision(9, 2);

            modelBuilder.Entity<FinancialAccount>()
                .Property(e => e.FinancialExpenditureProjectReportingCode)
                .HasPrecision(3, 0);

            modelBuilder.Entity<FinancialAccount>()
                .HasMany(e => e.OrganizationFinancials)
                .WithRequired(e => e.FinancialAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FinancialAidApplication>()
                .Property(e => e.FinancialAidYearDesignator)
                .IsFixedLength();

            modelBuilder.Entity<FinancialAidAward>()
                .Property(e => e.FinancialAidAwardAmount)
                .HasPrecision(9, 2);

            modelBuilder.Entity<FinancialAidAward>()
                .Property(e => e.FinancialAidYearDesignator)
                .IsFixedLength();

            modelBuilder.Entity<Goal>()
                .HasMany(e => e.GoalMeasurements)
                .WithRequired(e => e.Goal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Goal>()
                .HasMany(e => e.GoalPerformances)
                .WithRequired(e => e.Goal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Goal>()
                .HasMany(e => e.IndividualizedProgramGoals)
                .WithRequired(e => e.Goal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GoalMeasurement>()
                .HasMany(e => e.GoalMeasurementCriterions)
                .WithRequired(e => e.GoalMeasurement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GoalMeasurementCriterion>()
                .Property(e => e.AccuracyPercent)
                .HasPrecision(3, 2);

            modelBuilder.Entity<GoalPerformance>()
                .HasMany(e => e.IndividualizedProgramProgressGoals)
                .WithRequired(e => e.GoalPerformance)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IEPAuthorization>()
                .HasMany(e => e.IEPAuthorizationRejecteds)
                .WithRequired(e => e.IEPAuthorization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Incident>()
                .HasMany(e => e.IncidentPersons)
                .WithRequired(e => e.Incident)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgram>()
                .HasMany(e => e.IEPAuthorizations)
                .WithRequired(e => e.IndividualizedProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgram>()
                .HasMany(e => e.IEPPresentLevels)
                .WithRequired(e => e.IndividualizedProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgram>()
                .HasMany(e => e.IndividualizedProgramAccommodations)
                .WithRequired(e => e.IndividualizedProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgram>()
                .HasMany(e => e.IndividualizedProgramAmendments)
                .WithRequired(e => e.IndividualizedProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgram>()
                .HasMany(e => e.IndividualizedProgramAssessments)
                .WithRequired(e => e.IndividualizedProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgram>()
                .HasMany(e => e.IndividualizedProgramEligibilities)
                .WithRequired(e => e.IndividualizedProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgram>()
                .HasMany(e => e.IndividualizedProgramGoals)
                .WithRequired(e => e.IndividualizedProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgram>()
                .HasMany(e => e.IndividualizedProgramMeetings)
                .WithRequired(e => e.IndividualizedProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgram>()
                .HasMany(e => e.IndividualizedProgramProgressReports)
                .WithRequired(e => e.IndividualizedProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgram>()
                .HasMany(e => e.IndividualizedProgramProgressReportPlans)
                .WithRequired(e => e.IndividualizedProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgram>()
                .HasMany(e => e.IndividualizedProgramServicesReceiveds)
                .WithRequired(e => e.IndividualizedProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgramAccommodation>()
                .HasMany(e => e.IndividualizedProgramAccommodationSubjects)
                .WithRequired(e => e.IndividualizedProgramAccommodation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgramAssessment>()
                .HasMany(e => e.IndividualizedProgramAssessmentAccommodations)
                .WithRequired(e => e.IndividualizedProgramAssessment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgramEligibility>()
                .HasMany(e => e.IndividualizedProgramEligibilityEvaluations)
                .WithRequired(e => e.IndividualizedProgramEligibility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgramMeeting>()
                .HasMany(e => e.IndividualizedProgramMeetingAttendees)
                .WithRequired(e => e.IndividualizedProgramMeeting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgramProgressReport>()
                .HasMany(e => e.IndividualizedProgramProgressGoals)
                .WithRequired(e => e.IndividualizedProgramProgressReport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgramProgressReportPlan>()
                .HasMany(e => e.IndividualizedProgramProgressReports)
                .WithRequired(e => e.IndividualizedProgramProgressReportPlan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualizedProgramService>()
                .Property(e => e.PlannedServiceDuration)
                .HasPrecision(6, 2);

            modelBuilder.Entity<K12Course>()
                .Property(e => e.AvailableCarnegieUnitCredit)
                .HasPrecision(9, 2);

            modelBuilder.Entity<K12Course>()
                .Property(e => e.SCEDCourseCode)
                .IsFixedLength();

            modelBuilder.Entity<K12Course>()
                .Property(e => e.SCEDGradeSpan)
                .IsFixedLength();

            modelBuilder.Entity<K12Course>()
                .HasMany(e => e.K12StudentGraduationPlan)
                .WithRequired(e => e.K12Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12Lea>()
                .Property(e => e.SupervisoryUnionIdentificationNumber)
                .IsFixedLength();

            modelBuilder.Entity<K12Lea>()
                .HasMany(e => e.K12LeaFederalReporting)
                .WithRequired(e => e.K12Lea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12Lea>()
                .HasMany(e => e.K12LeaGradeLevelsApproved)
                .WithRequired(e => e.K12Lea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12Lea>()
                .HasMany(e => e.K12LeaGradeOffered)
                .WithRequired(e => e.K12Lea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12Lea>()
                .HasMany(e => e.K12LeaPreKEligibility)
                .WithRequired(e => e.K12Lea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12Lea>()
                .HasMany(e => e.K12LeaPreKEligibleAgesIDEA)
                .WithRequired(e => e.K12Lea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12Lea>()
                .HasMany(e => e.K12LeaSafeDrugFree)
                .WithRequired(e => e.K12Lea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12Lea>()
                .HasMany(e => e.K12LeaTitleIIIProfessionalDevelopment)
                .WithRequired(e => e.K12Lea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12Lea>()
                .HasMany(e => e.K12LeaTitleISupportService)
                .WithRequired(e => e.K12Lea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12LeaFederalFunds>()
                .Property(e => e.InnovativeProgramsFundsReceived)
                .HasPrecision(12, 2);

            modelBuilder.Entity<K12LeaFederalFunds>()
                .Property(e => e.InnovativeDollarsSpent)
                .HasPrecision(12, 2);

            modelBuilder.Entity<K12LeaFederalFunds>()
                .Property(e => e.InnovativeDollarsSpentOnStrategicPriorities)
                .HasPrecision(12, 2);

            modelBuilder.Entity<K12LeaFederalFunds>()
                .Property(e => e.PublicSchoolChoiceFundsSpent)
                .HasPrecision(12, 2);

            modelBuilder.Entity<K12LeaFederalFunds>()
                .Property(e => e.SesFundsSpent)
                .HasPrecision(12, 2);

            modelBuilder.Entity<K12LeaFederalFunds>()
                .Property(e => e.SesSchoolChoice20PercentObligation)
                .HasPrecision(12, 2);

            modelBuilder.Entity<K12LeaFederalFunds>()
                .Property(e => e.ParentalInvolvementReservationFunds)
                .HasPrecision(12, 2);

            modelBuilder.Entity<K12LeaFederalReporting>()
                .Property(e => e.StateAssessmentAdminFunding)
                .HasPrecision(5, 2);

            modelBuilder.Entity<K12LeaFederalReporting>()
                .Property(e => e.StateAssessStandardsFunding)
                .HasPrecision(5, 2);

            modelBuilder.Entity<K12School>()
                .HasMany(e => e.K12SchoolCorrectiveAction)
                .WithRequired(e => e.K12School)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12School>()
                .HasMany(e => e.K12SchoolGradeLevelsApproved)
                .WithRequired(e => e.K12School)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12School>()
                .HasMany(e => e.K12SchoolGradeOffered)
                .WithRequired(e => e.K12School)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12School>()
                .HasMany(e => e.K12SchoolImprovement)
                .WithRequired(e => e.K12School)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12School>()
                .HasMany(e => e.K12SchoolIndicatorStatus)
                .WithRequired(e => e.K12School)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12School>()
                .HasMany(e => e.K12SchoolStatus)
                .WithRequired(e => e.K12School)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12Sea>()
                .HasMany(e => e.K12SeaFederalFunds)
                .WithRequired(e => e.K12Sea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12SeaFederalFunds>()
                .Property(e => e.NumberOfDaysForTitleIIISubgrants)
                .HasPrecision(6, 2);

            modelBuilder.Entity<K12SeaFederalFunds>()
                .HasMany(e => e.K12SeaAlternateFundUse)
                .WithRequired(e => e.K12SeaFederalFunds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12StaffAssignment>()
                .Property(e => e.FullTimeEquivalency)
                .HasPrecision(5, 4);

            modelBuilder.Entity<K12StaffAssignment>()
                .Property(e => e.ContributionPercentage)
                .HasPrecision(5, 2);

            modelBuilder.Entity<K12StaffAssignment>()
                .HasMany(e => e.TeacherStudentDataLinkExclusions)
                .WithRequired(e => e.K12StaffAssignment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12StaffEmployment>()
                .Property(e => e.ContractDaysOfServicePerYear)
                .HasPrecision(5, 2);

            modelBuilder.Entity<K12StudentAcademicRecord>()
                .Property(e => e.CreditsAttemptedCumulative)
                .HasPrecision(9, 2);

            modelBuilder.Entity<K12StudentAcademicRecord>()
                .Property(e => e.CreditsEarnedCumulative)
                .HasPrecision(9, 2);

            modelBuilder.Entity<K12StudentAcademicRecord>()
                .Property(e => e.GradePointsEarnedCumulative)
                .HasPrecision(9, 2);

            modelBuilder.Entity<K12StudentAcademicRecord>()
                .Property(e => e.GradePointAverageCumulative)
                .HasPrecision(9, 4);

            modelBuilder.Entity<K12StudentActivity>()
                .Property(e => e.ActivityTimeInvolved)
                .HasPrecision(9, 2);

            modelBuilder.Entity<K12StudentCohort>()
                .Property(e => e.CohortYear)
                .IsFixedLength();

            modelBuilder.Entity<K12StudentCohort>()
                .Property(e => e.CohortGraduationYear)
                .IsFixedLength();

            modelBuilder.Entity<K12StudentCohort>()
                .Property(e => e.GraduationRateSurveyCohortYear)
                .IsFixedLength();

            modelBuilder.Entity<K12StudentCourseSection>()
                .Property(e => e.NumberOfCreditsAttempted)
                .HasPrecision(9, 2);

            modelBuilder.Entity<K12StudentCourseSection>()
                .Property(e => e.NumberOfCreditsEarned)
                .HasPrecision(9, 2);

            modelBuilder.Entity<K12StudentCourseSection>()
                .HasMany(e => e.K12StudentCourseSectionMark)
                .WithRequired(e => e.K12StudentCourseSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12StudentCourseSection>()
                .HasMany(e => e.TeacherStudentDataLinkExclusions)
                .WithRequired(e => e.K12StudentCourseSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K12StudentDiscipline>()
                .Property(e => e.DurationOfDisciplinaryAction)
                .HasPrecision(9, 2);

            modelBuilder.Entity<K12StudentEmployment>()
                .Property(e => e.EmploymentNaicsCode)
                .IsFixedLength();

            modelBuilder.Entity<K12StudentGraduationPlan>()
                .Property(e => e.CreditsRequired)
                .HasPrecision(9, 2);

            modelBuilder.Entity<K12StudentSession>()
                .Property(e => e.GradePointAverageGivenSession)
                .HasPrecision(9, 4);

            modelBuilder.Entity<LearnerActivity>()
                .Property(e => e.MaximumTimeAllowed)
                .HasPrecision(9, 0);

            modelBuilder.Entity<LearnerActivity>()
                .Property(e => e.MaximumAttemptsAllowed)
                .HasPrecision(9, 0);

            modelBuilder.Entity<LearnerActivity>()
                .Property(e => e.Weight)
                .HasPrecision(9, 2);

            modelBuilder.Entity<LearnerActivity>()
                .Property(e => e.PossiblePoints)
                .HasPrecision(9, 2);

            modelBuilder.Entity<LearnerActivity>()
                .HasMany(e => e.LearnerActivity_LearningResource)
                .WithRequired(e => e.LearnerActivity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LearningResource>()
                .Property(e => e.CopyrightYear)
                .IsFixedLength();

            modelBuilder.Entity<LearningResource>()
                .Property(e => e.TimeRequired)
                .HasPrecision(9, 2);

            modelBuilder.Entity<LearningResource>()
                .HasMany(e => e.LearnerActivity_LearningResource)
                .WithRequired(e => e.LearningResource)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LearningResource>()
                .HasMany(e => e.LearningResourceEducationLevels)
                .WithRequired(e => e.LearningResource)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LearningResource>()
                .HasMany(e => e.LearningResourceAdaptations)
                .WithRequired(e => e.LearningResource)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LearningResource>()
                .HasMany(e => e.LearningResourceMediaFeatures)
                .WithRequired(e => e.LearningResource)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LearningResource>()
                .HasMany(e => e.LearningResourcePeerRatings)
                .WithRequired(e => e.LearningResource)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LearningResource>()
                .HasMany(e => e.LearningResourcePhysicalMedias)
                .WithRequired(e => e.LearningResource)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LearningResourcePeerRating>()
                .Property(e => e.Value)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Classrooms)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.FacilityLocations)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.OrganizationLocations)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Activities)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.AeProviders)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.AssessmentAdministration_Organization)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.AssessmentRegistrations)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.OrganizationId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.AssessmentRegistrations1)
                .WithOptional(e => e.Organization1)
                .HasForeignKey(e => e.SchoolOrganizationId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.AssessmentRegistrations2)
                .WithOptional(e => e.Organization2)
                .HasForeignKey(e => e.LeaOrganizationId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.AssessmentSessions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.Lea_OrganizationId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.AssessmentSessions1)
                .WithOptional(e => e.Organization1)
                .HasForeignKey(e => e.School_OrganizationId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.AssessmentSessions2)
                .WithOptional(e => e.Organization2)
                .HasForeignKey(e => e.OrganizationId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.CredentialIssuers)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.EarlyChildhoodProgramTypeOffereds)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ELClassSections)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ELFacilityLicensings)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ELOrganizations)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ELOrganizationAvailabilities)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ELOrganizationFunds)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ELOrganizationMonitorings)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ELProgramLicensings)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ELQualityInitiatives)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ELQualityRatingImprovements)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ELServicePartners)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.K12ProgramOrService)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.K12School)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.K12TitleIIILanguageInstruction)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.LearnerActivities)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.SchoolOrganizationId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.LearnerActivities1)
                .WithOptional(e => e.Organization1)
                .HasForeignKey(e => e.LeaOrganizationId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationRelationships)
                .WithRequired(e => e.Organization)
                .HasForeignKey(e => e.Parent_OrganizationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationEmails)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationAccreditations)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationCalendars)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationCalendarCrisis)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationDetails)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationEmployeeBenefits)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationFederalAccountabilities)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationIdentifiers)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationImages)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationIndicators)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationLocations)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationOperationalStatus)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationPersonRoles)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationPolicies)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationPopulationServeds)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationProgramTypes)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationRelationships1)
                .WithRequired(e => e.Organization1)
                .HasForeignKey(e => e.OrganizationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationServices)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationTechnicalAssistances)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationTelephones)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.OrganizationWebsites)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Programs)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ProgramParticipationMigrants)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.DesignatedGraduationSchoolId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.PsPrograms)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RecordStatuses)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RecordStatusCreatorOrganizationId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RecordStatusHistories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RecordStatusCreatorOrganizationId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAbsentAttendanceCategories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAcademicAwardLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAcademicAwardPrerequisiteTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAcademicHonorTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAcademicRanks)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAcademicSubjects)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAcademicTermDesignators)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAccommodationsNeededTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAccommodationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAccreditationAgencies)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefActivityRecognitionTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefActivityTimeMeasurementTypes)
                .WithOptional(e => e.Organization).HasForeignKey<int?>(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAdditionalCreditTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAdditionalTargetedSupportAndImprovementStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAddressTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAdministrativeFundingControls)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAdmissionConsiderationLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAdmissionConsiderationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAdmittedStudents)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAdultEducationProgramExitReasons)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAdvancedPlacementCourseCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAeCertificationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAeFunctioningLevelAtIntakes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAeFunctioningLevelAtPosttests)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAeInstructionalProgramTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAePostsecondaryTransitionActions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAeSpecialProgramTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAeStaffClassifications)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAeStaffEmploymentStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAllergySeverities)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAllergyTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAlternateFundUses)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAlternativeSchoolFocus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAltRouteToCertificationOrLicensures)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAmaoAttainmentStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefApipInteractionTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentItemCharacteristicTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentItemResponseStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentAssetIdentifierTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentAssetTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentELDevelopmentalDomains)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentFormSectionIdentificationSystems)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentItemResponseScoreStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentItemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedAlternativeRepresentationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedBrailleGradeTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedBrailleMarkTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedBrailleStatusCellTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedHazardTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedIncreasedWhitespacingTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedLanguageLearnerTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedLinkIndicationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedMaskingTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedNumberOfBrailleDots)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedSigningTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedSpokenSourcePreferenceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedSupportTools)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedUsageTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentNeedUserSpokenPreferenceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentParticipationIndicators)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentPlatformTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentPurposes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentReasonNotCompletings)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentReasonNotTesteds)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentRegistrationCompletionStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentReportingMethods)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentResultDataTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentResultScoreTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentSessionSpecialCircumstanceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentSessionStaffRoleTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentSessionTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentPretestOutcomes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentTypeChildrenWithDisabilities)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAssessmentSubtestIdentifierTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEntityTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAttendanceEventTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAttendanceStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAuthorizerTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefAypStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBarrierToEducatingHomelesses)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBarrierToInternetAccessInResidences)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBillableBasisTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBlendedLearningModelTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBloomsTaxonomyDomains)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingAdministrativeSpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingAirDistributionSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingArtSpecialtySpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingAssemblySpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingBasicClassroomDesignTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingCareerTechEducationSpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingCharterSchoolRealtyAccessTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingCirculationSpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingCleaningStandardTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingCommMgmtComponentSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingCommunityUseSpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingCoolingGenerationSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingDesignTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingElectricalSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingEnergyConservationMeasureTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingEnergySourceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingEnvOrEnergyPerformanceRatingCats)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingFireProtectionSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingFoodServiceSpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingFullServiceKitchenTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingHeatingGenerationSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingHistoricStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingHVACSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingIndoorAthleticOrPhysEdSpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingInstructionalSpaceFactorTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingJointUseRationaleTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingJointUserTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingJointUseSchedulingTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingLibMediaCenterSpecialtySpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingMechanicalConveyingSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingMechanicalSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingOperationsOrMaintSpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingOutdoorAthleticOrPhysEdSpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingOutdoorOrNonathleticSpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingPerformingArtsSpecialtySpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingPlumbingSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingPrimaryUseTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingSchoolDesignTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingScienceSpecialtySpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingSecuritySystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingSiteUseRestrictionsTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingSpaceDesignTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingSpecEdSpecialtySpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingStudentSupportSpaceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingTechnologyWiringSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingUseTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefBuildingVerticalTransportationSystemTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCalendarEventTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCampusResidencyTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCampusStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCampusTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCareerClusters)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCareerEducationPlanTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCarnegieBasicClassifications)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCharterLeaStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCharterSchoolAuthorizerTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCharterSchoolManagementOrganizationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCharterSchoolTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefChildDevelopmentAssociateTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefChildDevelopmentalScreeningStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefChildOutcomesSummaryRatings)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCipCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCipUses)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCipVersions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefClassroomPositionTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCohortExclusions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCommunicationMethods)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCommunityBasedTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCompetencyDefAssociationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCompetencyDefNodeAccessibilityProfiles)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCompetencyDefTestabilityTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCompetencyFrameworkPublicationStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCompetencySetCompletionCriterias)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefComprehensiveAndTargetedSupports)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefComprehensiveSupports)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefComprehensiveSupportAndImprovementStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefContentStandardTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefContinuationOfServices)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefControlOfInstitutions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCoreKnowledgeAreas)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCorrectionalEducationFacilityTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCorrectiveActionTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCountries)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCounties)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseAcademicGradeStatusCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseApplicableEducationLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseCreditBasisTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseCreditLevelTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseCreditUnits)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseGpaApplicabilities)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseHonorsTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseInstructionMethods)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseInstructionSiteTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseInteractionModes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseLevelCharacteristics)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseLevelTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseRepeatCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseSectionAssessmentReportingMethods)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseSectionDeliveryModes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseSectionEnrollmentStatusTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseSectionEntryTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCourseSectionExitTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCredentialDefAgentRoleTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCredentialDefAssessMethodTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCredentialDefIntendedPurposeTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCredentialDefStatusTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCredentialDefVerificationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCredentialIdentifierSystems)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCredentialTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCreditHoursAppliedOtherPrograms)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCreditTypeEarneds)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCriticalTeacherShortageCandidates)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCTDLAudienceLevelTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCTDLOrganizationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCteGraduationRateInclusions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCteNonTraditionalGenderStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefCurriculumFrameworkTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDataCollectionStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDegreeOrCertificateTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDentalScreeningStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDentalInsuranceCoverageTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDependencyStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDevelopmentalEducationReferralStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDevelopmentalEducationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDevelopmentalEvaluationFindings)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDirectoryInformationBlockStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDisabilityTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDisabilityConditionStatusCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDisabilityConditionTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDisabilityDeterminationSourceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDisciplinaryActionTakens)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDisciplineLengthDifferenceReasons)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDisciplineMethodFirearms)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDisciplineMethodOfCwds)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDisciplineReasons)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDistanceEducationCourseEnrollments)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDoctoralExamsRequiredCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefDQPCategoriesOfLearnings)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEarlyChildhoodCredentials)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEarlyChildhoodProgramEnrollmentTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEarlyChildhoodServices)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEDFactsTeacherInexperiencedStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEducationLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEducationLevelTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefK12StaffClassification)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEducationVerificationMethods)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELEducationStaffClassifications)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefElementaryMiddleAdditionals)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELEmploymentSeparationReasons)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELFacilityLicensingStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELFederalFundingTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELGroupSizeStandardMets)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELLevelOfSpecializations)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELLocalRevenueSources)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELOtherFederalFundingSources)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELOutcomeMeasurementLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELProfessionalDevelopmentTopicAreas)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELProgramEligibilities)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELProgramEligibilityStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELProgramLicenseStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELServiceProfessionalStaffClassifications)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELServiceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELStateRevenueSources)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefELTrainerCoreKnowledgeAreas)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEmailTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEmergencyOrProvisionalCredentialStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEmployedAfterExits)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEmployedPriorToEnrollments)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEmployedWhileEnrolleds)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEmployeeBenefits)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEmploymentContractTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEmploymentSeparationReasons)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEmploymentSeparationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEmploymentStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEmploymentStatusWhileEnrolleds)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEndOfTermStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEnrollmentStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEntryTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefEnvironmentSettings)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefERAdministrativeDataSources)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefERSRuralUrbanContinuumCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefExitOrWithdrawalStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefExitOrWithdrawalTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilitiesMandateAuthorityTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilitiesMgmtEmergencyTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilitiesPlanTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityApplicableFederalMandateTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityAuditTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityCapitalProgramMgmtTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityComplianceAgencyTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityComplianceStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityConstructionDateTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityConstructionMaterialTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityFederalMandateInterestTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityFinancingFeeTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityFurnishingsTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityHazardousMaterialsOrCondTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityJointDevelopmentTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityLeaseAmountCategories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityLeaseTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityMaintStandardTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityMortgageInterestTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityMortgageTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityNaturallyOccurringHazardTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityOperationsMgmtTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilitySiteImprovementLocationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilitySiteOutdoorAreaTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityStandardTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityStateOrLocalMandateInterestTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilitySystemOrComponentConditions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityUtilityProviderTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFacilityUtilityTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFamilyIncomeSources)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFederalProgramFundingAllocationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialAccountCategories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialAccountFundClassifications)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialAccountProgramCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialAidApplicationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialAidAwardStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialAidAwardTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialAidVeteransBenefitStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialAidVeteransBenefitTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialAccountBalanceSheetCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialExpenditureFunctionCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialExpenditureLevelOfInstructionCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialExpenditureObjectCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFinancialAccountRevenueCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFirearmTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFoodServiceEligibilities)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdiction);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFoodServiceParticipations)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFrequencyOfServices)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFrequencyUnits)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefFullTimeStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefGoalMeasurementTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefGoalsForAttendingAdultEducations)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefGoalStatusTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefGpaWeightedIndicators)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefGradeLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefGradeLevelsApproveds)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefGradeLevelTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefGradePointAverageDomains)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefGraduateAssistantIpedsCategories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefGraduateOrDoctoralExamResultsStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefGunFreeSchoolsActReportingStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefHearingScreeningStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefHigherEducationInstitutionAccreditationStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefHighSchoolDiplomaTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefHomelessNighttimeResidences)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefHighSchoolDiplomaDistinctionTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefHighSchoolGraduationRateIndicators)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIDEADisabilityTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIDEADisciplineMethodFirearms)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIDEAEducationalEnvironmentECs)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIDEAEducationalEnvironmentSchoolAges)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIDEAEligibilityEvaluationCategories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIDEAEnvironmentELs)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIDEAIEPStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIDEAInterimRemovals)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIDEAInterimRemovalReasons)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIDEAPartCEligibilityCategories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOrganizationIdentificationSystems)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPersonIdentificationSystems)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIEPAuthorizationDocumentTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIEPEligibilityEvaluationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIEPGoalTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefImmunizationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncidentBehaviors)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncidentBehaviorSecondaries)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncidentInjuryTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncidentLocations)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncidentMultipleOffenseTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncidentPerpetratorInjuryTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncidentPersonRoleTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncidentPersonTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncidentReporterTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncidentTimeDescriptionCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncomeCalculationMethods)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncomeCalculationMethods1)
                .WithOptional(e => e.Organization1)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIncreasedLearningTimeTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIndicatorStateDefinedStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIndicatorStatusCustomTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIndicatorStatusSubgroupTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIndicatorStatusTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIndividualizedProgramDateTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIndividualizedProgramLocations)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIndividualizedProgramPlannedServiceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIndividualizedProgramTransitionTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIndividualizedProgramTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefInstitutionTelephoneTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefInstructionalActivityHours)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefInstructionCreditTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefInstructionLocationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefInstructionalStaffContractLengths)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefInstructionalStaffFacultyTenures)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefHealthInsuranceCoverages)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIntegratedTechnologyStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefInternetAccesses)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefInternetAccessTypeInResidences)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefInternetPerformanceInResidences)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPEDSFASBFinancialPositions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPEDSFASBFunctionalExpenses)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPEDSFASBPellGrantTransactions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPEDSFASBRevenues)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPEDSFASBRevenueRestrictions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPEDSFASBScholarshipsandFellowshipsRevenues)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPEDSGASBFinancialPositions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPEDSGASBFunctionalExpenses)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPEDSGASBRevenues)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPEDSGASBScholarshipsandFellowshipsRevenues)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPEDSIntercollegiateAthleticsExpenses)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPEDSNaturalExpenses)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIpedsOccupationalCategories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPSPProgressReportSchedules)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefIPSPProgressReportTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefItemResponseTheoryDifficultyCategories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefItemResponseTheoryKappaAlgorithms)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefISO6392Language)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefISO6393Language)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefISO6395LanguageFamily)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefK12EndOfCourseRequirement)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefK12LeaTitleISupportService)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefK12ResponsibilityType)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLanguages)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTitleIIILanguageInstructionProgramTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLanguageUseTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLeaFundsTransferTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLeaImprovementStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearnerActionTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearnerActivityAddToGradeBookFlags)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearnerActivityTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceAccessAPITypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceAccessHazardTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceAccessModeTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceAccessRightsUrls)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceAuthorTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceBookFormatTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceCompetencyAlignmentTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceControlFlexibilityTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceDigitalMediaSubTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceDigitalMediaTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceInteractionModes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceMediaFeatureTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourcePhysicalMediaTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLeaTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLeaveEventTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLevelOfInstitutions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLicenseExempts)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLiteracyAssessments)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceEducationalUses)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceIntendedEndUserRoles)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceInteractivityTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearningResourceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMagnetSpecialPrograms)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefLearnerActivityMaximumTimeAllowedUnits)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMedicalAlertIndicators)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMepEnrollmentTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMepProjectBaseds)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMepProjectTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMepServiceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMepSessionTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMepStaffCategories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMethodOfServiceDeliveries)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMilitaryActiveStudentIndicators)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMilitaryBranches)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMilitaryConnectedStudentIndicators)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMilitaryVeteranStudentIndicators)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefMultipleIntelligenceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefNaepAspectsOfReadings)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefNaepMathComplexityLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefNationalSchoolLunchProgramStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefNCESCollegeCourseMapCodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefNeedDeterminationMethods)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefNeglectedProgramTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefNonPromotionReasons)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefNonTraditionalGenderStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefNSLPStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefNumberOfDependentsTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefONETSOCOccupationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOperationalStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOperationalStatusTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOrganizationElementTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOrganizationIdentifierTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOrganizationIndicators)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOrganizationLocationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOrganizationMonitoringNotifications)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOrganizationRelationships)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOrganizationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOtherNameTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOutcomeTimePoints)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefOutOfFieldStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefParaprofessionalQualifications)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefParticipationStatusAyps)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPDActivityApprovedPurposes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPDActivityCreditTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPDActivityEducationLevelsAddresseds)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPDActivityLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPDActivityTargetAudiences)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPDActivityTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPDAudienceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPDDeliveryMethods)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPDInstructionalDeliveryModes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPDSessionStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPersonalInformationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPersonalInformationVerifications)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPersonIdentifierTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPersonLocationTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPersonStatusTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPersonTelephoneNumberTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPESCAwardLevelTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPopulationServeds)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPsLepTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPreAndPostTestIndicators)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPredominantCalendarSystems)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPreKEligibleAgesNonIDEAs)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPrekindergartenEligibilities)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPresentAttendanceCategories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPrimaryLearningDeviceAccesses)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPrimaryLearningDeviceAwayFromSchools)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPrimaryLearningDeviceProviders)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProfessionalDevelopmentFinancialSupports)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProfessionalEducationJobClassifications)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProficiencyStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProficiencyTargetAyps)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProfitStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProfessionalTechnicalCredentialTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProgramDayLengths)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProgramEntryReasons)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProgramExitReasons)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProgramGiftedEligibilities)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProgramLengthHoursTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProgramSponsorTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdiction);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProgramTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProgressLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPromotionReasons)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefProofOfResidencyTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPsEnrollmentActions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdiction);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPsEnrollmentAwardTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPsEnrollmentStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPsEnrollmentTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPSExitOrWithdrawalTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPSProgramLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPsStudentLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPublicSchoolChoiceStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPublicSchoolResidences)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPurposeOfMonitoringVisits)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefQrisParticipations)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefRaces)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefReapAlternativeFundingStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefReasonDelayTransitionConfs)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefReconstitutedStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefRecordStatusCreatorEntities)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefRecordStatusTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefReferralOutcomes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefReimbursementTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefPersonRelationshipTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefRestructuringActions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefRlisProgramUses)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefRoles)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefRoleStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefRoleStatusTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSCEDCourseLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSCEDCourseSubjectAreas)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefScheduledWellChildScreenings)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSchoolDangerousStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSchoolFoodServicePrograms)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdiction);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSchoolImprovementFunds)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSchoolImprovementFunds1)
                .WithOptional(e => e.Organization1)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSchoolImprovementStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSchoolLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSchoolTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefScoreMetricTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefServiceFrequencies)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefServiceOptions)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefServices)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSessionTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSexes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSigInterventionTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSingleSexClassStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSpaceUseTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSpecialEducationAgeGroupTaughts)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSpecialEducationExitReasons)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSpecialEducationStaffCategories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefStaffCompensationSourceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefStaffPerformanceLevels)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefStandardizedAdmissionTests)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefStates)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefStateANSICodes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefStatePovertyDesignations)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefStudentEnrollmentAccessTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefStudentSchoolAffiliationStateDefinedStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefStudentSupportServiceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefSupervisedClinicalExperiences)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTargetedSupports)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTargetedSupportAndImprovementStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTeacherEducationCredentialExams)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTeacherEducationExamScoreTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTeacherEducationTestCompanies)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTeacherPrepCompleterStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTeacherPrepEnrollmentStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTeachingAssignmentRoles)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTeachingCredentialBasis)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTeachingCredentialTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTechnicalAssistanceDeliveryTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTechnicalAssistanceTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTechnologyLiteracyStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTelephoneNumberListedStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTelephoneNumberTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTenureSystems)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTextComplexitySystems)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTimeForCompletionUnits)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTitleISchoolStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTitleIIIAccountabilities)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTitleIIIProfessionalDevelopmentTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTitleIIndicators)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTitleIInstructionalServices)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTitleIProgramStaffCategories)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTitleIProgramTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTransferOutIndicators)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTransferReadies)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTribalAffiliations)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTrimesterWhenPrenatalCareBegans)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTuitionResidencyTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefTuitionUnits)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefUSCitizenshipStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefVirtualSchoolStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefVisaTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefVisionScreeningStatus)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefWageCollectionMethods)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefWageVerifications)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefWeaponTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefWfProgramParticipations)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefWIOABarrierstoEmployments)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RefWorkbasedLearningOpportunityTypes)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.RequiredImmunizations)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Roles)
                .WithOptional(e => e.Organization)
                .HasForeignKey(e => e.RefJurisdictionId);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.ServiceProviders)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationCalendar>()
                .Property(e => e.CalendarYear)
                .IsFixedLength();

            modelBuilder.Entity<OrganizationCalendar>()
                .HasMany(e => e.OrganizationCalendarDays)
                .WithRequired(e => e.OrganizationCalendar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationCalendar>()
                .HasMany(e => e.OrganizationCalendarEvents)
                .WithRequired(e => e.OrganizationCalendar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationCalendarSession>()
                .Property(e => e.InstructionalMinutes)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrganizationCalendarSession>()
                .HasMany(e => e.K12FederalFundAllocation)
                .WithRequired(e => e.OrganizationCalendarSession)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationCalendarSession>()
                .HasMany(e => e.K12LeaFederalFunds)
                .WithRequired(e => e.OrganizationCalendarSession)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationCalendarSession>()
                .HasMany(e => e.OrganizationFinancials)
                .WithRequired(e => e.OrganizationCalendarSession)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationFinancial>()
                .Property(e => e.ActualValue)
                .HasPrecision(12, 2);

            modelBuilder.Entity<OrganizationFinancial>()
                .Property(e => e.BudgetedValue)
                .HasPrecision(12, 1);

            modelBuilder.Entity<OrganizationFinancial>()
                .Property(e => e.EncumberedValue)
                .HasPrecision(9, 2);

            modelBuilder.Entity<OrganizationFinancial>()
                .Property(e => e.Value)
                .HasPrecision(9, 2);

            modelBuilder.Entity<OrganizationFinancial>()
                .Property(e => e.FiscalYear)
                .IsFixedLength();

            modelBuilder.Entity<OrganizationFinancial>()
                .HasMany(e => e.FacilityFinancials)
                .WithRequired(e => e.OrganizationFinancial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationFinancial>()
                .HasMany(e => e.IPEDSFinances)
                .WithRequired(e => e.OrganizationFinancial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.ActivityRecognitions)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.AeStaffs)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.AeStudentAcademicRecords)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.AeStudentEmployments)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.Authentications)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.Authorizations)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.AuthorizationDocuments)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.CteStudentAcademicRecords)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.ELChildProgramEligibilities)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.ELChildServices)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.ELChildServicesApplications)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.ELStaffs)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.ELStaffAssignments)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.FinancialAidApplications)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.FinancialAidAwards)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.IndividualizedPrograms)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.IndividualizedProgramMeetingAttendees)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12OrganizationStudentResponsibility)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12StaffAssignment)
                .WithRequired(e => e.OrganizationPersonRole)
                .HasForeignKey(e => e.OrganizationPersonRoleId);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12StaffAssignment1)
                .WithRequired(e => e.OrganizationPersonRole1)
                .HasForeignKey(e => e.OrganizationPersonRoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12StudentAcademicHonor)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12StudentActivity)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12StudentCohort)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12StudentEmployment)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12StudentEnrollment)
                .WithRequired(e => e.OrganizationPersonRole)
                .HasForeignKey(e => e.OrganizationPersonRoleId);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12StudentEnrollment1)
                .WithRequired(e => e.OrganizationPersonRole1)
                .HasForeignKey(e => e.OrganizationPersonRoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12StudentGraduationPlan)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12StudentHomeLanguageSurvey)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12StudentLiteracyAssessment)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.K12StudentSession)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.OrganizationPersonRoleApplications)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.OrganizationPersonRoleFTEs)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.OrganizationPersonRoleRelationships)
                .WithRequired(e => e.OrganizationPersonRole)
                .HasForeignKey(e => e.OrganizationPersonRoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.OrganizationPersonRoleRelationships1)
                .WithRequired(e => e.OrganizationPersonRole1)
                .HasForeignKey(e => e.OrganizationPersonRoleId_Parent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.ProfessionalDevelopmentSessionInstructors)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PersonLearningDevices)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PersonProgramParticipations)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.ProfessionalDevelopmentRequirements)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PsStudentAdmissionTests)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PsStudentAcademicAwards)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PsStudentAcademicRecords)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PsStudentApplications)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PsStudentCohorts)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PsStudentDemographics)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PsStudentEmployments)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PsStudentEnrollments)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PsStudentFinancialAids)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PSStudentPrograms)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.PsStudentSections)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.RoleAttendances)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.RoleAttendanceEvents)
                .WithRequired(e => e.OrganizationPersonRole)
                .HasForeignKey(e => e.OrganizationPersonRoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.RoleAttendanceEvents1)
                .WithRequired(e => e.OrganizationPersonRole1)
                .HasForeignKey(e => e.OrganizationPersonRoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.RoleStatus)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.ServicePlans)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.ServicesReceiveds)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.ServiceStaffs)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.StaffEmployments)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.StaffEvaluations)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.StaffEvaluationParts)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.StaffExperiences)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.StaffProfessionalDevelopmentActivities)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.StaffTechnicalAssistances)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.WorkforceEmploymentQuarterlyDatas)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRole>()
                .HasMany(e => e.WorkforceProgramParticipantCohorts)
                .WithRequired(e => e.OrganizationPersonRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationPersonRoleFTE>()
                .Property(e => e.FullTimeEquivalency)
                .HasPrecision(3, 2);

            modelBuilder.Entity<PeerRatingSystem>()
                .Property(e => e.MaximumValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PeerRatingSystem>()
                .Property(e => e.MinimumValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PeerRatingSystem>()
                .Property(e => e.OptimumValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PeerRatingSystem>()
                .HasMany(e => e.LearningResourcePeerRatings)
                .WithRequired(e => e.PeerRatingSystem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.AssessmentRegistrations)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.AssignedByPersonId);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.AssessmentRegistrations1)
                .WithRequired(e => e.Person1)
                .HasForeignKey(e => e.PersonId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.AssessmentSessionStaffRoles)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.ELChildDemographics)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.ELChildDevelopmentalAssessments)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.ELChildHealths)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.ELChildIndividualizedPrograms)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.ELChildOutcomeSummaries)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.ELChildTransitionPlans)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.ELEnrollmentOtherFundings)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Incidents)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.IncidentReporterId);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.IncidentPersons)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.IndividualizedProgramServices)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.LearnerActivities)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.PersonId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.LearnerActivities1)
                .WithOptional(e => e.Person1)
                .HasForeignKey(e => e.AssignedByPersonId);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.LearningResourcePeerRatings)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.OrganizationPersonRoles)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonHomelessnesses)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Person_AssessmentPersonalNeedsProfile)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonEmailAddresses)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonAddresses)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonAllergies)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonBirthplaces)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonCareerEducationPlans)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonCredentials)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonDegreeOrCertificates)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonDemographicRaces)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonDetails)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonDigitalAccesses)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonDisabilities)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonFamilies)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonHealths)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonHealthBirths)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonIdentifiers)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonImmunizations)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonLanguages)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonMilitaries)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonOtherNames)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonPersonalInformationVerifications)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonTelephones)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonReferrals)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonRelationships)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.PersonId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonRelationships1)
                .WithRequired(e => e.Person1)
                .HasForeignKey(e => e.RelatedPersonId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonStatus)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.QuarterlyEmploymentRecords)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.RecordStatuses)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.RecordStatusCreatorPersonId);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.RecordStatusHistories)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.RecordStatusCreatorPersonId);

            modelBuilder.Entity<PersonAddress>()
                .HasMany(e => e.PersonAddressNcesSides)
                .WithRequired(e => e.PersonAddress)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonAddressNcesSide>()
                .Property(e => e.NcesSideEstimate)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PersonAddressNcesSide>()
                .Property(e => e.NcesSideStandardError)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PersonCredential>()
                .HasMany(e => e.EarlyChildhoodCredentials)
                .WithRequired(e => e.PersonCredential)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonCredential>()
                .HasMany(e => e.StaffCredentials)
                .WithRequired(e => e.PersonCredential)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonDigitalAccessSpeed>()
                .Property(e => e.InternetDownloadSpeed)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PersonDigitalAccessSpeed>()
                .Property(e => e.InternetUploadSpeed)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PersonFamily>()
                .Property(e => e.FamilyIncome)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PersonProgramParticipation>()
                .HasMany(e => e.ProgramParticipationTeacherPreps)
                .WithRequired(e => e.PersonProgramParticipation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonProgramParticipation>()
                .HasMany(e => e.ProgramParticipationAEs)
                .WithRequired(e => e.PersonProgramParticipation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonProgramParticipation>()
                .HasMany(e => e.ProgramParticipationAttainments)
                .WithRequired(e => e.PersonProgramParticipation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonProgramParticipation>()
                .HasMany(e => e.ProgramParticipationCtes)
                .WithRequired(e => e.PersonProgramParticipation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonProgramParticipation>()
                .HasMany(e => e.ProgramParticipationFoodServices)
                .WithRequired(e => e.PersonProgramParticipation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonProgramParticipation>()
                .HasMany(e => e.ProgramParticipationMigrants)
                .WithRequired(e => e.PersonProgramParticipation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonProgramParticipation>()
                .HasMany(e => e.ProgramParticipationNeglecteds)
                .WithRequired(e => e.PersonProgramParticipation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonProgramParticipation>()
                .HasMany(e => e.ProgramParticipationSpecialEducations)
                .WithRequired(e => e.PersonProgramParticipation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonProgramParticipation>()
                .HasMany(e => e.ProgramParticipationTitleIs)
                .WithRequired(e => e.PersonProgramParticipation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonProgramParticipation>()
                .HasMany(e => e.ProgramParticipationTitleIIILeps)
                .WithRequired(e => e.PersonProgramParticipation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonProgramParticipation>()
                .HasMany(e => e.ProgramParticipationWIOAs)
                .WithRequired(e => e.PersonProgramParticipation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonProgramParticipation>()
                .HasMany(e => e.WorkforceProgramParticipations)
                .WithRequired(e => e.PersonProgramParticipation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProfessionalDevelopmentActivity>()
                .Property(e => e.Cost)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ProfessionalDevelopmentActivity>()
                .Property(e => e.Credits)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ProfessionalDevelopmentActivity>()
                .HasMany(e => e.PDActivityEducationLevels)
                .WithRequired(e => e.ProfessionalDevelopmentActivity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProfessionalDevelopmentActivity>()
                .HasMany(e => e.ProfessionalDevelopmentSessions)
                .WithRequired(e => e.ProfessionalDevelopmentActivity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProfessionalDevelopmentActivity>()
                .HasMany(e => e.StaffProfessionalDevelopmentActivities)
                .WithRequired(e => e.ProfessionalDevelopmentActivity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProfessionalDevelopmentRequirement>()
                .Property(e => e.RequiredTrainingClockHours)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ProfessionalDevelopmentRequirement>()
                .HasMany(e => e.ProfessionalDevelopmentActivities)
                .WithRequired(e => e.ProfessionalDevelopmentRequirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProfessionalDevelopmentRequirement>()
                .HasMany(e => e.StaffProfessionalDevelopmentActivities)
                .WithRequired(e => e.ProfessionalDevelopmentRequirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProfessionalDevelopmentSession>()
                .HasMany(e => e.ProfessionalDevelopmentSessionInstructors)
                .WithRequired(e => e.ProfessionalDevelopmentSession)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProfessionalDevelopmentSession>()
                .HasMany(e => e.StaffProfessionalDevelopmentActivities)
                .WithRequired(e => e.ProfessionalDevelopmentSession)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Program>()
                .Property(e => e.CreditsRequired)
                .HasPrecision(9, 2);

            modelBuilder.Entity<ProgramParticipationAE>()
                .Property(e => e.ProxyContactHours)
                .HasPrecision(5, 1);

            modelBuilder.Entity<ProgramParticipationAE>()
                .Property(e => e.InstructionalActivityHoursCompleted)
                .HasPrecision(9, 2);

            modelBuilder.Entity<ProgramParticipationSpecialEducation>()
                .Property(e => e.SpecialEducationFTE)
                .HasPrecision(5, 4);

            modelBuilder.Entity<ProgramParticipationTeacherPrep>()
                .Property(e => e.SchoolAgeEducationPSCredits)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ProgramParticipationTeacherPrep>()
                .HasMany(e => e.TeacherEducationCredentialExams)
                .WithRequired(e => e.ProgramParticipationTeacherPrep)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProgramParticipationWIOA>()
                .HasMany(e => e.ProgramParticipationWIOABarriers)
                .WithRequired(e => e.ProgramParticipationWIOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PsInstitution>()
                .HasMany(e => e.PsPriceOfAttendances)
                .WithRequired(e => e.PsInstitution)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PsPriceOfAttendance>()
                .Property(e => e.SessionDesignator)
                .IsFixedLength();

            modelBuilder.Entity<PsPriceOfAttendance>()
                .Property(e => e.TuitionPublished)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsPriceOfAttendance>()
                .Property(e => e.BoardCharges)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsPriceOfAttendance>()
                .Property(e => e.RoomCharges)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsPriceOfAttendance>()
                .Property(e => e.BooksAndSuppliesCosts)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsPriceOfAttendance>()
                .Property(e => e.RequiredStudentFees)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsPriceOfAttendance>()
                .Property(e => e.ComprehensiveFee)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsPriceOfAttendance>()
                .Property(e => e.OtherStudentExpenses)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsPriceOfAttendance>()
                .Property(e => e.PriceOfAttendance)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsPriceOfAttendance>()
                .Property(e => e.IPEDSCollectionYearDesignator)
                .IsFixedLength();

            modelBuilder.Entity<PsProgram>()
                .Property(e => e.ProgramLengthHours)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsSection>()
                .Property(e => e.GradeValueQualifier)
                .IsFixedLength();

            modelBuilder.Entity<PsSection>()
                .HasMany(e => e.PsSectionLocations)
                .WithRequired(e => e.PsSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PsStaffEmployment>()
                .Property(e => e.AnnualBaseContractualSalary)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsStudentAcademicRecord>()
                .Property(e => e.AcademicYearDesignator)
                .IsFixedLength();

            modelBuilder.Entity<PsStudentAcademicRecord>()
                .Property(e => e.GradePointAverage)
                .HasPrecision(9, 4);

            modelBuilder.Entity<PsStudentAcademicRecord>()
                .Property(e => e.GradePointAverageCumulative)
                .HasPrecision(9, 4);

            modelBuilder.Entity<PsStudentAcademicRecord>()
                .Property(e => e.DualCreditDualEnrollmentCredits)
                .HasPrecision(9, 4);

            modelBuilder.Entity<PsStudentAcademicRecord>()
                .Property(e => e.DiplomaOrCredentialAwardDate)
                .IsFixedLength();

            modelBuilder.Entity<PsStudentAcademicRecord>()
                .Property(e => e.CreditsAttemptedCumulative)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsStudentAcademicRecord>()
                .Property(e => e.CreditsEarnedCumulative)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsStudentAcademicRecord>()
                .Property(e => e.NumberOfCreditsAttempted)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsStudentAdmissionTest>()
                .Property(e => e.StandardizedAdmissionTestScore)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsStudentApplication>()
                .Property(e => e.GradePointAverageCumulative)
                .HasPrecision(9, 4);

            modelBuilder.Entity<PsStudentApplication>()
                .Property(e => e.HighSchoolPercentile)
                .HasPrecision(5, 4);

            modelBuilder.Entity<PsStudentCohort>()
                .Property(e => e.CohortGraduationYear)
                .IsFixedLength();

            modelBuilder.Entity<PsStudentEmployment>()
                .Property(e => e.EmploymentNaicsCode)
                .IsFixedLength();

            modelBuilder.Entity<PsStudentEnrollment>()
                .Property(e => e.InstructionalActivityHoursAttempted)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsStudentEnrollment>()
                .Property(e => e.InstructionalActivityHoursCompleted)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsStudentFinancialAid>()
                .Property(e => e.FinancialNeed)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsStudentFinancialAid>()
                .Property(e => e.FinancialAidIncomeLevel)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsStudentSection>()
                .Property(e => e.NumberOfCreditsEarned)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsStudentSection>()
                .Property(e => e.QualityPointsEarned)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsStudentSection>()
                .Property(e => e.NumberOfCreditsAttempted)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PsStudentSection>()
                .HasMany(e => e.PsStudentCourseSectionMarks)
                .WithRequired(e => e.PsStudentSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuarterlyEmploymentRecord>()
                .Property(e => e.Earnings)
                .HasPrecision(9, 2);

            modelBuilder.Entity<RecordStatus>()
                .HasMany(e => e.Organizations)
                .WithOptional(e => e.RecordStatus)
                .HasForeignKey(e => e.RecordStatusId);

            modelBuilder.Entity<RecordStatus>()
                .HasMany(e => e.People)
                .WithOptional(e => e.RecordStatus)
                .HasForeignKey(e => e.RecordStatusId);

            modelBuilder.Entity<RecordStatus>()
                .HasMany(e => e.RecordStatusHistories)
                .WithRequired(e => e.RecordStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefAbsentAttendanceCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAcademicAwardLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAcademicAwardPrerequisiteType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefAcademicHonorType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAcademicRank>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAcademicSubject>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAcademicSubject>()
                .HasMany(e => e.Assessments)
                .WithRequired(e => e.RefAcademicSubject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefAcademicTermDesignator>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAccommodationsNeededType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAccommodationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefAccreditationAgency>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefActivityRecognitionType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefActivityRecognitionType>()
                .HasMany(e => e.ActivityRecognitions)
                .WithRequired(e => e.RefActivityRecognitionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefActivityTimeMeasurementType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAdditionalCreditType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAdditionalTargetedSupportAndImprovementStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefAddressType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAdministrativeFundingControl>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAdmissionConsiderationLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAdmissionConsiderationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAdmittedStudent>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAdultEducationProgramExitReason>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefAdvancedPlacementCourseCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAeCertificationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAeFunctioningLevelAtIntake>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAeFunctioningLevelAtPosttest>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAeInstructionalProgramType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAePostsecondaryTransitionAction>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAeSpecialProgramType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAeStaffClassification>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAeStaffEmploymentStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAllergySeverity>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAllergyType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAllergyType>()
                .HasMany(e => e.PersonAllergies)
                .WithRequired(e => e.RefAllergyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefAlternateFundUs>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAlternateFundUs>()
                .HasMany(e => e.K12SeaAlternateFundUse)
                .WithRequired(e => e.RefAlternateFundUs)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefAlternativeSchoolFocu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAltRouteToCertificationOrLicensure>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAmaoAttainmentStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAmaoAttainmentStatu>()
                .HasMany(e => e.OrganizationFederalAccountabilities)
                .WithOptional(e => e.RefAmaoAttainmentStatu)
                .HasForeignKey(e => e.AmaoAypProgressAttainmentLepStudents);

            modelBuilder.Entity<RefAmaoAttainmentStatu>()
                .HasMany(e => e.OrganizationFederalAccountabilities1)
                .WithOptional(e => e.RefAmaoAttainmentStatu1)
                .HasForeignKey(e => e.AmaoProficiencyAttainmentLepStudents);

            modelBuilder.Entity<RefAmaoAttainmentStatu>()
                .HasMany(e => e.OrganizationFederalAccountabilities2)
                .WithOptional(e => e.RefAmaoAttainmentStatu2)
                .HasForeignKey(e => e.AmaoProgressAttainmentLepStudents);

            modelBuilder.Entity<RefApipInteractionType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentAccommodationCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentAssetIdentifierType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentAssetIdentifierType>()
                .HasMany(e => e.AssessmentAssets)
                .WithOptional(e => e.RefAssessmentAssetIdentifierType)
                .HasForeignKey(e => e.RefAssessmentAssestIdentifierType);

            modelBuilder.Entity<RefAssessmentAssetType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentELDevelopmentalDomain>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefAssessmentELDevelopmentalDomain>()
                .HasMany(e => e.AssessmentELDevelopmentalDomains)
                .WithRequired(e => e.RefAssessmentELDevelopmentalDomain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefAssessmentELDevelopmentalDomain>()
                .HasMany(e => e.AssessmentSubtestELDevelopmentalDomains)
                .WithRequired(e => e.RefAssessmentELDevelopmentalDomain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefAssessmentFormSectionIdentificationSystem>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentItemCharacteristicType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentItemResponseScoreStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentItemResponseStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentItemResponseStatu>()
                .HasMany(e => e.AssessmentItemResponses)
                .WithOptional(e => e.RefAssessmentItemResponseStatu)
                .HasForeignKey(e => e.RefAssessItemResponseStatusId);

            modelBuilder.Entity<RefAssessmentItemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedAlternativeRepresentationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedBrailleGradeType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedBrailleMarkType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedBrailleStatusCellType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedHazardType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedIncreasedWhitespacingType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedLanguageLearnerType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedLanguageLearnerType>()
                .HasMany(e => e.AssessmentPersonalNeedLanguageLearners)
                .WithRequired(e => e.RefAssessmentNeedLanguageLearnerType)
                .HasForeignKey(e => e.RefAssessmentNeedsProfileContentLanguageLearnerTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefAssessmentNeedLinkIndicationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefAssessmentNeedMaskingType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedNumberOfBrailleDot>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedSigningType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedSpokenSourcePreferenceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedSupportTool>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedUsageType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentNeedUserSpokenPreferenceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentParticipationIndicator>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentPlatformType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentPretestOutcome>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentPurpose>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentReasonNotCompleting>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentReasonNotTested>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentRegistrationCompletionStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentReportingMethod>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentResultDataType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentResultScoreType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentSessionSpecialCircumstanceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentSessionStaffRoleType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentSessionType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentSubtestIdentifierType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAssessmentTypeChildrenWithDisability>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAttendanceEventType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAttendanceStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefAuthorizerType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefAypStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefBarrierToEducatingHomeless>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefBarrierToInternetAccessInResidence>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBillableBasisType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefBlendedLearningModelType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefBloomsTaxonomyDomain>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefBuildingAdministrativeSpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingAirDistributionSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingArtSpecialtySpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingAssemblySpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingBasicClassroomDesignType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingCareerTechEducationSpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingCharterSchoolRealtyAccessType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingCirculationSpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingCleaningStandardType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingCommMgmtComponentSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingCommunityUseSpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingCoolingGenerationSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingDesignType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingElectricalSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingEnergyConservationMeasureType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingEnergySourceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingEnvOrEnergyPerformanceRatingCat>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingFireProtectionSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingFoodServiceSpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingFullServiceKitchenType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingHeatingGenerationSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingHistoricStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingHVACSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingIndoorAthleticOrPhysEdSpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingInstructionalSpaceFactorType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingJointUseRationaleType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingJointUserType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingJointUseSchedulingType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingLibMediaCenterSpecialtySpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingMechanicalConveyingSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingMechanicalSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingOperationsOrMaintSpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingOutdoorAthleticOrPhysEdSpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingOutdoorOrNonathleticSpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingPerformingArtsSpecialtySpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingPlumbingSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingPrimaryUseType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingSchoolDesignType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingSchoolDesignType>()
                .HasMany(e => e.FacilitySchoolDesigns)
                .WithRequired(e => e.RefBuildingSchoolDesignType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefBuildingScienceSpecialtySpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingSecuritySystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingSiteUseRestrictionsType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingSpaceDesignType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingSpecEdSpecialtySpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingStudentSupportSpaceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingTechnologyWiringSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefBuildingUseType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefBuildingVerticalTransportationSystemType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCalendarEventType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCalendarEventType>()
                .HasMany(e => e.OrganizationCalendarEvents)
                .WithOptional(e => e.RefCalendarEventType1)
                .HasForeignKey(e => e.RefCalendarEventType);

            modelBuilder.Entity<RefCampusResidencyType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCampusStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCampusType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCareerCluster>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCareerEducationPlanType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCarnegieBasicClassification>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCharterLeaStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCharterSchoolAuthorizerType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCharterSchoolAuthorizerType>()
                .HasMany(e => e.K12CharterSchoolAuthorizerAgency)
                .WithRequired(e => e.RefCharterSchoolAuthorizerType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefCharterSchoolManagementOrganizationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCharterSchoolType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefChildDevelopmentalScreeningStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefChildDevelopmentAssociateType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefChildDevelopmentAssociateType>()
                .HasMany(e => e.StaffCredentials)
                .WithOptional(e => e.RefChildDevelopmentAssociateType)
                .HasForeignKey(e => e.RefChildDevAssociateTypeId);

            modelBuilder.Entity<RefChildOutcomesSummaryRating>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefChildOutcomesSummaryRating>()
                .HasMany(e => e.ELChildOutcomeSummaries)
                .WithOptional(e => e.RefChildOutcomesSummaryRating)
                .HasForeignKey(e => e.COSRatingAId);

            modelBuilder.Entity<RefChildOutcomesSummaryRating>()
                .HasMany(e => e.ELChildOutcomeSummaries1)
                .WithOptional(e => e.RefChildOutcomesSummaryRating1)
                .HasForeignKey(e => e.COSRatingBId);

            modelBuilder.Entity<RefChildOutcomesSummaryRating>()
                .HasMany(e => e.ELChildOutcomeSummaries2)
                .WithOptional(e => e.RefChildOutcomesSummaryRating2)
                .HasForeignKey(e => e.COSRatingCId);

            modelBuilder.Entity<RefCipCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCipUse>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCipVersion>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefClassroomPositionType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCohortExclusion>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCommunicationMethod>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCommunityBasedType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCompetencyDefAssociationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCompetencyDefNodeAccessibilityProfile>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCompetencyDefTestabilityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCompetencyFrameworkPublicationStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCompetencySetCompletionCriteria>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCompetencySetCompletionCriteria>()
                .HasMany(e => e.CompetencySets)
                .WithOptional(e => e.RefCompetencySetCompletionCriteria)
                .HasForeignKey(e => e.RefCompletionCriteriaId);

            modelBuilder.Entity<RefComprehensiveAndTargetedSupport>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefComprehensiveSupport>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefComprehensiveSupportAndImprovementStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefContentStandardType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefContinuationOfService>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefControlOfInstitution>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCoreKnowledgeArea>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCoreKnowledgeArea>()
                .HasMany(e => e.CoreKnowledgeAreas)
                .WithRequired(e => e.RefCoreKnowledgeArea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefCorrectionalEducationFacilityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCorrectiveActionType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCorrectiveActionType>()
                .HasMany(e => e.K12SchoolCorrectiveAction)
                .WithRequired(e => e.RefCorrectiveActionType)
                .HasForeignKey(e => e.RefCorrectiveActionTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefCountry>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCountry>()
                .HasMany(e => e.ProgramParticipationMigrants)
                .WithOptional(e => e.RefCountry)
                .HasForeignKey(e => e.RefQualifyingMoveFromCountryId);

            modelBuilder.Entity<RefCounty>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseAcademicGradeStatusCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseApplicableEducationLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseCreditBasisType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseCreditLevelType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseCreditUnit>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseGpaApplicability>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseHonorsType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseInstructionMethod>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseInstructionSiteType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseInteractionMode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseLevelCharacteristic>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseLevelCharacteristic>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.RefCourseLevelCharacteristic)
                .HasForeignKey(e => e.RefCourseLevelCharacteristicsId);

            modelBuilder.Entity<RefCourseLevelType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseLevelType>()
                .HasMany(e => e.CourseSectionLevels)
                .WithRequired(e => e.RefCourseLevelType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefCourseRepeatCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseSectionAssessmentReportingMethod>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseSectionDeliveryMode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseSectionEnrollmentStatusType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseSectionEntryType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCourseSectionExitType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCredentialDefAgentRoleType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCredentialDefAssessMethodType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCredentialDefIntendedPurposeType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCredentialDefStatusType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCredentialDefVerificationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCredentialIdentifierSystem>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCredentialType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCreditHoursAppliedOtherProgram>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCreditTypeEarned>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCriticalTeacherShortageCandidate>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCTDLAudienceLevelType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCTDLOrganizationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefCteGraduationRateInclusion>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCteNonTraditionalGenderStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefCurriculumFrameworkType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDataCollectionStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefDegreeOrCertificateType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDentalInsuranceCoverageType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDentalScreeningStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDependencyStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDevelopmentalEducationReferralStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDevelopmentalEducationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDevelopmentalEvaluationFinding>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDirectoryInformationBlockStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDisabilityConditionStatusCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDisabilityConditionType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDisabilityDeterminationSourceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDisabilityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDisabilityType>()
                .HasMany(e => e.PersonDisabilities)
                .WithOptional(e => e.RefDisabilityType)
                .HasForeignKey(e => e.PrimaryDisabilityTypeId);

            modelBuilder.Entity<RefDisciplinaryActionTaken>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDisciplineLengthDifferenceReason>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDisciplineMethodFirearm>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDisciplineMethodOfCwd>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDisciplineReason>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDistanceEducationCourseEnrollment>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDoctoralExamsRequiredCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefDQPCategoriesOfLearning>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefEarlyChildhoodCredential>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEarlyChildhoodCredential>()
                .HasMany(e => e.EarlyChildhoodCredentials)
                .WithRequired(e => e.RefEarlyChildhoodCredential)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefEarlyChildhoodProgramEnrollmentType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEarlyChildhoodProgramEnrollmentType>()
                .HasMany(e => e.EarlyChildhoodProgramTypeOffereds)
                .WithRequired(e => e.RefEarlyChildhoodProgramEnrollmentType)
                .HasForeignKey(e => e.RefEarlyChildhoodProgramEnrollmentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefEarlyChildhoodService>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEarlyChildhoodService>()
                .HasMany(e => e.ELChildServices)
                .WithOptional(e => e.RefEarlyChildhoodService)
                .HasForeignKey(e => e.RefEarlyChildhoodServicesOfferedId);

            modelBuilder.Entity<RefEarlyChildhoodService>()
                .HasMany(e => e.ELChildServices1)
                .WithOptional(e => e.RefEarlyChildhoodService1)
                .HasForeignKey(e => e.RefEarlyChildhoodServicesReceivedId);

            modelBuilder.Entity<RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefEdFactsAcademicOrCareerAndTechnicalOutcomeType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefEDFactsTeacherInexperiencedStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefEducationLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEducationLevel>()
                .HasMany(e => e.CompetencyDefEducationLevels)
                .WithRequired(e => e.RefEducationLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefEducationLevel>()
                .HasMany(e => e.LearningResourceEducationLevels)
                .WithRequired(e => e.RefEducationLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefEducationLevel>()
                .HasMany(e => e.PersonDetails)
                .WithOptional(e => e.RefEducationLevel)
                .HasForeignKey(e => e.RefHighestEducationLevelCompletedId);

            modelBuilder.Entity<RefEducationLevel>()
                .HasMany(e => e.PersonFamilies)
                .WithOptional(e => e.RefEducationLevel)
                .HasForeignKey(e => e.RefHighestEducationLevelCompletedId);

            modelBuilder.Entity<RefEducationLevel>()
                .HasMany(e => e.PsStudentDemographics)
                .WithOptional(e => e.RefEducationLevel)
                .HasForeignKey(e => e.RefPaternalEducationLevelId);

            modelBuilder.Entity<RefEducationLevel>()
                .HasMany(e => e.PsStudentDemographics1)
                .WithOptional(e => e.RefEducationLevel1)
                .HasForeignKey(e => e.RefMaternalEducationLevelId);

            modelBuilder.Entity<RefEducationLevelType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEducationVerificationMethod>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELEducationStaffClassification>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefElementaryMiddleAdditional>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELEmploymentSeparationReason>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELFacilityLicensingStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELFederalFundingType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELGroupSizeStandardMet>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELLevelOfSpecialization>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELLocalRevenueSource>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELOtherFederalFundingSource>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELOutcomeMeasurementLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELProfessionalDevelopmentTopicArea>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELProgramEligibility>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELProgramEligibilityStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELProgramLicenseStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELServiceProfessionalStaffClassification>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELServiceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELStateRevenueSource>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefELTrainerCoreKnowledgeArea>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEmailType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEmergencyOrProvisionalCredentialStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEmployedAfterExit>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEmployedPriorToEnrollment>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEmployedWhileEnrolled>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEmployeeBenefit>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefEmploymentContractType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEmploymentLocation>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEmploymentSeparationReason>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEmploymentSeparationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEmploymentStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEmploymentStatusWhileEnrolled>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEndOfTermStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEnrollmentStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEntityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEntityType>()
                .HasMany(e => e.CompetencyDefAssociations)
                .WithRequired(e => e.RefEntityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefEntryType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefEntryType>()
                .HasMany(e => e.K12StudentEnrollment)
                .WithOptional(e => e.RefEntryType1)
                .HasForeignKey(e => e.RefEntryType);

            modelBuilder.Entity<RefEnvironmentSetting>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefERAdministrativeDataSource>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefERSRuralUrbanContinuumCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefExitOrWithdrawalStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefExitOrWithdrawalType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFacilitiesMandateAuthorityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilitiesMgmtEmergencyType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilitiesPlanType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityApplicableFederalMandateType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityAuditType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityCapitalProgramMgmtType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityComplianceAgencyType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityComplianceStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityConstructionDateType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityConstructionMaterialType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityFederalMandateInterestType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityFinancingFeeType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityFinancingFeeType>()
                .HasMany(e => e.FacilityMortgageFees)
                .WithRequired(e => e.RefFacilityFinancingFeeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefFacilityFurnishingsType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityHazardousMaterialsOrCondType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityJointDevelopmentType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityLeaseAmountCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityLeaseType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityMaintStandardType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityMortgageInterestType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityMortgageType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityNaturallyOccurringHazardType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityOperationsMgmtType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilitySiteImprovementLocationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilitySiteOutdoorAreaType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityStandardType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityStateOrLocalMandateInterestType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilitySystemOrComponentCondition>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityUtilityProviderType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFacilityUtilityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFamilyIncomeSource>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFederalProgramFundingAllocationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialAccountBalanceSheetCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialAccountBalanceSheetCode>()
                .HasMany(e => e.FinancialAccounts)
                .WithOptional(e => e.RefFinancialAccountBalanceSheetCode)
                .HasForeignKey(e => e.RefFinancialAccountBalanceSheetCodeId);

            modelBuilder.Entity<RefFinancialAccountCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialAccountFundClassification>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialAccountProgramCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialAccountRevenueCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialAidApplicationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialAidApplicationType>()
                .HasMany(e => e.FinancialAidApplications)
                .WithRequired(e => e.RefFinancialAidApplicationType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefFinancialAidAwardStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialAidAwardType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialAidVeteransBenefitStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialAidVeteransBenefitType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialExpenditureFunctionCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialExpenditureLevelOfInstructionCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFinancialExpenditureObjectCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFirearmType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFoodServiceEligibility>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFoodServiceParticipation>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFrequencyOfService>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefFrequencyUnit>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefFullTimeStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefGoalMeasurementType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefGoalsForAttendingAdultEducation>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefGoalStatusType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefGpaWeightedIndicator>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefGradeLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefGradeLevel>()
                .HasMany(e => e.AssessmentLevelsForWhichDesigneds)
                .WithRequired(e => e.RefGradeLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefGradeLevel>()
                .HasMany(e => e.AssessmentRegistrations)
                .WithOptional(e => e.RefGradeLevel)
                .HasForeignKey(e => e.RefGradeLevelWhenAssessedId);

            modelBuilder.Entity<RefGradeLevel>()
                .HasMany(e => e.AssessmentRegistrations1)
                .WithOptional(e => e.RefGradeLevel1)
                .HasForeignKey(e => e.RefGradeLevelToBeAssessedId);

            modelBuilder.Entity<RefGradeLevel>()
                .HasMany(e => e.AssessmentSubtestLevelsForWhichDesigneds)
                .WithRequired(e => e.RefGradeLevel)
                .HasForeignKey(e => e.RefGradeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefGradeLevel>()
                .HasMany(e => e.K12LeaGradeLevelsApproved)
                .WithRequired(e => e.RefGradeLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefGradeLevel>()
                .HasMany(e => e.K12LeaGradeOffered)
                .WithRequired(e => e.RefGradeLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefGradeLevel>()
                .HasMany(e => e.K12SchoolGradeLevelsApproved)
                .WithRequired(e => e.RefGradeLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefGradeLevel>()
                .HasMany(e => e.K12SchoolGradeOffered)
                .WithRequired(e => e.RefGradeLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefGradeLevel>()
                .HasMany(e => e.K12StudentCourseSection)
                .WithOptional(e => e.RefGradeLevel)
                .HasForeignKey(e => e.RefGradeLevelWhenCourseTakenId);

            modelBuilder.Entity<RefGradeLevel>()
                .HasMany(e => e.K12StudentEnrollment)
                .WithOptional(e => e.RefGradeLevel)
                .HasForeignKey(e => e.RefEntryGradeLevelId);

            modelBuilder.Entity<RefGradeLevel>()
                .HasMany(e => e.K12StudentEnrollment1)
                .WithOptional(e => e.RefGradeLevel1)
                .HasForeignKey(e => e.RefExitGradeLevelId);

            modelBuilder.Entity<RefGradeLevel>()
                .HasMany(e => e.K12StudentGraduationPlan)
                .WithOptional(e => e.RefGradeLevel)
                .HasForeignKey(e => e.RefGradeLevelWhenCourseTakenId);

            modelBuilder.Entity<RefGradeLevelsApproved>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefGradeLevelType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefGradePointAverageDomain>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefGraduateAssistantIpedsCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefGraduateOrDoctoralExamResultsStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefGunFreeSchoolsActReportingStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefHealthInsuranceCoverage>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefHearingScreeningStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefHigherEducationInstitutionAccreditationStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefHighSchoolDiplomaDistinctionType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefHighSchoolDiplomaType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefHighSchoolGraduationRateIndicator>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefHomelessNighttimeResidence>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefHomelessNighttimeResidence>()
                .HasMany(e => e.PersonHomelessnesses)
                .WithRequired(e => e.RefHomelessNighttimeResidence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefIDEADisabilityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIDEADisciplineMethodFirearm>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIDEAEducationalEnvironmentEC>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIDEAEducationalEnvironmentSchoolAge>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIDEAEligibilityEvaluationCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIDEAEligibilityEvaluationCategory>()
                .HasMany(e => e.IDEAEligibilityEvaluationCategories)
                .WithRequired(e => e.RefIDEAEligibilityEvaluationCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefIDEAEnvironmentEL>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIDEAIEPStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIDEAInterimRemoval>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIDEAInterimRemovalReason>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIDEAPartCEligibilityCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIEPAuthorizationDocumentType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIEPEligibilityEvaluationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIEPGoalType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefImmunizationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefImmunizationType>()
                .HasMany(e => e.PersonImmunizations)
                .WithRequired(e => e.RefImmunizationType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefImmunizationType>()
                .HasMany(e => e.RequiredImmunizations)
                .WithRequired(e => e.RefImmunizationType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefIncidentBehavior>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIncidentBehaviorSecondary>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIncidentInjuryType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIncidentLocation>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIncidentMultipleOffenseType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIncidentPerpetratorInjuryType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIncidentPersonRoleType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIncidentPersonRoleType>()
                .HasMany(e => e.IncidentPersons)
                .WithRequired(e => e.RefIncidentPersonRoleType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefIncidentPersonType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIncidentReporterType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIncidentTimeDescriptionCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIncomeCalculationMethod>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIncreasedLearningTimeType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIndicatorStateDefinedStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIndicatorStatusCustomType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIndicatorStatusSubgroupType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIndicatorStatusType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIndicatorStatusType>()
                .HasMany(e => e.K12SchoolIndicatorStatus)
                .WithRequired(e => e.RefIndicatorStatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefIndividualizedProgramDateType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIndividualizedProgramDateType>()
                .HasMany(e => e.IndividualizedPrograms)
                .WithOptional(e => e.RefIndividualizedProgramDateType1)
                .HasForeignKey(e => e.RefIndividualizedProgramDateType);

            modelBuilder.Entity<RefIndividualizedProgramLocation>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIndividualizedProgramPlannedServiceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIndividualizedProgramTransitionType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIndividualizedProgramType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefInstitutionTelephoneType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefInstructionalActivityHour>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefInstructionalStaffContractLength>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefInstructionalStaffFacultyTenure>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefInstructionCreditType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefInstructionLocationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIntegratedTechnologyStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefInternetAccess>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefInternetAccessTypeInResidence>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefInternetPerformanceInResidence>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPEDSFASBFinancialPosition>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPEDSFASBFunctionalExpense>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPEDSFASBPellGrantTransaction>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPEDSFASBRevenue>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPEDSFASBRevenueRestriction>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPEDSFASBScholarshipsandFellowshipsRevenue>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPEDSGASBFinancialPosition>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPEDSGASBFunctionalExpense>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPEDSGASBRevenue>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPEDSGASBScholarshipsandFellowshipsRevenue>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPEDSIntercollegiateAthleticsExpens>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPEDSNaturalExpense>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIpedsOccupationalCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefIPSPProgressReportSchedule>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefIPSPProgressReportType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefISO6392Language>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefISO6393Language>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefISO6395LanguageFamily>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefItemResponseTheoryDifficultyCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefItemResponseTheoryKappaAlgorithm>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefK12EndOfCourseRequirement>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefK12LeaTitleISupportService>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefK12LeaTitleISupportService>()
                .HasMany(e => e.K12LeaTitleISupportService)
                .WithRequired(e => e.RefK12LeaTitleISupportService)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefK12ResponsibilityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefK12ResponsibilityType>()
                .HasMany(e => e.K12OrganizationStudentResponsibility)
                .WithRequired(e => e.RefK12ResponsibilityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefK12StaffClassification>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLanguage>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLanguage>()
                .HasMany(e => e.AssessmentAssets)
                .WithOptional(e => e.RefLanguage)
                .HasForeignKey(e => e.RefAssessmentLanguageId);

            modelBuilder.Entity<RefLanguage>()
                .HasMany(e => e.AssessmentForms)
                .WithOptional(e => e.RefLanguage)
                .HasForeignKey(e => e.RefAssessmentLanguageId);

            modelBuilder.Entity<RefLanguage>()
                .HasMany(e => e.AssessmentItemApipDescriptions)
                .WithOptional(e => e.RefLanguage)
                .HasForeignKey(e => e.RefKeywordTranslationLanguageId);

            modelBuilder.Entity<RefLanguage>()
                .HasMany(e => e.AssessmentLanguages)
                .WithRequired(e => e.RefLanguage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefLanguage>()
                .HasMany(e => e.AssessmentNeedApipContents)
                .WithOptional(e => e.RefLanguage)
                .HasForeignKey(e => e.ItemTranslationDisplayLanguageTypeId);

            modelBuilder.Entity<RefLanguage>()
                .HasMany(e => e.AssessmentNeedApipContents1)
                .WithOptional(e => e.RefLanguage1)
                .HasForeignKey(e => e.KeywordTranslationLanguageTypeId);

            modelBuilder.Entity<RefLanguage>()
                .HasMany(e => e.AssessmentPersonalNeedsProfileContents)
                .WithOptional(e => e.RefLanguage)
                .HasForeignKey(e => e.RefKeywordTranslationsLanguageId);

            modelBuilder.Entity<RefLanguage>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.RefLanguage)
                .HasForeignKey(e => e.RefInstructionLanguageId);

            modelBuilder.Entity<RefLanguage>()
                .HasMany(e => e.CourseSections)
                .WithOptional(e => e.RefLanguage)
                .HasForeignKey(e => e.RefInstructionLanguageId);

            modelBuilder.Entity<RefLanguage>()
                .HasMany(e => e.PersonLanguages)
                .WithRequired(e => e.RefLanguage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefLanguageUseType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLanguageUseType>()
                .HasMany(e => e.PersonLanguages)
                .WithRequired(e => e.RefLanguageUseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefLeaFundsTransferType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLeaImprovementStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearnerActionType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearnerActivityAddToGradeBookFlag>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefLearnerActivityMaximumTimeAllowedUnit>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearnerActivityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceAccessAPIType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceAccessHazardType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceAccessModeType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceAccessRightsUrl>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceAuthorType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceBookFormatType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceCompetencyAlignmentType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceControlFlexibilityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceDigitalMediaSubType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceDigitalMediaType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceEducationalUse>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceIntendedEndUserRole>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceInteractionMode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceInteractivityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceMediaFeatureType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourceMediaFeatureType>()
                .HasMany(e => e.LearningResourceMediaFeatures)
                .WithRequired(e => e.RefLearningResourceMediaFeatureType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefLearningResourcePhysicalMediaType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLearningResourcePhysicalMediaType>()
                .HasMany(e => e.LearningResourcePhysicalMedias)
                .WithRequired(e => e.RefLearningResourcePhysicalMediaType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefLearningResourceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLeaType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLeaveEventType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLevelOfInstitution>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLevelOfInstitution>()
                .HasMany(e => e.AeProviders)
                .WithRequired(e => e.RefLevelOfInstitution)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefLicenseExempt>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefLiteracyAssessment>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMagnetSpecialProgram>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMedicalAlertIndicator>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMepEnrollmentType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMepProjectBased>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMepProjectType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMepServiceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMepSessionType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMepStaffCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMethodOfServiceDelivery>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMilitaryActiveStudentIndicator>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMilitaryBranch>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefMilitaryConnectedStudentIndicator>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMilitaryVeteranStudentIndicator>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefMultipleIntelligenceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefNaepAspectsOfReading>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefNaepMathComplexityLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefNationalSchoolLunchProgramStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefNCESCollegeCourseMapCode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefNeedDeterminationMethod>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefNeglectedProgramType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefNonPromotionReason>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefNonTraditionalGenderStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefNSLPStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefNumberOfDependentsType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefONETSOCOccupationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefOperationalStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefOperationalStatu>()
                .HasMany(e => e.OrganizationOperationalStatus)
                .WithRequired(e => e.RefOperationalStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefOperationalStatusType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefOrganizationElementType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefOrganizationIdentificationSystem>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefOrganizationIdentifierType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefOrganizationIndicator>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefOrganizationIndicator>()
                .HasMany(e => e.OrganizationIndicators)
                .WithRequired(e => e.RefOrganizationIndicator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefOrganizationLocationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefOrganizationMonitoringNotification>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefOrganizationRelationship>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefOrganizationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefOtherNameType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefOutcomeTimePoint>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefOutOfFieldStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefParaprofessionalQualification>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefParticipationStatusAyp>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefParticipationStatusAyp>()
                .HasMany(e => e.OrganizationFederalAccountabilities)
                .WithOptional(e => e.RefParticipationStatusAyp)
                .HasForeignKey(e => e.RefParticipationStatusMathId);

            modelBuilder.Entity<RefParticipationStatusAyp>()
                .HasMany(e => e.OrganizationFederalAccountabilities1)
                .WithOptional(e => e.RefParticipationStatusAyp1)
                .HasForeignKey(e => e.RefParticipationStatusRlaId);

            modelBuilder.Entity<RefParticipationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPDActivityApprovedPurpose>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPDActivityCreditType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPDActivityEducationLevelsAddressed>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPDActivityLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPDActivityTargetAudience>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPDActivityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPDAudienceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPDDeliveryMethod>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPDInstructionalDeliveryMode>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPDSessionStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPersonalInformationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefPersonalInformationVerification>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPersonIdentificationSystem>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPersonIdentificationSystem>()
                .HasMany(e => e.PersonIdentifiers)
                .WithRequired(e => e.RefPersonIdentificationSystem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefPersonIdentifierType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPersonLocationType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPersonLocationType>()
                .HasMany(e => e.PersonAddresses)
                .WithRequired(e => e.RefPersonLocationType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefPersonRelationshipType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPersonRelationshipType>()
                .HasMany(e => e.PersonRelationships)
                .WithRequired(e => e.RefPersonRelationshipType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefPersonStatusType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPersonStatusType>()
                .HasMany(e => e.PersonStatus)
                .WithRequired(e => e.RefPersonStatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefPersonTelephoneNumberType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPESCAwardLevelType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefPopulationServed>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPreAndPostTestIndicator>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPredominantCalendarSystem>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPreKEligibleAgesNonIDEA>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPreKEligibleAgesNonIDEA>()
                .HasMany(e => e.K12LeaPreKEligibleAgesIDEA)
                .WithRequired(e => e.RefPreKEligibleAgesNonIDEA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefPrekindergartenEligibility>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPrekindergartenEligibility>()
                .HasMany(e => e.K12LeaPreKEligibility)
                .WithRequired(e => e.RefPrekindergartenEligibility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefPresentAttendanceCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPrimaryLearningDeviceAccess>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefPrimaryLearningDeviceAwayFromSchool>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefPrimaryLearningDeviceProvider>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefProfessionalDevelopmentFinancialSupport>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProfessionalEducationJobClassification>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProfessionalTechnicalCredentialType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProfessionalTechnicalCredentialType>()
                .HasMany(e => e.PsStudentAcademicRecords)
                .WithOptional(e => e.RefProfessionalTechnicalCredentialType)
                .HasForeignKey(e => e.RefProfessionalTechCredentialTypeId);

            modelBuilder.Entity<RefProficiencyStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProficiencyTargetAyp>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProficiencyTargetAyp>()
                .HasMany(e => e.OrganizationFederalAccountabilities)
                .WithOptional(e => e.RefProficiencyTargetAyp)
                .HasForeignKey(e => e.RefProficiencyTargetStatusMathId);

            modelBuilder.Entity<RefProficiencyTargetAyp>()
                .HasMany(e => e.OrganizationFederalAccountabilities1)
                .WithOptional(e => e.RefProficiencyTargetAyp1)
                .HasForeignKey(e => e.RefProficiencyTargetStatusRLAId);

            modelBuilder.Entity<RefProfitStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefProgramDayLength>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProgramDayLength>()
                .HasMany(e => e.K12ProgramOrService)
                .WithOptional(e => e.RefProgramDayLength)
                .HasForeignKey(e => e.RefPrekindergartenDailyLengthId);

            modelBuilder.Entity<RefProgramDayLength>()
                .HasMany(e => e.K12ProgramOrService1)
                .WithOptional(e => e.RefProgramDayLength1)
                .HasForeignKey(e => e.RefKindergartenDailyLengthId);

            modelBuilder.Entity<RefProgramEntryReason>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefProgramExitReason>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProgramGiftedEligibility>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProgramLengthHoursType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProgramSponsorType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProgramType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProgramType>()
                .HasMany(e => e.OrganizationProgramTypes)
                .WithRequired(e => e.RefProgramType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefProgressAchievingEnglishLanguageProficiencyIndicatorStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProgressLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPromotionReason>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefProofOfResidencyType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPsEnrollmentAction>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPsEnrollmentAwardType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPsEnrollmentStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPsEnrollmentType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPSExitOrWithdrawalType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPsLepType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPSProgramLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPsStudentLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPublicSchoolChoiceStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPublicSchoolResidence>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefPublicSchoolResidence>()
                .HasMany(e => e.K12StudentEnrollment)
                .WithOptional(e => e.RefPublicSchoolResidence1)
                .HasForeignKey(e => e.RefPublicSchoolResidence);

            modelBuilder.Entity<RefPurposeOfMonitoringVisit>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefQrisParticipation>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefRace>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefRace>()
                .HasMany(e => e.PersonDemographicRaces)
                .WithRequired(e => e.RefRace)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefReapAlternativeFundingStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefReasonDelayTransitionConf>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefReconstitutedStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefRecordStatusCreatorEntity>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefRecordStatusType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefRecordStatusType>()
                .HasMany(e => e.RecordStatus)
                .WithRequired(e => e.RefRecordStatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefRecordStatusType>()
                .HasMany(e => e.RecordStatusHistories)
                .WithRequired(e => e.RefRecordStatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefReferralOutcome>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefReimbursementType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefRestructuringAction>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefRlisProgramUse>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefRole>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefRoleStatus>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefRoleStatusType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSCEDCourseLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSCEDCourseSubjectArea>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSCEDCourseSubjectArea>()
                .HasMany(e => e.IndividualizedProgramAccommodationSubjects)
                .WithRequired(e => e.RefSCEDCourseSubjectArea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefScheduledWellChildScreening>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSchoolDangerousStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSchoolFoodServiceProgram>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSchoolFoodServiceProgram>()
                .HasMany(e => e.ProgramParticipationFoodServices)
                .WithRequired(e => e.RefSchoolFoodServiceProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefSchoolImprovementFund>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSchoolImprovementStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSchoolLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSchoolType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefScoreMetricType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefServiceFrequency>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefServiceOption>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefService>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSessionType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSex>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSigInterventionType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSingleSexClassStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSpaceUseType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSpecialEducationAgeGroupTaught>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSpecialEducationExitReason>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSpecialEducationStaffCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefSpecialEducationStaffCategory>()
                .HasMany(e => e.ServiceStaffs)
                .WithRequired(e => e.RefSpecialEducationStaffCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefStaffCompensationSourceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefStaffPerformanceLevel>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefStandardizedAdmissionTest>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefStandardizedAdmissionTest>()
                .HasMany(e => e.PsStudentAdmissionTests)
                .WithRequired(e => e.RefStandardizedAdmissionTest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefState>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefState>()
                .HasMany(e => e.PersonCredentials)
                .WithOptional(e => e.RefState)
                .HasForeignKey(e => e.RefIssuingStateId);

            modelBuilder.Entity<RefState>()
                .HasMany(e => e.PersonDetails)
                .WithOptional(e => e.RefState)
                .HasForeignKey(e => e.RefStateOfResidenceId);

            modelBuilder.Entity<RefState>()
                .HasMany(e => e.ProgramParticipationMigrants)
                .WithOptional(e => e.RefState)
                .HasForeignKey(e => e.RefQualifyingMoveFromStateId);

            modelBuilder.Entity<RefStateANSICode>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefStatePovertyDesignation>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefStudentEnrollmentAccessType>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefStudentSchoolAffiliationStateDefinedStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefStudentSupportServiceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefStudentSupportServiceType>()
                .HasMany(e => e.OrganizationServices)
                .WithRequired(e => e.RefStudentSupportServiceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefSupervisedClinicalExperience>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTargetedSupport>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTargetedSupportAndImprovementStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefTeacherEducationCredentialExam>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTeacherEducationExamScoreType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTeacherEducationTestCompany>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTeacherPrepCompleterStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTeacherPrepEnrollmentStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTeachingAssignmentRole>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTeachingCredentialBasi>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTeachingCredentialType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTechnicalAssistanceDeliveryType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTechnicalAssistanceType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTechnologyLiteracyStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTelephoneNumberListedStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefTelephoneNumberType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTenureSystem>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTextComplexitySystem>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTimeForCompletionUnit>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTitleIIIAccountability>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTitleIIILanguageInstructionProgramType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTitleIIILanguageInstructionProgramType>()
                .HasMany(e => e.K12TitleIIILanguageInstruction)
                .WithRequired(e => e.RefTitleIIILanguageInstructionProgramType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefTitleIIIProfessionalDevelopmentType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTitleIIIProfessionalDevelopmentType>()
                .HasMany(e => e.K12LeaTitleIIIProfessionalDevelopment)
                .WithRequired(e => e.RefTitleIIIProfessionalDevelopmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefTitleIIndicator>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTitleIInstructionalService>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTitleIProgramStaffCategory>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTitleIProgramType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTitleISchoolStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTransferOutIndicator>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTransferReady>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTribalAffiliation>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefTrimesterWhenPrenatalCareBegan>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTuitionResidencyType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefTuitionUnit>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefUSCitizenshipStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefVirtualSchoolStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefVisaType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefVisionScreeningStatu>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefWageCollectionMethod>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefWageVerification>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefWeaponType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefWfProgramParticipation>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RefWIOABarrierstoEmployment>()
                .Property(e => e.SortOrder)
                .HasPrecision(6, 2);

            modelBuilder.Entity<RefWorkbasedLearningOpportunityType>()
                .Property(e => e.SortOrder)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.OrganizationPersonRoles)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoleAttendance>()
                .Property(e => e.NumberOfDaysInAttendance)
                .HasPrecision(9, 2);

            modelBuilder.Entity<RoleAttendance>()
                .Property(e => e.NumberOfDaysAbsent)
                .HasPrecision(9, 2);

            modelBuilder.Entity<RoleAttendance>()
                .Property(e => e.AttendanceRate)
                .HasPrecision(5, 4);

            modelBuilder.Entity<RoleAttendance>()
                .Property(e => e.NumberOfDaysTardy)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Rubric>()
                .HasMany(e => e.CompetencySet_Rubric)
                .WithRequired(e => e.Rubric)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rubric>()
                .HasMany(e => e.RubricCriterions)
                .WithRequired(e => e.Rubric)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RubricCriterion>()
                .Property(e => e.Weight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RubricCriterion>()
                .HasMany(e => e.CompetencySet_RubricCriterion)
                .WithRequired(e => e.RubricCriterion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RubricCriterion>()
                .HasMany(e => e.RubricCriterionLevels)
                .WithRequired(e => e.RubricCriterion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RubricCriterionLevel>()
                .Property(e => e.Score)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RubricCriterionLevel>()
                .HasMany(e => e.AssessmentItemRubricCriterionResults)
                .WithRequired(e => e.RubricCriterionLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RubricCriterionLevel>()
                .HasMany(e => e.AssessmentResultRubricCriterionResults)
                .WithRequired(e => e.RubricCriterionLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServicePlan>()
                .HasMany(e => e.ServiceFrequencies)
                .WithRequired(e => e.ServicePlan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServicePlan>()
                .HasMany(e => e.ServicesReceiveds)
                .WithRequired(e => e.ServicePlan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceProvided>()
                .HasMany(e => e.ServiceProviders)
                .WithRequired(e => e.ServiceProvided)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServicesReceived>()
                .Property(e => e.FullTimeEquivalency)
                .HasPrecision(3, 2);

            modelBuilder.Entity<ServicesReceived>()
                .HasMany(e => e.IndividualizedProgramServicesReceiveds)
                .WithRequired(e => e.ServicesReceived)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServicesReceived>()
                .HasMany(e => e.ServiceProvideds)
                .WithRequired(e => e.ServicesReceived)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceStaff>()
                .HasMany(e => e.ServiceProviders)
                .WithRequired(e => e.ServiceStaff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StaffCompensation>()
                .Property(e => e.StaffCompensationAnnualSupplement)
                .HasPrecision(9, 2);

            modelBuilder.Entity<StaffCompensation>()
                .Property(e => e.StaffCompensationBaseSalary)
                .HasPrecision(9, 2);

            modelBuilder.Entity<StaffCompensation>()
                .Property(e => e.StaffCompensationHealthBenefits)
                .HasPrecision(9, 2);

            modelBuilder.Entity<StaffCompensation>()
                .Property(e => e.StaffCompensationLongevity)
                .HasPrecision(9, 2);

            modelBuilder.Entity<StaffCompensation>()
                .Property(e => e.StaffCompensationOtherBenefits)
                .HasPrecision(9, 2);

            modelBuilder.Entity<StaffCompensation>()
                .Property(e => e.StaffCompensationRetirementBenefits)
                .HasPrecision(9, 2);

            modelBuilder.Entity<StaffCompensation>()
                .Property(e => e.StaffCompensationTotalBenefits)
                .HasPrecision(9, 2);

            modelBuilder.Entity<StaffCompensation>()
                .Property(e => e.StaffCompensationTotalSalary)
                .HasPrecision(9, 2);

            modelBuilder.Entity<StaffEmployment>()
                .Property(e => e.StandardOccupationalClassification)
                .IsFixedLength();

            modelBuilder.Entity<StaffEmployment>()
                .Property(e => e.FullTimeEquivalency)
                .HasPrecision(5, 4);

            modelBuilder.Entity<StaffEmployment>()
                .HasMany(e => e.ELStaffEmployments)
                .WithRequired(e => e.StaffEmployment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StaffEmployment>()
                .HasMany(e => e.K12StaffEmployment)
                .WithRequired(e => e.StaffEmployment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StaffEmployment>()
                .HasMany(e => e.PsStaffEmployments)
                .WithRequired(e => e.StaffEmployment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StaffEmployment>()
                .HasMany(e => e.StaffCompensations)
                .WithRequired(e => e.StaffEmployment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StaffExperience>()
                .Property(e => e.YearsOfPriorTeachingExperience)
                .HasPrecision(9, 2);

            modelBuilder.Entity<StaffExperience>()
                .Property(e => e.YearsOfPriorAETeachingExperience)
                .HasPrecision(9, 2);

            modelBuilder.Entity<StaffProfessionalDevelopmentActivity>()
                .Property(e => e.NumberOfCreditsEarned)
                .HasPrecision(10, 2);

            modelBuilder.Entity<StaffProfessionalDevelopmentActivity>()
                .HasMany(e => e.CoreKnowledgeAreas)
                .WithRequired(e => e.StaffProfessionalDevelopmentActivity)
                .HasForeignKey(e => e.ProfessionalDevelopmentActivityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkforceEmploymentQuarterlyData>()
                .Property(e => e.EmployedInMultipleJobsCount)
                .HasPrecision(2, 0);

            modelBuilder.Entity<WorkforceProgramParticipantCohort>()
                .Property(e => e.CohortMedianEarnings)
                .HasPrecision(9, 2);

            modelBuilder.Entity<WorkforceProgramParticipation>()
                .Property(e => e.DiplomaOrCredentialAwardDate)
                .IsFixedLength();

            modelBuilder.Entity<C_CEDStoNDSMapping>()
                .Property(e => e.GlobalID)
                .IsUnicode(false);

            modelBuilder.Entity<C_CEDStoNDSMapping>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<C_CEDStoNDSMapping>()
                .Property(e => e.ColumnName)
                .IsUnicode(false);
        }
    }
}
