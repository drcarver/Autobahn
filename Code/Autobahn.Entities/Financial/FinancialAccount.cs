//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   FinancialAccount.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Interfaces.Financial;

namespace Autobahn.Entities.Financial
{
    [Table("FinancialAccount", Schema = "Financial")]
    public partial class FinancialAccount : EntityBase, IFinancialAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FinancialAccount()
        {
            OrganizationFinancials = new HashSet<OrganizationFinancial>();
        }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(30)]
        public string AccountNumber { get; set; }

        [ForeignKey("RefFinancialAccountCategory")]
        public Guid? RefFinancialAccountCategoryId { get; set; }

        [ForeignKey("RefFinancialAccountFundClassification")]
        public Guid? RefFinancialAccountFundClassificationId { get; set; }

        [ForeignKey("RefFinancialAccountProgramCode")]
        public Guid? RefFinancialAccountProgramCodeId { get; set; }

        [ForeignKey("RefFinancialAccountBalanceSheetCode")]
        public Guid? RefFinancialAccountBalanceSheetCodeId { get; set; }

        [ForeignKey("RefFinancialExpenditureFunctionCode")]
        public Guid? RefFinancialExpenditureFunctionCodeId { get; set; }

        [ForeignKey("RefFinancialExpenditureObjectCode")]
        public Guid? RefFinancialExpenditureObjectCodeId { get; set; }

        [StringLength(30)]
        public string FinancialAccountNumber { get; set; }

        public decimal? FinancialExpenditureProjectReportingCode { get; set; }

        [ForeignKey("RefFinancialExpenditureLevelOfInstructionCode")]
        public Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

        [ForeignKey("RefFinancialAccountRevenueCode")]
        public Guid? RefFinancialAccountRevenueCodeId { get; set; }

        [StringLength(10)]
        public string FederalProgramCode { get; set; }

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
