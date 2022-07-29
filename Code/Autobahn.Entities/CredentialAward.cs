using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CredentialAward")]
    public partial class CredentialAward
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CredentialAward()
        {
            CredentialAwardCredits = new HashSet<CredentialAwardCredit>();
            CredentialAwardEvidences = new HashSet<CredentialAwardEvidence>();
        }

        public int CredentialAwardId { get; set; }

        public int CredentialDefinitionId { get; set; }

        public int CredentialIssuerId { get; set; }

        public int? PersonId { get; set; }

        public string AdvancedStandingDescription { get; set; }

        [StringLength(512)]
        public string AdvancedStandingURL { get; set; }

        [StringLength(300)]
        public string ApproverName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CompletionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CredentialAwardEndDate { get; set; }

        [StringLength(512)]
        public string EvidenceURL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RevokedDate { get; set; }

        public bool? RevokedIndicator { get; set; }

        public string RevokedReason { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CredentialAwardStartDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? OrganizationId { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual CredentialIssuer CredentialIssuer { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialAwardCredit> CredentialAwardCredits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialAwardEvidence> CredentialAwardEvidences { get; set; }

        public virtual CredentialDefinition CredentialDefinition { get; set; }
    }
}
