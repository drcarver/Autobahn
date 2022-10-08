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
    [Table("AssessmentItem", Schema = "Assessment")]
    public partial class AssessmentItem
    {
        public AssessmentItem()
        {
            AssessmentFormSectionAssessmentItems = new HashSet<AssessmentFormSectionAssessmentItem>();
            AssessmentItemApips = new HashSet<AssessmentItemApip>();
            AssessmentItemCharacteristics = new HashSet<AssessmentItemCharacteristic>();
            AssessmentItemPossibleResponses = new HashSet<AssessmentItemPossibleResponse>();
            AssessmentItemResponseTheories = new HashSet<AssessmentItemResponseTheory>();
            AssessmentItemResponses = new HashSet<AssessmentItemResponse>();
            AssessmentSubtestAssessmentItems = new HashSet<AssessmentSubtestAssessmentItem>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentItemId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? Identifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? AssessmentItemBankIdentifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? AssessmentItemBankName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentItemTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? BodyText { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Stimulus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Stem { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? AdaptiveIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? MaximumScore { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? MinimumScore { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(100)]
        public string? DistractorAnalysis { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? AllottedTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefNaepMathComplexityLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefNaepAspectsOfReadingId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Difficulty { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTextComplexitySystemId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? TextComplexityValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? LinkingItemIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? ReleaseStatus { get; set; }
        /// <summary>
        /// Foreign key - AssessmentItemRubric
        /// </summary>
        public int? RubricId { get; set; }
        /// <summary>
        /// Foreign key - LearningResource
        /// </summary>
        public int? LearningResourceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? AssessmentFormSectionItemFieldTestIndicator { get; set; }
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
        [InverseProperty("AssessmentItems")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LearningResourceId")]
        [InverseProperty("AssessmentItems")]
        public virtual LearningResource? LearningResource { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentItems")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentItemTypeId")]
        [InverseProperty("AssessmentItems")]
        public virtual RefAssessmentItemType? RefAssessmentItemType { get; set; }
        [ForeignKey("RefNaepAspectsOfReadingId")]
        [InverseProperty("AssessmentItems")]
        public virtual RefNaepAspectsOfReading? RefNaepAspectsOfReading { get; set; }
        [ForeignKey("RefNaepMathComplexityLevelId")]
        [InverseProperty("AssessmentItems")]
        public virtual RefNaepMathComplexityLevel? RefNaepMathComplexityLevel { get; set; }
        [ForeignKey("RefTextComplexitySystemId")]
        [InverseProperty("AssessmentItems")]
        public virtual RefTextComplexitySystem? RefTextComplexitySystem { get; set; }
        [ForeignKey("RubricId")]
        [InverseProperty("AssessmentItems")]
        public virtual Rubric? Rubric { get; set; }
        [InverseProperty("AssessmentItem")]
        public virtual ICollection<AssessmentFormSectionAssessmentItem> AssessmentFormSectionAssessmentItems { get; set; }
        [InverseProperty("AssessmentItem")]
        public virtual ICollection<AssessmentItemApip> AssessmentItemApips { get; set; }
        [InverseProperty("AssessmentItem")]
        public virtual ICollection<AssessmentItemCharacteristic> AssessmentItemCharacteristics { get; set; }
        [InverseProperty("AssessmentItem")]
        public virtual ICollection<AssessmentItemPossibleResponse> AssessmentItemPossibleResponses { get; set; }
        [InverseProperty("AssessmentItem")]
        public virtual ICollection<AssessmentItemResponseTheory> AssessmentItemResponseTheories { get; set; }
        [InverseProperty("AssessmentItem")]
        public virtual ICollection<AssessmentItemResponse> AssessmentItemResponses { get; set; }
        [InverseProperty("AssessmentItem")]
        public virtual ICollection<AssessmentSubtestAssessmentItem> AssessmentSubtestAssessmentItems { get; set; }
    }
}
