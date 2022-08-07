//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityMortgageFeeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityMortgageFeeModel Interface
     /// </summary>
    public partial interface IFacilityMortgageFeeModel : IAutobahnBase
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
