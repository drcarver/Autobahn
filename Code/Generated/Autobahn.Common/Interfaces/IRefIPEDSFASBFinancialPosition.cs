//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefIPEDSFASBFinancialPosition.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefIPEDSFASBFinancialPosition
     /// </summary>
    public partial interface IRefIPEDSFASBFinancialPosition
    {
        /// <summary>
        /// Defines the RefIPEDSFASBFinancialPosition.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFinancialPosition.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFinancialPosition.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFinancialPosition.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFinancialPosition.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBFinancialPosition.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
