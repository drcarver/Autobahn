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
        serviceCollection.AddTransient<IAssessment, AssessmentViewModel>();
        serviceCollection.AddTransient<IAssessmentAccommodation, AssessmentAccommodationViewModel>();
        serviceCollection.AddTransient<IAssessmentAdministration, AssessmentAdministrationViewModel>();
        serviceCollection.AddTransient<IAssessmentAdministrationOrganization, AssessmentAdministrationOrganizationViewModel>();
        serviceCollection.AddTransient<IAssessmentAssessmentAdministration, AssessmentAssessmentAdministrationViewModel>();
        serviceCollection.AddTransient<IAssessmentAsset, AssessmentAssetViewModel>();
        serviceCollection.AddTransient<IAssessmentELDevelopmentalDomain, AssessmentELDevelopmentalDomainViewModel>();
        serviceCollection.AddTransient<IAssessmentForm, AssessmentFormViewModel>();
        serviceCollection.AddTransient<IAssessmentFormAssessmentAsset, AssessmentFormAssessmentAssetViewModel>();
        serviceCollection.AddTransient<IAssessmentFormAssessmentFormSection, AssessmentFormAssessmentFormSectionViewModel>();
        serviceCollection.AddTransient<IAssessmentFormSection, AssessmentFormSectionViewModel>();
        serviceCollection.AddTransient<IAssessmentFormSectionAssessmentAsset, AssessmentFormSectionAssessmentAssetViewModel>();
        serviceCollection.AddTransient<IAssessmentFormSectionAssessmentItem, AssessmentFormSectionAssessmentItemViewModel>();
        serviceCollection.AddTransient<IAssessmentItem, AssessmentItemViewModel>();
        serviceCollection.AddTransient<IAssessmentItemApip, AssessmentItemApipViewModel>();
        serviceCollection.AddTransient<IAssessmentItemApipDescription, AssessmentItemApipDescriptionViewModel>();
        serviceCollection.AddTransient<IAssessmentItemCharacteristic, AssessmentItemCharacteristicViewModel>();
        serviceCollection.AddTransient<IAssessmentItemPossibleResponse, AssessmentItemPossibleResponseViewModel>();
        serviceCollection.AddTransient<IAssessmentItemResponse, AssessmentItemResponseViewModel>();
        serviceCollection.AddTransient<IAssessmentItemResponseTheory, AssessmentItemResponseTheoryViewModel>();
        serviceCollection.AddTransient<IAssessmentItemRubricCriterionResult, AssessmentItemRubricCriterionResultViewModel>();
        serviceCollection.AddTransient<IAssessmentLanguage, AssessmentLanguageViewModel>();
        serviceCollection.AddTransient<IAssessmentLevelsForWhichDesigned, AssessmentLevelsForWhichDesignedViewModel>();
        serviceCollection.AddTransient<IAssessmentNeedApipContent, AssessmentNeedApipContentViewModel>();
        serviceCollection.AddTransient<IAssessmentNeedApipControl, AssessmentNeedApipControlViewModel>();
        serviceCollection.AddTransient<IAssessmentNeedApipDisplay, AssessmentNeedApipDisplayViewModel>();
        serviceCollection.AddTransient<IAssessmentNeedBraille, AssessmentNeedBrailleViewModel>();
        serviceCollection.AddTransient<IAssessmentNeedScreenEnhancement, AssessmentNeedScreenEnhancementViewModel>();
        serviceCollection.AddTransient<IAssessmentParticipantSession, AssessmentParticipantSessionViewModel>();
        serviceCollection.AddTransient<IAssessmentParticipantSessionAccommodation, AssessmentParticipantSessionAccommodationViewModel>();
        serviceCollection.AddTransient<IAssessmentPerformanceLevel, AssessmentPerformanceLevelViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedLanguageLearner, AssessmentPersonalNeedLanguageLearnerViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedScreenReader, AssessmentPersonalNeedScreenReaderViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfile, AssessmentPersonalNeedsProfileViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfileContent, AssessmentPersonalNeedsProfileContentViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfileControl, AssessmentPersonalNeedsProfileControlViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfileDisplay, AssessmentPersonalNeedsProfileDisplayViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfileScreenEnhancement, AssessmentPersonalNeedsProfileScreenEnhancementViewModel>();
        serviceCollection.AddTransient<IAssessmentRegistration, AssessmentRegistrationViewModel>();
        serviceCollection.AddTransient<IAssessmentRegistrationAccommodation, AssessmentRegistrationAccommodationViewModel>();
        serviceCollection.AddTransient<IAssessmentResult, AssessmentResultViewModel>();
        serviceCollection.AddTransient<IAssessmentResultPerformanceLevel, AssessmentResultPerformanceLevelViewModel>();
        serviceCollection.AddTransient<IAssessmentResultRubricCriterionResult, AssessmentResultRubricCriterionResultViewModel>();
        serviceCollection.AddTransient<IAssessmentSession, AssessmentSessionViewModel>();
        serviceCollection.AddTransient<IAssessmentSessionStaffRole, AssessmentSessionStaffRoleViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtest, AssessmentSubtestViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtestAssessmentItem, AssessmentSubtestAssessmentItemViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtestCompetencyDefinition, AssessmentSubtestCompetencyDefinitionViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtestELDevelopmentalDomain, AssessmentSubtestELDevelopmentalDomainViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtestLevelsForWhichDesigned, AssessmentSubtestLevelsForWhichDesignedViewModel>();
        serviceCollection.AddTransient<IGoal, GoalViewModel>();
        serviceCollection.AddTransient<IGoalMeasurement, GoalMeasurementViewModel>();
        serviceCollection.AddTransient<IGoalMeasurementCriterion, GoalMeasurementCriterionViewModel>();
        serviceCollection.AddTransient<IGoalPerformance, GoalPerformanceViewModel>();
        serviceCollection.AddTransient<ILearnerAction, LearnerActionViewModel>();
        serviceCollection.AddTransient<ILearnerActivity, LearnerActivityViewModel>();
        serviceCollection.AddTransient<ILearnerActivityLearningResource, LearnerActivityLearningResourceViewModel>();
        serviceCollection.AddTransient<IRubric, RubricViewModel>();
        serviceCollection.AddTransient<IRubricCriterion, RubricCriterionViewModel>();
        serviceCollection.AddTransient<IRubricCriterionLevel, RubricCriterionLevelViewModel>();

        // Now the known views
        serviceCollection.AddTransient<AssessmentView>();
        serviceCollection.AddTransient<AssessmentAccommodationView>();
        serviceCollection.AddTransient<AssessmentAdministrationView>();
        serviceCollection.AddTransient<AssessmentAdministrationOrganizationView>();
        serviceCollection.AddTransient<AssessmentAssessmentAdministrationView>();
        serviceCollection.AddTransient<AssessmentAssetView>();
        serviceCollection.AddTransient<AssessmentELDevelopmentalDomainView>();
        serviceCollection.AddTransient<AssessmentFormView>();
        serviceCollection.AddTransient<AssessmentFormAssessmentAssetView>();
        serviceCollection.AddTransient<AssessmentFormAssessmentFormSectionView>();
        serviceCollection.AddTransient<AssessmentFormSectionView>();
        serviceCollection.AddTransient<AssessmentFormSectionAssessmentAssetView>();
        serviceCollection.AddTransient<AssessmentFormSectionAssessmentItemView>();
        serviceCollection.AddTransient<AssessmentItemView>();
        serviceCollection.AddTransient<AssessmentItemApipView>();
        serviceCollection.AddTransient<AssessmentItemApipDescriptionView>();
        serviceCollection.AddTransient<AssessmentItemCharacteristicView>();
        serviceCollection.AddTransient<AssessmentItemPossibleResponseView>();
        serviceCollection.AddTransient<AssessmentItemResponseView>();
        serviceCollection.AddTransient<AssessmentItemResponseTheoryView>();
        serviceCollection.AddTransient<AssessmentItemRubricCriterionResultView>();
        serviceCollection.AddTransient<AssessmentLanguageView>();
        serviceCollection.AddTransient<AssessmentLevelsForWhichDesignedView>();
        serviceCollection.AddTransient<AssessmentNeedApipContentView>();
        serviceCollection.AddTransient<AssessmentNeedApipControlView>();
        serviceCollection.AddTransient<AssessmentNeedApipDisplayView>();
        serviceCollection.AddTransient<AssessmentNeedBrailleView>();
        serviceCollection.AddTransient<AssessmentNeedScreenEnhancementView>();
        serviceCollection.AddTransient<AssessmentParticipantSessionView>();
        serviceCollection.AddTransient<AssessmentParticipantSessionAccommodationView>();
        serviceCollection.AddTransient<AssessmentPerformanceLevelView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedLanguageLearnerView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedScreenReaderView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedsProfileView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedsProfileContentView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedsProfileControlView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedsProfileDisplayView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedsProfileScreenEnhancementView>();
        serviceCollection.AddTransient<AssessmentRegistrationView>();
        serviceCollection.AddTransient<AssessmentRegistrationAccommodationView>();
        serviceCollection.AddTransient<AssessmentResultView>();
        serviceCollection.AddTransient<AssessmentResultPerformanceLevelView>();
        serviceCollection.AddTransient<AssessmentResultRubricCriterionResultView>();
        serviceCollection.AddTransient<AssessmentSessionView>();
        serviceCollection.AddTransient<AssessmentSessionStaffRoleView>();
        serviceCollection.AddTransient<AssessmentSubtestView>();
        serviceCollection.AddTransient<AssessmentSubtestAssessmentItemView>();
        serviceCollection.AddTransient<AssessmentSubtestCompetencyDefinitionView>();
        serviceCollection.AddTransient<AssessmentSubtestELDevelopmentalDomainView>();
        serviceCollection.AddTransient<AssessmentSubtestLevelsForWhichDesignedView>();
        serviceCollection.AddTransient<GoalView>();
        serviceCollection.AddTransient<GoalMeasurementView>();
        serviceCollection.AddTransient<GoalMeasurementCriterionView>();
        serviceCollection.AddTransient<GoalPerformanceView>();
        serviceCollection.AddTransient<LearnerActionView>();
        serviceCollection.AddTransient<LearnerActivityView>();
        serviceCollection.AddTransient<LearnerActivityLearningResourceView>();
        serviceCollection.AddTransient<RubricView>();
        serviceCollection.AddTransient<RubricCriterionView>();
        serviceCollection.AddTransient<RubricCriterionLevelView>();

        return serviceCollection;
    }
}
