//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   RefFinancialExpenditureFunctionCode.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Financial
{
    [Table("RefFinancialExpenditureFunctionCode", Schema= "Financial")]
    public partial class RefFinancialExpenditureFunctionCode : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefFinancialExpenditureFunctionCode()
        {
            FinancialAccounts = new HashSet<FinancialAccount>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinancialAccount> FinancialAccounts { get; set; }
    }
}
