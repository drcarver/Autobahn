//**********************************************************
//* DomainName: Credentials
//* FileName:   Credentials.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Credentials.Interfaces;
using Autobahn.Credentials.ViewModels;
using Autobahn.Credentials.Views;

/// <summary>
/// The Service Collection Extensions for the Credentials domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Credentials Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddCredentialsServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<ICredentialAward, CredentialAwardViewModel>();
        serviceCollection.AddTransient<ICredentialAwardCredit, CredentialAwardCreditViewModel>();
        serviceCollection.AddTransient<ICredentialAwardEvidence, CredentialAwardEvidenceViewModel>();
        serviceCollection.AddTransient<ICredentialCriteriaCourse, CredentialCriteriaCourseViewModel>();
        serviceCollection.AddTransient<ICredentialDefAgent, CredentialDefAgentViewModel>();
        serviceCollection.AddTransient<ICredentialDefAgentCredential, CredentialDefAgentCredentialViewModel>();
        serviceCollection.AddTransient<ICredentialDefCategory, CredentialDefCategoryViewModel>();
        serviceCollection.AddTransient<ICredentialDefCriteria, CredentialDefCriteriaViewModel>();
        serviceCollection.AddTransient<ICredentialDefentifier, CredentialDefentifierViewModel>();
        serviceCollection.AddTransient<ICredentialDefIdentifier, CredentialDefIdentifierViewModel>();
        serviceCollection.AddTransient<ICredentialDefinition, CredentialDefinitionViewModel>();
        serviceCollection.AddTransient<ICredentialIssuer, CredentialIssuerViewModel>();
        serviceCollection.AddTransient<ICredentialOffered, CredentialOfferedViewModel>();

        // Now the known views
        serviceCollection.AddTransient<CredentialAwardView>();
        serviceCollection.AddTransient<CredentialAwardCreditView>();
        serviceCollection.AddTransient<CredentialAwardEvidenceView>();
        serviceCollection.AddTransient<CredentialCriteriaCourseView>();
        serviceCollection.AddTransient<CredentialDefAgentView>();
        serviceCollection.AddTransient<CredentialDefAgentCredentialView>();
        serviceCollection.AddTransient<CredentialDefCategoryView>();
        serviceCollection.AddTransient<CredentialDefCriteriaView>();
        serviceCollection.AddTransient<CredentialDefentifierView>();
        serviceCollection.AddTransient<CredentialDefIdentifierView>();
        serviceCollection.AddTransient<CredentialDefinitionView>();
        serviceCollection.AddTransient<CredentialIssuerView>();
        serviceCollection.AddTransient<CredentialOfferedView>();

        return serviceCollection;
    }
}
