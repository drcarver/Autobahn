//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityFinanceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityFinanceModel Interface
     /// </summary>
    public partial interface IFacilityFinanceModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.FacilityReplacementValue nullable property
        /// </summary>
        System.Decimal? FacilityReplacementValue { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.IndebtednessAmountAllowed nullable property
        /// </summary>
        System.Decimal? IndebtednessAmountAllowed { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.InsuranceDeductible nullable property
        /// </summary>
        System.Decimal? InsuranceDeductible { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.PublicEducationMillRate nullable property
        /// </summary>
        System.Decimal? PublicEducationMillRate { get; set; }

    }
}
