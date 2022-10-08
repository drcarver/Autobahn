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
    [Table("AssessmentNeedBraille", Schema = "Assessment")]
    public partial class AssessmentNeedBraille
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentNeedBrailleId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentPersonNeedProfileDisplay.
        /// </summary>
        public int? AssessmentPersonalNeedsProfileDisplayId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedUsageTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedBrailleGradeTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedNumberOfBrailleDotId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? NumberOfBrailleCells { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedBrailleMarkTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(10, 4)")]
        public decimal? BrailleDotPressure { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentNeedBrailleStatusCellTypeId { get; set; }
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

        [ForeignKey("AssessmentPersonalNeedsProfileDisplayId")]
        [InverseProperty("AssessmentNeedBrailles")]
        public virtual AssessmentPersonalNeedsProfileDisplay? AssessmentPersonalNeedsProfileDisplay { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentNeedBrailles")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentNeedBrailles")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentNeedBrailleGradeTypeId")]
        [InverseProperty("AssessmentNeedBrailles")]
        public virtual RefAssessmentNeedBrailleGradeType? RefAssessmentNeedBrailleGradeType { get; set; }
        [ForeignKey("RefAssessmentNeedBrailleMarkTypeId")]
        [InverseProperty("AssessmentNeedBrailles")]
        public virtual RefAssessmentNeedBrailleMarkType? RefAssessmentNeedBrailleMarkType { get; set; }
        [ForeignKey("RefAssessmentNeedBrailleStatusCellTypeId")]
        [InverseProperty("AssessmentNeedBrailles")]
        public virtual RefAssessmentNeedBrailleStatusCellType? RefAssessmentNeedBrailleStatusCellType { get; set; }
        [ForeignKey("RefAssessmentNeedNumberOfBrailleDotId")]
        [InverseProperty("AssessmentNeedBrailles")]
        public virtual RefAssessmentNeedNumberOfBrailleDot? RefAssessmentNeedNumberOfBrailleDots { get; set; }
        [ForeignKey("RefAssessmentNeedUsageTypeId")]
        [InverseProperty("AssessmentNeedBrailles")]
        public virtual RefAssessmentNeedUsageType? RefAssessmentNeedUsageType { get; set; }
    }
}
