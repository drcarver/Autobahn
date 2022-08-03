//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityMortgage.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityMortgage
     /// </summary>
    public partial class FacilityMortgage : IFacilityMortgage
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityMortgage.FacilityMortgageInterestAmount nullable property
        /// </summary>
        public System.Decimal? FacilityMortgageInterestAmount { get; set; }

        /// <summary>
        /// Defines the FacilityMortgage.FacilityTotalAssessedValue nullable property
        /// </summary>
        public System.Decimal? FacilityTotalAssessedValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageInterestType"/> model
        /// </summary>
        public Guid? RefFacilityMortgageInterestTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageType"/> model
        /// </summary>
        public Guid? RefFacilityMortgageTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityMortgage.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityMortgage.RecordEndDateTime nullable property
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
