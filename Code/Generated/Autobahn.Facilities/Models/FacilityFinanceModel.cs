//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinanceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityFinance Model
     /// </summary>
    public partial class FacilityFinanceModel : AutobahnBase, Interfaces.IFacilityFinance
    {
        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        public System.Decimal? FacilityReplacementValue { get; set; }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        public System.Decimal? IndebtednessAmountAllowed { get; set; }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        public System.Decimal? InsuranceDeductible { get; set; }

        /// <summary>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </summary>
        public System.Decimal? PublicEducationMillRate { get; set; }

    }
}
