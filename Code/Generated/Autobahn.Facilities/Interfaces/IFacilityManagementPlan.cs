//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityManagementPlan.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityManagementPlan
     /// </summary>
    public partial interface IFacilityManagementPlan : IAutobahnBase
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
