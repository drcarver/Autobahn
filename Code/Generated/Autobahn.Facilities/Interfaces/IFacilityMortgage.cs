//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityMortgage.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityMortgage
     /// </summary>
    public partial interface IFacilityMortgage
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityMortgage.FacilityMortgageInterestAmount nullable property
        /// </summary>
        System.Decimal? FacilityMortgageInterestAmount { get; set; }

        /// <summary>
        /// Defines the FacilityMortgage.FacilityTotalAssessedValue nullable property
        /// </summary>
        System.Decimal? FacilityTotalAssessedValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageInterestType"/> model
        /// </summary>
        Guid? RefFacilityMortgageInterestTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageType"/> model
        /// </summary>
        Guid? RefFacilityMortgageTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityMortgage.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityMortgage.RecordEndDateTime nullable property
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
