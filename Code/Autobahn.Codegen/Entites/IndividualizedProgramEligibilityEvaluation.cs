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
    [Table("IndividualizedProgramEligibilityEvaluation", Schema = "K12")]
    public partial class IndividualizedProgramEligibilityEvaluation
    {
        [Key]
        public int IndividualizedProgramEligibilityEvaluationId { get; set; }
        public int EligibilityEvaluationId { get; set; }
        public int IndividualizedProgramEligibilityId { get; set; }
        public int? RefIEPEligibilityEvaluationTypeId { get; set; }
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
        [InverseProperty("IndividualizedProgramEligibilityEvaluations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("EligibilityEvaluationId")]
        [InverseProperty("IndividualizedProgramEligibilityEvaluations")]
        public virtual EligibilityEvaluation EligibilityEvaluation { get; set; } = null!;
        [ForeignKey("IndividualizedProgramEligibilityId")]
        [InverseProperty("IndividualizedProgramEligibilityEvaluations")]
        public virtual IndividualizedProgramEligibility IndividualizedProgramEligibility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramEligibilityEvaluations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIepeligibilityEvaluationTypeId")]
        [InverseProperty("IndividualizedProgramEligibilityEvaluations")]
        public virtual RefIEPEligibilityEvaluationType? RefIepeligibilityEvaluationType { get; set; }
    }
}
