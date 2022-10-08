using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("DataCollection", Schema = "Common")]
    public partial class DataCollection
    {
        public DataCollection()
        {
            Activities = new HashSet<Activity>();
            ActivityRecognitions = new HashSet<ActivityRecognition>();
            AeCourses = new HashSet<AeCourse>();
            AeProviders = new HashSet<AeProvider>();
            AeStaffs = new HashSet<AeStaff>();
            AeStudentAcademicRecords = new HashSet<AeStudentAcademicRecord>();
            AeStudentEmployments = new HashSet<AEStudentEmployment>();
            ApipInteractions = new HashSet<ApipInteraction>();
            Applications = new HashSet<Application>();
            AssessmentAccommodations = new HashSet<AssessmentAccommodation>();
            AssessmentAdministrationOrganizations = new HashSet<AssessmentAdministrationOrganization>();
            AssessmentAdministrations = new HashSet<AssessmentAdministration>();
            AssessmentAssessmentAdministrations = new HashSet<AssessmentAssessmentAdministration>();
            AssessmentAssets = new HashSet<AssessmentAsset>();
            AssessmentEldevelopmentalDomains = new HashSet<AssessmentELDevelopmentalDomain>();
            AssessmentFormAssessmentAssets = new HashSet<AssessmentFormAssessmentAsset>();
            AssessmentFormAssessmentFormSections = new HashSet<AssessmentFormAssessmentFormSection>();
            AssessmentFormSectionAssessmentAssets = new HashSet<AssessmentFormSectionAssessmentAsset>();
            AssessmentFormSectionAssessmentItems = new HashSet<AssessmentFormSectionAssessmentItem>();
            AssessmentFormSections = new HashSet<AssessmentFormSection>();
            AssessmentForms = new HashSet<AssessmentForm>();
            AssessmentItemApipDescriptions = new HashSet<AssessmentItemApipDescription>();
            AssessmentItemApips = new HashSet<AssessmentItemApip>();
            AssessmentItemCharacteristics = new HashSet<AssessmentItemCharacteristic>();
            AssessmentItemPossibleResponses = new HashSet<AssessmentItemPossibleResponse>();
            AssessmentItemResponseTheories = new HashSet<AssessmentItemResponseTheory>();
            AssessmentItemResponses = new HashSet<AssessmentItemResponse>();
            AssessmentItemRubricCriterionResults = new HashSet<AssessmentItemRubricCriterionResult>();
            AssessmentItems = new HashSet<AssessmentItem>();
            AssessmentLanguages = new HashSet<AssessmentLanguage>();
            AssessmentLevelsForWhichDesigneds = new HashSet<AssessmentLevelsForWhichDesigned>();
            AssessmentNeedApipContents = new HashSet<AssessmentNeedApipContent>();
            AssessmentNeedApipControls = new HashSet<AssessmentNeedApipControl>();
            AssessmentNeedApipDisplays = new HashSet<AssessmentNeedApipDisplay>();
            AssessmentNeedBrailles = new HashSet<AssessmentNeedBraille>();
            AssessmentNeedScreenEnhancements = new HashSet<AssessmentNeedScreenEnhancement>();
            AssessmentParticipantSessionAccommodations = new HashSet<AssessmentParticipantSessionAccommodation>();
            AssessmentParticipantSessions = new HashSet<AssessmentParticipantSession>();
            AssessmentPerformanceLevels = new HashSet<AssessmentPerformanceLevel>();
            AssessmentPersonalNeedLanguageLearners = new HashSet<AssessmentPersonalNeedLanguageLearner>();
            AssessmentPersonalNeedScreenReaders = new HashSet<AssessmentPersonalNeedScreenReader>();
            AssessmentPersonalNeedsProfileContents = new HashSet<AssessmentPersonalNeedsProfileContent>();
            AssessmentPersonalNeedsProfileControls = new HashSet<AssessmentPersonalNeedsProfileControl>();
            AssessmentPersonalNeedsProfileDisplays = new HashSet<AssessmentPersonalNeedsProfileDisplay>();
            AssessmentPersonalNeedsProfileScreenEnhancements = new HashSet<AssessmentPersonalNeedsProfileScreenEnhancement>();
            AssessmentPersonalNeedsProfiles = new HashSet<AssessmentPersonalNeedsProfile>();
            AssessmentRegistrationAccommodations = new HashSet<AssessmentRegistrationAccommodation>();
            AssessmentRegistrations = new HashSet<AssessmentRegistration>();
            AssessmentResultPerformanceLevels = new HashSet<AssessmentResultPerformanceLevel>();
            AssessmentResultRubricCriterionResults = new HashSet<AssessmentResultRubricCriterionResult>();
            AssessmentResults = new HashSet<AssessmentResult>();
            AssessmentSessionStaffRoles = new HashSet<AssessmentSessionStaffRole>();
            AssessmentSessions = new HashSet<AssessmentSession>();
            AssessmentSubtestAssessmentItems = new HashSet<AssessmentSubtestAssessmentItem>();
            AssessmentSubtestCompetencyDefinitions = new HashSet<AssessmentSubtestCompetencyDefinition>();
            AssessmentSubtestEldevelopmentalDomains = new HashSet<AssessmentSubtestELDevelopmentalDomain>();
            AssessmentSubtestLevelsForWhichDesigneds = new HashSet<AssessmentSubtestLevelsForWhichDesigned>();
            AssessmentSubtests = new HashSet<AssessmentSubTest>();
            Assessments = new HashSet<Assessment>();
            Authentications = new HashSet<Authentication>();
            AuthorizationDocuments = new HashSet<AuthorizationDocument>();
            Authorizations = new HashSet<Authorization>();
            BuildingSpaceUtilizations = new HashSet<BuildingSpaceUtilization>();
            BuildingSpaces = new HashSet<BuildingSpace>();
            BuildingSystemCategories = new HashSet<BuildingSystemCategory>();
            BuildingSystemComponentServices = new HashSet<BuildingSystemComponentService>();
            BuildingSystemComponents = new HashSet<BuildingSystemComponent>();
            Classrooms = new HashSet<Classroom>();
            CompetencyDefAssociations = new HashSet<CompetencyDefAssociation>();
            CompetencyDefEducationLevels = new HashSet<CompetencyDefEducationLevel>();
            CompetencyDefinitionCompetencySets = new HashSet<CompetencyDefinitionCompetencySet>();
            CompetencyDefinitions = new HashSet<CompetencyDefinition>();
            CompetencyFrameworks = new HashSet<CompetencyFramework>();
            CompetencySetRubricCriteria = new HashSet<CompetencySetRubricCriterion>();
            CompetencySetRubrics = new HashSet<CompetencySetRubric>();
            CompetencySets = new HashSet<CompetencySet>();
            CoreKnowledgeAreas = new HashSet<CoreKnowledgeArea>();
            CourseSectionAssessmentReportings = new HashSet<CourseSectionAssessmentReporting>();
            CourseSectionLevels = new HashSet<CourseSectionLevel>();
            CourseSectionLocations = new HashSet<CourseSectionLocation>();
            CourseSectionSchedules = new HashSet<CourseSectionSchedule>();
            CourseSections = new HashSet<CourseSection>();
            Courses = new HashSet<Course>();
            CredentialAwardCredits = new HashSet<CredentialAwardCredit>();
            CredentialAwardEvidences = new HashSet<CredentialAwardEvidence>();
            CredentialAwards = new HashSet<CredentialAward>();
            CredentialCriteriaCourses = new HashSet<CredentialCriteriaCourse>();
            CredentialDefAgentCredentials = new HashSet<CredentialDefAgentCredential>();
            CredentialDefAgents = new HashSet<CredentialDefAgent>();
            CredentialDefCategories = new HashSet<CredentialDefCategory>();
            CredentialDefCriteria = new HashSet<CredentialDefCriterion>();
            CredentialDefIdentifiers = new HashSet<CredentialDefIdentifier>();
            CredentialDefinitions = new HashSet<CredentialDefinition>();
            CredentialIssuers = new HashSet<CredentialIssuer>();
            CredentialOffereds = new HashSet<CredentialOffered>();
            CteCourses = new HashSet<CteCourse>();
            CteStudentAcademicRecords = new HashSet<CteStudentAcademicRecord>();
            EarlyChildhoodCredentials = new HashSet<EarlyChildhoodCredential>();
            EarlyChildhoodProgramTypeOffereds = new HashSet<EarlyChildhoodProgramTypeOffered>();
            ElchildDemographics = new HashSet<ELChildDemographic>();
            ElchildDevelopmentalAssessments = new HashSet<ELChildDevelopmentalAssessment>();
            ElchildHealths = new HashSet<ELChildHealth>();
            ElchildIndividualizedPrograms = new HashSet<ELChildIndividualizedProgram>();
            ElchildOutcomeSummaries = new HashSet<ELChildOutcomeSummary>();
            ElchildProgramEligibilities = new HashSet<ELChildProgramEligibility>();
            ElchildServices = new HashSet<ELChildService>();
            ElchildServicesApplications = new HashSet<ELChildServicesApplication>();
            ElchildTransitionPlans = new HashSet<ELChildTransitionPlan>();
            ElclassSectionServices = new HashSet<ELClassSectionService>();
            ElclassSections = new HashSet<ELClassSection>();
            ElenrollmentOtherFundings = new HashSet<ELEnrollmentOtherFunding>();
            Elenrollments = new HashSet<ELEnrollment>();
            ElfacilityLicensings = new HashSet<ELFacilityLicensing>();
            EligibilityEvaluations = new HashSet<EligibilityEvaluation>();
            ElorganizationAvailabilities = new HashSet<ELOrganizationAvailability>();
            ElorganizationFunds = new HashSet<ELOrganizationFunds>();
            ElorganizationMonitorings = new HashSet<ELOrganizationMonitoring>();
            Elorganizations = new HashSet<ELOrganization>();
            ElprogramLicensings = new HashSet<ELProgramLicensing>();
            ElqualityInitiatives = new HashSet<ELQualityInitiative>();
            ElqualityRatingImprovements = new HashSet<ELQualityRatingImprovement>();
            ElservicePartners = new HashSet<ELServicePartner>();
            ElstaffAssignments = new HashSet<ELStaffAssignment>();
            ElstaffEducations = new HashSet<ELStaffEducation>();
            ElstaffEmployments = new HashSet<ELStaffEmployment>();
            Elstaffs = new HashSet<ELStaff>();
            Facilities = new HashSet<Facility>();
            FacilityAudits = new HashSet<FacilityAudit>();
            FacilityCompliances = new HashSet<FacilityCompliance>();
            FacilityDesignConstructions = new HashSet<FacilityDesignConstruction>();
            FacilityDesigns = new HashSet<FacilityDesign>();
            FacilityEnergies = new HashSet<FacilityEnergy>();
            FacilityFinances = new HashSet<FacilityFinance>();
            FacilityFinancials = new HashSet<FacilityFinancial>();
            FacilityHazards = new HashSet<FacilityHazard>();
            FacilityJointUses = new HashSet<FacilityJointUse>();
            FacilityLeases = new HashSet<FacilityLease>();
            FacilityLocations = new HashSet<FacilityLocation>();
            FacilityManagementPlans = new HashSet<FacilityManagementPlan>();
            FacilityManagements = new HashSet<FacilityManagement>();
            FacilityMandates = new HashSet<FacilityMandate>();
            FacilityMortgageFees = new HashSet<FacilityMortgageFee>();
            FacilityMortgages = new HashSet<FacilityMortgage>();
            FacilityRelationships = new HashSet<FacilityRelationship>();
            FacilitySchoolDesigns = new HashSet<FacilitySchoolDesign>();
            FacilitySites = new HashSet<FacilitySite>();
            FacilityUtilizations = new HashSet<FacilityUtilization>();
            FinancialAccountPrograms = new HashSet<FinancialAccountProgram>();
            FinancialAccounts = new HashSet<FinancialAccount>();
            FinancialAidApplications = new HashSet<FinancialAidApplication>();
            FinancialAidAwards = new HashSet<FinancialAidAward>();
            GoalMeasurementCriteria = new HashSet<GoalMeasurementCriterion>();
            GoalMeasurements = new HashSet<GoalMeasurement>();
            GoalPerformances = new HashSet<GoalPerformance>();
            Goals = new HashSet<Goal>();
            IdeaeligibilityEvaluationCategories = new HashSet<IDEAEligibilityEvaluationCategory>();
            IepauthorizationRejecteds = new HashSet<IEPAuthorizationRejected>();
            Iepauthorizations = new HashSet<IEPAuthorization>();
            IeppresentLevels = new HashSet<IEPPresentLevel>();
            IncidentPeople = new HashSet<IncidentPerson>();
            Incidents = new HashSet<Incident>();
            IndividualizedProgramAccommodationSubjects = new HashSet<IndividualizedProgramAccommodationSubject>();
            IndividualizedProgramAccommodations = new HashSet<IndividualizedProgramAccommodation>();
            IndividualizedProgramAmendments = new HashSet<IndividualizedProgramAmendment>();
            IndividualizedProgramAssessmentAccommodations = new HashSet<IndividualizedProgramAssessmentAccommodation>();
            IndividualizedProgramAssessments = new HashSet<IndividualizedProgramAssessment>();
            IndividualizedProgramEligibilities = new HashSet<IndividualizedProgramEligibility>();
            IndividualizedProgramEligibilityEvaluations = new HashSet<IndividualizedProgramEligibilityEvaluation>();
            IndividualizedProgramGoals = new HashSet<IndividualizedProgramGoal>();
            IndividualizedProgramMeetingAttendees = new HashSet<IndividualizedProgramMeetingAttendee>();
            IndividualizedProgramMeetings = new HashSet<IndividualizedProgramMeeting>();
            IndividualizedProgramProgressGoals = new HashSet<IndividualizedProgramProgressGoal>();
            IndividualizedProgramProgressReportPlans = new HashSet<IndividualizedProgramProgressReportPlan>();
            IndividualizedProgramProgressReports = new HashSet<IndividualizedProgramProgressReport>();
            IndividualizedProgramServices = new HashSet<IndividualizedProgramService>();
            IndividualizedProgramServicesReceiveds = new HashSet<IndividualizedProgramServicesReceived>();
            IndividualizedPrograms = new HashSet<IndividualizedProgram>();
            Ipedsfinances = new HashSet<IPEDSFinance>();
            K12charterSchoolAuthorizerAgencies = new HashSet<K12CharterSchoolAuthorizerAgency>();
            K12charterSchoolManagementOrganizations = new HashSet<K12CharterSchoolManagementOrganization>();
            K12courses = new HashSet<K12Course>();
            K12federalFundAllocations = new HashSet<K12FederalFundAllocation>();
            K12leaFederalFunds = new HashSet<K12LeaFederalFunds>();
            K12leaFederalReportings = new HashSet<K12LeaFederalReporting>();
            K12leaGradeLevelsApproveds = new HashSet<K12LeaGradeLevelsApproved>();
            K12leaGradeOffereds = new HashSet<K12LeaGradeOffered>();
            K12leaPreKeligibilities = new HashSet<K12LeaPreKEligibility>();
            K12leaPreKeligibleAgesIdeas = new HashSet<K12leaPreKeligibleAgesIdea>();
            K12leaSafeDrugFrees = new HashSet<K12LeaSafeDrugFree>();
            K12leaTitleIiiprofessionalDevelopments = new HashSet<K12LeaTitleIIIProfessionalDevelopment>();
            K12leaTitleIsupportServices = new HashSet<K12LeaTitleISupportService>();
            K12leas = new HashSet<K12Lea>();
            K12organizationStudentResponsibilities = new HashSet<K12OrganizationStudentResponsibility>();
            K12programOrServices = new HashSet<K12ProgramOrService>();
            K12schoolCorrectiveActions = new HashSet<K12SchoolCorrectiveAction>();
            K12schoolGradeLevelsApproveds = new HashSet<K12SchoolGradeLevelsApproved>();
            K12schoolGradeOffereds = new HashSet<K12SchoolGradeOffered>();
            K12schoolImprovements = new HashSet<K12SchoolImprovement>();
            K12schoolIndicatorStatuses = new HashSet<K12SchoolIndicatorStatus>();
            K12schoolStatuses = new HashSet<K12SchoolStatus>();
            K12schools = new HashSet<K12School>();
            K12seaAlternateFundUses = new HashSet<K12SeaAlternateFundUse>();
            K12seaFederalFunds = new HashSet<K12seaFederalFund>();
            K12seas = new HashSet<K12Sea>();
            K12staffAssignments = new HashSet<K12StaffAssignment>();
            K12staffEmployments = new HashSet<K12StaffEmployment>();
            K12studentAcademicHonors = new HashSet<K12StudentAcademicHonor>();
            K12studentAcademicRecords = new HashSet<K12StudentAcademicRecord>();
            K12studentActivities = new HashSet<K12StudentActivity>();
            K12studentCohorts = new HashSet<K12StudentCohort>();
            K12studentCourseSectionMarks = new HashSet<K12StudentCourseSectionMark>();
            K12studentCourseSections = new HashSet<K12StudentCourseSection>();
            K12studentDisciplines = new HashSet<K12StudentDiscipline>();
            K12studentEmployments = new HashSet<K12StudentEmployment>();
            K12studentEnrollments = new HashSet<K12StudentEnrollment>();
            K12studentGraduationPlans = new HashSet<K12StudentGraduationPlan>();
            K12studentHomeLanguageSurveys = new HashSet<K12StudentHomeLanguageSurvey>();
            K12studentLiteracyAssessments = new HashSet<K12StudentLiteracyAssessment>();
            K12studentSessions = new HashSet<K12StudentSession>();
            K12titleIiilanguageInstructions = new HashSet<K12TitleIIILanguageInstruction>();
            LearnerActions = new HashSet<LearnerAction>();
            LearnerActivities = new HashSet<LearnerActivity>();
            LearnerActivityLearningResources = new HashSet<LearnerActivityLearningResource>();
            LearningResourceAdaptations = new HashSet<LearningResourceAdaptation>();
            LearningResourceEducationLevels = new HashSet<LearningResourceEducationLevel>();
            LearningResourceMediaFeatures = new HashSet<LearningResourceMediaFeature>();
            LearningResourcePeerRatings = new HashSet<LearningResourcePeerRating>();
            LearningResourcePhysicalMedia = new HashSet<LearningResourcePhysicalMedium>();
            LearningResources = new HashSet<LearningResource>();
            LocationAddresses = new HashSet<LocationAddress>();
            Locations = new HashSet<Location>();
            OrganizationAccreditations = new HashSet<OrganizationAccreditation>();
            OrganizationCalendarCrises = new HashSet<OrganizationCalendarCrisis>();
            OrganizationCalendarDays = new HashSet<OrganizationCalendarDay>();
            OrganizationCalendarEvents = new HashSet<OrganizationCalendarEvent>();
            OrganizationCalendarSessions = new HashSet<OrganizationCalendarSession>();
            OrganizationCalendars = new HashSet<OrganizationCalendar>();
            OrganizationDetails = new HashSet<OrganizationDetail>();
            OrganizationEmails = new HashSet<OrganizationEmail>();
            OrganizationEmployeeBenefits = new HashSet<OrganizationEmployeeBenefit>();
            OrganizationFederalAccountabilities = new HashSet<OrganizationFederalAccountability>();
            OrganizationFinancials = new HashSet<OrganizationFinancial>();
            OrganizationIdentifiers = new HashSet<OrganizationIdentifier>();
            OrganizationImages = new HashSet<OrganizationImage>();
            OrganizationIndicators = new HashSet<OrganizationIndicator>();
            OrganizationLocations = new HashSet<OrganizationLocation>();
            OrganizationOperationalStatuses = new HashSet<OrganizationOperationalStatus>();
            OrganizationPersonRoleApplications = new HashSet<OrganizationPersonRoleApplication>();
            OrganizationPersonRoleFtes = new HashSet<OrganizationPersonRoleFTE>();
            OrganizationPersonRoleRelationships = new HashSet<OrganizationPersonRoleRelationship>();
            OrganizationPersonRoles = new HashSet<OrganizationPersonRole>();
            OrganizationPolicies = new HashSet<OrganizationPolicy>();
            OrganizationPopulationServeds = new HashSet<OrganizationPopulationServed>();
            OrganizationProgramTypes = new HashSet<OrganizationProgramType>();
            OrganizationRelationships = new HashSet<OrganizationRelationship>();
            OrganizationServices = new HashSet<OrganizationService>();
            OrganizationTechnicalAssistances = new HashSet<OrganizationTechnicalAssistance>();
            OrganizationTelephones = new HashSet<OrganizationTelephone>();
            OrganizationWebsites = new HashSet<OrganizationWebsite>();
            Organizations = new HashSet<Organization>();
            PdactivityEducationLevels = new HashSet<PDActivityEducationLevel>();
            PeerRatingSystems = new HashSet<PeerRatingSystem>();
            People = new HashSet<Person>();
            PersonAddressNcesSides = new HashSet<PersonAddressNcesSide>();
            PersonAddresses = new HashSet<PersonAddress>();
            PersonAllergies = new HashSet<PersonAllergy>();
            PersonAssessmentPersonalNeedsProfiles = new HashSet<PersonAssessmentPersonalNeedsProfile>();
            PersonBirthplaces = new HashSet<PersonBirthplace>();
            PersonCareerEducationPlans = new HashSet<PersonCareerEducationPlan>();
            PersonCredentials = new HashSet<PersonCredential>();
            PersonDegreeOrCertificates = new HashSet<PersonDegreeOrCertificate>();
            PersonDemographicRaces = new HashSet<PersonDemographicRace>();
            PersonDetails = new HashSet<PersonDetail>();
            PersonDigitalAccessSpeeds = new HashSet<PersonDigitalAccessSpeed>();
            PersonDigitalAccesses = new HashSet<PersonDigitalAccess>();
            PersonDisabilities = new HashSet<PersonDisability>();
            PersonEmailAddresses = new HashSet<PersonEmailAddress>();
            PersonFamilies = new HashSet<PersonFamily>();
            PersonHealthBirths = new HashSet<PersonHealthBirth>();
            PersonHealths = new HashSet<PersonHealth>();
            PersonHomelessnesses = new HashSet<PersonHomelessness>();
            PersonIdentifiers = new HashSet<PersonIdentifier>();
            PersonImmunizations = new HashSet<PersonImmunization>();
            PersonLanguages = new HashSet<PersonLanguage>();
            PersonLearningDevices = new HashSet<PersonLearningDevice>();
            PersonMasters = new HashSet<PersonMaster>();
            PersonMilitaries = new HashSet<PersonMilitary>();
            PersonOtherNames = new HashSet<PersonOtherName>();
            PersonPersonalInformationVerifications = new HashSet<PersonPersonalInformationVerification>();
            PersonProgramParticipations = new HashSet<PersonProgramParticipation>();
            PersonReferrals = new HashSet<PersonReferral>();
            PersonRelationships = new HashSet<PersonRelationship>();
            PersonStatuses = new HashSet<PersonStatus>();
            PersonTelephones = new HashSet<PersonTelephone>();
            ProfessionalDevelopmentActivities = new HashSet<ProfessionalDevelopmentActivity>();
            ProfessionalDevelopmentRequirements = new HashSet<ProfessionalDevelopmentRequirement>();
            ProfessionalDevelopmentSessionInstructors = new HashSet<ProfessionalDevelopmentSessionInstructor>();
            ProfessionalDevelopmentSessions = new HashSet<ProfessionalDevelopmentSession>();
            ProgramParticipationAes = new HashSet<ProgramParticipationAE>();
            ProgramParticipationAttainments = new HashSet<ProgramParticipationAttainment>();
            ProgramParticipationCtes = new HashSet<ProgramParticipationCte>();
            ProgramParticipationFoodServices = new HashSet<ProgramParticipationFoodService>();
            ProgramParticipationMigrants = new HashSet<ProgramParticipationMigrant>();
            ProgramParticipationNeglecteds = new HashSet<ProgramParticipationNeglected>();
            ProgramParticipationSpecialEducations = new HashSet<ProgramParticipationSpecialEducation>();
            ProgramParticipationTeacherPreps = new HashSet<ProgramParticipationTeacherPrep>();
            ProgramParticipationTitleIiileps = new HashSet<ProgramParticipationTitleIIILep>();
            ProgramParticipationTitleIs = new HashSet<ProgramParticipationTitleI>();
            ProgramParticipationWioabarriers = new HashSet<ProgramParticipationWIOABarriers>();
            ProgramParticipationWioas = new HashSet<ProgramParticipationWIOA>();
            Programs = new HashSet<Program>();
            PsCourses = new HashSet<PsCourse>();
            PsInstitutions = new HashSet<PsInstitution>();
            PsPriceOfAttendances = new HashSet<PsPriceOfAttendance>();
            PsPrograms = new HashSet<PsProgram>();
            PsSectionLocations = new HashSet<PsSectionLocation>();
            PsSections = new HashSet<PsSection>();
            PsStaffEmployments = new HashSet<PsStaffEmployment>();
            PsStudentAcademicAwards = new HashSet<PsStudentAcademicAward>();
            PsStudentAcademicRecords = new HashSet<PsStudentAcademicRecord>();
            PsStudentAdmissionTests = new HashSet<PsStudentAdmissionTest>();
            PsStudentApplications = new HashSet<PsStudentApplication>();
            PsStudentCohorts = new HashSet<PsStudentCohort>();
            PsStudentCourseSectionMarks = new HashSet<PsStudentCourseSectionMark>();
            PsStudentDemographics = new HashSet<PsStudentDemographic>();
            PsStudentEmployments = new HashSet<PsStudentEmployment>();
            PsStudentEnrollments = new HashSet<PsStudentEnrollment>();
            PsStudentFinancialAids = new HashSet<PsStudentFinancialAid>();
            PsStudentSections = new HashSet<PsStudentSection>();
            PsstudentPrograms = new HashSet<PSStudentProgram>();
            QuarterlyEmploymentRecords = new HashSet<QuarterlyEmploymentRecord>();
            RequiredImmunizations = new HashSet<RequiredImmunization>();
            RoleAttendanceEvents = new HashSet<RoleAttendanceEvent>();
            RoleAttendances = new HashSet<RoleAttendance>();
            RoleStatuses = new HashSet<RoleStatus>();
            Roles = new HashSet<Role>();
            RubricCriteria = new HashSet<RubricCriterion>();
            RubricCriterionLevels = new HashSet<RubricCriterionLevel>();
            Rubrics = new HashSet<Rubric>();
            ServiceFrequencies = new HashSet<ServiceFrequency>();
            ServicePlans = new HashSet<ServicePlan>();
            ServiceProvideds = new HashSet<ServiceProvided>();
            ServiceProviders = new HashSet<ServiceProvider>();
            ServiceStaffs = new HashSet<ServiceStaff>();
            ServicesReceiveds = new HashSet<ServicesReceived>();
            StaffCompensations = new HashSet<StaffCompensation>();
            StaffCredentials = new HashSet<StaffCredential>();
            StaffEmployments = new HashSet<StaffEmployment>();
            StaffEvaluationParts = new HashSet<StaffEvaluationPart>();
            StaffEvaluations = new HashSet<StaffEvaluation>();
            StaffExperiences = new HashSet<StaffExperience>();
            StaffProfessionalDevelopmentActivities = new HashSet<StaffProfessionalDevelopmentActivity>();
            StaffTechnicalAssistances = new HashSet<StaffTechnicalAssistance>();
            TeacherEducationCredentialExams = new HashSet<TeacherEducationCredentialExam>();
            TeacherStudentDataLinkExclusions = new HashSet<TeacherStudentDataLinkExclusion>();
            WorkforceEmploymentQuarterlyData = new HashSet<WorkforceEmploymentQuarterlyDatum>();
            WorkforceProgramParticipantCohorts = new HashSet<WorkforceProgramParticipantCohort>();
            WorkforceProgramParticipations = new HashSet<WorkforceProgramParticipation>();
        }

        [Key]
        public int DataCollectionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(4)]
        public string? DataCollectionAcademicSchoolYear { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DataCollectionCloseDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? DataCollectionDescription { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(100)]
        public string? DataCollectionName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(4)]
        public string? DataCollectionSchoolYear { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(36)]
        public string? SourceSystemDataCollectionIdentifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(100)]
        public string? SourceSystemName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DataCollectionOpenDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDataCollectionStatusId { get; set; }

        [ForeignKey("RefDataCollectionStatusId")]
        [InverseProperty("DataCollections")]
        public virtual RefDataCollectionStatus? RefDataCollectionStatus { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Activity> Activities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ActivityRecognition> ActivityRecognitions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AeCourse> AeCourses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AeProvider> AeProviders { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AeStaff> AeStaffs { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AeStudentAcademicRecord> AeStudentAcademicRecords { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AEStudentEmployment> AeStudentEmployments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ApipInteraction> ApipInteractions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Application> Applications { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentAccommodation> AssessmentAccommodations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentAdministrationOrganization> AssessmentAdministrationOrganizations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentAdministration> AssessmentAdministrations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentAssessmentAdministration> AssessmentAssessmentAdministrations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentAsset> AssessmentAssets { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentELDevelopmentalDomain> AssessmentEldevelopmentalDomains { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentFormAssessmentAsset> AssessmentFormAssessmentAssets { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentFormAssessmentFormSection> AssessmentFormAssessmentFormSections { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentFormSectionAssessmentAsset> AssessmentFormSectionAssessmentAssets { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentFormSectionAssessmentItem> AssessmentFormSectionAssessmentItems { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentFormSection> AssessmentFormSections { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentForm> AssessmentForms { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentItemApipDescription> AssessmentItemApipDescriptions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentItemApip> AssessmentItemApips { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentItemCharacteristic> AssessmentItemCharacteristics { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentItemPossibleResponse> AssessmentItemPossibleResponses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentItemResponseTheory> AssessmentItemResponseTheories { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentItemResponse> AssessmentItemResponses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentItemRubricCriterionResult> AssessmentItemRubricCriterionResults { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentItem> AssessmentItems { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentLanguage> AssessmentLanguages { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentLevelsForWhichDesigned> AssessmentLevelsForWhichDesigneds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentNeedApipContent> AssessmentNeedApipContents { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentNeedApipControl> AssessmentNeedApipControls { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentNeedApipDisplay> AssessmentNeedApipDisplays { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentNeedBraille> AssessmentNeedBrailles { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentNeedScreenEnhancement> AssessmentNeedScreenEnhancements { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentParticipantSessionAccommodation> AssessmentParticipantSessionAccommodations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentParticipantSession> AssessmentParticipantSessions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentPerformanceLevel> AssessmentPerformanceLevels { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentPersonalNeedLanguageLearner> AssessmentPersonalNeedLanguageLearners { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentPersonalNeedScreenReader> AssessmentPersonalNeedScreenReaders { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentPersonalNeedsProfileContent> AssessmentPersonalNeedsProfileContents { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentPersonalNeedsProfileControl> AssessmentPersonalNeedsProfileControls { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentPersonalNeedsProfileDisplay> AssessmentPersonalNeedsProfileDisplays { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentPersonalNeedsProfileScreenEnhancement> AssessmentPersonalNeedsProfileScreenEnhancements { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentPersonalNeedsProfile> AssessmentPersonalNeedsProfiles { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentRegistrationAccommodation> AssessmentRegistrationAccommodations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentResultPerformanceLevel> AssessmentResultPerformanceLevels { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentResultRubricCriterionResult> AssessmentResultRubricCriterionResults { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentResult> AssessmentResults { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentSessionStaffRole> AssessmentSessionStaffRoles { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentSession> AssessmentSessions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentSubtestAssessmentItem> AssessmentSubtestAssessmentItems { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentSubtestCompetencyDefinition> AssessmentSubtestCompetencyDefinitions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentSubtestELDevelopmentalDomain> AssessmentSubtestEldevelopmentalDomains { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentSubtestLevelsForWhichDesigned> AssessmentSubtestLevelsForWhichDesigneds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AssessmentSubTest> AssessmentSubtests { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Assessment> Assessments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Authentication> Authentications { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<AuthorizationDocument> AuthorizationDocuments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Authorization> Authorizations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<BuildingSpaceUtilization> BuildingSpaceUtilizations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<BuildingSpace> BuildingSpaces { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<BuildingSystemCategory> BuildingSystemCategories { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<BuildingSystemComponentService> BuildingSystemComponentServices { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<BuildingSystemComponent> BuildingSystemComponents { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Classroom> Classrooms { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CompetencyDefAssociation> CompetencyDefAssociations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CompetencyDefEducationLevel> CompetencyDefEducationLevels { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CompetencyDefinitionCompetencySet> CompetencyDefinitionCompetencySets { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CompetencyDefinition> CompetencyDefinitions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CompetencyFramework> CompetencyFrameworks { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CompetencySetRubricCriterion> CompetencySetRubricCriteria { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CompetencySetRubric> CompetencySetRubrics { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CompetencySet> CompetencySets { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CoreKnowledgeArea> CoreKnowledgeAreas { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CourseSectionAssessmentReporting> CourseSectionAssessmentReportings { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CourseSectionLevel> CourseSectionLevels { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CourseSectionLocation> CourseSectionLocations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CourseSectionSchedule> CourseSectionSchedules { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CourseSection> CourseSections { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Course> Courses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CredentialAwardCredit> CredentialAwardCredits { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CredentialAwardEvidence> CredentialAwardEvidences { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CredentialAward> CredentialAwards { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CredentialCriteriaCourse> CredentialCriteriaCourses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CredentialDefAgentCredential> CredentialDefAgentCredentials { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CredentialDefAgent> CredentialDefAgents { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CredentialDefCategory> CredentialDefCategories { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CredentialDefCriterion> CredentialDefCriteria { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CredentialDefIdentifier> CredentialDefIdentifiers { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CredentialDefinition> CredentialDefinitions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CredentialIssuer> CredentialIssuers { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CredentialOffered> CredentialOffereds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CteCourse> CteCourses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<CteStudentAcademicRecord> CteStudentAcademicRecords { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<EarlyChildhoodCredential> EarlyChildhoodCredentials { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<EarlyChildhoodProgramTypeOffered> EarlyChildhoodProgramTypeOffereds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELChildDemographic> ElchildDemographics { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELChildDevelopmentalAssessment> ElchildDevelopmentalAssessments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELChildHealth> ElchildHealths { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELChildIndividualizedProgram> ElchildIndividualizedPrograms { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELChildOutcomeSummary> ElchildOutcomeSummaries { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELChildProgramEligibility> ElchildProgramEligibilities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELChildService> ElchildServices { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELChildServicesApplication> ElchildServicesApplications { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELChildTransitionPlan> ElchildTransitionPlans { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELClassSectionService> ElclassSectionServices { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELClassSection> ElclassSections { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELEnrollmentOtherFunding> ElenrollmentOtherFundings { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELEnrollment> Elenrollments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELFacilityLicensing> ElfacilityLicensings { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<EligibilityEvaluation> EligibilityEvaluations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELOrganizationAvailability> ElorganizationAvailabilities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELOrganizationFunds> ElorganizationFunds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELOrganizationMonitoring> ElorganizationMonitorings { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELOrganization> Elorganizations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELProgramLicensing> ElprogramLicensings { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELQualityInitiative> ElqualityInitiatives { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELQualityRatingImprovement> ElqualityRatingImprovements { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELServicePartner> ElservicePartners { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELStaffAssignment> ElstaffAssignments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELStaffEducation> ElstaffEducations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELStaffEmployment> ElstaffEmployments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ELStaff> Elstaffs { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Facility> Facilities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityAudit> FacilityAudits { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityCompliance> FacilityCompliances { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityDesignConstruction> FacilityDesignConstructions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityDesign> FacilityDesigns { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityEnergy> FacilityEnergies { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityFinance> FacilityFinances { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityFinancial> FacilityFinancials { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityHazard> FacilityHazards { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityJointUse> FacilityJointUses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityLease> FacilityLeases { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityLocation> FacilityLocations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityManagementPlan> FacilityManagementPlans { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityManagement> FacilityManagements { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityMandate> FacilityMandates { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityMortgageFee> FacilityMortgageFees { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityMortgage> FacilityMortgages { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityRelationship> FacilityRelationships { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilitySchoolDesign> FacilitySchoolDesigns { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilitySite> FacilitySites { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FacilityUtilization> FacilityUtilizations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FinancialAccountProgram> FinancialAccountPrograms { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FinancialAccount> FinancialAccounts { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FinancialAidApplication> FinancialAidApplications { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<FinancialAidAward> FinancialAidAwards { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<GoalMeasurementCriterion> GoalMeasurementCriteria { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<GoalMeasurement> GoalMeasurements { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<GoalPerformance> GoalPerformances { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Goal> Goals { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IDEAEligibilityEvaluationCategory> IdeaeligibilityEvaluationCategories { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IEPAuthorizationRejected> IepauthorizationRejecteds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IEPAuthorization> Iepauthorizations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IEPPresentLevel> IeppresentLevels { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IncidentPerson> IncidentPeople { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Incident> Incidents { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramAccommodationSubject> IndividualizedProgramAccommodationSubjects { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramAccommodation> IndividualizedProgramAccommodations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramAmendment> IndividualizedProgramAmendments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramAssessmentAccommodation> IndividualizedProgramAssessmentAccommodations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramAssessment> IndividualizedProgramAssessments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramEligibility> IndividualizedProgramEligibilities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramEligibilityEvaluation> IndividualizedProgramEligibilityEvaluations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramGoal> IndividualizedProgramGoals { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramMeetingAttendee> IndividualizedProgramMeetingAttendees { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramMeeting> IndividualizedProgramMeetings { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramProgressGoal> IndividualizedProgramProgressGoals { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramProgressReportPlan> IndividualizedProgramProgressReportPlans { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramProgressReport> IndividualizedProgramProgressReports { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramService> IndividualizedProgramServices { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgramServicesReceived> IndividualizedProgramServicesReceiveds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IndividualizedProgram> IndividualizedPrograms { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<IPEDSFinance> Ipedsfinances { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12CharterSchoolAuthorizerAgency> K12charterSchoolAuthorizerAgencies { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12CharterSchoolManagementOrganization> K12charterSchoolManagementOrganizations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12Course> K12courses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12FederalFundAllocation> K12federalFundAllocations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12LeaFederalFunds> K12leaFederalFunds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12LeaFederalReporting> K12leaFederalReportings { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12LeaGradeLevelsApproved> K12leaGradeLevelsApproveds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12LeaGradeOffered> K12leaGradeOffereds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12LeaPreKEligibility> K12leaPreKeligibilities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12leaPreKeligibleAgesIdea> K12leaPreKeligibleAgesIdeas { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12LeaSafeDrugFree> K12leaSafeDrugFrees { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12LeaTitleIIIProfessionalDevelopment> K12leaTitleIiiprofessionalDevelopments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12LeaTitleISupportService> K12leaTitleIsupportServices { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12Lea> K12leas { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12OrganizationStudentResponsibility> K12organizationStudentResponsibilities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12ProgramOrService> K12programOrServices { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12SchoolCorrectiveAction> K12schoolCorrectiveActions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12SchoolGradeLevelsApproved> K12schoolGradeLevelsApproveds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12SchoolGradeOffered> K12schoolGradeOffereds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12SchoolImprovement> K12schoolImprovements { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12SchoolIndicatorStatus> K12schoolIndicatorStatuses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12SchoolStatus> K12schoolStatuses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12School> K12schools { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12SeaAlternateFundUse> K12seaAlternateFundUses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12seaFederalFund> K12seaFederalFunds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12Sea> K12seas { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StaffAssignment> K12staffAssignments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StaffEmployment> K12staffEmployments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentAcademicHonor> K12studentAcademicHonors { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentAcademicRecord> K12studentAcademicRecords { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentActivity> K12studentActivities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentCohort> K12studentCohorts { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentCourseSectionMark> K12studentCourseSectionMarks { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentCourseSection> K12studentCourseSections { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentDiscipline> K12studentDisciplines { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentEmployment> K12studentEmployments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentEnrollment> K12studentEnrollments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentGraduationPlan> K12studentGraduationPlans { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentHomeLanguageSurvey> K12studentHomeLanguageSurveys { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentLiteracyAssessment> K12studentLiteracyAssessments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12StudentSession> K12studentSessions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<K12TitleIIILanguageInstruction> K12titleIiilanguageInstructions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<LearnerAction> LearnerActions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<LearnerActivity> LearnerActivities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<LearnerActivityLearningResource> LearnerActivityLearningResources { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<LearningResourceAdaptation> LearningResourceAdaptations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<LearningResourceEducationLevel> LearningResourceEducationLevels { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<LearningResourceMediaFeature> LearningResourceMediaFeatures { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<LearningResourcePeerRating> LearningResourcePeerRatings { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<LearningResourcePhysicalMedium> LearningResourcePhysicalMedia { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<LearningResource> LearningResources { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<LocationAddress> LocationAddresses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Location> Locations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationAccreditation> OrganizationAccreditations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationCalendarCrisis> OrganizationCalendarCrises { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationCalendarDay> OrganizationCalendarDays { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationCalendarEvent> OrganizationCalendarEvents { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationCalendarSession> OrganizationCalendarSessions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationCalendar> OrganizationCalendars { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationDetail> OrganizationDetails { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationEmail> OrganizationEmails { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationEmployeeBenefit> OrganizationEmployeeBenefits { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationFederalAccountability> OrganizationFederalAccountabilities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationFinancial> OrganizationFinancials { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationIdentifier> OrganizationIdentifiers { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationImage> OrganizationImages { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationIndicator> OrganizationIndicators { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationLocation> OrganizationLocations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationOperationalStatus> OrganizationOperationalStatuses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationPersonRoleApplication> OrganizationPersonRoleApplications { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationPersonRoleFTE> OrganizationPersonRoleFtes { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationPersonRoleRelationship> OrganizationPersonRoleRelationships { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationPersonRole> OrganizationPersonRoles { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationPolicy> OrganizationPolicies { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationPopulationServed> OrganizationPopulationServeds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationProgramType> OrganizationProgramTypes { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationRelationship> OrganizationRelationships { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationService> OrganizationServices { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationTechnicalAssistance> OrganizationTechnicalAssistances { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationTelephone> OrganizationTelephones { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<OrganizationWebsite> OrganizationWebsites { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Organization> Organizations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PDActivityEducationLevel> PdactivityEducationLevels { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PeerRatingSystem> PeerRatingSystems { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Person> People { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonAddressNcesSide> PersonAddressNcesSides { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonAllergy> PersonAllergies { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonAssessmentPersonalNeedsProfile> PersonAssessmentPersonalNeedsProfiles { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonBirthplace> PersonBirthplaces { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonCareerEducationPlan> PersonCareerEducationPlans { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonCredential> PersonCredentials { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonDegreeOrCertificate> PersonDegreeOrCertificates { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonDemographicRace> PersonDemographicRaces { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonDetail> PersonDetails { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonDigitalAccessSpeed> PersonDigitalAccessSpeeds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonDigitalAccess> PersonDigitalAccesses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonDisability> PersonDisabilities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonEmailAddress> PersonEmailAddresses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonFamily> PersonFamilies { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonHealthBirth> PersonHealthBirths { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonHealth> PersonHealths { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonHomelessness> PersonHomelessnesses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonIdentifier> PersonIdentifiers { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonImmunization> PersonImmunizations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonLanguage> PersonLanguages { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonLearningDevice> PersonLearningDevices { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonMaster> PersonMasters { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonMilitary> PersonMilitaries { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonOtherName> PersonOtherNames { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonPersonalInformationVerification> PersonPersonalInformationVerifications { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonProgramParticipation> PersonProgramParticipations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonReferral> PersonReferrals { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonRelationship> PersonRelationships { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonStatus> PersonStatuses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PersonTelephone> PersonTelephones { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProfessionalDevelopmentActivity> ProfessionalDevelopmentActivities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProfessionalDevelopmentRequirement> ProfessionalDevelopmentRequirements { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProfessionalDevelopmentSessionInstructor> ProfessionalDevelopmentSessionInstructors { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProfessionalDevelopmentSession> ProfessionalDevelopmentSessions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProgramParticipationAE> ProgramParticipationAes { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProgramParticipationAttainment> ProgramParticipationAttainments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProgramParticipationCte> ProgramParticipationCtes { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProgramParticipationFoodService> ProgramParticipationFoodServices { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProgramParticipationMigrant> ProgramParticipationMigrants { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProgramParticipationNeglected> ProgramParticipationNeglecteds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProgramParticipationSpecialEducation> ProgramParticipationSpecialEducations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProgramParticipationTeacherPrep> ProgramParticipationTeacherPreps { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProgramParticipationTitleIIILep> ProgramParticipationTitleIiileps { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProgramParticipationTitleI> ProgramParticipationTitleIs { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProgramParticipationWIOABarriers> ProgramParticipationWioabarriers { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ProgramParticipationWIOA> ProgramParticipationWioas { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Program> Programs { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsCourse> PsCourses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsInstitution> PsInstitutions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsPriceOfAttendance> PsPriceOfAttendances { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsProgram> PsPrograms { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsSectionLocation> PsSectionLocations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsSection> PsSections { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsStaffEmployment> PsStaffEmployments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsStudentAcademicAward> PsStudentAcademicAwards { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsStudentAcademicRecord> PsStudentAcademicRecords { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsStudentAdmissionTest> PsStudentAdmissionTests { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsStudentApplication> PsStudentApplications { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsStudentCohort> PsStudentCohorts { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsStudentCourseSectionMark> PsStudentCourseSectionMarks { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsStudentDemographic> PsStudentDemographics { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsStudentEmployment> PsStudentEmployments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsStudentEnrollment> PsStudentEnrollments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsStudentFinancialAid> PsStudentFinancialAids { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PsStudentSection> PsStudentSections { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<PSStudentProgram> PsstudentPrograms { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<QuarterlyEmploymentRecord> QuarterlyEmploymentRecords { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<RequiredImmunization> RequiredImmunizations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<RoleAttendanceEvent> RoleAttendanceEvents { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<RoleAttendance> RoleAttendances { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<RoleStatus> RoleStatuses { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Role> Roles { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<RubricCriterion> RubricCriteria { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<RubricCriterionLevel> RubricCriterionLevels { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<Rubric> Rubrics { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ServiceFrequency> ServiceFrequencies { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ServicePlan> ServicePlans { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ServiceProvided> ServiceProvideds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ServiceStaff> ServiceStaffs { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<ServicesReceived> ServicesReceiveds { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<StaffCompensation> StaffCompensations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<StaffCredential> StaffCredentials { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<StaffEmployment> StaffEmployments { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<StaffEvaluationPart> StaffEvaluationParts { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<StaffEvaluation> StaffEvaluations { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<StaffExperience> StaffExperiences { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<StaffProfessionalDevelopmentActivity> StaffProfessionalDevelopmentActivities { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<StaffTechnicalAssistance> StaffTechnicalAssistances { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<TeacherEducationCredentialExam> TeacherEducationCredentialExams { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<TeacherStudentDataLinkExclusion> TeacherStudentDataLinkExclusions { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<WorkforceEmploymentQuarterlyDatum> WorkforceEmploymentQuarterlyData { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<WorkforceProgramParticipantCohort> WorkforceProgramParticipantCohorts { get; set; }
        [InverseProperty("DataCollection")]
        public virtual ICollection<WorkforceProgramParticipation> WorkforceProgramParticipations { get; set; }
    }
}
