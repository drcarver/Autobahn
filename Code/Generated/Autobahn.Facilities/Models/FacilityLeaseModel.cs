//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityLeaseModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityLease Model
     /// </summary>
    public partial class FacilityLeaseModel : AutobahnBase, Interfaces.IFacilityLease
    {
        /// <summary>
        /// Building Area
        /// <para>
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
        /// </para>
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Facility Lease Amount
        /// <para>
        /// The amount of money the school must pay to rent the facility that it is in.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20868">Facility Lease Amount</a>
        /// </para>
        /// </summary>
        public System.Decimal? FacilityLeaseAmount { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseAmountCategory"/> model
        /// </summary>
        public Guid? RefFacilityLeaseAmountCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityLeaseType"/> model
        /// </summary>
        public Guid? RefFacilityLeaseTypeId { get; set; }

    }
}
