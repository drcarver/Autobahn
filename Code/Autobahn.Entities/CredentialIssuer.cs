using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CredentialIssuer")]
    public partial class CredentialIssuer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CredentialIssuer()
        {
            CredentialAwards = new HashSet<CredentialAward>();
            CredentialOffereds = new HashSet<CredentialOffered>();
        }

        public int CredentialIssuerId { get; set; }

        public int OrganizationId { get; set; }

        [StringLength(512)]
        public string AwardIssuerOriginURL { get; set; }

        [StringLength(512)]
        public string RevocationListURL { get; set; }

        public int? RefCTDLOrganizationTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialAward> CredentialAwards { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCTDLOrganizationType RefCTDLOrganizationType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialOffered> CredentialOffereds { get; set; }
    }
}
