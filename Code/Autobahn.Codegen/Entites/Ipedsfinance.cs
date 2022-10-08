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
    [Table("IPEDSFinance", Schema = "Finance")]
    public partial class IPEDSFinance
    {
        [Key]
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
        public virtual RefIPEDSFASBFinancialPosition? RefIPEDSFASBFinancialPosition { get; set; }
        [ForeignKey("RefIpedsfasbfunctionalExpenseId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIPEDSFASBFunctionalExpense? RefIpedsfasbfunctionalExpense { get; set; }
        [ForeignKey("RefIpedsfasbpellGrantTransactionsId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIPEDSFASBPellGrantTransactions? RefIpedsfasbpellGrantTransactions { get; set; }
        [ForeignKey("RefIPEDSFASBRevenueId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIPEDSFASBRevenue? RefIpedsfasbrevenue { get; set; }
        [ForeignKey("RefIpedsfasbrevenueRestrictionId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIPEDSFASBRevenueRestriction? RefIpedsfasbrevenueRestriction { get; set; }
        [ForeignKey("RefIpedsfasbscholarshipsandFellowshipsRevenueId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIPEDSFASBScholarshipsandFellowshipsRevenue? RefIpedsfasbscholarshipsandFellowshipsRevenue { get; set; }
        [ForeignKey("RefIpedsgasbfinancialPositionId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIPEDSGASBFinancialPosition? RefIpedsgasbfinancialPosition { get; set; }
        [ForeignKey("RefIpedsgasbfunctionalExpenseId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIPEDSGASBFunctionalExpense? RefIpedsgasbfunctionalExpense { get; set; }
        [ForeignKey("RefIpedsgasbrevenueId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIPEDSGASBRevenue? RefIpedsgasbrevenue { get; set; }
        [ForeignKey("RefIpedsgasbscholarshipsandFellowshipsRevenueId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIPEDSGASBScholarshipsandFellowshipsRevenue? RefIpedsgasbscholarshipsandFellowshipsRevenue { get; set; }
        [ForeignKey("RefIpedsintercollegiateAthleticsExpensesId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIPEDSIntercollegiateAthleticsExpenses? RefIpedsintercollegiateAthleticsExpenses { get; set; }
        [ForeignKey("RefIpedsnaturalExpenseId")]
        [InverseProperty("Ipedsfinances")]
        public virtual RefIPEDSNaturalExpense? RefIpedsnaturalExpense { get; set; }
    }
}
