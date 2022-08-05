//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityAudit.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityAudit
     /// </summary>
    public partial class FacilityAudit : AutobahnBase, Interfaces.IFacilityAudit
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityAudit.FacilityAuditDate nullable property
        /// </summary>
        public System.DateTime? FacilityAuditDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityAuditType"/> model
        /// </summary>
        public Guid? RefFacilityAuditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
