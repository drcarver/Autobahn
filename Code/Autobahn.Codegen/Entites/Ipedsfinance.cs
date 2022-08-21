using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("IPEDSFinance")]
    public partial class Ipedsfinance
    {
        [Key]
        [Column("IPEDSFinanceId")]
        public int IpedsfinanceId { get; set; }
        public int OrganizationFinancialId { get; set; }
        [Column("RefIPEDSFASBFinancialPositionId")]
        public int? RefIpedsfasbfinancialPositionId { get; set; }
        [Column("RefIPEDSFASBFunctionalExpenseId")]
        public int? RefIpedsfasbfunctionalExpenseId { get; set; }
        [Column("RefIPEDSFASBPellGrantTransactionsId")]
        public int? RefIpedsfasbpellGrantTransactionsId { get; set; }
        [Column("RefIPEDSFASBRevenueId")]
        public int? RefIpedsfasbrevenueId { get; set; }
        [Column("RefIPEDSFASBRevenueRestrictionId")]
        public int? RefIpedsfasbrevenueRestrictionId { get; set; }
        [Column("RefIPEDSFASBScholarshipsandFellowshipsRevenueId")]
        public int? RefIpedsfasbscholarshipsandFellowshipsRevenueId { get; set; }
        [Column("RefIPEDSGASBFinancialPositionId")]
        public int? RefIpedsgasbfinancialPositionId { get; set; }
        [Column("RefIPEDSGASBFunctionalExpenseId")]
        public int? RefIpedsgasbfunctionalExpenseId { get; set; }
        [Column("RefIPEDSGASBRevenueId")]
        public int? RefIpedsgasbrevenueId { get; set; }
        [Column("RefIPEDSGASBScholarshipsandFellowshipsRevenueId")]
        public int? RefIpedsgasbscholarshipsandFellowshipsRevenueId { get; set; }
        [Column("RefIPEDSIntercollegiateAthleticsExpensesId")]
        public int? RefIpedsintercollegiateAthleticsExpensesId { get; set; }
        [Column("RefIPEDSNaturalExpenseId")]
        public int? RefIpedsnaturalExpenseId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("Ipedsfinances")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationFinancialId")]
        [InverseProperty("Ipedsfinances")]
        public virtual OrganizationFinancial OrganizationFinancial { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIpedsfasbfinancialPositionId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIpedsfasbfinancialPosition? RefIpedsfasbfinancialPosition { get; set; }
        [ForeignKey("RefIpedsfasbfunctionalExpenseId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIpedsfasbfunctionalExpense? RefIpedsfasbfunctionalExpense { get; set; }
        [ForeignKey("RefIpedsfasbpellGrantTransactionsId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIpedsfasbpellGrantTransaction? RefIpedsfasbpellGrantTransactions { get; set; }
        [ForeignKey("RefIpedsfasbrevenueId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIpedsfasbrevenue? RefIpedsfasbrevenue { get; set; }
        [ForeignKey("RefIpedsfasbrevenueRestrictionId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIpedsfasbrevenueRestriction? RefIpedsfasbrevenueRestriction { get; set; }
        [ForeignKey("RefIpedsfasbscholarshipsandFellowshipsRevenueId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIpedsfasbscholarshipsandFellowshipsRevenue? RefIpedsfasbscholarshipsandFellowshipsRevenue { get; set; }
        [ForeignKey("RefIpedsgasbfinancialPositionId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIpedsgasbfinancialPosition? RefIpedsgasbfinancialPosition { get; set; }
        [ForeignKey("RefIpedsgasbfunctionalExpenseId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIpedsgasbfunctionalExpense? RefIpedsgasbfunctionalExpense { get; set; }
        [ForeignKey("RefIpedsgasbrevenueId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIpedsgasbrevenue? RefIpedsgasbrevenue { get; set; }
        [ForeignKey("RefIpedsgasbscholarshipsandFellowshipsRevenueId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIpedsgasbscholarshipsandFellowshipsRevenue? RefIpedsgasbscholarshipsandFellowshipsRevenue { get; set; }
        [ForeignKey("RefIpedsintercollegiateAthleticsExpensesId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIpedsintercollegiateAthleticsExpense? RefIpedsintercollegiateAthleticsExpenses { get; set; }
        [ForeignKey("RefIpedsnaturalExpenseId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIpedsnaturalExpense? RefIpedsnaturalExpense { get; set; }
    }
}
