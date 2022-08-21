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
    [Table("IndividualizedProgramGoal")]
    public partial class IndividualizedProgramGoal
    {
        [Key]
        public int IndividualizedProgramGoalId { get; set; }
        public int GoalId { get; set; }
        public int IndividualizedProgramId { get; set; }
        [Column("RefIEPGoalTypeId")]
        public int? RefIepgoalTypeId { get; set; }
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
        [InverseProperty("IndividualizedProgramGoals")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("GoalId")]
        [InverseProperty("IndividualizedProgramGoals")]
        public virtual Goal Goal { get; set; } = null!;
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("IndividualizedProgramGoals")]
        public virtual IndividualizedProgram IndividualizedProgram { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramGoals")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIepgoalTypeId")]
        [InverseProperty("IndividualizedProgramGoals")]
        public virtual RefIepgoalType? RefIepgoalType { get; set; }
    }
}
