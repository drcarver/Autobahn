//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonTelephone.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("PersonTelephone", Schema = "Common")]
    public partial class PersonTelephone : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonTelephone()
        {
            PersonPersonalInformationVerifications = new HashSet<PersonPersonalInformationVerification>();
        }

        [ForeignKey("Person")]
        public Guid PersonId { get; set; }

        [StringLength(24)]
        public string TelephoneNumber { get; set; }

        public bool PrimaryTelephoneNumberIndicator { get; set; }

        [ForeignKey("RefPersonTelephoneNumberType")]
        public Guid? RefPersonTelephoneNumberTypeId { get; set; }

        public bool? DoNotPublishIndicator { get; set; }

        [ForeignKey("RefTelephoneNumberListedStatus")]
        public Guid? RefTelephoneNumberListedStatusId { get; set; }

        public virtual Person Person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonPersonalInformationVerification> PersonPersonalInformationVerifications { get; set; }

        public virtual RefPersonTelephoneNumberType RefPersonTelephoneNumberType { get; set; }

        public virtual RefTelephoneNumberListedStatus RefTelephoneNumberListedStatus { get; set; }
    }
}
