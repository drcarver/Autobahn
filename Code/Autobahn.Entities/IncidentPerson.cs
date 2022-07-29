using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IncidentPerson")]
    public partial class IncidentPerson
    {
        public int IncidentPersonId { get; set; }

        public int IncidentId { get; set; }

        public int PersonId { get; set; }

        [StringLength(40)]
        public string Identifier { get; set; }

        public int RefIncidentPersonRoleTypeId { get; set; }

        public int? RefIncidentPersonTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Incident Incident { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefIncidentPersonRoleType RefIncidentPersonRoleType { get; set; }

        public virtual RefIncidentPersonType RefIncidentPersonType { get; set; }
    }
}
