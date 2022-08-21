using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RefComprehensiveSupport")]
    public partial class RefComprehensiveSupport
    {
        public RefComprehensiveSupport()
        {
            K12schoolStatuses = new HashSet<K12schoolStatus>();
        }

        [Key]
        public int RefComprehensiveSupportId { get; set; }
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
        [InverseProperty("RefComprehensiveSupports")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefComprehensiveSupport")]
        public virtual ICollection<K12schoolStatus> K12schoolStatuses { get; set; }
    }
}
