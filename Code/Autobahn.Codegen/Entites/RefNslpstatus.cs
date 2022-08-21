using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RefNSLPStatus")]
    public partial class RefNslpstatus
    {
        public RefNslpstatus()
        {
            K12schoolStatuses = new HashSet<K12schoolStatus>();
        }

        [Key]
        [Column("RefNSLPStatusId")]
        public int RefNslpstatusId { get; set; }
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
        public virtual ICollection<K12schoolStatus> K12schoolStatuses { get; set; }
    }
}
