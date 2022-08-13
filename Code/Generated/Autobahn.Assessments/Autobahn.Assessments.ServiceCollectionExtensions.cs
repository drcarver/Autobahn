//**********************************************************
//* DomainName: Assessments
//* FileName:   Assessments.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Assessments.ViewModels;
using Autobahn.Assessments.Views;

/// <summary>
/// The Service Collection Extensions for the Assessments domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Assessments Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddAssessmentsServices(this IServiceCollection serviceCollection)
    {
        // First the known view models

        // Now the known views

        return serviceCollection;
    }
}
