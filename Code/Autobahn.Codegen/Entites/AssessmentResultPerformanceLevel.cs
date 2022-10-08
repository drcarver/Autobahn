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
    [Table("AssessmentResultPerformanceLevel", Schema = "Assessment")]
    public partial class AssessmentResultPerformanceLevel
    {
        [Key]
        public int AssessmentResultPerformanceLevelId { get; set; }
        /// <summary>
        /// Foreign key to AssessmentResult.  [Related CEDS Elements: Developmental Evaluation Finding (000315), Early Learning Child Developmental Screening Status (000314)]
        /// </summary>
        public int AssessmentResultId { get; set; }
        /// <summary>
        /// Foreign key to AssessmentPerformanceLevel.  [Related CEDS Elements: Developmental Evaluation Finding (000315), Early Learning Child Developmental Screening Status (000314)]
        /// </summary>
        public int AssessmentPerformanceLevelId { get; set; }
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

        [ForeignKey("AssessmentPerformanceLevelId")]
        [InverseProperty("AssessmentResultPerformanceLevels")]
        public virtual AssessmentPerformanceLevel AssessmentPerformanceLevel { get; set; } = null!;
        [ForeignKey("AssessmentResultId")]
        [InverseProperty("AssessmentResultPerformanceLevels")]
        public virtual AssessmentResult AssessmentResult { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentResultPerformanceLevels")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentResultPerformanceLevels")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
