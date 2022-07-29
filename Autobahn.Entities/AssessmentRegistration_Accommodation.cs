using System;

namespace Autobahn.Entities
{
    public partial class AssessmentRegistration_Accommodation
    {
        public int AssessmentRegistration_AccommodationId { get; set; }

        public int AssessmentRegistrationId { get; set; }

        public int AssessmentAccommodationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentAccommodation AssessmentAccommodation { get; set; }

        public virtual AssessmentRegistration AssessmentRegistration { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
