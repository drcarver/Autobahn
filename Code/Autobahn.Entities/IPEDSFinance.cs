using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IPEDSFinance")]
    public partial class IPEDSFinance
    {
        public int IPEDSFinanceId { get; set; }

        public int OrganizationFinancialId { get; set; }

        public int? RefIPEDSFASBFinancialPositionId { get; set; }

        public int? RefIPEDSFASBFunctionalExpenseId { get; set; }

        public int? RefIPEDSFASBPellGrantTransactionsId { get; set; }

        public int? RefIPEDSFASBRevenueId { get; set; }

        public int? RefIPEDSFASBRevenueRestrictionId { get; set; }

        public int? RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get; set; }

        public int? RefIPEDSGASBFinancialPositionId { get; set; }

        public int? RefIPEDSGASBFunctionalExpenseId { get; set; }

        public int? RefIPEDSGASBRevenueId { get; set; }

        public int? RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get; set; }

        public int? RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

        public int? RefIPEDSNaturalExpenseId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationFinancial OrganizationFinancial { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefIPEDSFASBFinancialPosition RefIPEDSFASBFinancialPosition { get; set; }

        public virtual RefIPEDSFASBFunctionalExpense RefIPEDSFASBFunctionalExpense { get; set; }

        public virtual RefIPEDSFASBPellGrantTransaction RefIPEDSFASBPellGrantTransaction { get; set; }

        public virtual RefIPEDSFASBRevenue RefIPEDSFASBRevenue { get; set; }

        public virtual RefIPEDSFASBRevenueRestriction RefIPEDSFASBRevenueRestriction { get; set; }

        public virtual RefIPEDSFASBScholarshipsandFellowshipsRevenue RefIPEDSFASBScholarshipsandFellowshipsRevenue { get; set; }

        public virtual RefIPEDSGASBFinancialPosition RefIPEDSGASBFinancialPosition { get; set; }

        public virtual RefIPEDSGASBFunctionalExpense RefIPEDSGASBFunctionalExpense { get; set; }

        public virtual RefIPEDSGASBRevenue RefIPEDSGASBRevenue { get; set; }

        public virtual RefIPEDSGASBScholarshipsandFellowshipsRevenue RefIPEDSGASBScholarshipsandFellowshipsRevenue { get; set; }

        public virtual RefIPEDSIntercollegiateAthleticsExpenses RefIPEDSIntercollegiateAthleticsExpenses { get; set; }

        public virtual RefIPEDSNaturalExpense RefIPEDSNaturalExpense { get; set; }
    }
}
