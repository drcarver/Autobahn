//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   RefIPEDSFASBFunctionalExpense.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Financial
{
    [Table("RefIPEDSFASBFunctionalExpense", Schema= "Financial")]
    public partial class RefIPEDSFASBFunctionalExpense : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefIPEDSFASBFunctionalExpense()
        {
            IPEDSFinances = new HashSet<IPEDSFinance>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPEDSFinance> IPEDSFinances { get; set; }
    }
}
