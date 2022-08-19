using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("GoalPerformance")]
    public partial class GoalPerformance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoalPerformance()
        {
            IndividualizedProgramProgressGoals = new HashSet<IndividualizedProgramProgressGoal>();
        }

        public int GoalPerformanceId { get; set; }

        public int GoalId { get; set; }

        public string CurrentPerformanceDescription { get; set; }

        public DateTime? Date { get; set; }

        public string Status { get; set; }

        public int? RefGoalStatusTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Goal Goal { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefGoalStatusType RefGoalStatusType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramProgressGoal> IndividualizedProgramProgressGoals { get; set; }
    }
}
