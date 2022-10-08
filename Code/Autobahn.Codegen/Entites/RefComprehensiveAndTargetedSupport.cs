using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RefComprehensiveAndTargetedSupport", Schema = "K12")]
    public partial class RefComprehensiveAndTargetedSupport
    {
        public RefComprehensiveAndTargetedSupport()
        {
            K12schoolStatuses = new HashSet<K12SchoolStatus>();
        }

        [Key]
        public int RefComprehensiveAndTargetedSupportId { get; set; }
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
        [InverseProperty("RefComprehensiveAndTargetedSupports")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefComprehensiveAndTargetedSupport")]
        public virtual ICollection<K12SchoolStatus> K12schoolStatuses { get; set; }
    }
}
