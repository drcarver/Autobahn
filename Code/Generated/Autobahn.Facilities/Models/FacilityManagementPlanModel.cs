//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementPlanModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityManagementPlan Model
     /// </summary>
    public partial class FacilityManagementPlanModel : AutobahnBase, Interfaces.IFacilityManagementPlan
    {
        /// <summary>
        /// The type of abnormal and urgent circumstances that disrupt the normal operation of the building, threaten the health and safety of the occupants, or require an emergency response.
        /// </summary>
        public System.String FacilitiesPlanDescription { get; set; }

        /// <summary>
        /// The type of abnormal and urgent circumstances that disrupt the normal operation of the building, threaten the health and safety of the occupants, or require an emergency response.
        /// </summary>
        public Guid FacilityManagementId { get; set; }

        /// <summary>
        /// The type of abnormal and urgent circumstances that disrupt the normal operation of the building, threaten the health and safety of the occupants, or require an emergency response.
        /// </summary>
        public Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

        /// <summary>
        /// The type of abnormal and urgent circumstances that disrupt the normal operation of the building, threaten the health and safety of the occupants, or require an emergency response.
        /// </summary>
        public Guid? RefFacilitiesPlanTypeId { get; set; }

    }
}
