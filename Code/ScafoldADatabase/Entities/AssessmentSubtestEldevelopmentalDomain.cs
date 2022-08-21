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
    [Table("AssessmentSubtestELDevelopmentalDomain")]
    [Index("AssessmentSubtestId", "RefAssessmentEldevelopmentalDomainId", Name = "IX_AssessmentSubtestELDevelopmentalDomain", IsUnique = true)]
    public partial class AssessmentSubtestEldevelopmentalDomain
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("AssessmentSubtestELDevelopmentalDomainId")]
        public int AssessmentSubtestEldevelopmentalDomainId { get; set; }
        /// <summary>
        /// Foreign key - Assessment
        /// </summary>
        public int AssessmentSubtestId { get; set; }
        /// <summary>
        /// Foreign key - RefAssessmentELDevelopmentalDomain
        /// </summary>
        [Column("RefAssessmentELDevelopmentalDomainId")]
        public int RefAssessmentEldevelopmentalDomainId { get; set; }
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

        [ForeignKey("AssessmentSubtestId")]
        [InverseProperty("AssessmentSubtestEldevelopmentalDomains")]
        public virtual AssessmentSubtest AssessmentSubtest { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentSubtestEldevelopmentalDomains")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentSubtestEldevelopmentalDomains")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentEldevelopmentalDomainId")]
        [InverseProperty("AssessmentSubtestEldevelopmentalDomains")]
        public virtual RefAssessmentEldevelopmentalDomain RefAssessmentEldevelopmentalDomain { get; set; } = null!;
    }
}
