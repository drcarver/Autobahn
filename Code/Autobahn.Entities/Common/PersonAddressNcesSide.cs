//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAddressNcesSide.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("PersonAddressNcesSide")]
    public partial class PersonAddressNcesSide : EntityBase
    {
        [ForeignKey("PersonAddress")]
        public Guid PersonAddressId { get; set; }

        public DateTime? NcesSideDateProcessed { get; set; }

        public decimal? NcesSideEstimate { get; set; }

        public decimal? NcesSideStandardError { get; set; }

        [StringLength(4)]
        public string NcesSideVintageBeginYear { get; set; }

        [StringLength(4)]
        public string NcesSideVintageEndYear { get; set; }

        public virtual PersonAddress PersonAddress { get; set; }
    }
}
