//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyLearning.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.EarlyLearning.Interfaces;
using Autobahn.EarlyLearning.ViewModels;
using Autobahn.EarlyLearning.Views;

/// <summary>
/// The Service Collection Extensions for the Early Learning (EL) domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Early Learning (EL) Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddEarlyLearningServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IEarlyChildhoodCredential, EarlyChildhoodCredentialViewModel>();
        serviceCollection.AddTransient<IEarlyChildhoodProgramTypeOffered, EarlyChildhoodProgramTypeOfferedViewModel>();
        serviceCollection.AddTransient<IELChildDemographic, ELChildDemographicViewModel>();
        serviceCollection.AddTransient<IELChildDevelopmentalAssessment, ELChildDevelopmentalAssessmentViewModel>();
        serviceCollection.AddTransient<IELChildHealth, ELChildHealthViewModel>();
        serviceCollection.AddTransient<IELChildIndividualizedProgram, ELChildIndividualizedProgramViewModel>();
        serviceCollection.AddTransient<IELChildOutcomeSummary, ELChildOutcomeSummaryViewModel>();
        serviceCollection.AddTransient<IELChildProgramEligibility, ELChildProgramEligibilityViewModel>();
        serviceCollection.AddTransient<IELChildService, ELChildServiceViewModel>();
        serviceCollection.AddTransient<IELChildServicesApplication, ELChildServicesApplicationViewModel>();
        serviceCollection.AddTransient<IELChildTransitionPlan, ELChildTransitionPlanViewModel>();
        serviceCollection.AddTransient<IELClassSection, ELClassSectionViewModel>();
        serviceCollection.AddTransient<IELClassSectionService, ELClassSectionServiceViewModel>();
        serviceCollection.AddTransient<IELEnrollment, ELEnrollmentViewModel>();
        serviceCollection.AddTransient<IELEnrollmentOtherFunding, ELEnrollmentOtherFundingViewModel>();
        serviceCollection.AddTransient<IELFacilityLicensing, ELFacilityLicensingViewModel>();
        serviceCollection.AddTransient<IELOrganization, ELOrganizationViewModel>();
        serviceCollection.AddTransient<IELOrganizationAvailability, ELOrganizationAvailabilityViewModel>();
        serviceCollection.AddTransient<IELOrganizationFund, ELOrganizationFundViewModel>();
        serviceCollection.AddTransient<IELOrganizationFunds, ELOrganizationFundsViewModel>();
        serviceCollection.AddTransient<IELOrganizationMonitoring, ELOrganizationMonitoringViewModel>();
        serviceCollection.AddTransient<IELProgramLicensing, ELProgramLicensingViewModel>();
        serviceCollection.AddTransient<IELQualityInitiative, ELQualityInitiativeViewModel>();
        serviceCollection.AddTransient<IELQualityRatingImprovement, ELQualityRatingImprovementViewModel>();
        serviceCollection.AddTransient<IELServicePartner, ELServicePartnerViewModel>();
        serviceCollection.AddTransient<IELStaff, ELStaffViewModel>();
        serviceCollection.AddTransient<IELStaffAssignment, ELStaffAssignmentViewModel>();
        serviceCollection.AddTransient<IELStaffEducation, ELStaffEducationViewModel>();
        serviceCollection.AddTransient<IELStaffEmployment, ELStaffEmploymentViewModel>();

        // Now the known views
        serviceCollection.AddTransient<EarlyChildhoodCredentialView>();
        serviceCollection.AddTransient<EarlyChildhoodProgramTypeOfferedView>();
        serviceCollection.AddTransient<ELChildDemographicView>();
        serviceCollection.AddTransient<ELChildDevelopmentalAssessmentView>();
        serviceCollection.AddTransient<ELChildHealthView>();
        serviceCollection.AddTransient<ELChildIndividualizedProgramView>();
        serviceCollection.AddTransient<ELChildOutcomeSummaryView>();
        serviceCollection.AddTransient<ELChildProgramEligibilityView>();
        serviceCollection.AddTransient<ELChildServiceView>();
        serviceCollection.AddTransient<ELChildServicesApplicationView>();
        serviceCollection.AddTransient<ELChildTransitionPlanView>();
        serviceCollection.AddTransient<ELClassSectionView>();
        serviceCollection.AddTransient<ELClassSectionServiceView>();
        serviceCollection.AddTransient<ELEnrollmentView>();
        serviceCollection.AddTransient<ELEnrollmentOtherFundingView>();
        serviceCollection.AddTransient<ELFacilityLicensingView>();
        serviceCollection.AddTransient<ELOrganizationView>();
        serviceCollection.AddTransient<ELOrganizationAvailabilityView>();
        serviceCollection.AddTransient<ELOrganizationFundView>();
        serviceCollection.AddTransient<ELOrganizationFundsView>();
        serviceCollection.AddTransient<ELOrganizationMonitoringView>();
        serviceCollection.AddTransient<ELProgramLicensingView>();
        serviceCollection.AddTransient<ELQualityInitiativeView>();
        serviceCollection.AddTransient<ELQualityRatingImprovementView>();
        serviceCollection.AddTransient<ELServicePartnerView>();
        serviceCollection.AddTransient<ELStaffView>();
        serviceCollection.AddTransient<ELStaffAssignmentView>();
        serviceCollection.AddTransient<ELStaffEducationView>();
        serviceCollection.AddTransient<ELStaffEmploymentView>();

        return serviceCollection;
    }
}
