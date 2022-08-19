using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonImmunization")]
    public partial class PersonImmunization
    {
        public int PersonImmunizationId { get; set; }

        public int PersonId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ImmunizationDate { get; set; }

        public int RefImmunizationTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefImmunizationType RefImmunizationType { get; set; }
    }
}
