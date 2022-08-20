//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInternetAccessTypeInResidence.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefInternetAccessTypeInResidence", Schema = "Common")]
    public partial class RefInternetAccessTypeInResidence : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefInternetAccessTypeInResidence()
        {
            PersonDigitalAccesses = new HashSet<PersonDigitalAccess>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDigitalAccess> PersonDigitalAccesses { get; set; }
    }
}
