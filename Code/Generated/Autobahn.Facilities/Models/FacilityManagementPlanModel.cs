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
        /// 
        /// </summary>
        public  FacilitiesPlanDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilitiesPlanTypeId { get; set; }

    }
}
