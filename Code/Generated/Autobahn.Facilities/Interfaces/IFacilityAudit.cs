//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityAudit.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityAudit
     /// </summary>
    public partial interface IFacilityAudit : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityAudit.FacilityAuditDate nullable property
        /// </summary>
        System.DateTime? FacilityAuditDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityAuditType"/> model
        /// </summary>
        Guid? RefFacilityAuditTypeId { get; set; }

    }
}
