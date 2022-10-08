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
    [Table("AssessmentSubtest_AssessmentItem", Schema = "Assessment")]
    public partial class AssessmentSubtestAssessmentItem
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentSubtestItemId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentSubtest
        /// </summary>
        public int AssessmentSubTestId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentItem
        /// </summary>
        public int AssessmentItemId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? ItemWeightCorrect { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? ItemWeightIncorrect { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? ItemWeightNotAttempted { get; set; }
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

        [ForeignKey("AssessmentItemId")]
        [InverseProperty("AssessmentSubtestAssessmentItems")]
        public virtual AssessmentItem AssessmentItem { get; set; } = null!;
        [ForeignKey("AssessmentSubtestId")]
        [InverseProperty("AssessmentSubtestAssessmentItems")]
        public virtual AssessmentSubTest AssessmentSubtest { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentSubtestAssessmentItems")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentSubtestAssessmentItems")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
