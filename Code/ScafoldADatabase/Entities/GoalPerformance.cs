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
    [Table("GoalPerformance")]
    public partial class GoalPerformance
    {
        public GoalPerformance()
        {
            IndividualizedProgramProgressGoals = new HashSet<IndividualizedProgramProgressGoal>();
        }

        [Key]
        public int GoalPerformanceId { get; set; }
        public int GoalId { get; set; }
        public string? CurrentPerformanceDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        public string? Status { get; set; }
        public int? RefGoalStatusTypeId { get; set; }
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
        [InverseProperty("GoalPerformances")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("GoalId")]
        [InverseProperty("GoalPerformances")]
        public virtual Goal Goal { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("GoalPerformances")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefGoalStatusTypeId")]
        [InverseProperty("GoalPerformances")]
        public virtual RefGoalStatusType? RefGoalStatusType { get; set; }
        [InverseProperty("GoalPerformance")]
        public virtual ICollection<IndividualizedProgramProgressGoal> IndividualizedProgramProgressGoals { get; set; }
    }
}
