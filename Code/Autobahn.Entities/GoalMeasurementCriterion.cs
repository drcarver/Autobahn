using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("GoalMeasurementCriterion")]
    public partial class GoalMeasurementCriterion
    {
        public int GoalMeasurementCriterionId { get; set; }

        public int GoalMeasurementId { get; set; }

        public decimal? AccuracyPercent { get; set; }

        public int? AttemptsCount { get; set; }

        [StringLength(60)]
        public string Metric { get; set; }

        public int? SuccessCount { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual GoalMeasurement GoalMeasurement { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
