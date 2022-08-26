//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityAudit.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Facilities
{
     /// <summary>
     /// The IFacilityAudit Interface
     /// </summary>
    public partial interface IFacilityAudit : IAutobahnBase
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
        DateTime? FacilityAuditDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Facility Audit Type
        /// <para>
        /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20845">Facility Audit Type</a>
        /// </para>
        /// </summary>
        Guid? RefFacilityAuditTypeId { get; set; }

    }
}
