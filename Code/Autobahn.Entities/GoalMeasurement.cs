using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("GoalMeasurement")]
    public partial class GoalMeasurement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoalMeasurement()
        {
            GoalMeasurementCriterions = new HashSet<GoalMeasurementCriterion>();
        }

        public int GoalMeasurementId { get; set; }

        public int GoalId { get; set; }

        public string Description { get; set; }

        public string Schedule { get; set; }

        [StringLength(300)]
        public string SuccessCriteria { get; set; }

        public int? RefGoalMeasurementTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Goal Goal { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefGoalMeasurementType RefGoalMeasurementType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalMeasurementCriterion> GoalMeasurementCriterions { get; set; }
    }
}
