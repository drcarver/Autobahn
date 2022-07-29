using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CredentialDefCriteria")]
    public partial class CredentialDefCriteria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CredentialDefCriteria()
        {
            CredentialCriteriaCourses = new HashSet<CredentialCriteriaCourse>();
        }

        public int CredentialDefCriteriaId { get; set; }

        public int CredentialDefinitionId { get; set; }

        public int? CompetencySetId { get; set; }

        [StringLength(300)]
        public string Criteria { get; set; }

        [StringLength(512)]
        public string CriteriaUrl { get; set; }

        [StringLength(5)]
        public string EstimatedDuration { get; set; }

        [StringLength(5)]
        public string MaximumDuration { get; set; }

        public int? MinimumAge { get; set; }

        [StringLength(5)]
        public string MinimumDuration { get; set; }

        public int? RefCredentialDefAssessMethodTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual CompetencySet CompetencySet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialCriteriaCourse> CredentialCriteriaCourses { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCredentialDefAssessMethodType RefCredentialDefAssessMethodType { get; set; }

        public virtual CredentialDefinition CredentialDefinition { get; set; }
    }
}
