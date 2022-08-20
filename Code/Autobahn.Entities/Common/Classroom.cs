//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Classroom.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Interfaces.Common;

namespace Autobahn.Entities.Common
{
    [Table("Classroom", Schema = "Common")]
    public partial class Classroom : EntityBase, IClassroom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Classroom()
        {
            CourseSectionLocations = new HashSet<CourseSectionLocation>();
        }

        [ForeignKey("Location")]
        public Guid LocationId { get; set; }

        [StringLength(40)]
        public string ClassroomIdentifier { get; set; }

        public virtual Location Location { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSectionLocation> CourseSectionLocations { get; set; }
    }
}
