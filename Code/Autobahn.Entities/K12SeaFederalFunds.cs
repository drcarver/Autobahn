using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12SeaFederalFunds")]
    public partial class K12SeaFederalFunds
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public K12SeaFederalFunds()
        {
            K12SeaAlternateFundUse = new HashSet<K12SeaAlternateFundUse>();
        }

        public int K12SeaFederalFundsId { get; set; }

        public int K12SeaId { get; set; }

        public bool? StateTransferabilityOfFunds { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateStateReceivedTitleIIIAllocation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateTitleIIIFundsAvailableToSubgrantees { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NumberOfDaysForTitleIIISubgrants { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12Sea K12Sea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12SeaAlternateFundUse> K12SeaAlternateFundUse { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
