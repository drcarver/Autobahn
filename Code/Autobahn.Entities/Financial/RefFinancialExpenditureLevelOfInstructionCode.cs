//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   RefFinancialExpenditureLevelOfInstructionCode.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Financial
{
    [Table("RefFinancialExpenditureLevelOfInstructionCode", Schema= "Financial")]
    public partial class RefFinancialExpenditureLevelOfInstructionCode : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefFinancialExpenditureLevelOfInstructionCode()
        {
            FinancialAccounts = new HashSet<FinancialAccount>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinancialAccount> FinancialAccounts { get; set; }
    }
}
