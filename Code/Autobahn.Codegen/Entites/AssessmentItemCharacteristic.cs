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
    [Table("AssessmentItemCharacteristic", Schema = "Assessment")]
    public partial class AssessmentItemCharacteristic
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentItemCharacteristicId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentItem
        /// </summary>
        public int AssessmentItemId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentItemCharacteristicTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Value { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(100)]
        public string? ResponseChoicePattern { get; set; }
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
        [InverseProperty("AssessmentItemCharacteristics")]
        public virtual AssessmentItem AssessmentItem { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentItemCharacteristics")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentItemCharacteristics")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentItemCharacteristicTypeId")]
        [InverseProperty("AssessmentItemCharacteristics")]
        public virtual RefAssessmentItemCharacteristicType? RefAssessmentItemCharacteristicType { get; set; }
    }
}
