using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AuthorizationDocument")]
    public partial class AuthorizationDocument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AuthorizationDocument()
        {
            IEPAuthorizations = new HashSet<IEPAuthorization>();
        }

        public int AuthorizationDocumentId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public bool? AcceptanceIndicator { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AuthorizationDate { get; set; }

        public string DecisionExplanation { get; set; }

        public int? RefAuthorizerTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAuthorizerType RefAuthorizerType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IEPAuthorization> IEPAuthorizations { get; set; }
    }
}
