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
    [Table("ELChildDevelopmentalAssessment", Schema = "EarlyLearning")]
    public partial class ELChildDevelopmentalAssessment
    {
        [Key]
        public int ELChildDevelopmentalAssessmentId { get; set; }
        /// <summary>
        /// Surrogate key from Person.
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefChildDevelopmentalScreeningStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDevelopmentalEvaluationFindingId { get; set; }
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
        [InverseProperty("ElchildDevelopmentalAssessments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("ElchildDevelopmentalAssessments")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ElchildDevelopmentalAssessments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefChildDevelopmentalScreeningStatusId")]
        [InverseProperty("ElchildDevelopmentalAssessments")]
        public virtual RefChildDevelopmentalScreeningStatus? RefChildDevelopmentalScreeningStatus { get; set; }
        [ForeignKey("RefDevelopmentalEvaluationFindingId")]
        [InverseProperty("ElchildDevelopmentalAssessments")]
        public virtual RefDevelopmentalEvaluationFinding? RefDevelopmentalEvaluationFinding { get; set; }
    }
}
