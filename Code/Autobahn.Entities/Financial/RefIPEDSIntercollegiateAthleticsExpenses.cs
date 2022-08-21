//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   RefIPEDSIntercollegiateAthleticsExpenses.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Financial
{
    [Table("RefIPEDSIntercollegiateAthleticsExpenses", Schema= "Financial")]
    public partial class RefIPEDSIntercollegiateAthleticsExpenses : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefIPEDSIntercollegiateAthleticsExpenses()
        {
            IPEDSFinances = new HashSet<IPEDSFinance>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPEDSFinance> IPEDSFinances { get; set; }
    }
}
