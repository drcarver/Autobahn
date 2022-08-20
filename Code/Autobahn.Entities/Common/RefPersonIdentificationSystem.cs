//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonIdentificationSystem.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefPersonIdentificationSystem")]
    public partial class RefPersonIdentificationSystem : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefPersonIdentificationSystem()
        {
            PersonIdentifiers = new HashSet<PersonIdentifier>();
        }

        [ForeignKey("RefPersonIdentifierType")]
        public Guid? RefPersonIdentifierTypeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonIdentifier> PersonIdentifiers { get; set; }

        public virtual RefPersonIdentifierType RefPersonIdentifierType { get; set; }
    }
}
