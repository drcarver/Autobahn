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
    [Table("PersonHealth", Schema = "Person")]
    public partial class PersonHealth
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int PersonHealthId { get; set; }
        /// <summary>
        /// Foreign key - Person
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? VisionScreeningDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefVisionScreeningStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? HearingScreeningDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefHearingScreeningStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime DentalScreeningDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDentalScreeningStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefHealthInsuranceCoverageId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDentalInsuranceCoverageTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefMedicalAlertIndicatorId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? HealthScreeningEquipmentUsed { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? HealthScreeningFollowUpRecommendation { get; set; }
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
        [InverseProperty("PersonHealths")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("PersonHealths")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonHealths")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefDentalInsuranceCoverageTypeId")]
        [InverseProperty("PersonHealths")]
        public virtual RefDentalInsuranceCoverageType? RefDentalInsuranceCoverageType { get; set; }
        [ForeignKey("RefDentalScreeningStatusId")]
        [InverseProperty("PersonHealths")]
        public virtual RefDentalScreeningStatus? RefDentalScreeningStatus { get; set; }
        [ForeignKey("RefHealthInsuranceCoverageId")]
        [InverseProperty("PersonHealths")]
        public virtual RefHealthInsuranceCoverage? RefHealthInsuranceCoverage { get; set; }
        [ForeignKey("RefHearingScreeningStatusId")]
        [InverseProperty("PersonHealths")]
        public virtual RefHearingScreeningStatus? RefHearingScreeningStatus { get; set; }
        [ForeignKey("RefMedicalAlertIndicatorId")]
        [InverseProperty("PersonHealths")]
        public virtual RefMedicalAlertIndicator? RefMedicalAlertIndicator { get; set; }
        [ForeignKey("RefVisionScreeningStatusId")]
        [InverseProperty("PersonHealths")]
        public virtual RefVisionScreeningStatus? RefVisionScreeningStatus { get; set; }
    }
}
