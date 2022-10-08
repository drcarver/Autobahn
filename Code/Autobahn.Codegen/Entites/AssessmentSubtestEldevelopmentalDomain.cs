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
    [Table("AssessmentSubtestELDevelopmentalDomain", Schema = "Assessment")]
    [Index("AssessmentSubtestId", "RefAssessmentEldevelopmentalDomainId", Name = "IX_AssessmentSubtestELDevelopmentalDomain", IsUnique = true)]
    public partial class AssessmentSubtestELDevelopmentalDomain
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentSubtestELDevelopmentalDomainId { get; set; }
        /// <summary>
        /// Foreign key - Assessment
        /// </summary>
        public int AssessmentSubTestId { get; set; }
        /// <summary>
        /// Foreign key - RefAssessmentELDevelopmentalDomain
        /// </summary>
        public int RefAssessmentELDevelopmentalDomainId { get; set; }
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
        public virtual AssessmentSubTest AssessmentSubtest { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentSubtestEldevelopmentalDomains")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentSubtestEldevelopmentalDomains")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentEldevelopmentalDomainId")]
        [InverseProperty("AssessmentSubtestEldevelopmentalDomains")]
        public virtual RefAssessmentELDevelopmentalDomain RefAssessmentEldevelopmentalDomain { get; set; } = null!;
    }
}
