//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDigitalAccessSpeed.cs
//**********************************************************using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefPrimaryLearningDeviceAccess", Schema = "Common")]
    public partial class RefPrimaryLearningDeviceAccess : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefPrimaryLearningDeviceAccess()
        {
            PersonLearningDevices = new HashSet<PersonLearningDevice>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonLearningDevice> PersonLearningDevices { get; set; }
    }
}
