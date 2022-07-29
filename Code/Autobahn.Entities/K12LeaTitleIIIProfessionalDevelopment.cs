namespace Autobahn.Entities
{
    public partial class K12LeaTitleIIIProfessionalDevelopment
    {
        public int K12LEATitleIIIProfessionalDevelopmentId { get; set; }

        public int K12LeaId { get; set; }

        public int RefTitleIIIProfessionalDevelopmentTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12Lea K12Lea { get; set; }

        public virtual RefTitleIIIProfessionalDevelopmentType RefTitleIIIProfessionalDevelopmentType { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
