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
    [Table("IndividualizedProgramAssessment", Schema = "Assessment")]
    public partial class IndividualizedProgramAssessment
    {
        public IndividualizedProgramAssessment()
        {
            IndividualizedProgramAssessmentAccommodations = new HashSet<IndividualizedProgramAssessmentAccommodation>();
        }

        [Key]
        public int IndividualizedProgramAssessmentId { get; set; }
        public int AssessmentId { get; set; }
        public int IndividualizedProgramId { get; set; }
        public string? IEPAlternativeAssessmentRationale { get; set; }
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
        [InverseProperty("IndividualizedProgramAssessments")]
        public virtual Assessment Assessment { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("IndividualizedProgramAssessments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("IndividualizedProgramAssessments")]
        public virtual IndividualizedProgram IndividualizedProgram { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramAssessments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("IndividualizedProgramAssessment")]
        public virtual ICollection<IndividualizedProgramAssessmentAccommodation> IndividualizedProgramAssessmentAccommodations { get; set; }
    }
}
