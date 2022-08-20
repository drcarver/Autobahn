//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAttendanceStatus.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefAttendanceStatus")]
    public partial class RefAttendanceStatus : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefAttendanceStatus()
        {
            RoleAttendanceEvents = new HashSet<RoleAttendanceEvent>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleAttendanceEvent> RoleAttendanceEvents { get; set; }
    }
}
