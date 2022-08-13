//**********************************************************
//* DomainName: Implementation
//* FileName:   Implementation.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Implementation.ViewModels;
using Autobahn.Implementation.Views;

/// <summary>
/// The Service Collection Extensions for the Implementation domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Implementation Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddImplementationServices(this IServiceCollection serviceCollection)
    {
        // First the known view models

        // Now the known views

        return serviceCollection;
    }
}
