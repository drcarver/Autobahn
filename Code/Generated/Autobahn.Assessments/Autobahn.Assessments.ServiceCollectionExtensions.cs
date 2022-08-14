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
        serviceCollection.AddTransient<IAssessment_AssessmentAdministration, Assessment_AssessmentAdministrationViewModel>();
        serviceCollection.AddTransient<IAssessmentAccommodation, AssessmentAccommodationViewModel>();
        serviceCollection.AddTransient<IAssessmentAdministration, AssessmentAdministrationViewModel>();
        serviceCollection.AddTransient<IAssessmentAdministration_Organization, AssessmentAdministration_OrganizationViewModel>();
        serviceCollection.AddTransient<IAssessmentAsset, AssessmentAssetViewModel>();
        serviceCollection.AddTransient<IAssessmentELDevelopmentalDomain, AssessmentELDevelopmentalDomainViewModel>();
        serviceCollection.AddTransient<IAssessmentForm, AssessmentFormViewModel>();
        serviceCollection.AddTransient<IAssessmentForm_AssessmentAsset, AssessmentForm_AssessmentAssetViewModel>();
        serviceCollection.AddTransient<IAssessmentForm_AssessmentFormSection, AssessmentForm_AssessmentFormSectionViewModel>();
        serviceCollection.AddTransient<IAssessmentFormSection, AssessmentFormSectionViewModel>();
        serviceCollection.AddTransient<IAssessmentFormSection_AssessmentAsset, AssessmentFormSection_AssessmentAssetViewModel>();
        serviceCollection.AddTransient<IAssessmentFormSection_AssessmentItem, AssessmentFormSection_AssessmentItemViewModel>();
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
        serviceCollection.AddTransient<IAssessmentParticipantSession_Accommodation, AssessmentParticipantSession_AccommodationViewModel>();
        serviceCollection.AddTransient<IAssessmentPerformanceLevel, AssessmentPerformanceLevelViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedLanguageLearner, AssessmentPersonalNeedLanguageLearnerViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedScreenReader, AssessmentPersonalNeedScreenReaderViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfile, AssessmentPersonalNeedsProfileViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfileContent, AssessmentPersonalNeedsProfileContentViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfileControl, AssessmentPersonalNeedsProfileControlViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfileDisplay, AssessmentPersonalNeedsProfileDisplayViewModel>();
        serviceCollection.AddTransient<IAssessmentPersonalNeedsProfileScreenEnhancement, AssessmentPersonalNeedsProfileScreenEnhancementViewModel>();
        serviceCollection.AddTransient<IAssessmentRegistration, AssessmentRegistrationViewModel>();
        serviceCollection.AddTransient<IAssessmentRegistration_Accommodation, AssessmentRegistration_AccommodationViewModel>();
        serviceCollection.AddTransient<IAssessmentResult, AssessmentResultViewModel>();
        serviceCollection.AddTransient<IAssessmentResult_PerformanceLevel, AssessmentResult_PerformanceLevelViewModel>();
        serviceCollection.AddTransient<IAssessmentResultRubricCriterionResult, AssessmentResultRubricCriterionResultViewModel>();
        serviceCollection.AddTransient<IAssessmentSession, AssessmentSessionViewModel>();
        serviceCollection.AddTransient<IAssessmentSessionStaffRole, AssessmentSessionStaffRoleViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtest, AssessmentSubtestViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtest_AssessmentItem, AssessmentSubtest_AssessmentItemViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtest_CompetencyDefinition, AssessmentSubtest_CompetencyDefinitionViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtestELDevelopmentalDomain, AssessmentSubtestELDevelopmentalDomainViewModel>();
        serviceCollection.AddTransient<IAssessmentSubtestLevelsForWhichDesigned, AssessmentSubtestLevelsForWhichDesignedViewModel>();
        serviceCollection.AddTransient<IGoal, GoalViewModel>();
        serviceCollection.AddTransient<IGoalMeasurement, GoalMeasurementViewModel>();
        serviceCollection.AddTransient<IGoalMeasurementCriterion, GoalMeasurementCriterionViewModel>();
        serviceCollection.AddTransient<IGoalPerformance, GoalPerformanceViewModel>();
        serviceCollection.AddTransient<ILearnerAction, LearnerActionViewModel>();
        serviceCollection.AddTransient<ILearnerActivity, LearnerActivityViewModel>();
        serviceCollection.AddTransient<ILearnerActivity_LearningResource, LearnerActivity_LearningResourceViewModel>();
        serviceCollection.AddTransient<IRubric, RubricViewModel>();
        serviceCollection.AddTransient<IRubricCriterion, RubricCriterionViewModel>();
        serviceCollection.AddTransient<IRubricCriterionLevel, RubricCriterionLevelViewModel>();

        // Now the known views
        serviceCollection.AddTransient<AssessmentView>();
        serviceCollection.AddTransient<Assessment_AssessmentAdministrationView>();
        serviceCollection.AddTransient<AssessmentAccommodationView>();
        serviceCollection.AddTransient<AssessmentAdministrationView>();
        serviceCollection.AddTransient<AssessmentAdministration_OrganizationView>();
        serviceCollection.AddTransient<AssessmentAssetView>();
        serviceCollection.AddTransient<AssessmentELDevelopmentalDomainView>();
        serviceCollection.AddTransient<AssessmentFormView>();
        serviceCollection.AddTransient<AssessmentForm_AssessmentAssetView>();
        serviceCollection.AddTransient<AssessmentForm_AssessmentFormSectionView>();
        serviceCollection.AddTransient<AssessmentFormSectionView>();
        serviceCollection.AddTransient<AssessmentFormSection_AssessmentAssetView>();
        serviceCollection.AddTransient<AssessmentFormSection_AssessmentItemView>();
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
        serviceCollection.AddTransient<AssessmentParticipantSession_AccommodationView>();
        serviceCollection.AddTransient<AssessmentPerformanceLevelView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedLanguageLearnerView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedScreenReaderView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedsProfileView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedsProfileContentView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedsProfileControlView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedsProfileDisplayView>();
        serviceCollection.AddTransient<AssessmentPersonalNeedsProfileScreenEnhancementView>();
        serviceCollection.AddTransient<AssessmentRegistrationView>();
        serviceCollection.AddTransient<AssessmentRegistration_AccommodationView>();
        serviceCollection.AddTransient<AssessmentResultView>();
        serviceCollection.AddTransient<AssessmentResult_PerformanceLevelView>();
        serviceCollection.AddTransient<AssessmentResultRubricCriterionResultView>();
        serviceCollection.AddTransient<AssessmentSessionView>();
        serviceCollection.AddTransient<AssessmentSessionStaffRoleView>();
        serviceCollection.AddTransient<AssessmentSubtestView>();
        serviceCollection.AddTransient<AssessmentSubtest_AssessmentItemView>();
        serviceCollection.AddTransient<AssessmentSubtest_CompetencyDefinitionView>();
        serviceCollection.AddTransient<AssessmentSubtestELDevelopmentalDomainView>();
        serviceCollection.AddTransient<AssessmentSubtestLevelsForWhichDesignedView>();
        serviceCollection.AddTransient<GoalView>();
        serviceCollection.AddTransient<GoalMeasurementView>();
        serviceCollection.AddTransient<GoalMeasurementCriterionView>();
        serviceCollection.AddTransient<GoalPerformanceView>();
        serviceCollection.AddTransient<LearnerActionView>();
        serviceCollection.AddTransient<LearnerActivityView>();
        serviceCollection.AddTransient<LearnerActivity_LearningResourceView>();
        serviceCollection.AddTransient<RubricView>();
        serviceCollection.AddTransient<RubricCriterionView>();
        serviceCollection.AddTransient<RubricCriterionLevelView>();

        return serviceCollection;
    }
}
