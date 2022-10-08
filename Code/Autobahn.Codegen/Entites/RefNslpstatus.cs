using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RefNSLPStatus", Schema = "K12")]
    public partial class RefNSLPStatus
    {
        public RefNSLPStatus()
        {
            K12schoolStatuses = new HashSet<K12SchoolStatus>();
        }

        [Key]
        public int RefNSLPStatusId { get; set; }
        [StringLength(150)]
        public string Description { get; set; } = null!;
        [StringLength(50)]
        public string? Code { get; set; }
        [StringLength(4000)]
        public string? Definition { get; set; }
        public int? RefJurisdictionId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefNslpstatuses")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefNslpstatus")]
        public virtual ICollection<K12SchoolStatus> K12schoolStatuses { get; set; }
    }
}
