//**********************************************************
//* DomainName: Competencies
//* FileName:   Competencies.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Competencies.ViewModels;
using Autobahn.Competencies.Views;

/// <summary>
/// The Service Collection Extensions for the Competencies domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Competencies Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddCompetenciesServices(this IServiceCollection serviceCollection)
    {
        // First the known view models

        // Now the known views

        return serviceCollection;
    }
}
