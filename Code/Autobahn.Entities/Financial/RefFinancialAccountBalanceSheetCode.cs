//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   RefFinancialAccountBalanceSheetCode.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Financial
{
    [Table("RefFinancialAccountBalanceSheetCode", Schema= "Financial")]
    public partial class RefFinancialAccountBalanceSheetCode : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefFinancialAccountBalanceSheetCode()
        {
            FinancialAccounts = new HashSet<FinancialAccount>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinancialAccount> FinancialAccounts { get; set; }
    }
}
