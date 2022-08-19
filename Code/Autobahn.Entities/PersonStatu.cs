using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonStatus")]
    public partial class PersonStatus
    {
        [Key]
        public int PersonStatusId { get; set; }

        public int PersonId { get; set; }

        public int RefPersonStatusTypeId { get; set; }

        public bool StatusValue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StatusStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StatusEndDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefPersonStatusType RefPersonStatusType { get; set; }
    }
}
