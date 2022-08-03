//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefDentalInsuranceCoverageType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefDentalInsuranceCoverageType
     /// </summary>
    public partial class RefDentalInsuranceCoverageType : IRefDentalInsuranceCoverageType
    {
        /// <summary>
        /// Defines the RefDentalInsuranceCoverageType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefDentalInsuranceCoverageType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefDentalInsuranceCoverageType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefDentalInsuranceCoverageType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefDentalInsuranceCoverageType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefDentalInsuranceCoverageType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
