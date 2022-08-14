//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IRefFinancialAccountBalanceSheetCode.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The RefFinancialAccountBalanceSheetCode Interface Model
     /// </summary>
    public partial interface IRefFinancialAccountBalanceSheetCode : IReferenceModel
    {
        /// <summary>
        /// Balance sheet accounts and statement of net position accounts are used to track financial transactions for each fund. Such financial statements only report assets, deferred outflows of resources, liabilities, deferred inflows of resources, and equity accounts and are considered "snapshots" of how these accounts stand as of a certain point in time.
        /// </summary>
        Guid RefFinancialBalanceSheetAccountCodeId { get; set; }

    }
}
