using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELChildService")]
    public partial class ELChildService
    {
        public int ELChildServiceId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public bool? ECEAPEligibility { get; set; }

        [StringLength(100)]
        public string EligibilityPriorityPoints { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ServiceDate { get; set; }

        public int? RefEarlyChildhoodServicesOfferedId { get; set; }

        public int? RefEarlyChildhoodServicesReceivedId { get; set; }

        public int? RefELServiceTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEarlyChildhoodService RefEarlyChildhoodService { get; set; }

        public virtual RefEarlyChildhoodService RefEarlyChildhoodService1 { get; set; }

        public virtual RefELServiceType RefELServiceType { get; set; }
    }
}
