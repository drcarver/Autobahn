//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefFinancialExpenditureLevelOfInstructionCode.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefFinancialExpenditureLevelOfInstructionCode
     /// </summary>
    public partial interface IRefFinancialExpenditureLevelOfInstructionCode
    {
        /// <summary>
        /// Defines the RefFinancialExpenditureLevelOfInstructionCode.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureLevelOfInstructionCode.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureLevelOfInstructionCode.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureLevelOfInstructionCode.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureLevelOfInstructionCode.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureLevelOfInstructionCode.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
