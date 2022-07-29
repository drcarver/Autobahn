namespace Autobahn.Entities
{
    public partial class K12SchoolCorrectiveAction
    {
        public int K12SchoolCorrectiveActionId { get; set; }

        public int K12SchoolId { get; set; }

        public int RefCorrectiveActionTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12School K12School { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCorrectiveActionType RefCorrectiveActionType { get; set; }
    }
}
