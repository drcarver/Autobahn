//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   Postsecondary.ServiceCollectionExtensions.cs
//**********************************************************

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
        serviceCollection.AddTransient<Interfaces.IPsCourse, PsCourseViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsInstitution, PsInstitutionViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsPriceOfAttendance, PsPriceOfAttendanceViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsProgram, PsProgramViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsSection, PsSectionViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsSectionLocation, PsSectionLocationViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsStaffEmployment, PsStaffEmploymentViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsStudentAcademicAward, PsStudentAcademicAwardViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsStudentAcademicRecord, PsStudentAcademicRecordViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsStudentAdmissionTest, PsStudentAdmissionTestViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsStudentApplication, PsStudentApplicationViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsStudentCohort, PsStudentCohortViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsStudentCourseSectionMark, PsStudentCourseSectionMarkViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsStudentDemographic, PsStudentDemographicViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsStudentEmployment, PsStudentEmploymentViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsStudentEnrollment, PsStudentEnrollmentViewModel>();
        serviceCollection.AddTransient<Interfaces.IPSStudentEnrollment, PSStudentEnrollmentViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsStudentFinancialAid, PsStudentFinancialAidViewModel>();
        serviceCollection.AddTransient<Interfaces.IPSStudentProgram, PSStudentProgramViewModel>();
        serviceCollection.AddTransient<Interfaces.IPsStudentSection, PsStudentSectionViewModel>();

        // Now the known views
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
