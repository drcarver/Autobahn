using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FinancialAccount")]
    public partial class FinancialAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FinancialAccount()
        {
            OrganizationFinancials = new HashSet<OrganizationFinancial>();
        }

        public int FinancialAccountId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(30)]
        public string AccountNumber { get; set; }

        public int? RefFinancialAccountCategoryId { get; set; }

        public int? RefFinancialAccountFundClassificationId { get; set; }

        public int? RefFinancialAccountProgramCodeId { get; set; }

        public int? RefFinancialAccountBalanceSheetCodeId { get; set; }

        public int? RefFinancialExpenditureFunctionCodeId { get; set; }

        public int? RefFinancialExpenditureObjectCodeId { get; set; }

        [StringLength(30)]
        public string FinancialAccountNumber { get; set; }

        public decimal? FinancialExpenditureProjectReportingCode { get; set; }

        public int? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

        public int? RefFinancialAccountRevenueCodeId { get; set; }

        [StringLength(10)]
        public string FederalProgramCode { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFinancialAccountCategory RefFinancialAccountCategory { get; set; }

        public virtual RefFinancialAccountFundClassification RefFinancialAccountFundClassification { get; set; }

        public virtual RefFinancialAccountProgramCode RefFinancialAccountProgramCode { get; set; }

        public virtual RefFinancialAccountRevenueCode RefFinancialAccountRevenueCode { get; set; }

        public virtual RefFinancialAccountBalanceSheetCode RefFinancialAccountBalanceSheetCode { get; set; }

        public virtual RefFinancialExpenditureFunctionCode RefFinancialExpenditureFunctionCode { get; set; }

        public virtual RefFinancialExpenditureLevelOfInstructionCode RefFinancialExpenditureLevelOfInstructionCode { get; set; }

        public virtual RefFinancialExpenditureObjectCode RefFinancialExpenditureObjectCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationFinancial> OrganizationFinancials { get; set; }
    }
}
