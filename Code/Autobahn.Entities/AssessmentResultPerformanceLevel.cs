using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentResultPerformanceLevel")]
    public partial class AssessmentResultPerformanceLevel
    {
        public int AssessmentResultPerformanceLevelId { get; set; }

        public int AssessmentResultId { get; set; }

        public int AssessmentPerformanceLevelId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentPerformanceLevel AssessmentPerformanceLevel { get; set; }

        public virtual AssessmentResult AssessmentResult { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
