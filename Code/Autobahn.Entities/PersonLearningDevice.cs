using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonLearningDevice")]
    public partial class PersonLearningDevice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonLearningDevice()
        {
            PersonDigitalAccessSpeeds = new HashSet<PersonDigitalAccessSpeed>();
        }

        public int PersonLearningDeviceId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int? RefPrimaryLearningDeviceAccessId { get; set; }

        public int? RefPrimaryLearningDeviceAwayFromSchoolId { get; set; }

        public int? RefPrimaryLearningDeviceProviderId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDigitalAccessSpeed> PersonDigitalAccessSpeeds { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefPrimaryLearningDeviceAccess RefPrimaryLearningDeviceAccess { get; set; }

        public virtual RefPrimaryLearningDeviceAwayFromSchool RefPrimaryLearningDeviceAwayFromSchool { get; set; }

        public virtual RefPrimaryLearningDeviceProvider RefPrimaryLearningDeviceProvider { get; set; }
    }
}
