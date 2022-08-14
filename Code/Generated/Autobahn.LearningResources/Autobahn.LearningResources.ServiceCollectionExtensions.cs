//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResources.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.LearningResources.Interfaces;
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
        serviceCollection.AddTransient<ILearningResource, LearningResourceViewModel>();
        serviceCollection.AddTransient<ILearningResourceAdaptation, LearningResourceAdaptationViewModel>();
        serviceCollection.AddTransient<ILearningResourceEducationLevel, LearningResourceEducationLevelViewModel>();
        serviceCollection.AddTransient<ILearningResourceMediaFeature, LearningResourceMediaFeatureViewModel>();
        serviceCollection.AddTransient<ILearningResourcePeerRating, LearningResourcePeerRatingViewModel>();
        serviceCollection.AddTransient<ILearningResourcePhysicalMedia, LearningResourcePhysicalMediaViewModel>();
        serviceCollection.AddTransient<IPeerRatingSystem, PeerRatingSystemViewModel>();

        // Now the known views
        serviceCollection.AddTransient<LearningResourceView>();
        serviceCollection.AddTransient<LearningResourceAdaptationView>();
        serviceCollection.AddTransient<LearningResourceEducationLevelView>();
        serviceCollection.AddTransient<LearningResourceMediaFeatureView>();
        serviceCollection.AddTransient<LearningResourcePeerRatingView>();
        serviceCollection.AddTransient<LearningResourcePhysicalMediaView>();
        serviceCollection.AddTransient<PeerRatingSystemView>();

        return serviceCollection;
    }
}
