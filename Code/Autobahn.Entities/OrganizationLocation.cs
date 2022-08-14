using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationLocation")]
    public partial class OrganizationLocation
    {
        public int OrganizationLocationId { get; set; }

        public int OrganizationId { get; set; }

        public int LocationId { get; set; }

        public int? RefOrganizationLocationTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Location Location { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefOrganizationLocationType RefOrganizationLocationType { get; set; }
    }
}
