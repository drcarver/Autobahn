//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IIPEDSFinance.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IIPEDSFinance Interface
     /// </summary>
    public partial interface IIPEDSFinance : IAutobahnBase
    {
        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSFASBFunctionalExpenseId { get; set; }

    }
}
