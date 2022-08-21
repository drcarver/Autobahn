//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTribalAffiliation.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefTribalAffiliation")]
    public partial class RefTribalAffiliation : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefTribalAffiliation()
        {
            PersonDetails = new HashSet<PersonDetail>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDetail> PersonDetails { get; set; }
    }
}
