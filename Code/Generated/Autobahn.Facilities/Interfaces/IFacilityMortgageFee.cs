//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityMortgageFee.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityMortgageFee
     /// </summary>
    public partial interface IFacilityMortgageFee : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityMortgage"/> model
        /// </summary>
        Guid FacilityMortgageId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefFacilityFinancingFeeType"/> model
        /// </summary>
        Guid RefFacilityFinancingFeeTypeId { get; set; }

    }
}
