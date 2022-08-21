﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("K12SeaAlternateFundUse")]
    [Index("K12seaFederalFundsId", "RefAlternateFundUsesId", Name = "IX_K12SeaAlternateFundUse", IsUnique = true)]
    public partial class K12seaAlternateFundUse
    {
        [Key]
        [Column("K12SeaAlternateFundUseId")]
        public int K12seaAlternateFundUseId { get; set; }
        [Column("K12SeaFederalFundsId")]
        public int K12seaFederalFundsId { get; set; }
        /// <summary>
        /// CEDS Element has been removed.
        /// </summary>
        public int RefAlternateFundUsesId { get; set; }
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
        [InverseProperty("K12seaAlternateFundUses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12seaFederalFundsId")]
        [InverseProperty("K12seaAlternateFundUses")]
        public virtual K12seaFederalFund K12seaFederalFunds { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12seaAlternateFundUses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAlternateFundUsesId")]
        [InverseProperty("K12seaAlternateFundUses")]
        public virtual RefAlternateFundUse RefAlternateFundUses { get; set; } = null!;
    }
}
