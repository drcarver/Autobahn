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
    [Table("IndividualizedProgramProgressGoal", Schema = "Common")]
    [Index("GoalPerformanceId", "IndividualizedProgramProgressReportId", Name = "IX_GoalPerformance_IndividualizedProgramProgressReport", IsUnique = true)]
    public partial class IndividualizedProgramProgressGoal
    {
        [Key]
        public int IndividualizedProgramProgressGoalId { get; set; }
        public int GoalPerformanceId { get; set; }
        public int IndividualizedProgramProgressReportId { get; set; }
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
        [InverseProperty("IndividualizedProgramProgressGoals")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("GoalPerformanceId")]
        [InverseProperty("IndividualizedProgramProgressGoals")]
        public virtual GoalPerformance GoalPerformance { get; set; } = null!;
        [ForeignKey("IndividualizedProgramProgressReportId")]
        [InverseProperty("IndividualizedProgramProgressGoals")]
        public virtual IndividualizedProgramProgressReport IndividualizedProgramProgressReport { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramProgressGoals")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
