//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyLearning.ServiceCollectionExtensions.cs
//**********************************************************

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
        serviceCollection.AddTransient<Interfaces.IEarlyChildhoodCredential, EarlyChildhoodCredentialViewModel>();
        serviceCollection.AddTransient<Interfaces.IEarlyChildhoodProgramTypeOffered, EarlyChildhoodProgramTypeOfferedViewModel>();
        serviceCollection.AddTransient<Interfaces.IELChildDemographic, ELChildDemographicViewModel>();
        serviceCollection.AddTransient<Interfaces.IELChildDevelopmentalAssessment, ELChildDevelopmentalAssessmentViewModel>();
        serviceCollection.AddTransient<Interfaces.IELChildHealth, ELChildHealthViewModel>();
        serviceCollection.AddTransient<Interfaces.IELChildIndividualizedProgram, ELChildIndividualizedProgramViewModel>();
        serviceCollection.AddTransient<Interfaces.IELChildOutcomeSummary, ELChildOutcomeSummaryViewModel>();
        serviceCollection.AddTransient<Interfaces.IELChildProgramEligibility, ELChildProgramEligibilityViewModel>();
        serviceCollection.AddTransient<Interfaces.IELChildService, ELChildServiceViewModel>();
        serviceCollection.AddTransient<Interfaces.IELChildServicesApplication, ELChildServicesApplicationViewModel>();
        serviceCollection.AddTransient<Interfaces.IELChildTransitionPlan, ELChildTransitionPlanViewModel>();
        serviceCollection.AddTransient<Interfaces.IELClassSection, ELClassSectionViewModel>();
        serviceCollection.AddTransient<Interfaces.IELClassSectionService, ELClassSectionServiceViewModel>();
        serviceCollection.AddTransient<Interfaces.IELEnrollment, ELEnrollmentViewModel>();
        serviceCollection.AddTransient<Interfaces.IELEnrollmentOtherFunding, ELEnrollmentOtherFundingViewModel>();
        serviceCollection.AddTransient<Interfaces.IELFacilityLicensing, ELFacilityLicensingViewModel>();
        serviceCollection.AddTransient<Interfaces.IELOrganization, ELOrganizationViewModel>();
        serviceCollection.AddTransient<Interfaces.IELOrganizationAvailability, ELOrganizationAvailabilityViewModel>();
        serviceCollection.AddTransient<Interfaces.IELOrganizationFund, ELOrganizationFundViewModel>();
        serviceCollection.AddTransient<Interfaces.IELOrganizationFunds, ELOrganizationFundsViewModel>();
        serviceCollection.AddTransient<Interfaces.IELOrganizationMonitoring, ELOrganizationMonitoringViewModel>();
        serviceCollection.AddTransient<Interfaces.IELProgramLicensing, ELProgramLicensingViewModel>();
        serviceCollection.AddTransient<Interfaces.IELQualityInitiative, ELQualityInitiativeViewModel>();
        serviceCollection.AddTransient<Interfaces.IELQualityRatingImprovement, ELQualityRatingImprovementViewModel>();
        serviceCollection.AddTransient<Interfaces.IELServicePartner, ELServicePartnerViewModel>();
        serviceCollection.AddTransient<Interfaces.IELStaff, ELStaffViewModel>();
        serviceCollection.AddTransient<Interfaces.IELStaffAssignment, ELStaffAssignmentViewModel>();
        serviceCollection.AddTransient<Interfaces.IELStaffEducation, ELStaffEducationViewModel>();
        serviceCollection.AddTransient<Interfaces.IELStaffEmployment, ELStaffEmploymentViewModel>();

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
