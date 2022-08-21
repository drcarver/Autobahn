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
    [Table("ELChildOutcomeSummary")]
    public partial class ElchildOutcomeSummary
    {
        [Key]
        [Column("ELChildOutcomeSummaryId")]
        public int ElchildOutcomeSummaryId { get; set; }
        /// <summary>
        /// Surrogate key from Person.
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("COSProgressAIndicator")]
        public bool? CosprogressAindicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("COSProgressBIndicator")]
        public bool? CosprogressBindicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("COSProgressCIndicator")]
        public bool? CosprogressCindicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("COSRatingAId")]
        public int? CosratingAid { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("COSRatingBId")]
        public int? CosratingBid { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("COSRatingCId")]
        public int? CosratingCid { get; set; }
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

        [ForeignKey("CosratingAid")]
        [InverseProperty("ElchildOutcomeSummaryCosratingAs")]
        public virtual RefChildOutcomesSummaryRating? CosratingA { get; set; }
        [ForeignKey("CosratingBid")]
        [InverseProperty("ElchildOutcomeSummaryCosratingBs")]
        public virtual RefChildOutcomesSummaryRating? CosratingB { get; set; }
        [ForeignKey("CosratingCid")]
        [InverseProperty("ElchildOutcomeSummaryCosratingCs")]
        public virtual RefChildOutcomesSummaryRating? CosratingC { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("ElchildOutcomeSummaries")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("ElchildOutcomeSummaries")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ElchildOutcomeSummaries")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
