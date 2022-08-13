//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageFeeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityMortgageFee Model
     /// </summary>
    public partial class FacilityMortgageFeeModel : AutobahnBase, Interfaces.IFacilityMortgageFee
    {
        /// <summary>
        /// The type of fee that one must pay when getting a mortgage.
        /// </summary>
        public Guid FacilityMortgageId { get; set; }

        /// <summary>
        /// The type of fee that one must pay when getting a mortgage.
        /// </summary>
        public Guid RefFacilityFinancingFeeTypeId { get; set; }

    }
}
