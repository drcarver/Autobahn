using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IndividualizedProgramAssessmentAccommodation")]
    public partial class IndividualizedProgramAssessmentAccommodation
    {
        public int IndividualizedProgramAssessmentAccommodationId { get; set; }

        public int AssessmentAccommodationId { get; set; }

        public int IndividualizedProgramAssessmentId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentAccommodation AssessmentAccommodation { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IndividualizedProgramAssessment IndividualizedProgramAssessment { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
