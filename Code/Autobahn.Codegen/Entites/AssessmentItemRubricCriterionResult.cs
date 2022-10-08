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
    [Table("AssessmentItemRubricCriterionResult", Schema = "Assessment")]
    public partial class AssessmentItemRubricCriterionResult
    {
        [Key]
        public int AssessmentItemResponseId { get; set; }
        [Key]
        public int RubricCriterionLevelId { get; set; }
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

        [ForeignKey("AssessmentItemResponseId")]
        [InverseProperty("AssessmentItemRubricCriterionResults")]
        public virtual AssessmentItemResponse AssessmentItemResponse { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentItemRubricCriterionResults")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentItemRubricCriterionResults")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RubricCriterionLevelId")]
        [InverseProperty("AssessmentItemRubricCriterionResults")]
        public virtual RubricCriterionLevel RubricCriterionLevel { get; set; } = null!;
    }
}
