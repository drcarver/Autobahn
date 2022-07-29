using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IndividualizedProgramAmendment")]
    public partial class IndividualizedProgramAmendment
    {
        public int IndividualizedProgramAmendmentId { get; set; }

        public int IndividualizedProgramId { get; set; }

        public string Description { get; set; }

        public string ReasonDescription { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IndividualizedProgram IndividualizedProgram { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
