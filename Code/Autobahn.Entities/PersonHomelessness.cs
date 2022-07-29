using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonHomelessness")]
    public partial class PersonHomelessness
    {
        public int PersonHomelessnessId { get; set; }

        public int PersonId { get; set; }

        public bool HomelessnessStatus { get; set; }

        public int RefHomelessNighttimeResidenceId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RefHomelessNighttimeResidence RefHomelessNighttimeResidence { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
