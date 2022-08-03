//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityFinance.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityFinance
     /// </summary>
    public partial interface IFacilityFinance
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.FacilityReplacementValue nullable property
        /// </summary>
        System.Decimal? FacilityReplacementValue { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.IndebtednessAmountAllowed nullable property
        /// </summary>
        System.Decimal? IndebtednessAmountAllowed { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.InsuranceDeductible nullable property
        /// </summary>
        System.Decimal? InsuranceDeductible { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.PublicEducationMillRate nullable property
        /// </summary>
        System.Decimal? PublicEducationMillRate { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityFinance.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
