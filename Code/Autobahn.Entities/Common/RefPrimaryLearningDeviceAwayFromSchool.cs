//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPrimaryLearningDeviceAwayFromSchool.cs
//**********************************************************using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.Common;

namespace Autobahn.Entities
{
    [Table("RefPrimaryLearningDeviceAwayFromSchool")]
    public partial class RefPrimaryLearningDeviceAwayFromSchool : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefPrimaryLearningDeviceAwayFromSchool()
        {
            PersonLearningDevices = new HashSet<PersonLearningDevice>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonLearningDevice> PersonLearningDevices { get; set; }
    }
}
