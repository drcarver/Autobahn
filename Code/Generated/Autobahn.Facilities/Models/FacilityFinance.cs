//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityFinance.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityFinance
     /// </summary>
    public partial class FacilityFinance : IFacilityFinance
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
        /// Defines the FacilityFinance.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
