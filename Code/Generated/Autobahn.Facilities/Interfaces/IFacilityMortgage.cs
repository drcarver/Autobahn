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
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </summary>
        System.Decimal? FacilityMortgageInterestAmount { get; set; }

        /// <summary>
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </summary>
        System.Decimal? FacilityTotalAssessedValue { get; set; }

        /// <summary>
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </summary>
        Guid? RefFacilityMortgageInterestTypeId { get; set; }

        /// <summary>
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </summary>
        Guid? RefFacilityMortgageTypeId { get; set; }

    }
}
