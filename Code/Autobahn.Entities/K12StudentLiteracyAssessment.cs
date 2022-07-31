namespace Autobahn.Entities
{
    public partial class K12StudentLiteracyAssessment
    {
        public int K12StudentLiteracyAssessmentId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public bool? LiteracyPreTestStatus { get; set; }

        public bool? LiteracyPostTestStatus { get; set; }

        public bool? LiteracyGoalMetStatus { get; set; }

        public int? RefLiteracyAssessmentId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefLiteracyAssessment RefLiteracyAssessment { get; set; }
    }
}