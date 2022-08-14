using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RefEmergencyOrProvisionalCredentialStatus")]
    public partial class RefEmergencyOrProvisionalCredentialStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefEmergencyOrProvisionalCredentialStatus()
        {
            K12StaffAssignment = new HashSet<K12StaffAssignment>();
        }

        [Key]
        public int RefEmergencyOrProvisionalCredentialStatusId { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public string Definition { get; set; }

        public int? RefJurisdictionId { get; set; }

        public decimal? SortOrder { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12StaffAssignment> K12StaffAssignment { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
