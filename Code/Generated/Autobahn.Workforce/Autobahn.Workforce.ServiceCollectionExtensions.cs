//**********************************************************
//* DomainName: Workforce
//* FileName:   Workforce.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Workforce.ViewModels;
using Autobahn.Workforce.Views;

/// <summary>
/// The Service Collection Extensions for the Workforce domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Workforce Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddWorkforceServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<Interfaces.IWorkforceEmploymentQuarterlyData, WorkforceEmploymentQuarterlyDataViewModel>();
        serviceCollection.AddTransient<Interfaces.IWorkforceProgramParticipantCohort, WorkforceProgramParticipantCohortViewModel>();
        serviceCollection.AddTransient<Interfaces.IWorkforceProgramParticipation, WorkforceProgramParticipationViewModel>();

        // Now the known views
        serviceCollection.AddTransient<WorkforceEmploymentQuarterlyDataView>();
        serviceCollection.AddTransient<WorkforceProgramParticipantCohortView>();
        serviceCollection.AddTransient<WorkforceProgramParticipationView>();

        return serviceCollection;
    }
}
