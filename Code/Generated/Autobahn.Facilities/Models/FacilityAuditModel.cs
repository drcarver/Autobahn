//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityAuditModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityAudit Model
     /// </summary>
    public partial class FacilityAuditModel : AutobahnBase, Interfaces.IFacilityAudit
    {
        /// <summary>
        /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </summary>
        public System.DateTime? FacilityAuditDate { get; set; }

        /// <summary>
        /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </summary>
        public Guid? RefFacilityAuditTypeId { get; set; }

    }
}
