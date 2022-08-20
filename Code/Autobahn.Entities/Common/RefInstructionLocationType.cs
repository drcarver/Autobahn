//**********************************************************
//* DomainName: Autobahn.Entities
//* FileName:   RefInstructionLocationType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefInstructionLocationType", Schema = "Common")]
    public partial class RefInstructionLocationType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefInstructionLocationType()
        {
            CourseSectionLocations = new HashSet<CourseSectionLocation>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSectionLocation> CourseSectionLocations { get; set; }
    }
}