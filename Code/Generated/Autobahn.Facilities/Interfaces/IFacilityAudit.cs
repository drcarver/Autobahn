//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityAudit.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityAudit Interface
     /// </summary>
    public partial interface IFacilityAudit : IAutobahnBase
    {
        /// <summary>
        /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </summary>
        System.DateTime? FacilityAuditDate { get; set; }

        /// <summary>
        /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </summary>
        Guid? RefFacilityAuditTypeId { get; set; }

    }
}
