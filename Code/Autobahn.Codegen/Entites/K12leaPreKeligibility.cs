using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("K12LeaPreKEligibility")]
    [Index("K12leaId", "RefPrekindergartenEligibilityId", Name = "IX_K12LeaPreKEligibility", IsUnique = true)]
    public partial class K12leaPreKeligibility
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("K12LEAPreKEligibilityId")]
        public int K12leapreKeligibilityId { get; set; }
        [Column("K12LeaId")]
        public int K12leaId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefPrekindergartenEligibilityId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("K12leaPreKeligibilities")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12leaId")]
        [InverseProperty("K12leaPreKeligibilities")]
        public virtual K12lea K12lea { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12leaPreKeligibilities")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefPrekindergartenEligibilityId")]
        [InverseProperty("K12leaPreKeligibilities")]
        public virtual RefPrekindergartenEligibility RefPrekindergartenEligibility { get; set; } = null!;
    }
}
