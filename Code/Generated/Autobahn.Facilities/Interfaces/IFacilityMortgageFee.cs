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
        /// The type of fee that one must pay when getting a mortgage.
        /// </summary>
        Guid RefFacilityFinancingFeeTypeId { get; set; }

    }
}
