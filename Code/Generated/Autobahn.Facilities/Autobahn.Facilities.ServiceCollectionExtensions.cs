//**********************************************************
//* DomainName: Facilities
//* FileName:   Facilities.ServiceCollectionExtensions.cs
//**********************************************************

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
        serviceCollection.AddTransient<Interfaces.IBuildingSpace, BuildingSpaceViewModel>();
        serviceCollection.AddTransient<Interfaces.IBuildingSpaceUtilization, BuildingSpaceUtilizationViewModel>();
        serviceCollection.AddTransient<Interfaces.IBuildingSystemCategory, BuildingSystemCategoryViewModel>();
        serviceCollection.AddTransient<Interfaces.IBuildingSystemComponent, BuildingSystemComponentViewModel>();
        serviceCollection.AddTransient<Interfaces.IBuildingSystemComponentService, BuildingSystemComponentServiceViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacility, FacilityViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityAudit, FacilityAuditViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityCompliance, FacilityComplianceViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityDesign, FacilityDesignViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityDesignConstruction, FacilityDesignConstructionViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityEnergy, FacilityEnergyViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityFinance, FacilityFinanceViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityFinancial, FacilityFinancialViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityHazard, FacilityHazardViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityJointUse, FacilityJointUseViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityLease, FacilityLeaseViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityLocation, FacilityLocationViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityManagement, FacilityManagementViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityManagementPlan, FacilityManagementPlanViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityMandate, FacilityMandateViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityMortgage, FacilityMortgageViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityMortgageFee, FacilityMortgageFeeViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityRelationship, FacilityRelationshipViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilitySchoolDesign, FacilitySchoolDesignViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilitySite, FacilitySiteViewModel>();
        serviceCollection.AddTransient<Interfaces.IFacilityUtilization, FacilityUtilizationViewModel>();

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
