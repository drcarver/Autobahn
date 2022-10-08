using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RefIndicatorStatusSubgroupType", Schema = "K12")]
    public partial class RefIndicatorStatusSubgroupType
    {
        public RefIndicatorStatusSubgroupType()
        {
            K12SchoolIndicatorStatuses = new HashSet<K12SchoolIndicatorStatus>();
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
        public virtual ICollection<K12SchoolIndicatorStatus> K12SchoolIndicatorStatuses { get; set; }
    }
}
