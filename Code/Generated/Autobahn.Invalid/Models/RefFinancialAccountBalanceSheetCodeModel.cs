//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefFinancialAccountBalanceSheetCodeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

using Autobahn.Invalid.Interfaces;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RefFinancialAccountBalanceSheetCode Model
     /// </summary>
    public partial class RefFinancialAccountBalanceSheetCode : ReferenceModelBase, Interfaces.IRefFinancialAccountBalanceSheetCode
    {
        /// <summary>
        /// Balance sheet accounts and statement of net position accounts are used to track financial transactions for each fund. Such financial statements only report assets, deferred outflows of resources, liabilities, deferred inflows of resources, and equity accounts and are considered "snapshots" of how these accounts stand as of a certain point in time.
        /// </summary>
        public Guid RefFinancialBalanceSheetAccountCodeId { get; set; }

    }
}
