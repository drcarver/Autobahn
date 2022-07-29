using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ServiceProvided")]
    public partial class ServiceProvided
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceProvided()
        {
            ServiceProviders = new HashSet<ServiceProvider>();
        }

        public int ServiceProvidedId { get; set; }

        public int ServicesReceivedId { get; set; }

        public int? RefServicesId { get; set; }

        public int? RefStudentSupportServiceTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefService RefService { get; set; }

        public virtual RefStudentSupportServiceType RefStudentSupportServiceType { get; set; }

        public virtual ServicesReceived ServicesReceived { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; }
    }
}
