//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonCredential.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.EarlyLearning;

namespace Autobahn.Entities.Common
{
    [Table("PersonCredential")]
    public partial class PersonCredential : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonCredential()
        {
            EarlyChildhoodCredentials = new HashSet<EarlyChildhoodCredential>();
            StaffCredentials = new HashSet<StaffCredential>();
        }

        [ForeignKey("Person")]
        public Guid PersonId { get; set; }

        [StringLength(60)]
        public string CredentialName { get; set; }

        [ForeignKey("RefCredentialType")]
        public Guid? RefCredentialTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IssuanceDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpirationDate { get; set; }

        [ForeignKey("RefState")]
        public Guid? RefIssuingStateId { get; set; }

        [StringLength(30)]
        public string ProfessionalCertificateOrLicenseNumber { get; set; }

        [StringLength(60)]
        public string CredentialOrLicenseAwardEntity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EarlyChildhoodCredential> EarlyChildhoodCredentials { get; set; }

        public virtual Person Person { get; set; }

        public virtual RefCredentialType RefCredentialType { get; set; }

        public virtual RefState RefState { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffCredential> StaffCredentials { get; set; }
    }
}
