//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityFinance.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityFinance Interface
     /// </summary>
    public partial interface IFacilityFinance : IAutobahnBase
    {
        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        System.Decimal? FacilityReplacementValue { get; set; }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        System.Decimal? IndebtednessAmountAllowed { get; set; }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        System.Decimal? InsuranceDeductible { get; set; }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        System.Decimal? PublicEducationMillRate { get; set; }

    }
}
