//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAccountBalanceSheetCode.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefFinancialAccountBalanceSheetCode
     /// </summary>
    public partial class RefFinancialAccountBalanceSheetCode : IRefFinancialAccountBalanceSheetCode
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialBalanceSheetAccountCode"/> model
        /// </summary>
        public Guid RefFinancialBalanceSheetAccountCodeId { get; set; }

        /// <summary>
        /// Defines the RefFinancialAccountBalanceSheetCode.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFinancialAccountBalanceSheetCode.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFinancialAccountBalanceSheetCode.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFinancialAccountBalanceSheetCode.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFinancialAccountBalanceSheetCode.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFinancialAccountBalanceSheetCode.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
