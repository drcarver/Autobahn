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
    [Table("AssessmentRegistrationAccommodation", Schema = "Assessment")]
    public partial class AssessmentRegistrationAccommodation
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentRegistrationAccommodationId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentRegistration
        /// </summary>
        public int AssessmentRegistrationId { get; set; }
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
        [InverseProperty("AssessmentRegistrationAccommodations")]
        public virtual AssessmentAccommodation AssessmentAccommodation { get; set; } = null!;
        [ForeignKey("AssessmentRegistrationId")]
        [InverseProperty("AssessmentRegistrationAccommodations")]
        public virtual AssessmentRegistration AssessmentRegistration { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentRegistrationAccommodations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentRegistrationAccommodations")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
