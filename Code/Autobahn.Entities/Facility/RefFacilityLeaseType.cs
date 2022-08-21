//**********************************************************
//* DomainName: Autobahn.Facility
//* FileName:   RefFacilityLeaseType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Facility
{
    [Table("RefFacilityLeaseType", Schema= "Facility")]
    public partial class RefFacilityLeaseType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefFacilityLeaseType()
        {
            FacilityLeases = new HashSet<FacilityLease>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityLease> FacilityLeases { get; set; }
    }
}
