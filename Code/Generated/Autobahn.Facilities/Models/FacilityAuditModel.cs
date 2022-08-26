//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityAuditModel.cs
//***************************************************************************

using Autobahn.Interfaces.Facilities;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityAudit Model
     /// </summary>
    public partial class FacilityAuditModel : AutobahnBase, IFacilityAudit
    {
        /// <summary>
        /// Facility Audit Date
        /// <para>
        /// The month, day, and year of the systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20862">Facility Audit Date</a>
        /// </para>
        /// </summary>
        public DateTime? FacilityAuditDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Facility Audit Type
        /// <para>
        /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20845">Facility Audit Type</a>
        /// </para>
        /// </summary>
        public Guid? RefFacilityAuditTypeId { get; set; }

    }
}
