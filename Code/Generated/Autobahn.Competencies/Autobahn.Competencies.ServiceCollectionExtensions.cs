//**********************************************************
//* DomainName: Competencies
//* FileName:   Competencies.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Competencies.Interfaces;
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
        serviceCollection.AddTransient<IChildOfCompetencyDefinition, ChildOfCompetencyDefinitionViewModel>();
        serviceCollection.AddTransient<ICompetencyDefAssociation, CompetencyDefAssociationViewModel>();
        serviceCollection.AddTransient<ICompetencyDefEducationLevel, CompetencyDefEducationLevelViewModel>();
        serviceCollection.AddTransient<ICompetencyDefinition, CompetencyDefinitionViewModel>();
        serviceCollection.AddTransient<ICompetencyDefinitionCompetencySet, CompetencyDefinitionCompetencySetViewModel>();
        serviceCollection.AddTransient<ICompetencyDefParent, CompetencyDefParentViewModel>();
        serviceCollection.AddTransient<ICompetencyFramework, CompetencyFrameworkViewModel>();
        serviceCollection.AddTransient<ICompetencySet, CompetencySetViewModel>();
        serviceCollection.AddTransient<ICompetencySetRubric, CompetencySetRubricViewModel>();
        serviceCollection.AddTransient<ICompetencySetRubricCriterion, CompetencySetRubricCriterionViewModel>();
        serviceCollection.AddTransient<ICoreKnowledgeArea, CoreKnowledgeAreaViewModel>();

        // Now the known views
        serviceCollection.AddTransient<ChildOfCompetencyDefinitionView>();
        serviceCollection.AddTransient<CompetencyDefAssociationView>();
        serviceCollection.AddTransient<CompetencyDefEducationLevelView>();
        serviceCollection.AddTransient<CompetencyDefinitionView>();
        serviceCollection.AddTransient<CompetencyDefinitionCompetencySetView>();
        serviceCollection.AddTransient<CompetencyDefParentView>();
        serviceCollection.AddTransient<CompetencyFrameworkView>();
        serviceCollection.AddTransient<CompetencySetView>();
        serviceCollection.AddTransient<CompetencySetRubricView>();
        serviceCollection.AddTransient<CompetencySetRubricCriterionView>();
        serviceCollection.AddTransient<CoreKnowledgeAreaView>();

        return serviceCollection;
    }
}
