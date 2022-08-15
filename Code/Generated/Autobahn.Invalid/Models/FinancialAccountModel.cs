//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAccountModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The FinancialAccount Model
     /// </summary>
    public partial class FinancialAccountModel : AutobahnBase, Interfaces.IFinancialAccount
    {
        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public Guid? RefFinancialAccountCategoryId { get; set; }

    }
}
