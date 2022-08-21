//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   RefIPEDSFASBRevenue.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Financial
{
    [Table("RefIPEDSFASBRevenue", Schema= "Financial")]
    public partial class RefIPEDSFASBRevenue : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefIPEDSFASBRevenue()
        {
            IPEDSFinances = new HashSet<IPEDSFinance>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPEDSFinance> IPEDSFinances { get; set; }
    }
}
