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
    [Table("AssessmentFormAssessmentFormSection", Schema = "Assessment")]
    public partial class AssessmentFormAssessmentFormSection
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentFormAssessmentFormSectionId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentForm.
        /// </summary>
        public int AssessmentFormId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentFormSection
        /// </summary>
        public int AssessmentFormSectionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? SequenceNumber { get; set; }
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

        [ForeignKey("AssessmentFormId")]
        [InverseProperty("AssessmentFormAssessmentFormSections")]
        public virtual AssessmentForm AssessmentForm { get; set; } = null!;
        [ForeignKey("AssessmentFormSectionId")]
        [InverseProperty("AssessmentFormAssessmentFormSections")]
        public virtual AssessmentFormSection AssessmentFormSection { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentFormAssessmentFormSections")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentFormAssessmentFormSections")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
