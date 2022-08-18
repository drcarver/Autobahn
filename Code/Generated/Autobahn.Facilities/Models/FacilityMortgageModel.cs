//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityMortgage Model
     /// </summary>
    public partial class FacilityMortgageModel : AutobahnBase, Interfaces.IFacilityMortgage
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
        /// Facility Mortgage Interest Amount
        /// <para>
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20871">Facility Mortgage Interest Amount</a>
        /// </para>
        /// </summary>
        public System.Decimal? FacilityMortgageInterestAmount { get; set; }

        /// <summary>
        /// Facility Total Assessed Value
        /// <para>
        /// The total assessed value of property that constitutes the basis for public borrowing.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20877">Facility Total Assessed Value</a>
        /// </para>
        /// </summary>
        public System.Decimal? FacilityTotalAssessedValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageInterestType"/> model
        /// </summary>
        public Guid? RefFacilityMortgageInterestTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageType"/> model
        /// </summary>
        public Guid? RefFacilityMortgageTypeId { get; set; }

    }
}
