//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   RefFinancialAccountProgramCode.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Financial
{
    [Table("RefFinancialAccountProgramCode", Schema= "Financial")]
    public partial class RefFinancialAccountProgramCode : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefFinancialAccountProgramCode()
        {
            FinancialAccounts = new HashSet<FinancialAccount>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinancialAccount> FinancialAccounts { get; set; }
    }
}
