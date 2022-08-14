using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ServiceProvider")]
    public partial class ServiceProvider
    {
        public int ServiceProviderId { get; set; }

        public int OrganizationId { get; set; }

        public int ServiceProvidedId { get; set; }

        public int ServiceStaffId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual ServiceProvided ServiceProvided { get; set; }

        public virtual ServiceStaff ServiceStaff { get; set; }
    }
}
