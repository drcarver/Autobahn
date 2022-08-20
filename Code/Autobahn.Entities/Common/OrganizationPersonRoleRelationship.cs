using System;
using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.Common;

namespace Autobahn.Entities
{
    [Table("OrganizationPersonRoleRelationship")]
    public partial class OrganizationPersonRoleRelationship
    {
        public int OrganizationPersonRoleRelationshipId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int OrganizationPersonRoleId_Parent { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole1 { get; set; }
    }
}
