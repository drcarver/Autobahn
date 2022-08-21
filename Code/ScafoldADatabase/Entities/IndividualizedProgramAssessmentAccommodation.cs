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
    [Table("IndividualizedProgramAssessmentAccommodation")]
    [Index("AssessmentAccommodationId", "IndividualizedProgramAssessmentId", Name = "IX_AssessmentAccommodation_IndividualizedProgramAssessment", IsUnique = true)]
    public partial class IndividualizedProgramAssessmentAccommodation
    {
        [Key]
        public int IndividualizedProgramAssessmentAccommodationId { get; set; }
        public int AssessmentAccommodationId { get; set; }
        public int IndividualizedProgramAssessmentId { get; set; }
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

        [ForeignKey("AssessmentAccommodationId")]
        [InverseProperty("IndividualizedProgramAssessmentAccommodations")]
        public virtual AssessmentAccommodation AssessmentAccommodation { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("IndividualizedProgramAssessmentAccommodations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramAssessmentId")]
        [InverseProperty("IndividualizedProgramAssessmentAccommodations")]
        public virtual IndividualizedProgramAssessment IndividualizedProgramAssessment { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramAssessmentAccommodations")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
