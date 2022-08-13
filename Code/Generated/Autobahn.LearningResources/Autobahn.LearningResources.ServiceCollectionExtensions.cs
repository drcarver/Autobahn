//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResources.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.LearningResources.ViewModels;
using Autobahn.LearningResources.Views;

/// <summary>
/// The Service Collection Extensions for the Learning Resources domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Learning Resources Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddLearningResourcesServices(this IServiceCollection serviceCollection)
    {
        // First the known view models

        // Now the known views

        return serviceCollection;
    }
}
