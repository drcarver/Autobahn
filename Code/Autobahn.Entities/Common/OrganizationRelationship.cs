using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationRelationship")]
    public partial class OrganizationRelationship
    {
        public int OrganizationRelationshipId { get; set; }

        public int Parent_OrganizationId { get; set; }

        public Guid OrganizationId { get; set; }

        public int? RefOrganizationRelationshipId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Organization Organization1 { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefOrganizationRelationship RefOrganizationRelationship { get; set; }
    }
}
