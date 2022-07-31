using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentItem")]
    public partial class AssessmentItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentItem()
        {
            AssessmentFormSection_AssessmentItem = new HashSet<AssessmentFormSection_AssessmentItem>();
            AssessmentItemApips = new HashSet<AssessmentItemApip>();
            AssessmentItemPossibleResponses = new HashSet<AssessmentItemPossibleResponse>();
            AssessmentItemResponses = new HashSet<AssessmentItemResponse>();
            AssessmentItemResponseTheories = new HashSet<AssessmentItemResponseTheory>();
            AssessmentSubtest_AssessmentItem = new HashSet<AssessmentSubtest_AssessmentItem>();
            AssessmentItemCharacteristics = new HashSet<AssessmentItemCharacteristic>();
        }

        public int AssessmentItemId { get; set; }

        [StringLength(40)]
        public string Identifier { get; set; }

        [StringLength(40)]
        public string AssessmentItemBankIdentifier { get; set; }

        [StringLength(60)]
        public string AssessmentItemBankName { get; set; }

        public int? RefAssessmentItemTypeId { get; set; }

        public string BodyText { get; set; }

        public string Stimulus { get; set; }

        public string Stem { get; set; }

        public bool? AdaptiveIndicator { get; set; }

        [StringLength(300)]
        public string MaximumScore { get; set; }

        [StringLength(300)]
        public string MinimumScore { get; set; }

        [StringLength(100)]
        public string DistractorAnalysis { get; set; }

        public TimeSpan? AllottedTime { get; set; }

        public int? RefNaepMathComplexityLevelId { get; set; }

        public int? RefNaepAspectsOfReadingId { get; set; }

        public decimal? Difficulty { get; set; }

        public int? RefTextComplexitySystemId { get; set; }

        [StringLength(30)]
        public string TextComplexityValue { get; set; }

        public bool? LinkingItemIndicator { get; set; }

        public bool? ReleaseStatus { get; set; }

        public int? RubricId { get; set; }

        public int? LearningResourceId { get; set; }

        public bool? AssessmentFormSectionItemFieldTestIndicator { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentFormSection_AssessmentItem> AssessmentFormSection_AssessmentItem { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual LearningResource LearningResource { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentItemType RefAssessmentItemType { get; set; }

        public virtual RefNaepAspectsOfReading RefNaepAspectsOfReading { get; set; }

        public virtual RefNaepMathComplexityLevel RefNaepMathComplexityLevel { get; set; }

        public virtual RefTextComplexitySystem RefTextComplexitySystem { get; set; }

        public virtual Rubric Rubric { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentItemApip> AssessmentItemApips { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentItemPossibleResponse> AssessmentItemPossibleResponses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentItemResponse> AssessmentItemResponses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentItemResponseTheory> AssessmentItemResponseTheories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSubtest_AssessmentItem> AssessmentSubtest_AssessmentItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentItemCharacteristic> AssessmentItemCharacteristics { get; set; }
    }
}