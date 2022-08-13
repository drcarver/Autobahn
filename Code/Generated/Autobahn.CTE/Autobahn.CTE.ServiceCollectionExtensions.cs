//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CTE.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.CTE.ViewModels;
using Autobahn.CTE.Views;

/// <summary>
/// The Service Collection Extensions for the Career and Technical Education (CTE) domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Career and Technical Education (CTE) Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddCTEServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<Interfaces.ICteCourse, CteCourseViewModel>();
        serviceCollection.AddTransient<Interfaces.ICteStudentAcademicRecord, CteStudentAcademicRecordViewModel>();
        serviceCollection.AddTransient<Interfaces.IProgramParticipationCte, ProgramParticipationCteViewModel>();

        // Now the known views
        serviceCollection.AddTransient<CteCourseView>();
        serviceCollection.AddTransient<CteStudentAcademicRecordView>();
        serviceCollection.AddTransient<ProgramParticipationCteView>();

        return serviceCollection;
    }
}
