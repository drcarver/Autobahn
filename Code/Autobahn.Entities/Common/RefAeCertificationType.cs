//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAeCertificationType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefAeCertificationType", Schema = "Common")]
    public partial class RefAeCertificationType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefAeCertificationType()
        {
            StaffCredentials = new HashSet<StaffCredential>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffCredential> StaffCredentials { get; set; }
    }
}
