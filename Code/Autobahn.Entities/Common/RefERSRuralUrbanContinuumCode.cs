//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefERSRuralUrbanContinuumCode.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefERSRuralUrbanContinuumCode", Schema = "Common")]
    public partial class RefERSRuralUrbanContinuumCode : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefERSRuralUrbanContinuumCode()
        {
            LocationAddresses = new HashSet<LocationAddress>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationAddress> LocationAddresses { get; set; }
    }
}
