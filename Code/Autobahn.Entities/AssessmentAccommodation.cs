using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentAccommodation")]
    public partial class AssessmentAccommodation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentAccommodation()
        {
            AssessmentParticipantSession_Accommodation = new HashSet<AssessmentParticipantSession_Accommodation>();
            AssessmentRegistration_Accommodation = new HashSet<AssessmentRegistration_Accommodation>();
            IndividualizedProgramAssessmentAccommodations = new HashSet<IndividualizedProgramAssessmentAccommodation>();
        }

        public int AssessmentAccommodationId { get; set; }

        [StringLength(30)]
        public string OtherDescription { get; set; }

        public int? RefAccommodationTypeId { get; set; }

        public int? RefAssessmentAccommodationCategoryId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAccommodationType RefAccommodationType { get; set; }

        public virtual RefAssessmentAccommodationCategory RefAssessmentAccommodationCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentParticipantSession_Accommodation> AssessmentParticipantSession_Accommodation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentRegistration_Accommodation> AssessmentRegistration_Accommodation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramAssessmentAccommodation> IndividualizedProgramAssessmentAccommodations { get; set; }
    }
}
