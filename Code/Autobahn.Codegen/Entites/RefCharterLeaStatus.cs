using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RefCharterLeaStatus", Schema = "K12")]
    public partial class RefCharterLeaStatus
    {
        public RefCharterLeaStatus()
        {
            K12leas = new HashSet<K12Lea>();
        }

        [Key]
        public int RefCharterLeaStatusId { get; set; }
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
        [InverseProperty("RefCharterLeaStatuses")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefCharterLeaStatus")]
        public virtual ICollection<K12Lea> K12leas { get; set; }
    }
}
