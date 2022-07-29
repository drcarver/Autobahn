using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonIdentifier")]
    public partial class PersonIdentifier
    {
        public int PersonIdentifierId { get; set; }

        public int PersonId { get; set; }

        [StringLength(40)]
        public string Identifier { get; set; }

        public int RefPersonIdentificationSystemId { get; set; }

        public int? RefPersonalInformationVerificationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefPersonIdentificationSystem RefPersonIdentificationSystem { get; set; }

        public virtual RefPersonalInformationVerification RefPersonalInformationVerification { get; set; }
    }
}
