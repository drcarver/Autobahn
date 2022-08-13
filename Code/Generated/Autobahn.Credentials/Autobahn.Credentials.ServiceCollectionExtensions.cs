//**********************************************************
//* DomainName: Credentials
//* FileName:   Credentials.ServiceCollectionExtensions.cs
//**********************************************************

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
        serviceCollection.AddTransient<Interfaces.ICredentialAward, CredentialAwardViewModel>();
        serviceCollection.AddTransient<Interfaces.ICredentialAwardCredit, CredentialAwardCreditViewModel>();
        serviceCollection.AddTransient<Interfaces.ICredentialAwardEvidence, CredentialAwardEvidenceViewModel>();
        serviceCollection.AddTransient<Interfaces.ICredentialCriteriaCourse, CredentialCriteriaCourseViewModel>();
        serviceCollection.AddTransient<Interfaces.ICredentialDefAgent, CredentialDefAgentViewModel>();
        serviceCollection.AddTransient<Interfaces.ICredentialDefAgentCredential, CredentialDefAgentCredentialViewModel>();
        serviceCollection.AddTransient<Interfaces.ICredentialDefCategory, CredentialDefCategoryViewModel>();
        serviceCollection.AddTransient<Interfaces.ICredentialDefCriteria, CredentialDefCriteriaViewModel>();
        serviceCollection.AddTransient<Interfaces.ICredentialDefIdentifier, CredentialDefIdentifierViewModel>();
        serviceCollection.AddTransient<Interfaces.ICredentialDefinition, CredentialDefinitionViewModel>();
        serviceCollection.AddTransient<Interfaces.ICredentialIssuer, CredentialIssuerViewModel>();
        serviceCollection.AddTransient<Interfaces.ICredentialOffered, CredentialOfferedViewModel>();

        // Now the known views
        serviceCollection.AddTransient<CredentialAwardView>();
        serviceCollection.AddTransient<CredentialAwardCreditView>();
        serviceCollection.AddTransient<CredentialAwardEvidenceView>();
        serviceCollection.AddTransient<CredentialCriteriaCourseView>();
        serviceCollection.AddTransient<CredentialDefAgentView>();
        serviceCollection.AddTransient<CredentialDefAgentCredentialView>();
        serviceCollection.AddTransient<CredentialDefCategoryView>();
        serviceCollection.AddTransient<CredentialDefCriteriaView>();
        serviceCollection.AddTransient<CredentialDefIdentifierView>();
        serviceCollection.AddTransient<CredentialDefinitionView>();
        serviceCollection.AddTransient<CredentialIssuerView>();
        serviceCollection.AddTransient<CredentialOfferedView>();

        return serviceCollection;
    }
}
