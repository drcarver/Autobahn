//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDigitalAccess.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefBarrierToInternetAccessInResidence")]
    public partial class RefBarrierToInternetAccessInResidence : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefBarrierToInternetAccessInResidence()
        {
            PersonDigitalAccesses = new HashSet<PersonDigitalAccess>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDigitalAccess> PersonDigitalAccesses { get; set; }
    }
}
