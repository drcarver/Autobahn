//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPEDSFinanceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The IPEDSFinance Model
     /// </summary>
    public partial class IPEDSFinanceModel : AutobahnBase, Interfaces.IIPEDSFinance
    {
        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid OrganizationFinancialId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSFASBFinancialPositionId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSFASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSFASBPellGrantTransactionsId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSFASBRevenueId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSFASBRevenueRestrictionId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSGASBFinancialPositionId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSGASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSGASBRevenueId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSNaturalExpenseId { get; set; }

    }
}
