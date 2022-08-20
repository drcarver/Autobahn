//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonTelephone.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("PersonPersonalInformationVerification")]
    public partial class PersonPersonalInformationVerification : EntityBase
    {
        [ForeignKey("Person")]
        public Guid PersonId { get; set; }

        [ForeignKey("PersonAddress")]
        public Guid? PersonAddressId { get; set; }

        [ForeignKey("PersonDetail")]
        public Guid? PersonDetailId { get; set; }

        [ForeignKey("PersonTelephone")]
        public Guid? PersonTelephoneId { get; set; }

        [ForeignKey("RefPersonalInformationType")]
        public Guid? RefPersonalInformationTypeId { get; set; }

        [ForeignKey("RefPersonalInformationVerification")]
        public Guid? RefPersonalInformationVerificationId { get; set; }

        public virtual Person Person { get; set; }

        public virtual PersonAddress PersonAddress { get; set; }

        public virtual PersonDetail PersonDetail { get; set; }

        public virtual PersonTelephone PersonTelephone { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefPersonalInformationType RefPersonalInformationType { get; set; }

        public virtual RefPersonalInformationVerification RefPersonalInformationVerification { get; set; }
    }
}
