using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
    /// </summary>
    [Table("RefStateANSICode")]
    public partial class RefStateAnsicode
    {
        public RefStateAnsicode()
        {
            K12seas = new HashSet<K12sea>();
        }

        [Key]
        [Column("RefStateANSICodeId")]
        public int RefStateAnsicodeId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(50)]
        public string Code { get; set; } = null!;
        [StringLength(150)]
        public string Description { get; set; } = null!;
        [StringLength(4000)]
        public string? Definition { get; set; }
        public int? RefJurisdictionId { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefStateAnsicodes")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefStateAnsicode")]
        public virtual ICollection<K12sea> K12seas { get; set; }
    }
}
