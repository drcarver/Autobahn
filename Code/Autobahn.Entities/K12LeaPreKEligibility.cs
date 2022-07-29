namespace Autobahn.Entities
{
    public partial class K12LeaPreKEligibility
    {
        public int K12LEAPreKEligibilityId { get; set; }

        public int K12LeaId { get; set; }

        public int RefPrekindergartenEligibilityId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12Lea K12Lea { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefPrekindergartenEligibility RefPrekindergartenEligibility { get; set; }
    }
}
