//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.K12.ViewModels;
using Autobahn.K12.Views;

/// <summary>
/// The Service Collection Extensions for the Elementary and Secondary (K12) domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Elementary and Secondary (K12) Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddK12Services(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<Interfaces.IK12CharterSchoolApprovalAgency, K12CharterSchoolApprovalAgencyViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12CharterSchoolAuthorizerAgency, K12CharterSchoolAuthorizerAgencyViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12CharterSchoolManagementOrganization, K12CharterSchoolManagementOrganizationViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12Course, K12CourseViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12FederalFundAllocation, K12FederalFundAllocationViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12Lea, K12LeaViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12LeaFederalFunds, K12LeaFederalFundsViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12LeaFederalReporting, K12LeaFederalReportingViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12LeaGradeLevelsApproved, K12LeaGradeLevelsApprovedViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12LeaGradeOffered, K12LeaGradeOfferedViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12LeaPreKEligibility, K12LeaPreKEligibilityViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12LeaPreKEligibleAgesIDEA, K12LeaPreKEligibleAgesIDEAViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12LeaSafeDrugFree, K12LeaSafeDrugFreeViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12LeaTitleIIIProfessionalDevelopment, K12LeaTitleIIIProfessionalDevelopmentViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12LeaTitleISupportService, K12LeaTitleISupportServiceViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12OrganizationStudentResponsibility, K12OrganizationStudentResponsibilityViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12ProgramOrService, K12ProgramOrServiceViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12School, K12SchoolViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12SchoolCorrectiveAction, K12SchoolCorrectiveActionViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12SchoolGradeLevelsApproved, K12SchoolGradeLevelsApprovedViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12SchoolGradeOffered, K12SchoolGradeOfferedViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12SchoolImprovement, K12SchoolImprovementViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12SchoolIndicatorStatus, K12SchoolIndicatorStatusViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12SchoolStatus, K12SchoolStatusViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12Sea, K12SeaViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12SeaAlternateFundUse, K12SeaAlternateFundUseViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12SeaFederalFundAllocation, K12SeaFederalFundAllocationViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12SeaFederalFunds, K12SeaFederalFundsViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StaffAssignment, K12StaffAssignmentViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StaffEmployment, K12StaffEmploymentViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentAcademicHonor, K12StudentAcademicHonorViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentAcademicRecord, K12StudentAcademicRecordViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentActivity, K12StudentActivityViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentCohort, K12StudentCohortViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentCourseSection, K12StudentCourseSectionViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentCourseSectionMark, K12StudentCourseSectionMarkViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentDiscipline, K12StudentDisciplineViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentEmployment, K12StudentEmploymentViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentEnrollment, K12StudentEnrollmentViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentGraduationPlan, K12StudentGraduationPlanViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentHomeLanguageSurvey, K12StudentHomeLanguageSurveyViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentLiteracyAssessment, K12StudentLiteracyAssessmentViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12StudentSession, K12StudentSessionViewModel>();
        serviceCollection.AddTransient<Interfaces.IK12TitleIIILanguageInstruction, K12TitleIIILanguageInstructionViewModel>();

        // Now the known views
        serviceCollection.AddTransient<K12CharterSchoolApprovalAgencyView>();
        serviceCollection.AddTransient<K12CharterSchoolAuthorizerAgencyView>();
        serviceCollection.AddTransient<K12CharterSchoolManagementOrganizationView>();
        serviceCollection.AddTransient<K12CourseView>();
        serviceCollection.AddTransient<K12FederalFundAllocationView>();
        serviceCollection.AddTransient<K12LeaView>();
        serviceCollection.AddTransient<K12LeaFederalFundsView>();
        serviceCollection.AddTransient<K12LeaFederalReportingView>();
        serviceCollection.AddTransient<K12LeaGradeLevelsApprovedView>();
        serviceCollection.AddTransient<K12LeaGradeOfferedView>();
        serviceCollection.AddTransient<K12LeaPreKEligibilityView>();
        serviceCollection.AddTransient<K12LeaPreKEligibleAgesIDEAView>();
        serviceCollection.AddTransient<K12LeaSafeDrugFreeView>();
        serviceCollection.AddTransient<K12LeaTitleIIIProfessionalDevelopmentView>();
        serviceCollection.AddTransient<K12LeaTitleISupportServiceView>();
        serviceCollection.AddTransient<K12OrganizationStudentResponsibilityView>();
        serviceCollection.AddTransient<K12ProgramOrServiceView>();
        serviceCollection.AddTransient<K12SchoolView>();
        serviceCollection.AddTransient<K12SchoolCorrectiveActionView>();
        serviceCollection.AddTransient<K12SchoolGradeLevelsApprovedView>();
        serviceCollection.AddTransient<K12SchoolGradeOfferedView>();
        serviceCollection.AddTransient<K12SchoolImprovementView>();
        serviceCollection.AddTransient<K12SchoolIndicatorStatusView>();
        serviceCollection.AddTransient<K12SchoolStatusView>();
        serviceCollection.AddTransient<K12SeaView>();
        serviceCollection.AddTransient<K12SeaAlternateFundUseView>();
        serviceCollection.AddTransient<K12SeaFederalFundAllocationView>();
        serviceCollection.AddTransient<K12SeaFederalFundsView>();
        serviceCollection.AddTransient<K12StaffAssignmentView>();
        serviceCollection.AddTransient<K12StaffEmploymentView>();
        serviceCollection.AddTransient<K12StudentAcademicHonorView>();
        serviceCollection.AddTransient<K12StudentAcademicRecordView>();
        serviceCollection.AddTransient<K12StudentActivityView>();
        serviceCollection.AddTransient<K12StudentCohortView>();
        serviceCollection.AddTransient<K12StudentCourseSectionView>();
        serviceCollection.AddTransient<K12StudentCourseSectionMarkView>();
        serviceCollection.AddTransient<K12StudentDisciplineView>();
        serviceCollection.AddTransient<K12StudentEmploymentView>();
        serviceCollection.AddTransient<K12StudentEnrollmentView>();
        serviceCollection.AddTransient<K12StudentGraduationPlanView>();
        serviceCollection.AddTransient<K12StudentHomeLanguageSurveyView>();
        serviceCollection.AddTransient<K12StudentLiteracyAssessmentView>();
        serviceCollection.AddTransient<K12StudentSessionView>();
        serviceCollection.AddTransient<K12TitleIIILanguageInstructionView>();

        return serviceCollection;
    }
}
