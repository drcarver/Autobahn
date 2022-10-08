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
    [Table("AssessmentSubTest", Schema = "Assessment")]
    public partial class AssessmentSubTest
    {
        public AssessmentSubTest()
        {
            AssessmentPerformanceLevels = new HashSet<AssessmentPerformanceLevel>();
            AssessmentResults = new HashSet<AssessmentResult>();
            AssessmentSubtestAssessmentItems = new HashSet<AssessmentSubtestAssessmentItem>();
            AssessmentSubtestCompetencyDefinitions = new HashSet<AssessmentSubtestCompetencyDefinition>();
            AssessmentSubtestEldevelopmentalDomains = new HashSet<AssessmentSubtestELDevelopmentalDomain>();
            AssessmentSubtestLevelsForWhichDesigneds = new HashSet<AssessmentSubtestLevelsForWhichDesigned>();
            InverseChildOfAssessmentSubtest = new HashSet<AssessmentSubTest>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentSubTestId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? Identifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentSubtestIdentifierTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? Title { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Version { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? PublishedDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Abbreviation { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefScoreMetricTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? MinimumValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? MaximumValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? OptimalValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? Tier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? ContainerOnly { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentPurposeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? Description { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Rules { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefContentStandardTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAcademicSubjectId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentSubtest 
        /// </summary>
        public int? ChildOfAssessmentSubtestId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentForm
        /// </summary>
        public int? AssessmentFormId { get; set; }
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
        [InverseProperty("AssessmentSubtests")]
        public virtual AssessmentForm? AssessmentForm { get; set; }
        [ForeignKey("ChildOfAssessmentSubtestId")]
        [InverseProperty("InverseChildOfAssessmentSubtest")]
        public virtual AssessmentSubTest? ChildOfAssessmentSubtest { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentSubtests")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentSubtests")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAcademicSubjectId")]
        [InverseProperty("AssessmentSubtests")]
        public virtual RefAcademicSubject? RefAcademicSubject { get; set; }
        [ForeignKey("RefAssessmentPurposeId")]
        [InverseProperty("AssessmentSubtests")]
        public virtual RefAssessmentPurpose? RefAssessmentPurpose { get; set; }
        [ForeignKey("RefAssessmentSubtestIdentifierTypeId")]
        [InverseProperty("AssessmentSubtests")]
        public virtual RefAssessmentSubtestIdentifierType? RefAssessmentSubtestIdentifierType { get; set; }
        [ForeignKey("RefContentStandardTypeId")]
        [InverseProperty("AssessmentSubtests")]
        public virtual RefContentStandardType? RefContentStandardType { get; set; }
        [ForeignKey("RefScoreMetricTypeId")]
        [InverseProperty("AssessmentSubtests")]
        public virtual RefScoreMetricType? RefScoreMetricType { get; set; }
        [InverseProperty("AssessmentSubtest")]
        public virtual ICollection<AssessmentPerformanceLevel> AssessmentPerformanceLevels { get; set; }
        [InverseProperty("AssessmentSubtest")]
        public virtual ICollection<AssessmentResult> AssessmentResults { get; set; }
        [InverseProperty("AssessmentSubtest")]
        public virtual ICollection<AssessmentSubtestAssessmentItem> AssessmentSubtestAssessmentItems { get; set; }
        [InverseProperty("AssessmentSubtest")]
        public virtual ICollection<AssessmentSubtestCompetencyDefinition> AssessmentSubtestCompetencyDefinitions { get; set; }
        [InverseProperty("AssessmentSubtest")]
        public virtual ICollection<AssessmentSubtestELDevelopmentalDomain> AssessmentSubtestEldevelopmentalDomains { get; set; }
        [InverseProperty("AssessmentSubTest")]
        public virtual ICollection<AssessmentSubtestLevelsForWhichDesigned> AssessmentSubtestLevelsForWhichDesigneds { get; set; }
        [InverseProperty("ChildOfAssessmentSubtest")]
        public virtual ICollection<AssessmentSubTest> InverseChildOfAssessmentSubtest { get; set; }
    }
}
