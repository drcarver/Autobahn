using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IndividualizedProgramAccommodation")]
    public partial class IndividualizedProgramAccommodation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IndividualizedProgramAccommodation()
        {
            IndividualizedProgramAccommodationSubjects = new HashSet<IndividualizedProgramAccommodationSubject>();
        }

        public int IndividualizedProgramAccommodationId { get; set; }

        public int IndividualizedProgramId { get; set; }

        public string Description { get; set; }

        public string Applicability { get; set; }

        public int? RefAccommodationTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IndividualizedProgram IndividualizedProgram { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAccommodationType RefAccommodationType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramAccommodationSubject> IndividualizedProgramAccommodationSubjects { get; set; }
    }
}
