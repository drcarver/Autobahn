//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInstitutionTelephoneType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefInstitutionTelephoneType", Schema = "Common")]
    public partial class RefInstitutionTelephoneType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefInstitutionTelephoneType()
        {
            OrganizationTelephones = new HashSet<OrganizationTelephone>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationTelephone> OrganizationTelephones { get; set; }
    }
}
