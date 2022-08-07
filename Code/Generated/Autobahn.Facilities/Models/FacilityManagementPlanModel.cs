//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityManagementPlanModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityManagementPlan Model
     /// </summary>
    public partial class FacilityManagementPlanModel : AutobahnBase, Interfaces.IFacilityManagementPlanModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityManagement"/> model
        /// </summary>
        public Guid FacilityManagementId { get; set; }

        /// <summary>
        /// Defines the FacilityManagementPlan.FacilitiesPlanDescription non nullable property
        /// </summary>
        public System.String FacilitiesPlanDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesPlanType"/> model
        /// </summary>
        public Guid? RefFacilitiesPlanTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMgmtEmergencyType"/> model
        /// </summary>
        public Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
