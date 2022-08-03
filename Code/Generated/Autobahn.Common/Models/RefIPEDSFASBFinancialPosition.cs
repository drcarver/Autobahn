//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSFASBFinancialPosition.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIPEDSFASBFinancialPosition
     /// </summary>
    public partial class RefIPEDSFASBFinancialPosition : IRefIPEDSFASBFinancialPosition
    {
        /// <summary>
        /// Defines the RefIPEDSFASBFinancialPosition.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFinancialPosition.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFinancialPosition.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFinancialPosition.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFinancialPosition.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFinancialPosition.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
