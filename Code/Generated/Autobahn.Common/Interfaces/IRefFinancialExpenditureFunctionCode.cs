//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefFinancialExpenditureFunctionCode.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefFinancialExpenditureFunctionCode
     /// </summary>
    public partial interface IRefFinancialExpenditureFunctionCode
    {
        /// <summary>
        /// Defines the RefFinancialExpenditureFunctionCode.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureFunctionCode.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureFunctionCode.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureFunctionCode.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureFunctionCode.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFinancialExpenditureFunctionCode.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
