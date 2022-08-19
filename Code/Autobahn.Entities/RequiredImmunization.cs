using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RequiredImmunization")]
    public partial class RequiredImmunization
    {
        public int RequiredImmunizationId { get; set; }

        public Guid OrganizationId { get; set; }

        public int RefImmunizationTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefImmunizationType RefImmunizationType { get; set; }
    }
}
