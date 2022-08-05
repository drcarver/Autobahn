//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefFinancialAccountBalanceSheetCode.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefFinancialAccountBalanceSheetCode Interface
     /// </summary>
    public partial interface IRefFinancialAccountBalanceSheetCode : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialBalanceSheetAccountCode"/> model
        /// </summary>
        Guid RefFinancialBalanceSheetAccountCodeId { get; set; }

    }
}
