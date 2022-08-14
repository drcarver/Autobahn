//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   Postsecondary.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;
using Autobahn.Postsecondary.ViewModels;
using Autobahn.Postsecondary.Views;

/// <summary>
/// The Service Collection Extensions for the Postsecondary (PS) domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Postsecondary (PS) Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddPostsecondaryServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IIPEDSFinance, IPEDSFinanceViewModel>();
        serviceCollection.AddTransient<IPsCourse, PsCourseViewModel>();
        serviceCollection.AddTransient<IPsInstitution, PsInstitutionViewModel>();
        serviceCollection.AddTransient<IPsPriceOfAttendance, PsPriceOfAttendanceViewModel>();
        serviceCollection.AddTransient<IPsProgram, PsProgramViewModel>();
        serviceCollection.AddTransient<IPsSection, PsSectionViewModel>();
        serviceCollection.AddTransient<IPsSectionLocation, PsSectionLocationViewModel>();
        serviceCollection.AddTransient<IPsStaffEmployment, PsStaffEmploymentViewModel>();
        serviceCollection.AddTransient<IPsStudentAcademicAward, PsStudentAcademicAwardViewModel>();
        serviceCollection.AddTransient<IPsStudentAcademicRecord, PsStudentAcademicRecordViewModel>();
        serviceCollection.AddTransient<IPsStudentAdmissionTest, PsStudentAdmissionTestViewModel>();
        serviceCollection.AddTransient<IPsStudentApplication, PsStudentApplicationViewModel>();
        serviceCollection.AddTransient<IPsStudentCohort, PsStudentCohortViewModel>();
        serviceCollection.AddTransient<IPsStudentCourseSectionMark, PsStudentCourseSectionMarkViewModel>();
        serviceCollection.AddTransient<IPsStudentDemographic, PsStudentDemographicViewModel>();
        serviceCollection.AddTransient<IPsStudentEmployment, PsStudentEmploymentViewModel>();
        serviceCollection.AddTransient<IPsStudentEnrollment, PsStudentEnrollmentViewModel>();
        serviceCollection.AddTransient<IPSStudentEnrollment, PSStudentEnrollmentViewModel>();
        serviceCollection.AddTransient<IPsStudentFinancialAid, PsStudentFinancialAidViewModel>();
        serviceCollection.AddTransient<IPSStudentProgram, PSStudentProgramViewModel>();
        serviceCollection.AddTransient<IPsStudentSection, PsStudentSectionViewModel>();

        // Now the known views
        serviceCollection.AddTransient<IPEDSFinanceView>();
        serviceCollection.AddTransient<PsCourseView>();
        serviceCollection.AddTransient<PsInstitutionView>();
        serviceCollection.AddTransient<PsPriceOfAttendanceView>();
        serviceCollection.AddTransient<PsProgramView>();
        serviceCollection.AddTransient<PsSectionView>();
        serviceCollection.AddTransient<PsSectionLocationView>();
        serviceCollection.AddTransient<PsStaffEmploymentView>();
        serviceCollection.AddTransient<PsStudentAcademicAwardView>();
        serviceCollection.AddTransient<PsStudentAcademicRecordView>();
        serviceCollection.AddTransient<PsStudentAdmissionTestView>();
        serviceCollection.AddTransient<PsStudentApplicationView>();
        serviceCollection.AddTransient<PsStudentCohortView>();
        serviceCollection.AddTransient<PsStudentCourseSectionMarkView>();
        serviceCollection.AddTransient<PsStudentDemographicView>();
        serviceCollection.AddTransient<PsStudentEmploymentView>();
        serviceCollection.AddTransient<PsStudentEnrollmentView>();
        serviceCollection.AddTransient<PSStudentEnrollmentView>();
        serviceCollection.AddTransient<PsStudentFinancialAidView>();
        serviceCollection.AddTransient<PSStudentProgramView>();
        serviceCollection.AddTransient<PsStudentSectionView>();

        return serviceCollection;
    }
}
