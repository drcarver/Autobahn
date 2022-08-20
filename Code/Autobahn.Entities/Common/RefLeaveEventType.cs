//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefLeaveEventType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefLeaveEventType", Schema = "Common")]
    public partial class RefLeaveEventType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefLeaveEventType()
        {
            RoleAttendanceEvents = new HashSet<RoleAttendanceEvent>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleAttendanceEvent> RoleAttendanceEvents { get; set; }
    }
}
