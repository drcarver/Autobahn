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
    [Table("GoalMeasurement", Schema = "Common")]
    public partial class GoalMeasurement
    {
        public GoalMeasurement()
        {
            GoalMeasurementCriteria = new HashSet<GoalMeasurementCriterion>();
        }

        [Key]
        public int GoalMeasurementId { get; set; }
        public int GoalId { get; set; }
        public string? Description { get; set; }
        public string? Schedule { get; set; }
        [StringLength(300)]
        public string? SuccessCriteria { get; set; }
        public int? RefGoalMeasurementTypeId { get; set; }
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
        [InverseProperty("GoalMeasurements")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("GoalId")]
        [InverseProperty("GoalMeasurements")]
        public virtual Goal Goal { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("GoalMeasurements")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefGoalMeasurementTypeId")]
        [InverseProperty("GoalMeasurements")]
        public virtual RefGoalMeasurementType? RefGoalMeasurementType { get; set; }
        [InverseProperty("GoalMeasurement")]
        public virtual ICollection<GoalMeasurementCriterion> GoalMeasurementCriteria { get; set; }
    }
}
