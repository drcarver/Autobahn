//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonTelephoneNumberType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefPersonTelephoneNumberType", Schema = "Common")]
    public partial class RefPersonTelephoneNumberType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefPersonTelephoneNumberType()
        {
            PersonTelephones = new HashSet<PersonTelephone>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonTelephone> PersonTelephones { get; set; }
    }
}
