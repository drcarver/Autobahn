//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSex.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefSex", Schema= "Common")]
    public partial class RefSex : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefSex()
        {
            PersonDetails = new HashSet<PersonDetail>();
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDetail> PersonDetails { get; set; }
    }
}
