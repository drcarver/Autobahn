using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// CEDS entities. Used when the relationship of data requires the associated entity to be specified.
    /// </summary>
    [Table("RefEntityType")]
    public partial class RefEntityType
    {
        public RefEntityType()
        {
            CompetencyDefAssociations = new HashSet<CompetencyDefAssociation>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefEntityTypeId { get; set; }
        [StringLength(150)]
        public string Description { get; set; } = null!;
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(50)]
        public string? Code { get; set; }
        [StringLength(4000)]
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefEntityTypes")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefEntityType")]
        public virtual ICollection<CompetencyDefAssociation> CompetencyDefAssociations { get; set; }
    }
}
