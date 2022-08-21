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
    [Table("AssessmentAccommodation")]
    public partial class AssessmentAccommodation
    {
        public AssessmentAccommodation()
        {
            AssessmentParticipantSessionAccommodations = new HashSet<AssessmentParticipantSessionAccommodation>();
            AssessmentRegistrationAccommodations = new HashSet<AssessmentRegistrationAccommodation>();
            IndividualizedProgramAssessmentAccommodations = new HashSet<IndividualizedProgramAssessmentAccommodation>();
        }

        [Key]
        public int AssessmentAccommodationId { get; set; }
        [StringLength(30)]
        public string? OtherDescription { get; set; }
        public int? RefAccommodationTypeId { get; set; }
        public int? RefAssessmentAccommodationCategoryId { get; set; }
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
        [InverseProperty("AssessmentAccommodations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentAccommodations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAccommodationTypeId")]
        [InverseProperty("AssessmentAccommodations")]
        public virtual RefAccommodationType? RefAccommodationType { get; set; }
        [ForeignKey("RefAssessmentAccommodationCategoryId")]
        [InverseProperty("AssessmentAccommodations")]
        public virtual RefAssessmentAccommodationCategory? RefAssessmentAccommodationCategory { get; set; }
        [InverseProperty("AssessmentAccommodation")]
        public virtual ICollection<AssessmentParticipantSessionAccommodation> AssessmentParticipantSessionAccommodations { get; set; }
        [InverseProperty("AssessmentAccommodation")]
        public virtual ICollection<AssessmentRegistrationAccommodation> AssessmentRegistrationAccommodations { get; set; }
        [InverseProperty("AssessmentAccommodation")]
        public virtual ICollection<IndividualizedProgramAssessmentAccommodation> IndividualizedProgramAssessmentAccommodations { get; set; }
    }
}
