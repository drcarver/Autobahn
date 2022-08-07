//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityManagementPlanModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityManagementPlanModel Interface
     /// </summary>
    public partial interface IFacilityManagementPlanModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityManagement"/> model
        /// </summary>
        Guid FacilityManagementId { get; set; }

        /// <summary>
        /// Defines the FacilityManagementPlan.FacilitiesPlanDescription non nullable property
        /// </summary>
        System.String FacilitiesPlanDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesPlanType"/> model
        /// </summary>
        Guid? RefFacilitiesPlanTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMgmtEmergencyType"/> model
        /// </summary>
        Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

    }
}
