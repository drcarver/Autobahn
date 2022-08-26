//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageFeeModel.cs
//***************************************************************************

using Autobahn.Interfaces.Facilities;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityMortgageFee Model
     /// </summary>
    public partial class FacilityMortgageFeeModel : AutobahnBase, IFacilityMortgageFee
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
        /// </summary>
        public Guid FacilityMortgageId { get; set; }

        /// <summary>
        /// Facility Financing Fee Type
        /// <para>
        /// The type of fee that one must pay when getting a mortgage.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20867">Facility Financing Fee Type</a>
        /// </para>
        /// </summary>
        public Guid RefFacilityFinancingFeeTypeId { get; set; }

    }
}
