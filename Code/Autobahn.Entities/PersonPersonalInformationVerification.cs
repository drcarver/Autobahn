using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonPersonalInformationVerification")]
    public partial class PersonPersonalInformationVerification
    {
        public int PersonPersonalInformationVerificationId { get; set; }

        public int PersonId { get; set; }

        public int? PersonAddressId { get; set; }

        public int? PersonDetailId { get; set; }

        public int? PersonTelephoneId { get; set; }

        public int? RefPersonalInformationTypeId { get; set; }

        public int? RefPersonalInformationVerificationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual PersonAddress PersonAddress { get; set; }

        public virtual PersonDetail PersonDetail { get; set; }

        public virtual PersonTelephone PersonTelephone { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefPersonalInformationType RefPersonalInformationType { get; set; }

        public virtual RefPersonalInformationVerification RefPersonalInformationVerification { get; set; }
    }
}
