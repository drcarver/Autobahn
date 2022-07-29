using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
    public partial class RefRoleStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefRoleStatus()
        {
            RoleStatus = new HashSet<RoleStatus>();
        }

        [Key]
        public int RefRoleStatusId { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Definition { get; set; }

        public int? RefJurisdictionId { get; set; }

        public decimal? SortOrder { get; set; }

        public int? RefRoleStatusTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RefRoleStatusType RefRoleStatusType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleStatus> RoleStatus { get; set; }
    }
}
