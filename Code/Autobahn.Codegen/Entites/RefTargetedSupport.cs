using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RefTargetedSupport", Schema = "K12")]
    public partial class RefTargetedSupport
    {
        public RefTargetedSupport()
        {
            K12schoolStatuses = new HashSet<K12SchoolStatus>();
        }

        [Key]
        public int RefTargetedSupportId { get; set; }
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
        [InverseProperty("RefTargetedSupports")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefTargetedSupport")]
        public virtual ICollection<K12SchoolStatus> K12schoolStatuses { get; set; }
    }
}
