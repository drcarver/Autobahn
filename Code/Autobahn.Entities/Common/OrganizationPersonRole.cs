//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRole.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("OrganizationPersonRole", Schema = "Common")]
    public partial class OrganizationPersonRole : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganizationPersonRole()
        {
        //    ActivityRecognitions = new HashSet<ActivityRecognition>();
        //    AeStaffs = new HashSet<AeStaff>();
        //    AeStudentAcademicRecords = new HashSet<AeStudentAcademicRecord>();
        //    AeStudentEmployments = new HashSet<AeStudentEmployment>();
        //    Authentications = new HashSet<Authentication>();
        //    Authorizations = new HashSet<Authorization>();
        //    AuthorizationDocuments = new HashSet<AuthorizationDocument>();
        //    CredentialAwardCredits = new HashSet<CredentialAwardCredit>();
        //    CteStudentAcademicRecords = new HashSet<CteStudentAcademicRecord>();
        //    ELChildProgramEligibilities = new HashSet<ELChildProgramEligibility>();
        //    ELChildServices = new HashSet<ELChildService>();
        //    ELChildServicesApplications = new HashSet<ELChildServicesApplication>();
        //    ELEnrollments = new HashSet<ELEnrollment>();
        //    ELStaffs = new HashSet<ELStaff>();
        //    ELStaffAssignments = new HashSet<ELStaffAssignment>();
        //    FinancialAidApplications = new HashSet<FinancialAidApplication>();
        //    FinancialAidAwards = new HashSet<FinancialAidAward>();
        //    Goals = new HashSet<Goal>();
        //    Incidents = new HashSet<Incident>();
        //    IndividualizedPrograms = new HashSet<IndividualizedProgram>();
        //    IndividualizedProgramMeetingAttendees = new HashSet<IndividualizedProgramMeetingAttendee>();
        //    K12OrganizationStudentResponsibility = new HashSet<K12OrganizationStudentResponsibility>();
        //    K12StaffAssignment = new HashSet<K12StaffAssignment>();
        //    K12StaffAssignment1 = new HashSet<K12StaffAssignment>();
        //    K12StudentAcademicHonor = new HashSet<K12StudentAcademicHonor>();
        //    K12StudentAcademicRecord = new HashSet<K12StudentAcademicRecord>();
        //    K12StudentActivity = new HashSet<K12StudentActivity>();
        //    K12StudentCohort = new HashSet<K12StudentCohort>();
        //    K12StudentCourseSection = new HashSet<K12StudentCourseSection>();
        //    K12StudentDiscipline = new HashSet<K12StudentDiscipline>();
        //    K12StudentEmployment = new HashSet<K12StudentEmployment>();
        //    K12StudentEnrollment = new HashSet<K12StudentEnrollment>();
        //    K12StudentEnrollment1 = new HashSet<K12StudentEnrollment>();
        //    K12StudentGraduationPlan = new HashSet<K12StudentGraduationPlan>();
        //    K12StudentHomeLanguageSurvey = new HashSet<K12StudentHomeLanguageSurvey>();
        //    K12StudentLiteracyAssessment = new HashSet<K12StudentLiteracyAssessment>();
        //    K12StudentSession = new HashSet<K12StudentSession>();
        //    OrganizationPersonRoleApplications = new HashSet<OrganizationPersonRoleApplication>();
        //    OrganizationPersonRoleFTEs = new HashSet<OrganizationPersonRoleFTE>();
        //    OrganizationPersonRoleRelationships = new HashSet<OrganizationPersonRoleRelationship>();
        //    OrganizationPersonRoleRelationships1 = new HashSet<OrganizationPersonRoleRelationship>();
        //    ProfessionalDevelopmentSessionInstructors = new HashSet<ProfessionalDevelopmentSessionInstructor>();
        //    PersonLearningDevices = new HashSet<PersonLearningDevice>();
        //    PersonProgramParticipations = new HashSet<PersonProgramParticipation>();
        //    ProfessionalDevelopmentRequirements = new HashSet<ProfessionalDevelopmentRequirement>();
        //    PsStudentAdmissionTests = new HashSet<PsStudentAdmissionTest>();
        //    PsStudentAcademicAwards = new HashSet<PsStudentAcademicAward>();
        //    PsStudentAcademicRecords = new HashSet<PsStudentAcademicRecord>();
        //    PsStudentApplications = new HashSet<PsStudentApplication>();
        //    PsStudentCohorts = new HashSet<PsStudentCohort>();
        //    PsStudentDemographics = new HashSet<PsStudentDemographic>();
        //    PsStudentEmployments = new HashSet<PsStudentEmployment>();
        //    PsStudentEnrollments = new HashSet<PsStudentEnrollment>();
        //    PsStudentFinancialAids = new HashSet<PsStudentFinancialAid>();
        //    PSStudentPrograms = new HashSet<PSStudentProgram>();
        //    PsStudentSections = new HashSet<PsStudentSection>();
        //    RoleAttendances = new HashSet<RoleAttendance>();
        //    RoleAttendanceEvents = new HashSet<RoleAttendanceEvent>();
        //    RoleAttendanceEvents1 = new HashSet<RoleAttendanceEvent>();
        //    RoleStatus = new HashSet<RoleStatus>();
        //    ServicePlans = new HashSet<ServicePlan>();
        //    ServicesReceiveds = new HashSet<ServicesReceived>();
        //    ServiceStaffs = new HashSet<ServiceStaff>();
        //    StaffEmployments = new HashSet<StaffEmployment>();
        //    StaffEvaluations = new HashSet<StaffEvaluation>();
        //    StaffEvaluationParts = new HashSet<StaffEvaluationPart>();
        //    StaffExperiences = new HashSet<StaffExperience>();
        //    StaffProfessionalDevelopmentActivities = new HashSet<StaffProfessionalDevelopmentActivity>();
        //    StaffTechnicalAssistances = new HashSet<StaffTechnicalAssistance>();
        //    WorkforceEmploymentQuarterlyDatas = new HashSet<WorkforceEmploymentQuarterlyData>();
        //    WorkforceProgramParticipantCohorts = new HashSet<WorkforceProgramParticipantCohort>();
        }

        [ForeignKey("Organization")]
        public Guid OrganizationId { get; set; }

        [ForeignKey("Person")]
        public Guid PersonId { get; set; }
        
        [ForeignKey("Role")]
        public Guid RoleId { get; set; }

        public DateTime? EntryDate { get; set; }

        public DateTime? ExitDate { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ActivityRecognition> ActivityRecognitions { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AeStaff> AeStaffs { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AeStudentAcademicRecord> AeStudentAcademicRecords { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AeStudentEmployment> AeStudentEmployments { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Authentication> Authentications { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Authorization> Authorizations { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AuthorizationDocument> AuthorizationDocuments { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CredentialAwardCredit> CredentialAwardCredits { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CteStudentAcademicRecord> CteStudentAcademicRecords { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELChildProgramEligibility> ELChildProgramEligibilities { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELChildService> ELChildServices { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELChildServicesApplication> ELChildServicesApplications { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELEnrollment> ELEnrollments { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELStaff> ELStaffs { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELStaffAssignment> ELStaffAssignments { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FinancialAidApplication> FinancialAidApplications { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FinancialAidAward> FinancialAidAwards { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Goal> Goals { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Incident> Incidents { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<IndividualizedProgram> IndividualizedPrograms { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<IndividualizedProgramMeetingAttendee> IndividualizedProgramMeetingAttendees { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12OrganizationStudentResponsibility> K12OrganizationStudentResponsibility { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StaffAssignment> K12StaffAssignment { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StaffAssignment> K12StaffAssignment1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentAcademicHonor> K12StudentAcademicHonor { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentAcademicRecord> K12StudentAcademicRecord { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentActivity> K12StudentActivity { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentCohort> K12StudentCohort { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentCourseSection> K12StudentCourseSection { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentDiscipline> K12StudentDiscipline { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentEmployment> K12StudentEmployment { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentEnrollment> K12StudentEnrollment { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentEnrollment> K12StudentEnrollment1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentGraduationPlan> K12StudentGraduationPlan { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentHomeLanguageSurvey> K12StudentHomeLanguageSurvey { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentLiteracyAssessment> K12StudentLiteracyAssessment { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<K12StudentSession> K12StudentSession { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Person Person { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OrganizationPersonRoleApplication> OrganizationPersonRoleApplications { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OrganizationPersonRoleFTE> OrganizationPersonRoleFTEs { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OrganizationPersonRoleRelationship> OrganizationPersonRoleRelationships { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OrganizationPersonRoleRelationship> OrganizationPersonRoleRelationships1 { get; set; }

        public virtual Role Role { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ProfessionalDevelopmentSessionInstructor> ProfessionalDevelopmentSessionInstructors { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonLearningDevice> PersonLearningDevices { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonProgramParticipation> PersonProgramParticipations { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ProfessionalDevelopmentRequirement> ProfessionalDevelopmentRequirements { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PsStudentAdmissionTest> PsStudentAdmissionTests { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PsStudentAcademicAward> PsStudentAcademicAwards { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PsStudentAcademicRecord> PsStudentAcademicRecords { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PsStudentApplication> PsStudentApplications { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PsStudentCohort> PsStudentCohorts { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PsStudentDemographic> PsStudentDemographics { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PsStudentEmployment> PsStudentEmployments { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PsStudentEnrollment> PsStudentEnrollments { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PsStudentFinancialAid> PsStudentFinancialAids { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PSStudentProgram> PSStudentPrograms { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PsStudentSection> PsStudentSections { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<RoleAttendance> RoleAttendances { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<RoleAttendanceEvent> RoleAttendanceEvents { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<RoleAttendanceEvent> RoleAttendanceEvents1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<RoleStatus> RoleStatus { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ServicePlan> ServicePlans { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ServicesReceived> ServicesReceiveds { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ServiceStaff> ServiceStaffs { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<StaffEmployment> StaffEmployments { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<StaffEvaluation> StaffEvaluations { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<StaffEvaluationPart> StaffEvaluationParts { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<StaffExperience> StaffExperiences { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<StaffProfessionalDevelopmentActivity> StaffProfessionalDevelopmentActivities { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<StaffTechnicalAssistance> StaffTechnicalAssistances { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<WorkforceEmploymentQuarterlyData> WorkforceEmploymentQuarterlyDatas { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<WorkforceProgramParticipantCohort> WorkforceProgramParticipantCohorts { get; set; }
    }
}
