using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// List of identification system types.
    /// </summary>
    [Table("RefEducationLevelType", Schema = "Common")]
    public partial class RefEducationLevelType
    {
        public RefEducationLevelType()
        {
            RefEducationLevels = new HashSet<RefEducationLevel>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefEducationLevelTypeId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
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
        [InverseProperty("RefEducationLevelTypes")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefEducationLevelType")]
        public virtual ICollection<RefEducationLevel> RefEducationLevels { get; set; }
    }
}
