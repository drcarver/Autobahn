//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   RefIPEDSFASBScholarshipsandFellowshipsRevenue.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Financial
{
    [Table("RefIPEDSFASBScholarshipsandFellowshipsRevenue", Schema= "Financial")]
    public partial class RefIPEDSFASBScholarshipsandFellowshipsRevenue : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefIPEDSFASBScholarshipsandFellowshipsRevenue()
        {
            IPEDSFinances = new HashSet<IPEDSFinance>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPEDSFinance> IPEDSFinances { get; set; }
    }
}
