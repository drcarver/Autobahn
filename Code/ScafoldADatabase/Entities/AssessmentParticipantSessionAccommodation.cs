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
    [Table("AssessmentParticipantSession_Accommodation")]
    public partial class AssessmentParticipantSessionAccommodation
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("AssessmentParticipantSession_AccommodationId")]
        public int AssessmentParticipantSessionAccommodationId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentParticipantSession
        /// </summary>
        public int AssessmentParticipantSessionId { get; set; }
        public int AssessmentAccommodationId { get; set; }
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
        [InverseProperty("AssessmentParticipantSessionAccommodations")]
        public virtual AssessmentAccommodation AssessmentAccommodation { get; set; } = null!;
        [ForeignKey("AssessmentParticipantSessionId")]
        [InverseProperty("AssessmentParticipantSessionAccommodations")]
        public virtual AssessmentParticipantSession AssessmentParticipantSession { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentParticipantSessionAccommodations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentParticipantSessionAccommodations")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
