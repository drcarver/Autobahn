using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonCredential")]
    public partial class PersonCredential
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonCredential()
        {
            EarlyChildhoodCredentials = new HashSet<EarlyChildhoodCredential>();
            StaffCredentials = new HashSet<StaffCredential>();
        }

        public int PersonCredentialId { get; set; }

        public int PersonId { get; set; }

        [StringLength(60)]
        public string CredentialName { get; set; }

        public int? RefCredentialTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IssuanceDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpirationDate { get; set; }

        public int? RefIssuingStateId { get; set; }

        [StringLength(30)]
        public string ProfessionalCertificateOrLicenseNumber { get; set; }

        [StringLength(60)]
        public string CredentialOrLicenseAwardEntity { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EarlyChildhoodCredential> EarlyChildhoodCredentials { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCredentialType RefCredentialType { get; set; }

        public virtual RefState RefState { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffCredential> StaffCredentials { get; set; }
    }
}
