using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12SeaAlternateFundUse")]
    public partial class K12SeaAlternateFundUse
    {
        public int K12SeaAlternateFundUseId { get; set; }

        public int K12SeaFederalFundsId { get; set; }

        public int RefAlternateFundUsesId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12SeaFederalFunds K12SeaFederalFunds { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAlternateFundUs RefAlternateFundUs { get; set; }
    }
}
