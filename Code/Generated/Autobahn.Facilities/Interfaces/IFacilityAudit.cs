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
        /// Facility Audit Date
        /// <para>
        /// The month, day, and year of the systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20862">Facility Audit Date</a>
        /// </para>
        /// </summary>
        System.DateTime? FacilityAuditDate { get; set; }

        /// <summary>
        /// Building Area
        /// <para>
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
        /// </para>
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityAuditType"/> model
        /// </summary>
        Guid? RefFacilityAuditTypeId { get; set; }

    }
}
