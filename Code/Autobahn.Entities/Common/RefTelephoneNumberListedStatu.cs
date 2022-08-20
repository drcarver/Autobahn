//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTelephoneNumberListedStatus.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefTelephoneNumberListedStatus")]
    public partial class RefTelephoneNumberListedStatus : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefTelephoneNumberListedStatus()
        {
            OrganizationTelephones = new HashSet<OrganizationTelephone>();
            PersonTelephones = new HashSet<PersonTelephone>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationTelephone> OrganizationTelephones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonTelephone> PersonTelephones { get; set; }
    }
}
