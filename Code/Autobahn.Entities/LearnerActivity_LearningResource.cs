namespace Autobahn.Entities
{
    public partial class LearnerActivity_LearningResource
    {
        public int LearnerActivity_LearningResourceId { get; set; }

        public int LearnerActivityId { get; set; }

        public int LearningResourceId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual LearnerActivity LearnerActivity { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual LearningResource LearningResource { get; set; }
    }
}
