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
    [Table("AssessmentELDevelopmentalDomain", Schema = "Assessment")]
    [Index("AssessmentId", "RefAssessmentEldevelopmentalDomainId", Name = "IX_AssessmentELDevelopmentalDomain", IsUnique = true)]
    public partial class AssessmentELDevelopmentalDomain
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentELDevelopmentalDomainId { get; set; }
        /// <summary>
        /// Foreign key - Assessment
        /// </summary>
        public int AssessmentId { get; set; }
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

        [ForeignKey("AssessmentId")]
        [InverseProperty("AssessmentEldevelopmentalDomains")]
        public virtual Assessment Assessment { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentEldevelopmentalDomains")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentEldevelopmentalDomains")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentEldevelopmentalDomainId")]
        [InverseProperty("AssessmentEldevelopmentalDomains")]
        public virtual RefAssessmentELDevelopmentalDomain RefAssessmentEldevelopmentalDomain { get; set; } = null!;
    }
}
