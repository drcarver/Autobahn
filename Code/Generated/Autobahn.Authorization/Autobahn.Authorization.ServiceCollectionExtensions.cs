//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   Authorization.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Authorization.Interfaces;
using Autobahn.Authorization.ViewModels;
using Autobahn.Authorization.Views;

/// <summary>
/// The Service Collection Extensions for the Authentication and Authorization domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Authentication and Authorization Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddAuthorizationServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IApplication, ApplicationViewModel>();
        serviceCollection.AddTransient<IAuthentication, AuthenticationViewModel>();
        serviceCollection.AddTransient<IAuthorization, AuthorizationViewModel>();
        serviceCollection.AddTransient<IAuthorizationDocument, AuthorizationDocumentViewModel>();
        serviceCollection.AddTransient<IAutobahnDomain, AutobahnDomainViewModel>();
        serviceCollection.AddTransient<IAutobahnElement, AutobahnElementViewModel>();
        serviceCollection.AddTransient<IAutobahnTable, AutobahnTableViewModel>();
        serviceCollection.AddTransient<IC_CEDSElements, C_CEDSElementsViewModel>();
        serviceCollection.AddTransient<IC_CEDStoNDSMapping, C_CEDStoNDSMappingViewModel>();

        // Now the known views
        serviceCollection.AddTransient<ApplicationView>();
        serviceCollection.AddTransient<AuthenticationView>();
        serviceCollection.AddTransient<AuthorizationView>();
        serviceCollection.AddTransient<AuthorizationDocumentView>();
        serviceCollection.AddTransient<AutobahnDomainView>();
        serviceCollection.AddTransient<AutobahnElementView>();
        serviceCollection.AddTransient<AutobahnTableView>();
        serviceCollection.AddTransient<C_CEDSElementsView>();
        serviceCollection.AddTransient<C_CEDStoNDSMappingView>();

        return serviceCollection;
    }
}
