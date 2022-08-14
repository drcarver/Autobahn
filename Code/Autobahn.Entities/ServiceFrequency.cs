using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ServiceFrequency")]
    public partial class ServiceFrequency
    {
        public int ServiceFrequencyId { get; set; }

        public int ServicePlanId { get; set; }

        public int? DurationInMinutes { get; set; }

        public int? FrequencyLength { get; set; }

        public int? InstancesPerCycle { get; set; }

        public int? RefFrequencyUnitId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFrequencyUnit RefFrequencyUnit { get; set; }

        public virtual ServicePlan ServicePlan { get; set; }
    }
}
