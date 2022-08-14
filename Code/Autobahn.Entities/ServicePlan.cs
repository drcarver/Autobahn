using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ServicePlan")]
    public partial class ServicePlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServicePlan()
        {
            ServiceFrequencies = new HashSet<ServiceFrequency>();
            ServicesReceiveds = new HashSet<ServicesReceived>();
        }

        public int ServicePlanId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DeclinedServicesDate { get; set; }

        public bool? ExtendsOutsideSchoolYear { get; set; }

        public bool? InclusiveSettingIndicator { get; set; }

        public string ReasonForDeclinedServices { get; set; }

        public string SettingDescription { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceFrequency> ServiceFrequencies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicesReceived> ServicesReceiveds { get; set; }
    }
}
