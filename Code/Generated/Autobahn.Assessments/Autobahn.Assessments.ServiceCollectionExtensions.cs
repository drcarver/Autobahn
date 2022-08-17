//**********************************************************
//* DomainName: Assessments
//* FileName:   Assessments.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Assessments.Interfaces;
using Autobahn.Assessments.ViewModels;
using Autobahn.Assessments.Views;

/// <summary>
/// The Service Collection Extensions for the Assessments domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Assessments Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddAssessmentsServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IChildOfAssessmentSubtest, ChildOfAssessmentSubtestViewModel>();
        serviceCollection.AddTransient<IChildOfFormSection, ChildOfFormSectionViewModel>();
        serviceCollection.AddTransient<IGoalMeasurement, GoalMeasurementViewModel>();
        serviceCollection.AddTransient<IGoalMeasurementCriterion, GoalMeasurementCriterionViewModel>();
        serviceCollection.AddTransient<IGoalPerformance, GoalPerformanceViewModel>();

        // Now the known views
        serviceCollection.AddTransient<ChildOfAssessmentSubtestView>();
        serviceCollection.AddTransient<ChildOfFormSectionView>();
        serviceCollection.AddTransient<GoalMeasurementView>();
        serviceCollection.AddTransient<GoalMeasurementCriterionView>();
        serviceCollection.AddTransient<GoalPerformanceView>();

        return serviceCollection;
    }
}
