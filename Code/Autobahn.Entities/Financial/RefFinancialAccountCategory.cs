//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   RefFinancialAccountCategory.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Financial
{
    [Table("RefFinancialAccountCategory", Schema= "Financial")]
    public partial class RefFinancialAccountCategory : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefFinancialAccountCategory()
        {
            FinancialAccounts = new HashSet<FinancialAccount>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinancialAccount> FinancialAccounts { get; set; }
    }
}
