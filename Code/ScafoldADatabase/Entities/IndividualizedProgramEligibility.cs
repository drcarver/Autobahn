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
    [Table("IndividualizedProgramEligibility")]
    public partial class IndividualizedProgramEligibility
    {
        public IndividualizedProgramEligibility()
        {
            IndividualizedProgramEligibilityEvaluations = new HashSet<IndividualizedProgramEligibilityEvaluation>();
        }

        [Key]
        public int IndividualizedProgramEligibilityId { get; set; }
        public int IndividualizedProgramId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ConsentToEvaluateDate { get; set; }
        public bool? ConsentToEvaluateIndicator { get; set; }
        public string? ParentObservations { get; set; }
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
        [InverseProperty("IndividualizedProgramEligibilities")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("IndividualizedProgramEligibilities")]
        public virtual IndividualizedProgram IndividualizedProgram { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramEligibilities")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("IndividualizedProgramEligibility")]
        public virtual ICollection<IndividualizedProgramEligibilityEvaluation> IndividualizedProgramEligibilityEvaluations { get; set; }
    }
}
