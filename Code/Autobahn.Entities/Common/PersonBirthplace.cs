//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonBirthplace.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("PersonBirthplace")]
    public partial class PersonBirthplace : EntityBase
    {
        [ForeignKey("Person")]
        public Guid PersonId { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [ForeignKey("RefState")]
        public Guid? RefStateId { get; set; }

        [ForeignKey("RefCountry")]
        public Guid? RefCountryId { get; set; }

        public virtual Person Person { get; set; }

        public virtual RefCountry RefCountry { get; set; }

        public virtual RefState RefState { get; set; }
    }
}
