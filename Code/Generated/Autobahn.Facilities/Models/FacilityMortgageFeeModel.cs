//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageFeeModel.cs
//***************************************************************************

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
        /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
        /// </summary>
        public Guid FacilityMortgageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFinancingFeeType"/> model
        /// </summary>
        public Guid RefFacilityFinancingFeeTypeId { get; set; }

    }
}
