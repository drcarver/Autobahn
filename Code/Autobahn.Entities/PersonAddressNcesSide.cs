using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonAddressNcesSide")]
    public partial class PersonAddressNcesSide
    {
        public int PersonAddressNcesSideId { get; set; }

        public int PersonAddressId { get; set; }

        public DateTime? NcesSideDateProcessed { get; set; }

        public decimal? NcesSideEstimate { get; set; }

        public decimal? NcesSideStandardError { get; set; }

        [StringLength(4)]
        public string NcesSideVintageBeginYear { get; set; }

        [StringLength(4)]
        public string NcesSideVintageEndYear { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonAddress PersonAddress { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
