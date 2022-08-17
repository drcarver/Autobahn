//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.K12.Interfaces;
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
        serviceCollection.AddTransient<IIDEAEligibilityEvaluationCategory, IDEAEligibilityEvaluationCategoryViewModel>();
        serviceCollection.AddTransient<IIDSVersion, IDSVersionViewModel>();
        serviceCollection.AddTransient<IIEPAuthorization, IEPAuthorizationViewModel>();
        serviceCollection.AddTransient<IIEPAuthorizationRejected, IEPAuthorizationRejectedViewModel>();
        serviceCollection.AddTransient<IIEPPresentLevel, IEPPresentLevelViewModel>();
        serviceCollection.AddTransient<IK12CharterSchoolAuthorizerAgency, K12CharterSchoolAuthorizerAgencyViewModel>();
        serviceCollection.AddTransient<IK12CharterSchoolManagementOrganization, K12CharterSchoolManagementOrganizationViewModel>();
        serviceCollection.AddTransient<IK12Course, K12CourseViewModel>();
        serviceCollection.AddTransient<IK12FederalFundAllocation, K12FederalFundAllocationViewModel>();
        serviceCollection.AddTransient<IK12Lea, K12LeaViewModel>();
        serviceCollection.AddTransient<IK12LeaFederalFunds, K12LeaFederalFundsViewModel>();
        serviceCollection.AddTransient<IK12LeaFederalReporting, K12LeaFederalReportingViewModel>();
        serviceCollection.AddTransient<IK12LeaGradeLevelsApproved, K12LeaGradeLevelsApprovedViewModel>();
        serviceCollection.AddTransient<IK12LeaGradeOffered, K12LeaGradeOfferedViewModel>();
        serviceCollection.AddTransient<IK12LeaPreKEligibility, K12LeaPreKEligibilityViewModel>();
        serviceCollection.AddTransient<IK12LEAPreKEligibility, K12LEAPreKEligibilityViewModel>();
        serviceCollection.AddTransient<IK12LeaPreKEligibleAgesIDEA, K12LeaPreKEligibleAgesIDEAViewModel>();
        serviceCollection.AddTransient<IK12LEAPreKEligibleAgesIDEA, K12LEAPreKEligibleAgesIDEAViewModel>();
        serviceCollection.AddTransient<IK12LeaSafeDrugFree, K12LeaSafeDrugFreeViewModel>();
        serviceCollection.AddTransient<IK12LeaTitleIIIProfessionalDevelopment, K12LeaTitleIIIProfessionalDevelopmentViewModel>();
        serviceCollection.AddTransient<IK12LEATitleIIIProfessionalDevelopment, K12LEATitleIIIProfessionalDevelopmentViewModel>();
        serviceCollection.AddTransient<IK12LeaTitleISupportService, K12LeaTitleISupportServiceViewModel>();
        serviceCollection.AddTransient<IK12OrganizationStudentResponsibility, K12OrganizationStudentResponsibilityViewModel>();
        serviceCollection.AddTransient<IK12ProgramOrService, K12ProgramOrServiceViewModel>();
        serviceCollection.AddTransient<IK12School, K12SchoolViewModel>();
        serviceCollection.AddTransient<IK12SchoolCorrectiveAction, K12SchoolCorrectiveActionViewModel>();
        serviceCollection.AddTransient<IK12SchoolGradeLevelsApproved, K12SchoolGradeLevelsApprovedViewModel>();
        serviceCollection.AddTransient<IK12SchoolGradeOffered, K12SchoolGradeOfferedViewModel>();
        serviceCollection.AddTransient<IK12SchoolImprovement, K12SchoolImprovementViewModel>();
        serviceCollection.AddTransient<IK12SchoolIndicatorStatus, K12SchoolIndicatorStatusViewModel>();
        serviceCollection.AddTransient<IK12SchoolStatus, K12SchoolStatusViewModel>();
        serviceCollection.AddTransient<IK12Sea, K12SeaViewModel>();
        serviceCollection.AddTransient<IK12SeaAlternateFundUse, K12SeaAlternateFundUseViewModel>();
        serviceCollection.AddTransient<IK12SeaFederalFunds, K12SeaFederalFundsViewModel>();
        serviceCollection.AddTransient<IK12StaffAssignment, K12StaffAssignmentViewModel>();
        serviceCollection.AddTransient<IK12StaffEmployment, K12StaffEmploymentViewModel>();
        serviceCollection.AddTransient<IK12StudentAcademicHonor, K12StudentAcademicHonorViewModel>();
        serviceCollection.AddTransient<IK12StudentAcademicRecord, K12StudentAcademicRecordViewModel>();
        serviceCollection.AddTransient<IK12StudentActivity, K12StudentActivityViewModel>();
        serviceCollection.AddTransient<IK12StudentCohort, K12StudentCohortViewModel>();
        serviceCollection.AddTransient<IK12StudentCourseSection, K12StudentCourseSectionViewModel>();
        serviceCollection.AddTransient<IK12StudentCourseSectionMark, K12StudentCourseSectionMarkViewModel>();
        serviceCollection.AddTransient<IK12StudentDiscipline, K12StudentDisciplineViewModel>();
        serviceCollection.AddTransient<IK12StudentEmployment, K12StudentEmploymentViewModel>();
        serviceCollection.AddTransient<IK12StudentEnrollment, K12StudentEnrollmentViewModel>();
        serviceCollection.AddTransient<IK12StudentGraduationPlan, K12StudentGraduationPlanViewModel>();
        serviceCollection.AddTransient<IK12StudentHomeLanguageSurvey, K12StudentHomeLanguageSurveyViewModel>();
        serviceCollection.AddTransient<IK12StudentLiteracyAssessment, K12StudentLiteracyAssessmentViewModel>();
        serviceCollection.AddTransient<IK12StudentSession, K12StudentSessionViewModel>();
        serviceCollection.AddTransient<IK12TitleIIILanguageInstruction, K12TitleIIILanguageInstructionViewModel>();

        // Now the known views
        serviceCollection.AddTransient<IDEAEligibilityEvaluationCategoryView>();
        serviceCollection.AddTransient<IDSVersionView>();
        serviceCollection.AddTransient<IEPAuthorizationView>();
        serviceCollection.AddTransient<IEPAuthorizationRejectedView>();
        serviceCollection.AddTransient<IEPPresentLevelView>();
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
        serviceCollection.AddTransient<K12LEAPreKEligibilityView>();
        serviceCollection.AddTransient<K12LeaPreKEligibleAgesIDEAView>();
        serviceCollection.AddTransient<K12LEAPreKEligibleAgesIDEAView>();
        serviceCollection.AddTransient<K12LeaSafeDrugFreeView>();
        serviceCollection.AddTransient<K12LeaTitleIIIProfessionalDevelopmentView>();
        serviceCollection.AddTransient<K12LEATitleIIIProfessionalDevelopmentView>();
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
