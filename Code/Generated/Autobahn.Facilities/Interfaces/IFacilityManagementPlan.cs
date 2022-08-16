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
        /// 
        /// </summary>
         FacilitiesPlanDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilitiesPlanTypeId { get; set; }

    }
}
