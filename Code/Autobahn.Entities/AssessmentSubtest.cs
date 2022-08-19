using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentSubtest")]
    public partial class AssessmentSubtest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentSubtest()
        {
            AssessmentPerformanceLevels = new HashSet<AssessmentPerformanceLevel>();
            AssessmentResults = new HashSet<AssessmentResult>();
            AssessmentSubtestELDevelopmentalDomains = new HashSet<AssessmentSubtestELDevelopmentalDomain>();
            AssessmentSubtest1 = new HashSet<AssessmentSubtest>();
            AssessmentSubtestCompetencyDefinition = new HashSet<AssessmentSubtestCompetencyDefinition>();
            AssessmentSubtestAssessmentItem = new HashSet<AssessmentSubtestAssessmentItem>();
            AssessmentSubtestLevelsForWhichDesigneds = new HashSet<AssessmentSubtestLevelsForWhichDesigned>();
        }

        public int AssessmentSubtestId { get; set; }

        [StringLength(40)]
        public string Identifier { get; set; }

        public int? RefAssessmentSubtestIdentifierTypeId { get; set; }

        [StringLength(60)]
        public string Title { get; set; }

        [StringLength(30)]
        public string Version { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PublishedDate { get; set; }

        [StringLength(30)]
        public string Abbreviation { get; set; }

        public int? RefScoreMetricTypeId { get; set; }

        [StringLength(30)]
        public string MinimumValue { get; set; }

        [StringLength(30)]
        public string MaximumValue { get; set; }

        [StringLength(30)]
        public string OptimalValue { get; set; }

        public int? Tier { get; set; }

        [StringLength(30)]
        public string ContainerOnly { get; set; }

        public int? RefAssessmentPurposeId { get; set; }

        [StringLength(60)]
        public string Description { get; set; }

        public string Rules { get; set; }

        public int? RefContentStandardTypeId { get; set; }

        public int? RefAcademicSubjectId { get; set; }

        public int? ChildOfAssessmentSubtestId { get; set; }

        public int? AssessmentFormId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual AssessmentForm AssessmentForm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentPerformanceLevel> AssessmentPerformanceLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentResult> AssessmentResults { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSubtestELDevelopmentalDomain> AssessmentSubtestELDevelopmentalDomains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSubtest> AssessmentSubtest1 { get; set; }

        public virtual AssessmentSubtest AssessmentSubtest2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSubtestCompetencyDefinition> AssessmentSubtestCompetencyDefinition { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentPurpose RefAssessmentPurpose { get; set; }

        public virtual RefAssessmentSubtestIdentifierType RefAssessmentSubtestIdentifierType { get; set; }

        public virtual RefContentStandardType RefContentStandardType { get; set; }

        public virtual RefScoreMetricType RefScoreMetricType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSubtestAssessmentItem> AssessmentSubtestAssessmentItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSubtestLevelsForWhichDesigned> AssessmentSubtestLevelsForWhichDesigneds { get; set; }

        public virtual RefAcademicSubject RefAcademicSubject { get; set; }
    }
}
