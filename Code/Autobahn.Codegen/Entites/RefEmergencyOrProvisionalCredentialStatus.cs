using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RefEmergencyOrProvisionalCredentialStatus", Schema = "K12")]
    public partial class RefEmergencyOrProvisionalCredentialStatus
    {
        public RefEmergencyOrProvisionalCredentialStatus()
        {
            K12staffAssignments = new HashSet<K12StaffAssignment>();
        }

        [Key]
        public int RefEmergencyOrProvisionalCredentialStatusId { get; set; }
        [StringLength(150)]
        public string? Description { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        public string? Definition { get; set; }
        public int? RefJurisdictionId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefEmergencyOrProvisionalCredentialStatuses")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefEmergencyOrProvisionalCredentialStatus")]
        public virtual ICollection<K12StaffAssignment> K12staffAssignments { get; set; }
    }
}
