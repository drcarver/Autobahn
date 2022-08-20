//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonIdentifier.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("PersonIdentifier", Schema = "Common")]
    public partial class PersonIdentifier : EntityBase
    {
        [ForeignKey("Person")]
        public int PersonId { get; set; }

        [StringLength(40)]
        public string Identifier { get; set; }

        [ForeignKey("RefPersonIdentificationSystem")]
        public Guid RefPersonIdentificationSystemId { get; set; }

        [ForeignKey("RefPersonalInformationVerification")]
        public Guid? RefPersonalInformationVerificationId { get; set; }

        public virtual Person Person { get; set; }

        public virtual RefPersonIdentificationSystem RefPersonIdentificationSystem { get; set; }

        public virtual RefPersonalInformationVerification RefPersonalInformationVerification { get; set; }
    }
}
