//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   RefIPEDSGASBScholarshipsandFellowshipsRevenue.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Financial
{
    [Table("RefIPEDSGASBScholarshipsandFellowshipsRevenue", Schema= "Financial")]
    public partial class RefIPEDSGASBScholarshipsandFellowshipsRevenue : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefIPEDSGASBScholarshipsandFellowshipsRevenue()
        {
            IPEDSFinances = new HashSet<IPEDSFinance>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPEDSFinance> IPEDSFinances { get; set; }
    }
}
