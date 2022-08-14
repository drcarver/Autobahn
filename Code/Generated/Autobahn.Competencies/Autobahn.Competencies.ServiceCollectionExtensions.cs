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
        serviceCollection.AddTransient<ICompetencyDefAssociation, CompetencyDefAssociationViewModel>();
        serviceCollection.AddTransient<ICompetencyDefEducationLevel, CompetencyDefEducationLevelViewModel>();
        serviceCollection.AddTransient<ICompetencyDefinition, CompetencyDefinitionViewModel>();
        serviceCollection.AddTransient<ICompetencyDefinition_CompetencySet, CompetencyDefinition_CompetencySetViewModel>();
        serviceCollection.AddTransient<ICompetencyFramework, CompetencyFrameworkViewModel>();
        serviceCollection.AddTransient<ICompetencySet, CompetencySetViewModel>();
        serviceCollection.AddTransient<ICompetencySet_Rubric, CompetencySet_RubricViewModel>();
        serviceCollection.AddTransient<ICompetencySet_RubricCriterion, CompetencySet_RubricCriterionViewModel>();

        // Now the known views
        serviceCollection.AddTransient<CompetencyDefAssociationView>();
        serviceCollection.AddTransient<CompetencyDefEducationLevelView>();
        serviceCollection.AddTransient<CompetencyDefinitionView>();
        serviceCollection.AddTransient<CompetencyDefinition_CompetencySetView>();
        serviceCollection.AddTransient<CompetencyFrameworkView>();
        serviceCollection.AddTransient<CompetencySetView>();
        serviceCollection.AddTransient<CompetencySet_RubricView>();
        serviceCollection.AddTransient<CompetencySet_RubricCriterionView>();

        return serviceCollection;
    }
}
