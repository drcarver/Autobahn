//**********************************************************
//* DomainName: Autobahn.Facility
//* FileName:   RefFacilityLeaseAmountCategory.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Facility
{
    [Table("RefFacilityLeaseAmountCategory", Schema= "Facility")]
    public partial class RefFacilityLeaseAmountCategory : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefFacilityLeaseAmountCategory()
        {
            FacilityLeases = new HashSet<FacilityLease>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityLease> FacilityLeases { get; set; }
    }
}
