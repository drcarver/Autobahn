namespace Autobahn.Entities
{
    public partial class AssessmentResult_PerformanceLevel
    {
        public int AssessmentResult_PerformanceLevelId { get; set; }

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
