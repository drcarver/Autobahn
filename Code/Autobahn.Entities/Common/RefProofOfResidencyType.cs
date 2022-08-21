//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProofOfResidencyType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefProofOfResidencyType", Schema= "Common")]
    public partial class RefProofOfResidencyType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefProofOfResidencyType()
        {
            PersonDetails = new HashSet<PersonDetail>();
            PersonFamilies = new HashSet<PersonFamily>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDetail> PersonDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonFamily> PersonFamilies { get; set; }
    }
}
