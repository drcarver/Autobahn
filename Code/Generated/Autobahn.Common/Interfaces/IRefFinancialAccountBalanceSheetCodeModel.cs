//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefFinancialAccountBalanceSheetCodeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefFinancialAccountBalanceSheetCode Interface Model
     /// </summary>
    public partial interface IRefFinancialAccountBalanceSheetCodeModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialBalanceSheetAccountCode"/> model
        /// </summary>
        Guid RefFinancialBalanceSheetAccountCodeId { get; set; }

    }
}
