using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CredentialCriteriaCourse")]
    public partial class CredentialCriteriaCourse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CredentialCriteriaCourse()
        {
            CredentialAwardCredits = new HashSet<CredentialAwardCredit>();
        }

        public int CredentialCriteriaCourseId { get; set; }

        public int CredentialDefCriteriaId { get; set; }

        public int CourseId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual Course Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialAwardCredit> CredentialAwardCredits { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual CredentialDefCriteria CredentialDefCriteria { get; set; }
    }
}
