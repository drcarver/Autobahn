//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityFinanceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityFinance Model
     /// </summary>
    public partial class FacilityFinanceModel : AutobahnBase, Interfaces.IFacilityFinanceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.FacilityReplacementValue nullable property
        /// </summary>
        public System.Decimal? FacilityReplacementValue { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.IndebtednessAmountAllowed nullable property
        /// </summary>
        public System.Decimal? IndebtednessAmountAllowed { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.InsuranceDeductible nullable property
        /// </summary>
        public System.Decimal? InsuranceDeductible { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.PublicEducationMillRate nullable property
        /// </summary>
        public System.Decimal? PublicEducationMillRate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
