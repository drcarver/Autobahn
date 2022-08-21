//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   IPEDSFinance.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Interfaces.Financial;

namespace Autobahn.Entities.Financial
{
    [Table("IPEDSFinance", Schema= "Financial")]
    public partial class IPEDSFinance : EntityBase, IIPEDSFinance
    {
        [ForeignKey("OrganizationFinancial")]
        public Guid OrganizationFinancialId { get; set; }

        [ForeignKey("RefIPEDSFASBFinancialPosition")]
        public Guid? RefIPEDSFASBFinancialPositionId { get; set; }

        [ForeignKey("RefIPEDSFASBFunctionalExpense")]
        public Guid? RefIPEDSFASBFunctionalExpenseId { get; set; }

        [ForeignKey("RefIPEDSFASBPellGrantTransactions")]
        public Guid? RefIPEDSFASBPellGrantTransactionsId { get; set; }

        [ForeignKey("RefIPEDSFASBRevenue")]
        public Guid? RefIPEDSFASBRevenueId { get; set; }

        [ForeignKey("RefIPEDSFASBRevenueRestriction")]
        public Guid? RefIPEDSFASBRevenueRestrictionId { get; set; }

        [ForeignKey("RefIPEDSFASBScholarshipsandFellowshipsRevenue")]
        public Guid? RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get; set; }

        [ForeignKey("RefIPEDSGASBFinancialPosition")]
        public Guid? RefIPEDSGASBFinancialPositionId { get; set; }

        [ForeignKey("RefIPEDSGASBFunctionalExpense")]
        public Guid? RefIPEDSGASBFunctionalExpenseId { get; set; }

        [ForeignKey("RefIPEDSGASBRevenue")]
        public Guid? RefIPEDSGASBRevenueId { get; set; }

        [ForeignKey("RefIPEDSGASBScholarshipsandFellowshipsRevenue")]
        public Guid? RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get; set; }

        [ForeignKey("RefIPEDSIntercollegiateAthleticsExpenses")]
        public Guid? RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

        [ForeignKey("RefIPEDSNaturalExpense")]
        public Guid? RefIPEDSNaturalExpenseId { get; set; }

        public virtual OrganizationFinancial OrganizationFinancial { get; set; }

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
