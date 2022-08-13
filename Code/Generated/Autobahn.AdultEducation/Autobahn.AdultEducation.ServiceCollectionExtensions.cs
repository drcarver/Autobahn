//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AdultEducation.ServiceCollectionExtensions.cs
//**********************************************************

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
        serviceCollection.AddTransient<Interfaces.IAeCourse, AeCourseViewModel>();
        serviceCollection.AddTransient<Interfaces.IAeProvider, AeProviderViewModel>();
        serviceCollection.AddTransient<Interfaces.IAeStaff, AeStaffViewModel>();
        serviceCollection.AddTransient<Interfaces.IAeStudentAcademicRecord, AeStudentAcademicRecordViewModel>();
        serviceCollection.AddTransient<Interfaces.IAeStudentEmployment, AeStudentEmploymentViewModel>();
        serviceCollection.AddTransient<Interfaces.IProgramParticipationAE, ProgramParticipationAEViewModel>();

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
