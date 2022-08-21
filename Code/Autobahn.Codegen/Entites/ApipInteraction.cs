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
    [Table("ApipInteraction")]
    public partial class ApipInteraction
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int ApipInteractionId { get; set; }
        public int AssessmentItemApipId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Xml { get; set; }
        public int? SequenceNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("APIPInteractionSequenceNumber", TypeName = "decimal(9, 2)")]
        public decimal? ApipinteractionSequenceNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefApipInteractionTypeId { get; set; }
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

        [ForeignKey("AssessmentItemApipId")]
        [InverseProperty("ApipInteractions")]
        public virtual AssessmentItemApip AssessmentItemApip { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("ApipInteractions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ApipInteractions")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefApipInteractionTypeId")]
        [InverseProperty("ApipInteractions")]
        public virtual RefApipInteractionType? RefApipInteractionType { get; set; }
    }
}
