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
        Guid OrganizationFinancialId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSFASBFinancialPositionId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSFASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSFASBPellGrantTransactionsId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSFASBRevenueId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSFASBRevenueRestrictionId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSGASBFinancialPositionId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSGASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSGASBRevenueId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        Guid? RefIPEDSNaturalExpenseId { get; set; }

    }
}
