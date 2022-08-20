//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffCredential.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefCredentialType", Schema = "Common")]
    public partial class RefCredentialType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefCredentialType()
        {
            PersonCredentials = new HashSet<PersonCredential>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonCredential> PersonCredentials { get; set; }
    }
}
