//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRoleStatusType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefRoleStatus", Schema = "Common")]
    public partial class RefRoleStatus : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefRoleStatus()
        {
            RoleStatus = new HashSet<RoleStatus>();
        }

        [ForeignKey("RefRoleStatusType")]
        public Guid? RefRoleStatusTypeId { get; set; }

        public virtual RefRoleStatusType RefRoleStatusType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleStatus> RoleStatus { get; set; }
    }
}
