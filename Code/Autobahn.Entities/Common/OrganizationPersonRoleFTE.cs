using System;
using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.Common;

namespace Autobahn.Entities
{
    [Table("OrganizationPersonRoleFTE")]
    public partial class OrganizationPersonRoleFTE
    {
        public int OrganizationPersonRoleFTEId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public decimal FullTimeEquivalency { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}