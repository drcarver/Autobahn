//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefFinancialAccountBalanceSheetCode.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefFinancialAccountBalanceSheetCode
     /// </summary>
    public partial interface IRefFinancialAccountBalanceSheetCode
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialBalanceSheetAccountCode"/> model
        /// </summary>
        Guid RefFinancialBalanceSheetAccountCodeId { get; set; }

        /// <summary>
        /// Defines the RefFinancialAccountBalanceSheetCode.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFinancialAccountBalanceSheetCode.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFinancialAccountBalanceSheetCode.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFinancialAccountBalanceSheetCode.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFinancialAccountBalanceSheetCode.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFinancialAccountBalanceSheetCode.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
