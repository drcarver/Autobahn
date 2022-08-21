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
    [Table("OrganizationPersonRole")]
    [Index("EntryDate", "ExitDate", Name = "IX_EntryDate_ExitDate")]
    [Index("PersonId", Name = "IX_PersonID")]
    public partial class OrganizationPersonRole
    {
        public OrganizationPersonRole()
        {
            ActivityRecognitions = new HashSet<ActivityRecognition>();
            AeStaffs = new HashSet<AeStaff>();
            AeStudentAcademicRecords = new HashSet<AeStudentAcademicRecord>();
            AeStudentEmployments = new HashSet<AeStudentEmployment>();
            Authentications = new HashSet<Authentication>();
            AuthorizationDocuments = new HashSet<AuthorizationDocument>();
            Authorizations = new HashSet<Authorization>();
            CredentialAwardCredits = new HashSet<CredentialAwardCredit>();
            CteStudentAcademicRecords = new HashSet<CteStudentAcademicRecord>();
            ElchildProgramEligibilities = new HashSet<ElchildProgramEligibility>();
            ElchildServices = new HashSet<ElchildService>();
            ElchildServicesApplications = new HashSet<ElchildServicesApplication>();
            Elenrollments = new HashSet<Elenrollment>();
            ElstaffAssignments = new HashSet<ElstaffAssignment>();
            Elstaffs = new HashSet<Elstaff>();
            FinancialAidApplications = new HashSet<FinancialAidApplication>();
            FinancialAidAwards = new HashSet<FinancialAidAward>();
            Goals = new HashSet<Goal>();
            Incidents = new HashSet<Incident>();
            IndividualizedProgramMeetingAttendees = new HashSet<IndividualizedProgramMeetingAttendee>();
            IndividualizedPrograms = new HashSet<IndividualizedProgram>();
            K12organizationStudentResponsibilities = new HashSet<K12organizationStudentResponsibility>();
            K12staffAssignments = new HashSet<K12staffAssignment>();
            K12studentAcademicHonors = new HashSet<K12studentAcademicHonor>();
            K12studentAcademicRecords = new HashSet<K12studentAcademicRecord>();
            K12studentActivities = new HashSet<K12studentActivity>();
            K12studentCohorts = new HashSet<K12studentCohort>();
            K12studentCourseSections = new HashSet<K12studentCourseSection>();
            K12studentDisciplines = new HashSet<K12studentDiscipline>();
            K12studentEmployments = new HashSet<K12studentEmployment>();
            K12studentEnrollments = new HashSet<K12studentEnrollment>();
            K12studentGraduationPlans = new HashSet<K12studentGraduationPlan>();
            K12studentHomeLanguageSurveys = new HashSet<K12studentHomeLanguageSurvey>();
            K12studentLiteracyAssessments = new HashSet<K12studentLiteracyAssessment>();
            K12studentSessions = new HashSet<K12studentSession>();
            OrganizationPersonRoleApplications = new HashSet<OrganizationPersonRoleApplication>();
            OrganizationPersonRoleFtes = new HashSet<OrganizationPersonRoleFte>();
            OrganizationPersonRoleRelationshipOrganizationPersonRoleIdParentNavigations = new HashSet<OrganizationPersonRoleRelationship>();
            OrganizationPersonRoleRelationshipOrganizationPersonRoles = new HashSet<OrganizationPersonRoleRelationship>();
            PersonLearningDevices = new HashSet<PersonLearningDevice>();
            PersonProgramParticipations = new HashSet<PersonProgramParticipation>();
            ProfessionalDevelopmentRequirements = new HashSet<ProfessionalDevelopmentRequirement>();
            ProfessionalDevelopmentSessionInstructors = new HashSet<ProfessionalDevelopmentSessionInstructor>();
            PsStudentAcademicAwards = new HashSet<PsStudentAcademicAward>();
            PsStudentAcademicRecords = new HashSet<PsStudentAcademicRecord>();
            PsStudentAdmissionTests = new HashSet<PsStudentAdmissionTest>();
            PsStudentApplications = new HashSet<PsStudentApplication>();
            PsStudentCohorts = new HashSet<PsStudentCohort>();
            PsStudentDemographics = new HashSet<PsStudentDemographic>();
            PsStudentEmployments = new HashSet<PsStudentEmployment>();
            PsStudentEnrollments = new HashSet<PsStudentEnrollment>();
            PsStudentFinancialAids = new HashSet<PsStudentFinancialAid>();
            PsStudentSections = new HashSet<PsStudentSection>();
            PsstudentPrograms = new HashSet<PsstudentProgram>();
            RoleAttendanceEvents = new HashSet<RoleAttendanceEvent>();
            RoleAttendances = new HashSet<RoleAttendance>();
            RoleStatuses = new HashSet<RoleStatus>();
            ServicePlans = new HashSet<ServicePlan>();
            ServiceStaffs = new HashSet<ServiceStaff>();
            ServicesReceiveds = new HashSet<ServicesReceived>();
            StaffEmployments = new HashSet<StaffEmployment>();
            StaffEvaluationParts = new HashSet<StaffEvaluationPart>();
            StaffEvaluations = new HashSet<StaffEvaluation>();
            StaffExperiences = new HashSet<StaffExperience>();
            StaffProfessionalDevelopmentActivities = new HashSet<StaffProfessionalDevelopmentActivity>();
            StaffTechnicalAssistances = new HashSet<StaffTechnicalAssistance>();
            WorkforceEmploymentQuarterlyData = new HashSet<WorkforceEmploymentQuarterlyDatum>();
            WorkforceProgramParticipantCohorts = new HashSet<WorkforceProgramParticipantCohort>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// Surrogate key from Organization.
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// Surrogate key from Person
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// Surrogate key from Role.  The name of the role, e.g. Student, Staff, Employee
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EntryDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ExitDate { get; set; }
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
        [InverseProperty("OrganizationPersonRoles")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("OrganizationPersonRoles")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("PersonId")]
        [InverseProperty("OrganizationPersonRoles")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("OrganizationPersonRoles")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RoleId")]
        [InverseProperty("OrganizationPersonRoles")]
        public virtual Role Role { get; set; } = null!;
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<ActivityRecognition> ActivityRecognitions { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<AeStaff> AeStaffs { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<AeStudentAcademicRecord> AeStudentAcademicRecords { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<AeStudentEmployment> AeStudentEmployments { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<Authentication> Authentications { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<AuthorizationDocument> AuthorizationDocuments { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<Authorization> Authorizations { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<CredentialAwardCredit> CredentialAwardCredits { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<CteStudentAcademicRecord> CteStudentAcademicRecords { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<ElchildProgramEligibility> ElchildProgramEligibilities { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<ElchildService> ElchildServices { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<ElchildServicesApplication> ElchildServicesApplications { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<Elenrollment> Elenrollments { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<ElstaffAssignment> ElstaffAssignments { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<Elstaff> Elstaffs { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<FinancialAidApplication> FinancialAidApplications { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<FinancialAidAward> FinancialAidAwards { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<Goal> Goals { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<Incident> Incidents { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<IndividualizedProgramMeetingAttendee> IndividualizedProgramMeetingAttendees { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<IndividualizedProgram> IndividualizedPrograms { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12organizationStudentResponsibility> K12organizationStudentResponsibilities { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12staffAssignment> K12staffAssignments { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12studentAcademicHonor> K12studentAcademicHonors { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12studentAcademicRecord> K12studentAcademicRecords { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12studentActivity> K12studentActivities { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12studentCohort> K12studentCohorts { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12studentCourseSection> K12studentCourseSections { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12studentDiscipline> K12studentDisciplines { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12studentEmployment> K12studentEmployments { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12studentEnrollment> K12studentEnrollments { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12studentGraduationPlan> K12studentGraduationPlans { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12studentHomeLanguageSurvey> K12studentHomeLanguageSurveys { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12studentLiteracyAssessment> K12studentLiteracyAssessments { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<K12studentSession> K12studentSessions { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<OrganizationPersonRoleApplication> OrganizationPersonRoleApplications { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<OrganizationPersonRoleFte> OrganizationPersonRoleFtes { get; set; }
        [InverseProperty("OrganizationPersonRoleIdParentNavigation")]
        public virtual ICollection<OrganizationPersonRoleRelationship> OrganizationPersonRoleRelationshipOrganizationPersonRoleIdParentNavigations { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<OrganizationPersonRoleRelationship> OrganizationPersonRoleRelationshipOrganizationPersonRoles { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PersonLearningDevice> PersonLearningDevices { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PersonProgramParticipation> PersonProgramParticipations { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<ProfessionalDevelopmentRequirement> ProfessionalDevelopmentRequirements { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<ProfessionalDevelopmentSessionInstructor> ProfessionalDevelopmentSessionInstructors { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PsStudentAcademicAward> PsStudentAcademicAwards { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PsStudentAcademicRecord> PsStudentAcademicRecords { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PsStudentAdmissionTest> PsStudentAdmissionTests { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PsStudentApplication> PsStudentApplications { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PsStudentCohort> PsStudentCohorts { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PsStudentDemographic> PsStudentDemographics { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PsStudentEmployment> PsStudentEmployments { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PsStudentEnrollment> PsStudentEnrollments { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PsStudentFinancialAid> PsStudentFinancialAids { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PsStudentSection> PsStudentSections { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<PsstudentProgram> PsstudentPrograms { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<RoleAttendanceEvent> RoleAttendanceEvents { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<RoleAttendance> RoleAttendances { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<RoleStatus> RoleStatuses { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<ServicePlan> ServicePlans { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<ServiceStaff> ServiceStaffs { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<ServicesReceived> ServicesReceiveds { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<StaffEmployment> StaffEmployments { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<StaffEvaluationPart> StaffEvaluationParts { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<StaffEvaluation> StaffEvaluations { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<StaffExperience> StaffExperiences { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<StaffProfessionalDevelopmentActivity> StaffProfessionalDevelopmentActivities { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<StaffTechnicalAssistance> StaffTechnicalAssistances { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<WorkforceEmploymentQuarterlyDatum> WorkforceEmploymentQuarterlyData { get; set; }
        [InverseProperty("OrganizationPersonRole")]
        public virtual ICollection<WorkforceProgramParticipantCohort> WorkforceProgramParticipantCohorts { get; set; }
    }
}
