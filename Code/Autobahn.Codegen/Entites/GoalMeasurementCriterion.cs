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
    [Table("GoalMeasurementCriterion")]
    public partial class GoalMeasurementCriterion
    {
        [Key]
        public int GoalMeasurementCriterionId { get; set; }
        public int GoalMeasurementId { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? AccuracyPercent { get; set; }
        public int? AttemptsCount { get; set; }
        [StringLength(60)]
        public string? Metric { get; set; }
        public int? SuccessCount { get; set; }
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
        [InverseProperty("GoalMeasurementCriteria")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("GoalMeasurementId")]
        [InverseProperty("GoalMeasurementCriteria")]
        public virtual GoalMeasurement GoalMeasurement { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("GoalMeasurementCriteria")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
