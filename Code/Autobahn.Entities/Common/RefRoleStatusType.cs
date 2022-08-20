//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRoleStatusType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefRoleStatusType")]
    public partial class RefRoleStatusType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefRoleStatusType()
        {
            RefRoleStatus = new HashSet<RefRoleStatus>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefRoleStatus> RefRoleStatus { get; set; }
    }
}
