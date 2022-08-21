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
    [Table("FinancialAccount")]
    public partial class FinancialAccount
    {
        public FinancialAccount()
        {
            OrganizationFinancials = new HashSet<OrganizationFinancial>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int FinancialAccountId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(100)]
        public string Name { get; set; } = null!;
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? Description { get; set; }
        [StringLength(30)]
        public string? AccountNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFinancialAccountCategoryId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFinancialAccountFundClassificationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFinancialAccountProgramCodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFinancialAccountBalanceSheetCodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFinancialExpenditureFunctionCodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFinancialExpenditureObjectCodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? FinancialAccountNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(3, 0)")]
        public decimal? FinancialExpenditureProjectReportingCode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFinancialAccountRevenueCodeId { get; set; }
        [StringLength(10)]
        public string? FederalProgramCode { get; set; }
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
        [InverseProperty("FinancialAccounts")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FinancialAccounts")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefFinancialAccountBalanceSheetCodeId")]
        [InverseProperty("FinancialAccounts")]
        public virtual RefFinancialAccountBalanceSheetCode? RefFinancialAccountBalanceSheetCode { get; set; }
        [ForeignKey("RefFinancialAccountCategoryId")]
        [InverseProperty("FinancialAccounts")]
        public virtual RefFinancialAccountCategory? RefFinancialAccountCategory { get; set; }
        [ForeignKey("RefFinancialAccountFundClassificationId")]
        [InverseProperty("FinancialAccounts")]
        public virtual RefFinancialAccountFundClassification? RefFinancialAccountFundClassification { get; set; }
        [ForeignKey("RefFinancialAccountProgramCodeId")]
        [InverseProperty("FinancialAccounts")]
        public virtual RefFinancialAccountProgramCode? RefFinancialAccountProgramCode { get; set; }
        [ForeignKey("RefFinancialAccountRevenueCodeId")]
        [InverseProperty("FinancialAccounts")]
        public virtual RefFinancialAccountRevenueCode? RefFinancialAccountRevenueCode { get; set; }
        [ForeignKey("RefFinancialExpenditureFunctionCodeId")]
        [InverseProperty("FinancialAccounts")]
        public virtual RefFinancialExpenditureFunctionCode? RefFinancialExpenditureFunctionCode { get; set; }
        [ForeignKey("RefFinancialExpenditureLevelOfInstructionCodeId")]
        [InverseProperty("FinancialAccounts")]
        public virtual RefFinancialExpenditureLevelOfInstructionCode? RefFinancialExpenditureLevelOfInstructionCode { get; set; }
        [ForeignKey("RefFinancialExpenditureObjectCodeId")]
        [InverseProperty("FinancialAccounts")]
        public virtual RefFinancialExpenditureObjectCode? RefFinancialExpenditureObjectCode { get; set; }
        [InverseProperty("FinancialAccount")]
        public virtual ICollection<OrganizationFinancial> OrganizationFinancials { get; set; }
    }
}
