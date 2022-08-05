//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAccountBalanceSheetCode.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefFinancialAccountBalanceSheetCode Model
     /// </summary>
    public partial class RefFinancialAccountBalanceSheetCode : ReferenceModelBase, IRefFinancialAccountBalanceSheetCode
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialBalanceSheetAccountCode"/> model
        /// </summary>
        public Guid RefFinancialBalanceSheetAccountCodeId { get; set; }

    }
}
