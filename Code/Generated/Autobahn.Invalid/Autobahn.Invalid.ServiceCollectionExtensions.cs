//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   Invalid.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Invalid.ViewModels;
using Autobahn.Invalid.Views;

/// <summary>
/// The Service Collection Extensions for the Invalid or Unreferenced Models domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Invalid or Unreferenced Models Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddInvalidServices(this IServiceCollection serviceCollection)
    {
        // First the known view models

        // Now the known views

        return serviceCollection;
    }
}
