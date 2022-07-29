using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    public partial class PersonStatu
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

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefPersonStatusType RefPersonStatusType { get; set; }
    }
}
