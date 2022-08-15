//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IFinancialAccount.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IFinancialAccount Interface
     /// </summary>
    public partial interface IFinancialAccount : IAutobahnBase
    {
        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        Guid? RefFinancialAccountCategoryId { get; set; }

    }
}
