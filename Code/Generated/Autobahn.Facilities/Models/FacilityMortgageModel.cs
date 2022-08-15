//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityMortgage Model
     /// </summary>
    public partial class FacilityMortgageModel : AutobahnBase, Interfaces.IFacilityMortgage
    {
        /// <summary>
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </summary>
        public System.Decimal? FacilityMortgageInterestAmount { get; set; }

    }
}
