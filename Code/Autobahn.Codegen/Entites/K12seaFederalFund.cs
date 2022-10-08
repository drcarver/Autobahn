using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("K12SeaFederalFunds", Schema = "K12")]
    public partial class K12seaFederalFund
    {
        public K12seaFederalFund()
        {
            K12seaAlternateFundUses = new HashSet<K12SeaAlternateFundUse>();
        }

        [Key]
        public int K12SeaFederalFundsId { get; set; }
        public int K12SeaId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? StateTransferabilityOfFunds { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public DateTime? DateStateReceivedTitleIIIAllocation { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public DateTime? DateTitleIIIFundsAvailableToSubgrantees { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public decimal? NumberOfDaysForTitleIIISubgrants { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("K12seaFederalFunds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12seaId")]
        [InverseProperty("K12seaFederalFunds")]
        public virtual K12Sea K12sea { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12seaFederalFunds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("K12seaFederalFunds")]
        public virtual ICollection<K12SeaAlternateFundUse> K12seaAlternateFundUses { get; set; }
    }
}
