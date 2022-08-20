//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPresentAttendanceCategory.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefPresentAttendanceCategory")]
    public partial class RefPresentAttendanceCategory : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefPresentAttendanceCategory()
        {
            RoleAttendanceEvents = new HashSet<RoleAttendanceEvent>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleAttendanceEvent> RoleAttendanceEvents { get; set; }
    }
}
