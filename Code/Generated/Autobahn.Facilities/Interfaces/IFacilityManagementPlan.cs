//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityManagementPlan.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityManagementPlan Interface
     /// </summary>
    public partial interface IFacilityManagementPlan : IAutobahnBase
    {
        /// <summary>
        /// The type of abnormal and urgent circumstances that disrupt the normal operation of the building, threaten the health and safety of the occupants, or require an emergency response.
        /// </summary>
        Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

    }
}
