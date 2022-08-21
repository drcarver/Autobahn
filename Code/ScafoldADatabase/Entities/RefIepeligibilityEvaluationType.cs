using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("RefIEPEligibilityEvaluationType")]
    public partial class RefIepeligibilityEvaluationType
    {
        public RefIepeligibilityEvaluationType()
        {
            IndividualizedProgramEligibilityEvaluations = new HashSet<IndividualizedProgramEligibilityEvaluation>();
        }

        /// <summary>
        /// The surrogate key for the options in this option set.
        /// </summary>
        [Key]
        [Column("RefIEPEligibilityEvaluationTypeId")]
        public int RefIepeligibilityEvaluationTypeId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(150)]
        public string Description { get; set; } = null!;
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(60)]
        public string? Code { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(4000)]
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefIepeligibilityEvaluationTypes")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefIepeligibilityEvaluationType")]
        public virtual ICollection<IndividualizedProgramEligibilityEvaluation> IndividualizedProgramEligibilityEvaluations { get; set; }
    }
}
