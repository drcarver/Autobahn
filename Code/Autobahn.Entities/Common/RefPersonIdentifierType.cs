//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonIdentifierType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefPersonIdentifierType")]
    public partial class RefPersonIdentifierType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefPersonIdentifierType()
        {
            RefPersonIdentificationSystems = new HashSet<RefPersonIdentificationSystem>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPersonIdentificationSystem> RefPersonIdentificationSystems { get; set; }
    }
}
