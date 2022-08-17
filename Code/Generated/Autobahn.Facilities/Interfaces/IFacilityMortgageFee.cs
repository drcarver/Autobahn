//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityMortgageFee.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityMortgageFee Interface
     /// </summary>
    public partial interface IFacilityMortgageFee : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
        /// </summary>
        Guid FacilityMortgageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFacilityFinancingFeeType"/> model
        /// </summary>
        Guid RefFacilityFinancingFeeTypeId { get; set; }

    }
}
