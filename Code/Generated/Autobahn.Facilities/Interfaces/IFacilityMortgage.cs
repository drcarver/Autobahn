//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityMortgage.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityMortgage Interface
     /// </summary>
    public partial interface IFacilityMortgage : IAutobahnBase
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
        Guid FacilityId { get; set; }

        /// <summary>
        /// Facility Mortgage Interest Amount
        /// <para>
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20871">Facility Mortgage Interest Amount</a>
        /// </para>
        /// </summary>
        System.Decimal? FacilityMortgageInterestAmount { get; set; }

        /// <summary>
        /// Facility Total Assessed Value
        /// <para>
        /// The total assessed value of property that constitutes the basis for public borrowing.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20877">Facility Total Assessed Value</a>
        /// </para>
        /// </summary>
        System.Decimal? FacilityTotalAssessedValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFacilityMortgageInterestType"/> model
        /// </summary>
        Guid? RefFacilityMortgageInterestTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFacilityMortgageType"/> model
        /// </summary>
        Guid? RefFacilityMortgageTypeId { get; set; }

    }
}
