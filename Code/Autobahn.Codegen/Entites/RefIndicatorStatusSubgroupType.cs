using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RefIndicatorStatusSubgroupType")]
    public partial class RefIndicatorStatusSubgroupType
    {
        public RefIndicatorStatusSubgroupType()
        {
            K12schoolIndicatorStatuses = new HashSet<K12schoolIndicatorStatus>();
        }

        [Key]
        public int RefIndicatorStatusSubgroupTypeId { get; set; }
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
        [InverseProperty("RefIndicatorStatusSubgroupTypes")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefIndicatorStatusSubgroupType")]
        public virtual ICollection<K12schoolIndicatorStatus> K12schoolIndicatorStatuses { get; set; }
    }
}
