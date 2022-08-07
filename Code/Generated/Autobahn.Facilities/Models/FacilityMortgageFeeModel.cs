//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityMortgageFeeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityMortgageFee Model
     /// </summary>
    public partial class FacilityMortgageFeeModel : AutobahnBase, Interfaces.IFacilityMortgageFeeModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityMortgage"/> model
        /// </summary>
        public Guid FacilityMortgageId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefFacilityFinancingFeeType"/> model
        /// </summary>
        public Guid RefFacilityFinancingFeeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
