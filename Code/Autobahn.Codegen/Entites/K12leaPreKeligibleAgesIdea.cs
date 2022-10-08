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
    [Table("K12LeaPreKEligibleAgesIDEA", Schema = "K12")]
    public partial class K12leaPreKeligibleAgesIdea
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("K12LEAPreKEligibleAgesIDEAId")]
        public int K12leapreKeligibleAgesIdeaid { get; set; }
        [Column("K12LeaId")]
        public int K12leaId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefPreKEligibleAgesNonIDEAId")]
        public int RefPreKeligibleAgesNonIdeaid { get; set; }
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
        [InverseProperty("K12leaPreKeligibleAgesIdeas")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12leaId")]
        [InverseProperty("K12leaPreKeligibleAgesIdeas")]
        public virtual K12Lea K12lea { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12leaPreKeligibleAgesIdeas")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefPreKeligibleAgesNonIdeaid")]
        [InverseProperty("K12leaPreKeligibleAgesIdeas")]
        public virtual RefPreKEligibleAgesNonIDEA RefPreKeligibleAgesNonIdea { get; set; } = null!;
    }
}
