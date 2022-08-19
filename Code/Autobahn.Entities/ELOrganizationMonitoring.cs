using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELOrganizationMonitoring")]
    public partial class ELOrganizationMonitoring
    {
        public int ELOrganizationMonitoringId { get; set; }

        public Guid OrganizationId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VisitStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VisitEndDate { get; set; }

        public int? RefPurposeOfMonitoringVisitId { get; set; }

        [StringLength(300)]
        public string TypeOfMonitoring { get; set; }

        public int? RefOrganizationMonitoringNotificationsId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefOrganizationMonitoringNotification RefOrganizationMonitoringNotification { get; set; }

        public virtual RefPurposeOfMonitoringVisit RefPurposeOfMonitoringVisit { get; set; }
    }
}
