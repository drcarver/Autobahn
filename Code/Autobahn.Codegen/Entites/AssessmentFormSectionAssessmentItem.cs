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
    [Table("AssessmentFormSection_AssessmentItem", Schema = "Assessment")]
    public partial class AssessmentFormSectionAssessmentItem
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentFormSectionItemId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int SequenceNumber { get; set; }
        /// <summary>
        /// Foreign key - AssessmentFormSection
        /// </summary>
        public int AssessmentFormSectionId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentItem
        /// </summary>
        public int AssessmentItemId { get; set; }
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

        [ForeignKey("AssessmentFormSectionId")]
        [InverseProperty("AssessmentFormSectionAssessmentItems")]
        public virtual AssessmentFormSection AssessmentFormSection { get; set; } = null!;
        [ForeignKey("AssessmentItemId")]
        [InverseProperty("AssessmentFormSectionAssessmentItems")]
        public virtual AssessmentItem AssessmentItem { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentFormSectionAssessmentItems")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentFormSectionAssessmentItems")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
