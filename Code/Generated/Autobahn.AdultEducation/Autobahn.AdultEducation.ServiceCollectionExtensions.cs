//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AdultEducation.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.AdultEducation.Interfaces;
using Autobahn.AdultEducation.ViewModels;
using Autobahn.AdultEducation.Views;

/// <summary>
/// The Service Collection Extensions for the Adult Education (AE) domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Adult Education (AE) Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddAdultEducationServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IAeCourse, AeCourseViewModel>();
        serviceCollection.AddTransient<IAeProvider, AeProviderViewModel>();
        serviceCollection.AddTransient<IAeStaff, AeStaffViewModel>();
        serviceCollection.AddTransient<IAeStudentAcademicRecord, AeStudentAcademicRecordViewModel>();
        serviceCollection.AddTransient<IAeStudentEmployment, AeStudentEmploymentViewModel>();
        serviceCollection.AddTransient<IProgramParticipationAE, ProgramParticipationAEViewModel>();

        // Now the known views
        serviceCollection.AddTransient<AeCourseView>();
        serviceCollection.AddTransient<AeProviderView>();
        serviceCollection.AddTransient<AeStaffView>();
        serviceCollection.AddTransient<AeStudentAcademicRecordView>();
        serviceCollection.AddTransient<AeStudentEmploymentView>();
        serviceCollection.AddTransient<ProgramParticipationAEView>();

        return serviceCollection;
    }
}
