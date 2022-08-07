//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAccountBalanceSheetCodeModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefFinancialAccountBalanceSheetCode Model
     /// </summary>
    public partial class RefFinancialAccountBalanceSheetCodeModel : ReferenceModelBase, IRefFinancialAccountBalanceSheetCodeModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialBalanceSheetAccountCode"/> model
        /// </summary>
        public Guid RefFinancialBalanceSheetAccountCodeId { get; set; }

    }
}
