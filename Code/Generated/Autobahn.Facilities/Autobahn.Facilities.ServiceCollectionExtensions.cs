//**********************************************************
//* DomainName: Facilities
//* FileName:   Facilities.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;
using Autobahn.Facilities.ViewModels;
using Autobahn.Facilities.Views;

/// <summary>
/// The Service Collection Extensions for the Facilities domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Facilities Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddFacilitiesServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IBuildingSpace, BuildingSpaceViewModel>();
        serviceCollection.AddTransient<IBuildingSpaceUtilization, BuildingSpaceUtilizationViewModel>();
        serviceCollection.AddTransient<IBuildingSystemCategory, BuildingSystemCategoryViewModel>();
        serviceCollection.AddTransient<IBuildingSystemComponent, BuildingSystemComponentViewModel>();
        serviceCollection.AddTransient<IBuildingSystemComponentService, BuildingSystemComponentServiceViewModel>();
        serviceCollection.AddTransient<IFacility, FacilityViewModel>();
        serviceCollection.AddTransient<IFacilityAudit, FacilityAuditViewModel>();
        serviceCollection.AddTransient<IFacilityCompliance, FacilityComplianceViewModel>();
        serviceCollection.AddTransient<IFacilityDesign, FacilityDesignViewModel>();
        serviceCollection.AddTransient<IFacilityDesignConstruction, FacilityDesignConstructionViewModel>();
        serviceCollection.AddTransient<IFacilityEnergy, FacilityEnergyViewModel>();
        serviceCollection.AddTransient<IFacilityFinance, FacilityFinanceViewModel>();
        serviceCollection.AddTransient<IFacilityFinancial, FacilityFinancialViewModel>();
        serviceCollection.AddTransient<IFacilityHazard, FacilityHazardViewModel>();
        serviceCollection.AddTransient<IFacilityJointUse, FacilityJointUseViewModel>();
        serviceCollection.AddTransient<IFacilityLease, FacilityLeaseViewModel>();
        serviceCollection.AddTransient<IFacilityLocation, FacilityLocationViewModel>();
        serviceCollection.AddTransient<IFacilityManagement, FacilityManagementViewModel>();
        serviceCollection.AddTransient<IFacilityManagementPlan, FacilityManagementPlanViewModel>();
        serviceCollection.AddTransient<IFacilityMandate, FacilityMandateViewModel>();
        serviceCollection.AddTransient<IFacilityMortgage, FacilityMortgageViewModel>();
        serviceCollection.AddTransient<IFacilityMortgageFee, FacilityMortgageFeeViewModel>();
        serviceCollection.AddTransient<IFacilityRelationship, FacilityRelationshipViewModel>();
        serviceCollection.AddTransient<IFacilitySchoolDesign, FacilitySchoolDesignViewModel>();
        serviceCollection.AddTransient<IFacilitySite, FacilitySiteViewModel>();
        serviceCollection.AddTransient<IFacilityUtilization, FacilityUtilizationViewModel>();

        // Now the known views
        serviceCollection.AddTransient<BuildingSpaceView>();
        serviceCollection.AddTransient<BuildingSpaceUtilizationView>();
        serviceCollection.AddTransient<BuildingSystemCategoryView>();
        serviceCollection.AddTransient<BuildingSystemComponentView>();
        serviceCollection.AddTransient<BuildingSystemComponentServiceView>();
        serviceCollection.AddTransient<FacilityView>();
        serviceCollection.AddTransient<FacilityAuditView>();
        serviceCollection.AddTransient<FacilityComplianceView>();
        serviceCollection.AddTransient<FacilityDesignView>();
        serviceCollection.AddTransient<FacilityDesignConstructionView>();
        serviceCollection.AddTransient<FacilityEnergyView>();
        serviceCollection.AddTransient<FacilityFinanceView>();
        serviceCollection.AddTransient<FacilityFinancialView>();
        serviceCollection.AddTransient<FacilityHazardView>();
        serviceCollection.AddTransient<FacilityJointUseView>();
        serviceCollection.AddTransient<FacilityLeaseView>();
        serviceCollection.AddTransient<FacilityLocationView>();
        serviceCollection.AddTransient<FacilityManagementView>();
        serviceCollection.AddTransient<FacilityManagementPlanView>();
        serviceCollection.AddTransient<FacilityMandateView>();
        serviceCollection.AddTransient<FacilityMortgageView>();
        serviceCollection.AddTransient<FacilityMortgageFeeView>();
        serviceCollection.AddTransient<FacilityRelationshipView>();
        serviceCollection.AddTransient<FacilitySchoolDesignView>();
        serviceCollection.AddTransient<FacilitySiteView>();
        serviceCollection.AddTransient<FacilityUtilizationView>();

        return serviceCollection;
    }
}
