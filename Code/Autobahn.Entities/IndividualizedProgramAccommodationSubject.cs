using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IndividualizedProgramAccommodationSubject")]
    public partial class IndividualizedProgramAccommodationSubject
    {
        public int IndividualizedProgramAccommodationSubjectId { get; set; }

        public int IndividualizedProgramAccommodationId { get; set; }

        public int RefSCEDCourseSubjectAreaId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IndividualizedProgramAccommodation IndividualizedProgramAccommodation { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefSCEDCourseSubjectArea RefSCEDCourseSubjectArea { get; set; }
    }
}
