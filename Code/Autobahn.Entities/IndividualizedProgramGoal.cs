using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IndividualizedProgramGoal")]
    public partial class IndividualizedProgramGoal
    {
        public int IndividualizedProgramGoalId { get; set; }

        public int GoalId { get; set; }

        public int IndividualizedProgramId { get; set; }

        public int? RefIEPGoalTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Goal Goal { get; set; }

        public virtual IndividualizedProgram IndividualizedProgram { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefIEPGoalType RefIEPGoalType { get; set; }
    }
}
