//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonLearningDevice.cs
//**********************************************************using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("PersonLearningDevice")]
    public partial class PersonLearningDevice : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonLearningDevice()
        {
            PersonDigitalAccessSpeeds = new HashSet<PersonDigitalAccessSpeed>();
        }

        [ForeignKey("OrganizationPersonRole")]
        public Guid OrganizationPersonRoleId { get; set; }

        [ForeignKey("RefPrimaryLearningDeviceAccess")]
        public Guid? RefPrimaryLearningDeviceAccessId { get; set; }

        [ForeignKey("RefPrimaryLearningDeviceAwayFromSchool")]
        public Guid? RefPrimaryLearningDeviceAwayFromSchoolId { get; set; }

        [ForeignKey("RefPrimaryLearningDeviceProvider")]
        public Guid? RefPrimaryLearningDeviceProviderId { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDigitalAccessSpeed> PersonDigitalAccessSpeeds { get; set; }

        public virtual RefPrimaryLearningDeviceAccess RefPrimaryLearningDeviceAccess { get; set; }

        public virtual RefPrimaryLearningDeviceAwayFromSchool RefPrimaryLearningDeviceAwayFromSchool { get; set; }

        public virtual RefPrimaryLearningDeviceProvider RefPrimaryLearningDeviceProvider { get; set; }
    }
}
